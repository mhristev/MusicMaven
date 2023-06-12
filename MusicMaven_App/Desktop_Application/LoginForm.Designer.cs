namespace Desktop_Application
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label1 = new Label();
            txtBoxEmail = new TextBox();
            btnLogin = new Button();
            txtBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 529);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(356, 144);
            label1.Name = "label1";
            label1.Size = new Size(305, 38);
            label1.TabIndex = 1;
            label1.Text = "Login to your account";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxEmail.Location = new Point(356, 206);
            txtBoxEmail.MaximumSize = new Size(0, 30);
            txtBoxEmail.MinimumSize = new Size(0, 30);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(430, 30);
            txtBoxEmail.TabIndex = 2;
            txtBoxEmail.Text = "Email";
            txtBoxEmail.Enter += txtBoxEmail_Enter;
            txtBoxEmail.Leave += txtBoxEmail_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(24, 137, 149);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(356, 306);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(187, 37);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPassword.Location = new Point(356, 255);
            txtBoxPassword.MaximumSize = new Size(0, 30);
            txtBoxPassword.MinimumSize = new Size(0, 30);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(430, 30);
            txtBoxPassword.TabIndex = 5;
            txtBoxPassword.Text = "Password";
            txtBoxPassword.Enter += txtBoxPassword_Enter;
            txtBoxPassword.Leave += txtBoxPassword_Leave;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(78, 71, 108);
            ClientSize = new Size(873, 529);
            Controls.Add(txtBoxPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtBoxEmail);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtBoxEmail;
        private Button btnLogin;
        private TextBox txtBoxPassword;
    }
}