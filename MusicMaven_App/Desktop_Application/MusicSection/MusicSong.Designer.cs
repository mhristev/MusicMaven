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
            lblAlbum = new Label();
            lblRating = new Label();
            lblDuration = new Label();
            nmrDuration = new NumericUpDown();
            cmbBoxAlbum = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrDuration).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblAlbum);
            panel1.Controls.Add(lblRating);
            panel1.Controls.Add(lblDuration);
            panel1.Controls.Add(nmrDuration);
            panel1.Controls.Add(cmbBoxAlbum);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 617);
            panel1.TabIndex = 0;
            // 
            // lblAlbum
            // 
            lblAlbum.AutoSize = true;
            lblAlbum.Font = new Font("Yu Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlbum.ForeColor = Color.White;
            lblAlbum.Location = new Point(225, 244);
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
            lblRating.Location = new Point(225, 207);
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
            lblDuration.Location = new Point(225, 169);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(54, 25);
            lblDuration.TabIndex = 8;
            lblDuration.Text = "2:41";
            // 
            // nmrDuration
            // 
            nmrDuration.Location = new Point(328, 169);
            nmrDuration.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nmrDuration.Name = "nmrDuration";
            nmrDuration.Size = new Size(60, 23);
            nmrDuration.TabIndex = 7;
            // 
            // cmbBoxAlbum
            // 
            cmbBoxAlbum.FormattingEnabled = true;
            cmbBoxAlbum.Location = new Point(328, 245);
            cmbBoxAlbum.Name = "cmbBoxAlbum";
            cmbBoxAlbum.Size = new Size(200, 23);
            cmbBoxAlbum.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(115, 247);
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
            label3.Location = new Point(115, 210);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 4;
            label3.Text = "Rating:";
            // 
            // button2
            // 
            button2.Location = new Point(938, 61);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(115, 173);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "Duration:";
            // 
            // button1
            // 
            button1.Location = new Point(90, 61);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1047, 38);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrDuration).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Label lblAlbum;
        private Label lblRating;
        private Label lblDuration;
        private NumericUpDown nmrDuration;
        private ComboBox cmbBoxAlbum;
        private Label label4;
        private Label label3;
    }
}