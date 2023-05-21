namespace Desktop_Application.UsersSection
{
    partial class UsersSingleForm
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
            btnDelete = new Button();
            label9 = new Label();
            label3 = new Label();
            lblEmail = new Label();
            lblUserType = new Label();
            lblImage = new Label();
            cmBoxUserType = new ComboBox();
            label2 = new Label();
            txtBoxImage = new TextBox();
            lblUsername = new Label();
            txtBoxUsername = new TextBox();
            btnEdit = new Button();
            btnBack = new Button();
            txtBoxEmail = new TextBox();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources.icons8_delete_100;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(980, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(60, 56);
            btnDelete.TabIndex = 34;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(76, 168);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(56, 21);
            label9.TabIndex = 32;
            label9.Text = "Email:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(76, 130);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(89, 21);
            label3.TabIndex = 31;
            label3.Text = "User Type:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseMnemonic = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(196, 164);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 25);
            lblEmail.TabIndex = 30;
            lblEmail.Text = "8.1";
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.BackColor = Color.Transparent;
            lblUserType.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserType.ForeColor = Color.White;
            lblUserType.Location = new Point(196, 130);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(67, 25);
            lblUserType.TabIndex = 29;
            lblUserType.Text = "SOLO";
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.BackColor = Color.Transparent;
            lblImage.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblImage.ForeColor = Color.White;
            lblImage.Location = new Point(196, 98);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(140, 25);
            lblImage.TabIndex = 28;
            lblImage.Text = "/images/test";
            // 
            // cmBoxUserType
            // 
            cmBoxUserType.BackColor = Color.FromArgb(101, 93, 140);
            cmBoxUserType.FlatStyle = FlatStyle.Flat;
            cmBoxUserType.ForeColor = Color.White;
            cmBoxUserType.FormattingEnabled = true;
            cmBoxUserType.Location = new Point(353, 134);
            cmBoxUserType.Name = "cmBoxUserType";
            cmBoxUserType.Size = new Size(156, 23);
            cmBoxUserType.TabIndex = 27;
            cmBoxUserType.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(76, 98);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(61, 21);
            label2.TabIndex = 21;
            label2.Text = "Image:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseMnemonic = false;
            // 
            // txtBoxImage
            // 
            txtBoxImage.BackColor = Color.FromArgb(101, 93, 140);
            txtBoxImage.BorderStyle = BorderStyle.FixedSingle;
            txtBoxImage.ForeColor = Color.White;
            txtBoxImage.Location = new Point(353, 102);
            txtBoxImage.Name = "txtBoxImage";
            txtBoxImage.Size = new Size(156, 23);
            txtBoxImage.TabIndex = 26;
            txtBoxImage.Visible = false;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(130, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(805, 44);
            lblUsername.TabIndex = 20;
            lblUsername.Text = "Kendrick Lamar";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            lblUsername.UseMnemonic = false;
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.BackColor = Color.FromArgb(101, 93, 140);
            txtBoxUsername.BorderStyle = BorderStyle.None;
            txtBoxUsername.ForeColor = Color.White;
            txtBoxUsername.Location = new Point(469, 80);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(139, 16);
            txtBoxUsername.TabIndex = 25;
            txtBoxUsername.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(24, 137, 149);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(76, 320);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(901, 29);
            btnEdit.TabIndex = 24;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(24, 137, 149);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(5, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(63, 30);
            btnBack.TabIndex = 19;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.BackColor = Color.FromArgb(101, 93, 140);
            txtBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            txtBoxEmail.ForeColor = Color.White;
            txtBoxEmail.Location = new Point(353, 170);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(156, 23);
            txtBoxEmail.TabIndex = 35;
            txtBoxEmail.Visible = false;
            // 
            // UsersSingleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 61, 97);
            ClientSize = new Size(1045, 655);
            Controls.Add(txtBoxEmail);
            Controls.Add(btnDelete);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(lblEmail);
            Controls.Add(lblUserType);
            Controls.Add(lblImage);
            Controls.Add(cmBoxUserType);
            Controls.Add(label2);
            Controls.Add(txtBoxImage);
            Controls.Add(lblUsername);
            Controls.Add(txtBoxUsername);
            Controls.Add(btnEdit);
            Controls.Add(btnBack);
            MinimumSize = new Size(1061, 694);
            Name = "UsersSingleForm";
            Text = "UsersSingleForm";
            PreviewKeyDown += UsersSingleForm_PreviewKeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private GroupBox groupBox1;
        private Button btnAddArtist;
        private FlowLayoutPanel flowPanelAddArtists;
        private Label lblCreateAlbumArtist;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label1;
        private DateTimePicker dtPickerCreateAlbumReleaseDate;
        private ComboBox cmbBoxCreateAlbumGenre;
        private Button btnCreateAlbum;
        private TextBox txtBoxCreateAlbumImageURL;
        private TextBox txtBoxCreateAlbumName;
        private Label label9;
        private Label label3;
        private Label lblEmail;
        private Label lblUserType;
        private Label lblImage;
        private ComboBox cmBoxUserType;
        private Label label2;
        private TextBox txtBoxImage;
        private Label lblUsername;
        private TextBox txtBoxUsername;
        private Button btnEdit;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnBack;
        private TextBox txtBoxEmail;
    }
}