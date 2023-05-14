namespace Desktop_Application.MusicSection
{
    partial class MusicAlbum
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
            groupBox1 = new GroupBox();
            label8 = new Label();
            label2 = new Label();
            label1 = new Label();
            nmrDurationInSecondsCreateSong = new NumericUpDown();
            txtBoxImgCreateSong = new TextBox();
            btnCreateSong = new Button();
            txtBoxNameCreateSong = new TextBox();
            btnAddArtist = new Button();
            flowPanelArtists = new FlowLayoutPanel();
            btnBack = new Button();
            btnEdit = new Button();
            txtBoxName = new TextBox();
            cmBoxGenre = new ComboBox();
            dtpReleaseDate = new DateTimePicker();
            lblRating = new Label();
            lblReleaseDate = new Label();
            lblGenre = new Label();
            btnDelete = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblName = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrDurationInSecondsCreateSong).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnAddArtist);
            panel1.Controls.Add(flowPanelArtists);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(txtBoxName);
            panel1.Controls.Add(cmBoxGenre);
            panel1.Controls.Add(dtpReleaseDate);
            panel1.Controls.Add(lblRating);
            panel1.Controls.Add(lblReleaseDate);
            panel1.Controls.Add(lblGenre);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 655);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nmrDurationInSecondsCreateSong);
            groupBox1.Controls.Add(txtBoxImgCreateSong);
            groupBox1.Controls.Add(btnCreateSong);
            groupBox1.Controls.Add(txtBoxNameCreateSong);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(59, 527);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(930, 116);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Song";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(653, 41);
            label8.Name = "label8";
            label8.Size = new Size(58, 17);
            label8.TabIndex = 5;
            label8.Text = "Duration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 78);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 4;
            label2.Text = "Image URL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 41);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // nmrDurationInSecondsCreateSong
            // 
            nmrDurationInSecondsCreateSong.BackColor = Color.FromArgb(101, 93, 140);
            nmrDurationInSecondsCreateSong.ForeColor = Color.White;
            nmrDurationInSecondsCreateSong.Location = new Point(744, 33);
            nmrDurationInSecondsCreateSong.Name = "nmrDurationInSecondsCreateSong";
            nmrDurationInSecondsCreateSong.Size = new Size(171, 25);
            nmrDurationInSecondsCreateSong.TabIndex = 2;
            // 
            // txtBoxImgCreateSong
            // 
            txtBoxImgCreateSong.BackColor = Color.FromArgb(101, 93, 140);
            txtBoxImgCreateSong.BorderStyle = BorderStyle.None;
            txtBoxImgCreateSong.ForeColor = Color.White;
            txtBoxImgCreateSong.Location = new Point(114, 78);
            txtBoxImgCreateSong.Name = "txtBoxImgCreateSong";
            txtBoxImgCreateSong.Size = new Size(339, 18);
            txtBoxImgCreateSong.TabIndex = 1;
            // 
            // btnCreateSong
            // 
            btnCreateSong.BackColor = Color.FromArgb(24, 137, 149);
            btnCreateSong.FlatAppearance.BorderSize = 0;
            btnCreateSong.FlatStyle = FlatStyle.Popup;
            btnCreateSong.ForeColor = Color.WhiteSmoke;
            btnCreateSong.Location = new Point(658, 78);
            btnCreateSong.Name = "btnCreateSong";
            btnCreateSong.Size = new Size(257, 27);
            btnCreateSong.TabIndex = 18;
            btnCreateSong.Text = "Create Song";
            btnCreateSong.UseVisualStyleBackColor = false;
            btnCreateSong.Click += btnCreateSong_Click;
            // 
            // txtBoxNameCreateSong
            // 
            txtBoxNameCreateSong.BackColor = Color.FromArgb(101, 93, 140);
            txtBoxNameCreateSong.BorderStyle = BorderStyle.None;
            txtBoxNameCreateSong.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxNameCreateSong.ForeColor = Color.White;
            txtBoxNameCreateSong.Location = new Point(114, 40);
            txtBoxNameCreateSong.Name = "txtBoxNameCreateSong";
            txtBoxNameCreateSong.Size = new Size(339, 18);
            txtBoxNameCreateSong.TabIndex = 0;
            // 
            // btnAddArtist
            // 
            btnAddArtist.BackgroundImage = Properties.Resources.icons8_add_48__1_;
            btnAddArtist.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddArtist.FlatAppearance.BorderSize = 0;
            btnAddArtist.FlatStyle = FlatStyle.Flat;
            btnAddArtist.Location = new Point(156, 131);
            btnAddArtist.Name = "btnAddArtist";
            btnAddArtist.Size = new Size(42, 38);
            btnAddArtist.TabIndex = 21;
            btnAddArtist.UseVisualStyleBackColor = true;
            btnAddArtist.Visible = false;
            btnAddArtist.Click += btnAddArtist_Click;
            // 
            // flowPanelArtists
            // 
            flowPanelArtists.Location = new Point(204, 131);
            flowPanelArtists.Name = "flowPanelArtists";
            flowPanelArtists.Size = new Size(785, 38);
            flowPanelArtists.TabIndex = 20;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(24, 137, 149);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(28, 25);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(63, 30);
            btnBack.TabIndex = 19;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(24, 137, 149);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(59, 231);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(930, 28);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtBoxName
            // 
            txtBoxName.BackColor = Color.FromArgb(101, 93, 140);
            txtBoxName.BorderStyle = BorderStyle.None;
            txtBoxName.ForeColor = Color.White;
            txtBoxName.Location = new Point(440, 59);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(147, 16);
            txtBoxName.TabIndex = 16;
            txtBoxName.Visible = false;
            // 
            // cmBoxGenre
            // 
            cmBoxGenre.BackColor = Color.FromArgb(101, 93, 140);
            cmBoxGenre.FlatStyle = FlatStyle.Popup;
            cmBoxGenre.ForeColor = Color.White;
            cmBoxGenre.FormattingEnabled = true;
            cmBoxGenre.Location = new Point(289, 102);
            cmBoxGenre.Name = "cmBoxGenre";
            cmBoxGenre.Size = new Size(200, 23);
            cmBoxGenre.TabIndex = 15;
            cmBoxGenre.Visible = false;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(347, 173);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(200, 23);
            dtpReleaseDate.TabIndex = 14;
            dtpReleaseDate.Value = new DateTime(2023, 5, 10, 15, 10, 45, 0);
            dtpReleaseDate.Visible = false;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRating.ForeColor = Color.White;
            lblRating.Location = new Point(204, 204);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(42, 25);
            lblRating.TabIndex = 13;
            lblRating.Text = "7.6";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblReleaseDate.ForeColor = Color.White;
            lblReleaseDate.Location = new Point(204, 172);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(126, 25);
            lblReleaseDate.TabIndex = 12;
            lblReleaseDate.Text = "2023-04-20";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenre.ForeColor = Color.White;
            lblGenre.Location = new Point(204, 102);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(69, 25);
            lblGenre.TabIndex = 10;
            lblGenre.Text = "ROCK";
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources.icons8_delete_100;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(980, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(60, 56);
            btnDelete.TabIndex = 9;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(59, 304);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(930, 217);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(59, 274);
            label7.Name = "label7";
            label7.Size = new Size(76, 27);
            label7.TabIndex = 6;
            label7.Text = "Songs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(59, 207);
            label6.Name = "label6";
            label6.Size = new Size(63, 21);
            label6.TabIndex = 5;
            label6.Text = "Rating:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(59, 175);
            label5.Name = "label5";
            label5.Size = new Size(115, 21);
            label5.TabIndex = 4;
            label5.Text = "Release Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(59, 139);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 3;
            label4.Text = "Artists:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(59, 106);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 2;
            label3.Text = "Genre:";
            // 
            // lblName
            // 
            lblName.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(97, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(877, 31);
            lblName.TabIndex = 0;
            lblName.Text = "Good kid, maad city";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MusicAlbum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 61, 97);
            ClientSize = new Size(1047, 655);
            Controls.Add(panel1);
            MaximumSize = new Size(1063, 694);
            MinimumSize = new Size(1063, 694);
            Name = "MusicAlbum";
            Text = "MusicAlbum";
            PreviewKeyDown += MusicAlbum_PreviewKeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrDurationInSecondsCreateSong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblName;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDelete;
        private ComboBox cmBoxGenre;
        private DateTimePicker dtpReleaseDate;
        private Label lblRating;
        private Label lblReleaseDate;
        private Label lblGenre;
        private TextBox txtBoxName;
        private Button btnEdit;
        private Button btnCreateSong;
        private Button btnBack;
        private FlowLayoutPanel flowPanelArtists;
        private Button btnAddArtist;
        private GroupBox groupBox1;
        private TextBox txtBoxImgCreateSong;
        private TextBox txtBoxNameCreateSong;
        private Label label8;
        private Label label2;
        private Label label1;
        private NumericUpDown nmrDurationInSecondsCreateSong;
    }
}