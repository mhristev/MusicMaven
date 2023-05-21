namespace Desktop_Application.Controls
{
    partial class DefaultUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsername = new Label();
            lblEmail = new Label();
            lblType = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(28, 21);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(38, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "label1";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(455, 21);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(38, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "label1";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.ForeColor = Color.White;
            lblType.Location = new Point(831, 21);
            lblType.Name = "lblType";
            lblType.Size = new Size(38, 15);
            lblType.TabIndex = 2;
            lblType.Text = "label1";
            // 
            // DefaultUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 93, 140);
            Controls.Add(lblType);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            MaximumSize = new Size(950, 50);
            MinimumSize = new Size(950, 50);
            Name = "DefaultUserControl";
            Size = new Size(950, 50);
            Click += DefaultUserControl_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblEmail;
        private Label lblType;
    }
}
