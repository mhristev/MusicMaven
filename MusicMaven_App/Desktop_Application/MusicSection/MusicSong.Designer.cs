namespace Desktop_Application.MusicSection
{
    partial class MusicSong
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
            panel1 = new Panel();
            txtBoxSongName = new TextBox();
            msktxtBoxDuration = new MaskedTextBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            lblSongRating = new Label();
            lblSongDuration = new Label();
            cmbBoxSongAlbum = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblSongName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBoxSongName);
            panel1.Controls.Add(msktxtBoxDuration);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(lblSongRating);
            panel1.Controls.Add(lblSongDuration);
            panel1.Controls.Add(cmbBoxSongAlbum);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblSongName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 655);
            panel1.TabIndex = 0;
            // 
            // txtBoxSongName
            // 
            txtBoxSongName.Location = new Point(590, 93);
            txtBoxSongName.Name = "txtBoxSongName";
            txtBoxSongName.Size = new Size(100, 23);
            txtBoxSongName.TabIndex = 24;
            txtBoxSongName.Visible = false;
            // 
            // msktxtBoxDuration
            // 
            msktxtBoxDuration.Location = new Point(325, 102);
            msktxtBoxDuration.Mask = "00:00";
            msktxtBoxDuration.Name = "msktxtBoxDuration";
            msktxtBoxDuration.PromptChar = ' ';
            msktxtBoxDuration.Size = new Size(100, 23);
            msktxtBoxDuration.TabIndex = 23;
            msktxtBoxDuration.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            msktxtBoxDuration.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(24, 137, 149);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(115, 274);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(860, 28);
            btnEdit.TabIndex = 22;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources.icons8_delete_100;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(989, 14);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(55, 48);
            btnDelete.TabIndex = 21;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(24, 137, 149);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 22);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(63, 30);
            btnBack.TabIndex = 20;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblSongRating
            // 
            lblSongRating.AutoSize = true;
            lblSongRating.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblSongRating.ForeColor = Color.White;
            lblSongRating.Location = new Point(213, 142);
            lblSongRating.Name = "lblSongRating";
            lblSongRating.Size = new Size(42, 25);
            lblSongRating.TabIndex = 9;
            lblSongRating.Text = "8.1";
            // 
            // lblSongDuration
            // 
            lblSongDuration.AutoSize = true;
            lblSongDuration.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblSongDuration.ForeColor = Color.White;
            lblSongDuration.Location = new Point(213, 102);
            lblSongDuration.Name = "lblSongDuration";
            lblSongDuration.Size = new Size(66, 25);
            lblSongDuration.TabIndex = 8;
            lblSongDuration.Text = "02:41";
            // 
            // cmbBoxSongAlbum
            // 
            cmbBoxSongAlbum.FormattingEnabled = true;
            cmbBoxSongAlbum.Location = new Point(213, 189);
            cmbBoxSongAlbum.Name = "cmbBoxSongAlbum";
            cmbBoxSongAlbum.Size = new Size(200, 23);
            cmbBoxSongAlbum.TabIndex = 6;
            cmbBoxSongAlbum.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(115, 189);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 5;
            label4.Text = "Album:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(115, 145);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 4;
            label3.Text = "Rating:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(115, 106);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "Duration:";
            // 
            // lblSongName
            // 
            lblSongName.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblSongName.ForeColor = Color.White;
            lblSongName.Location = new Point(137, 34);
            lblSongName.Name = "lblSongName";
            lblSongName.Size = new Size(804, 38);
            lblSongName.TabIndex = 0;
            lblSongName.Text = "Backseat Freestyle";
            lblSongName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MusicSong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 61, 97);
            ClientSize = new Size(1047, 655);
            Controls.Add(panel1);
            MaximumSize = new Size(1063, 694);
            MinimumSize = new Size(1063, 694);
            Name = "MusicSong";
            Text = "MusicSong";
            PreviewKeyDown += MusicSong_PreviewKeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblSongName;
        private Label label2;
        private Label lblAlbum;
        private Label lblSongRating;
        private Label lblSongDuration;
        private NumericUpDown nmrDuration;
        private ComboBox cmbBoxSongAlbum;
        private Label label4;
        private Label label3;
        private Button btnBack;
        private Button btnDelete;
        private Button btnEdit;
        private MaskedTextBox msktxtBoxDuration;
        private TextBox txtBoxSongName;
    }
}