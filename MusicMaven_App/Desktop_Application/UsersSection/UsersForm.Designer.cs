namespace Desktop_Application.UsersSection
{
    partial class UsersForm
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
            flowLayoutPanelUsers = new FlowLayoutPanel();
            label1 = new Label();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            txtBoxEmail = new TextBox();
            txtBoxRepeatPassword = new TextBox();
            txtBoxPassword = new TextBox();
            cmbBoxUserType = new ComboBox();
            txtBoxImageURL = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCreateUser = new Button();
            txtBoxUsername = new TextBox();
            cmbBoxArtistType = new ComboBox();
            btnClear = new Button();
            btnSearch = new Button();
            txtboxSearch = new TextBox();
            panel1 = new Panel();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelUsers
            // 
            flowLayoutPanelUsers.AutoScroll = true;
            flowLayoutPanelUsers.Location = new Point(51, 225);
            flowLayoutPanelUsers.Name = "flowLayoutPanelUsers";
            flowLayoutPanelUsers.Size = new Size(960, 457);
            flowLayoutPanelUsers.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Semibold", 31F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 57);
            label1.TabIndex = 0;
            label1.Text = "Users";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(53, 47, 95);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1061, 67);
            panel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBoxEmail);
            groupBox1.Controls.Add(txtBoxRepeatPassword);
            groupBox1.Controls.Add(txtBoxPassword);
            groupBox1.Controls.Add(cmbBoxUserType);
            groupBox1.Controls.Add(txtBoxImageURL);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCreateUser);
            groupBox1.Controls.Add(txtBoxUsername);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(51, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(952, 130);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create User";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(340, 98);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(237, 23);
            txtBoxEmail.TabIndex = 20;
            // 
            // txtBoxRepeatPassword
            // 
            txtBoxRepeatPassword.Location = new Point(552, 60);
            txtBoxRepeatPassword.Name = "txtBoxRepeatPassword";
            txtBoxRepeatPassword.Size = new Size(298, 23);
            txtBoxRepeatPassword.TabIndex = 19;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(552, 23);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(298, 23);
            txtBoxPassword.TabIndex = 18;
            // 
            // cmbBoxUserType
            // 
            cmbBoxUserType.FormattingEnabled = true;
            cmbBoxUserType.Location = new Point(116, 98);
            cmbBoxUserType.Name = "cmbBoxUserType";
            cmbBoxUserType.Size = new Size(153, 23);
            cmbBoxUserType.TabIndex = 17;
            // 
            // txtBoxImageURL
            // 
            txtBoxImageURL.Location = new Point(116, 60);
            txtBoxImageURL.Name = "txtBoxImageURL";
            txtBoxImageURL.Size = new Size(298, 23);
            txtBoxImageURL.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(441, 60);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 16;
            label7.Text = "Repeat Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(441, 31);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 15;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 101);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 13;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 101);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 11;
            label4.Text = "User Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 62);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 10;
            label3.Text = "Image URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 31);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // btnCreateUser
            // 
            btnCreateUser.BackColor = Color.FromArgb(24, 137, 149);
            btnCreateUser.FlatAppearance.BorderSize = 0;
            btnCreateUser.FlatStyle = FlatStyle.Flat;
            btnCreateUser.ForeColor = Color.White;
            btnCreateUser.Location = new Point(746, 95);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(190, 27);
            btnCreateUser.TabIndex = 2;
            btnCreateUser.Text = "Create User";
            btnCreateUser.UseVisualStyleBackColor = false;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Location = new Point(116, 23);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(298, 23);
            txtBoxUsername.TabIndex = 6;
            // 
            // cmbBoxArtistType
            // 
            cmbBoxArtistType.Location = new Point(0, 0);
            cmbBoxArtistType.Name = "cmbBoxArtistType";
            cmbBoxArtistType.Size = new Size(121, 23);
            cmbBoxArtistType.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(24, 137, 149);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(624, 190);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(47, 29);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Visible = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(24, 137, 149);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(535, 190);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(83, 29);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Visible = false;
            // 
            // txtboxSearch
            // 
            txtboxSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxSearch.Location = new Point(59, 190);
            txtboxSearch.Multiline = true;
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.RightToLeft = RightToLeft.No;
            txtboxSearch.Size = new Size(457, 29);
            txtboxSearch.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 61, 97);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(flowLayoutPanelUsers);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtboxSearch);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1061, 694);
            panel1.TabIndex = 21;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(78, 71, 108);
            ClientSize = new Size(1061, 722);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximumSize = new Size(1077, 761);
            MinimumSize = new Size(1077, 761);
            Name = "UsersForm";
            Text = "UsersForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanelUsers;
        private Button button2;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private Label label7;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbBoxArtistType;
        private TextBox txtBoxArtistImageURL;
        private Button btnCreateUser;
        private TextBox txtBoxUsername;
        private Button btnClear;
        private Button btnSearch;
        private TextBox txtboxSearch;
        private TextBox txtBoxEmail;
        private TextBox txtBoxRepeatPassword;
        private TextBox txtBoxPassword;
        private ComboBox cmbBoxUserType;
        private TextBox txtBoxImageURL;
        private Panel panel1;
    }
}