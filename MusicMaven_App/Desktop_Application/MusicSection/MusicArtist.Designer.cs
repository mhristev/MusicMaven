namespace Desktop_Application
{
    partial class MusicArtist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicArtist));
            button1 = new Button();
            panel1 = new Panel();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            btnAddArtist = new Button();
            flowPanelAddArtists = new FlowLayoutPanel();
            lblCreateAlbumArtist = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label1 = new Label();
            dtPickerCreateAlbumReleaseDate = new DateTimePicker();
            cmbBoxCreateAlbumGenre = new ComboBox();
            btnCreateAlbum = new Button();
            txtBoxCreateAlbumImageURL = new TextBox();
            txtBoxCreateAlbumName = new TextBox();
            label9 = new Label();
            label3 = new Label();
            lblRating = new Label();
            lblArtistType = new Label();
            lblImage = new Label();
            cmBoxArtistType = new ComboBox();
            label2 = new Label();
            txtBoxImage = new TextBox();
            lblName = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 137, 149);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(63, 30);
            button1.TabIndex = 0;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblRating);
            panel1.Controls.Add(lblArtistType);
            panel1.Controls.Add(lblImage);
            panel1.Controls.Add(cmBoxArtistType);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBoxImage);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(1063, 761);
            panel1.MinimumSize = new Size(1063, 761);
            panel1.Name = "panel1";
            panel1.Size = new Size(1063, 761);
            panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources.icons8_delete_100;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(987, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(60, 56);
            btnDelete.TabIndex = 18;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddArtist);
            groupBox1.Controls.Add(flowPanelAddArtists);
            groupBox1.Controls.Add(lblCreateAlbumArtist);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtPickerCreateAlbumReleaseDate);
            groupBox1.Controls.Add(cmbBoxCreateAlbumGenre);
            groupBox1.Controls.Add(btnCreateAlbum);
            groupBox1.Controls.Add(txtBoxCreateAlbumImageURL);
            groupBox1.Controls.Add(txtBoxCreateAlbumName);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(83, 484);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(908, 171);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Album";
            // 
            // btnAddArtist
            // 
            btnAddArtist.BackColor = Color.FromArgb(24, 137, 149);
            btnAddArtist.BackgroundImage = (Image)resources.GetObject("btnAddArtist.BackgroundImage");
            btnAddArtist.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddArtist.FlatAppearance.BorderSize = 0;
            btnAddArtist.FlatStyle = FlatStyle.Flat;
            btnAddArtist.ForeColor = Color.White;
            btnAddArtist.Location = new Point(492, 26);
            btnAddArtist.Name = "btnAddArtist";
            btnAddArtist.Size = new Size(37, 35);
            btnAddArtist.TabIndex = 27;
            btnAddArtist.Text = "+";
            btnAddArtist.UseVisualStyleBackColor = false;
            btnAddArtist.Click += btnAddArtist_Click;
            // 
            // flowPanelAddArtists
            // 
            flowPanelAddArtists.Location = new Point(345, 66);
            flowPanelAddArtists.Name = "flowPanelAddArtists";
            flowPanelAddArtists.Size = new Size(556, 46);
            flowPanelAddArtists.TabIndex = 26;
            // 
            // lblCreateAlbumArtist
            // 
            lblCreateAlbumArtist.AutoSize = true;
            lblCreateAlbumArtist.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreateAlbumArtist.Location = new Point(345, 41);
            lblCreateAlbumArtist.Name = "lblCreateAlbumArtist";
            lblCreateAlbumArtist.Size = new Size(141, 17);
            lblCreateAlbumArtist.TabIndex = 25;
            lblCreateAlbumArtist.Text = "Artists: Kendrick Lamar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 136);
            label6.Name = "label6";
            label6.Size = new Size(78, 17);
            label6.TabIndex = 23;
            label6.Text = "Gentre Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 77);
            label5.Name = "label5";
            label5.Size = new Size(71, 17);
            label5.TabIndex = 22;
            label5.Text = "Image URL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(345, 136);
            label7.Name = "label7";
            label7.Size = new Size(84, 17);
            label7.TabIndex = 24;
            label7.Text = "Release Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 41);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 21;
            label1.Text = "Name";
            // 
            // dtPickerCreateAlbumReleaseDate
            // 
            dtPickerCreateAlbumReleaseDate.CalendarForeColor = Color.FromArgb(101, 93, 140);
            dtPickerCreateAlbumReleaseDate.CalendarMonthBackground = Color.FromArgb(101, 93, 140);
            dtPickerCreateAlbumReleaseDate.Location = new Point(435, 130);
            dtPickerCreateAlbumReleaseDate.Name = "dtPickerCreateAlbumReleaseDate";
            dtPickerCreateAlbumReleaseDate.Size = new Size(213, 25);
            dtPickerCreateAlbumReleaseDate.TabIndex = 20;
            // 
            // cmbBoxCreateAlbumGenre
            // 
            cmbBoxCreateAlbumGenre.BackColor = Color.FromArgb(101, 93, 140);
            cmbBoxCreateAlbumGenre.FlatStyle = FlatStyle.Flat;
            cmbBoxCreateAlbumGenre.ForeColor = Color.White;
            cmbBoxCreateAlbumGenre.FormattingEnabled = true;
            cmbBoxCreateAlbumGenre.Location = new Point(108, 128);
            cmbBoxCreateAlbumGenre.Name = "cmbBoxCreateAlbumGenre";
            cmbBoxCreateAlbumGenre.Size = new Size(213, 25);
            cmbBoxCreateAlbumGenre.TabIndex = 19;
            // 
            // btnCreateAlbum
            // 
            btnCreateAlbum.BackColor = Color.FromArgb(24, 137, 149);
            btnCreateAlbum.FlatAppearance.BorderSize = 0;
            btnCreateAlbum.FlatStyle = FlatStyle.Flat;
            btnCreateAlbum.ForeColor = Color.White;
            btnCreateAlbum.Location = new Point(708, 128);
            btnCreateAlbum.Name = "btnCreateAlbum";
            btnCreateAlbum.Size = new Size(162, 25);
            btnCreateAlbum.TabIndex = 16;
            btnCreateAlbum.Text = "Create Album";
            btnCreateAlbum.UseVisualStyleBackColor = false;
            btnCreateAlbum.Click += btnCreateAlbum_Click;
            // 
            // txtBoxCreateAlbumImageURL
            // 
            txtBoxCreateAlbumImageURL.BackColor = Color.FromArgb(101, 93, 140);
            txtBoxCreateAlbumImageURL.BorderStyle = BorderStyle.FixedSingle;
            txtBoxCreateAlbumImageURL.ForeColor = Color.White;
            txtBoxCreateAlbumImageURL.Location = new Point(108, 69);
            txtBoxCreateAlbumImageURL.Name = "txtBoxCreateAlbumImageURL";
            txtBoxCreateAlbumImageURL.Size = new Size(213, 25);
            txtBoxCreateAlbumImageURL.TabIndex = 18;
            // 
            // txtBoxCreateAlbumName
            // 
            txtBoxCreateAlbumName.BackColor = Color.FromArgb(101, 93, 140);
            txtBoxCreateAlbumName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxCreateAlbumName.ForeColor = Color.White;
            txtBoxCreateAlbumName.Location = new Point(108, 33);
            txtBoxCreateAlbumName.Name = "txtBoxCreateAlbumName";
            txtBoxCreateAlbumName.Size = new Size(213, 25);
            txtBoxCreateAlbumName.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(83, 168);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(63, 21);
            label9.TabIndex = 15;
            label9.Text = "Rating:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(83, 130);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(94, 21);
            label3.TabIndex = 14;
            label3.Text = "Artist Type:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseMnemonic = false;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.BackColor = Color.Transparent;
            lblRating.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRating.ForeColor = Color.White;
            lblRating.Location = new Point(203, 164);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(42, 25);
            lblRating.TabIndex = 13;
            lblRating.Text = "8.1";
            // 
            // lblArtistType
            // 
            lblArtistType.AutoSize = true;
            lblArtistType.BackColor = Color.Transparent;
            lblArtistType.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblArtistType.ForeColor = Color.White;
            lblArtistType.Location = new Point(203, 130);
            lblArtistType.Name = "lblArtistType";
            lblArtistType.Size = new Size(67, 25);
            lblArtistType.TabIndex = 12;
            lblArtistType.Text = "SOLO";
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.BackColor = Color.Transparent;
            lblImage.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblImage.ForeColor = Color.White;
            lblImage.Location = new Point(203, 98);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(140, 25);
            lblImage.TabIndex = 11;
            lblImage.Text = "/images/test";
            // 
            // cmBoxArtistType
            // 
            cmBoxArtistType.BackColor = Color.FromArgb(101, 93, 140);
            cmBoxArtistType.FlatStyle = FlatStyle.Flat;
            cmBoxArtistType.ForeColor = Color.White;
            cmBoxArtistType.FormattingEnabled = true;
            cmBoxArtistType.Location = new Point(360, 134);
            cmBoxArtistType.Name = "cmBoxArtistType";
            cmBoxArtistType.Size = new Size(156, 23);
            cmBoxArtistType.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(83, 98);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(61, 21);
            label2.TabIndex = 2;
            label2.Text = "Image:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseMnemonic = false;
            // 
            // txtBoxImage
            // 
            txtBoxImage.BackColor = Color.FromArgb(101, 93, 140);
            txtBoxImage.BorderStyle = BorderStyle.FixedSingle;
            txtBoxImage.ForeColor = Color.White;
            txtBoxImage.Location = new Point(360, 102);
            txtBoxImage.Name = "txtBoxImage";
            txtBoxImage.Size = new Size(156, 23);
            txtBoxImage.TabIndex = 9;
            // 
            // lblName
            // 
            lblName.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(137, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(805, 44);
            lblName.TabIndex = 1;
            lblName.Text = "Kendrick Lamar";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.UseMnemonic = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(101, 93, 140);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(476, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 16);
            textBox2.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 137, 149);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(83, 204);
            button2.Name = "button2";
            button2.Size = new Size(901, 29);
            button2.TabIndex = 6;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(83, 236);
            label4.Name = "label4";
            label4.Size = new Size(144, 27);
            label4.TabIndex = 5;
            label4.Text = "Discography";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(83, 266);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(920, 212);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // MusicArtist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 61, 97);
            ClientSize = new Size(1047, 655);
            Controls.Add(panel1);
            MaximumSize = new Size(1063, 694);
            MinimumSize = new Size(1063, 694);
            Name = "MusicArtist";
            Text = "Test2";
            PreviewKeyDown += MusicArtist_PreviewKeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label2;
        private Label lblName;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private TextBox textBox2;
        private ComboBox cmBoxArtistType;
        private TextBox txtBoxImage;
        private Label lblRating;
        private Label lblArtistType;
        private Label lblImage;
        private Label label3;
        private Label label9;
        private Button btnCreateAlbum;
        private GroupBox groupBox1;
        private TextBox txtBoxCreateAlbumImageURL;
        private TextBox txtBoxCreateAlbumName;
        private ComboBox cmbBoxCreateAlbumGenre;
        private Label lblCreateAlbumArtist;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private DateTimePicker dtPickerCreateAlbumReleaseDate;
        private Button btnAddArtist;
        private FlowLayoutPanel flowPanelAddArtists;
        private Button btnDelete;
    }
}