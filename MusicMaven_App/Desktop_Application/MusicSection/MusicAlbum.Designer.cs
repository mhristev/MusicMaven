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
            btnCreateSong = new Button();
            btnEdit = new Button();
            txtBoxName = new TextBox();
            cmBoxGenre = new ComboBox();
            dtpReleaseDate = new DateTimePicker();
            lblRating = new Label();
            lblReleaseDate = new Label();
            lblArtists = new Label();
            lblGenre = new Label();
            button2 = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCreateSong);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(txtBoxName);
            panel1.Controls.Add(cmBoxGenre);
            panel1.Controls.Add(dtpReleaseDate);
            panel1.Controls.Add(lblRating);
            panel1.Controls.Add(lblReleaseDate);
            panel1.Controls.Add(lblArtists);
            panel1.Controls.Add(lblGenre);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
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
            panel1.Size = new Size(1047, 617);
            panel1.TabIndex = 0;
            // 
            // btnCreateSong
            // 
            btnCreateSong.Location = new Point(883, 300);
            btnCreateSong.Name = "btnCreateSong";
            btnCreateSong.Size = new Size(106, 23);
            btnCreateSong.TabIndex = 18;
            btnCreateSong.Text = "Create Song";
            btnCreateSong.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(926, 90);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(459, 49);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(147, 23);
            txtBoxName.TabIndex = 16;
            txtBoxName.Visible = false;
            // 
            // cmBoxGenre
            // 
            cmBoxGenre.FormattingEnabled = true;
            cmBoxGenre.Location = new Point(356, 119);
            cmBoxGenre.Name = "cmBoxGenre";
            cmBoxGenre.Size = new Size(200, 23);
            cmBoxGenre.TabIndex = 15;
            cmBoxGenre.Visible = false;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(356, 190);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(200, 23);
            dtpReleaseDate.TabIndex = 14;
            dtpReleaseDate.Visible = false;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRating.ForeColor = Color.White;
            lblRating.Location = new Point(222, 221);
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
            lblReleaseDate.Location = new Point(222, 189);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(128, 25);
            lblReleaseDate.TabIndex = 12;
            lblReleaseDate.Text = "22/01/2003";
            // 
            // lblArtists
            // 
            lblArtists.AutoSize = true;
            lblArtists.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblArtists.ForeColor = Color.White;
            lblArtists.Location = new Point(222, 156);
            lblArtists.Name = "lblArtists";
            lblArtists.Size = new Size(72, 25);
            lblArtists.TabIndex = 11;
            lblArtists.Text = "label8";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenre.ForeColor = Color.White;
            lblGenre.Location = new Point(222, 119);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(69, 25);
            lblGenre.TabIndex = 10;
            lblGenre.Text = "ROCK";
            // 
            // button2
            // 
            button2.Location = new Point(926, 49);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(59, 49);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(59, 330);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(930, 327);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(59, 300);
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
            label6.Location = new Point(77, 224);
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
            label5.Location = new Point(77, 192);
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
            label4.Location = new Point(77, 156);
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
            label3.Location = new Point(77, 123);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 2;
            label3.Text = "Genre:";
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Top;
            lblName.Font = new Font("Tahoma", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(1047, 31);
            lblName.TabIndex = 0;
            lblName.Text = "Good kid, maad city";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MusicAlbum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 61, 97);
            ClientSize = new Size(1047, 617);
            Controls.Add(panel1);
            MaximumSize = new Size(1063, 656);
            MinimumSize = new Size(1063, 656);
            Name = "MusicAlbum";
            Text = "MusicAlbum";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button button1;
        private Button button2;
        private ComboBox cmBoxGenre;
        private DateTimePicker dtpReleaseDate;
        private Label lblRating;
        private Label lblReleaseDate;
        private Label lblArtists;
        private Label lblGenre;
        private TextBox txtBoxName;
        private Button btnEdit;
        private Button btnCreateSong;
    }
}