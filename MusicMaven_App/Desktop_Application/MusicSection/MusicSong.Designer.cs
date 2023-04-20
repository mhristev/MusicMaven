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
            msktxtBoxDuration = new MaskedTextBox();
            btnEdit = new Button();
            button3 = new Button();
            btnBack = new Button();
            lblAlbum = new Label();
            lblRating = new Label();
            lblDuration = new Label();
            cmbBoxAlbum = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(msktxtBoxDuration);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(lblAlbum);
            panel1.Controls.Add(lblRating);
            panel1.Controls.Add(lblDuration);
            panel1.Controls.Add(cmbBoxAlbum);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 617);
            panel1.TabIndex = 0;
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
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.icons8_delete_100;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(989, 14);
            button3.Name = "button3";
            button3.Size = new Size(55, 48);
            button3.TabIndex = 21;
            button3.UseVisualStyleBackColor = true;
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
            // lblAlbum
            // 
            lblAlbum.AutoSize = true;
            lblAlbum.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlbum.ForeColor = Color.White;
            lblAlbum.Location = new Point(213, 185);
            lblAlbum.Name = "lblAlbum";
            lblAlbum.Size = new Size(84, 25);
            lblAlbum.TabIndex = 10;
            lblAlbum.Text = "Album3";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRating.ForeColor = Color.White;
            lblRating.Location = new Point(213, 142);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(42, 25);
            lblRating.TabIndex = 9;
            lblRating.Text = "8.1";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblDuration.ForeColor = Color.White;
            lblDuration.Location = new Point(213, 102);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(66, 25);
            lblDuration.TabIndex = 8;
            lblDuration.Text = "02:41";
            // 
            // cmbBoxAlbum
            // 
            cmbBoxAlbum.FormattingEnabled = true;
            cmbBoxAlbum.Location = new Point(325, 185);
            cmbBoxAlbum.Name = "cmbBoxAlbum";
            cmbBoxAlbum.Size = new Size(200, 23);
            cmbBoxAlbum.TabIndex = 6;
            cmbBoxAlbum.Visible = false;
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
            // label1
            // 
            label1.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(137, 34);
            label1.Name = "label1";
            label1.Size = new Size(804, 38);
            label1.TabIndex = 0;
            label1.Text = "Backseat Freestyle";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MusicSong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 61, 97);
            ClientSize = new Size(1047, 617);
            Controls.Add(panel1);
            MaximumSize = new Size(1063, 656);
            MinimumSize = new Size(1063, 656);
            Name = "MusicSong";
            Text = "MusicSong";
            PreviewKeyDown += MusicSong_PreviewKeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label lblAlbum;
        private Label lblRating;
        private Label lblDuration;
        private NumericUpDown nmrDuration;
        private ComboBox cmbBoxAlbum;
        private Label label4;
        private Label label3;
        private Button btnBack;
        private Button button3;
        private Button btnEdit;
        private MaskedTextBox msktxtBoxDuration;
    }
}