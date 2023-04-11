namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            textBox2 = new TextBox();
            button3 = new Button();
            label2 = new Label();
            btnCreateAlbum = new Button();
            label9 = new Label();
            label3 = new Label();
            lblRating = new Label();
            lblArtistType = new Label();
            lblImage = new Label();
            cmBoxArtistType = new ComboBox();
            label4 = new Label();
            txtBoxImage = new TextBox();
            lblName = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            label5 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button4 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(432, 127);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(264, 123);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCreateAlbum);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblRating);
            panel1.Controls.Add(lblArtistType);
            panel1.Controls.Add(lblImage);
            panel1.Controls.Add(cmBoxArtistType);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtBoxImage);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(1063, 761);
            panel1.MinimumSize = new Size(1063, 761);
            panel1.Name = "panel1";
            panel1.Size = new Size(1063, 761);
            panel1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(512, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 19;
            // 
            // button3
            // 
            button3.Location = new Point(618, 202);
            button3.Name = "button3";
            button3.Size = new Size(62, 23);
            button3.TabIndex = 18;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(686, 206);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 17;
            label2.Text = "label2";
            // 
            // btnCreateAlbum
            // 
            btnCreateAlbum.Location = new Point(892, 265);
            btnCreateAlbum.Name = "btnCreateAlbum";
            btnCreateAlbum.Size = new Size(102, 23);
            btnCreateAlbum.TabIndex = 16;
            btnCreateAlbum.Text = "Create Album";
            btnCreateAlbum.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(59, 191);
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
            label3.Location = new Point(59, 153);
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
            lblRating.Location = new Point(179, 187);
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
            lblArtistType.Location = new Point(179, 153);
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
            lblImage.Location = new Point(179, 121);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(140, 25);
            lblImage.TabIndex = 11;
            lblImage.Text = "/images/test";
            // 
            // cmBoxArtistType
            // 
            cmBoxArtistType.FormattingEnabled = true;
            cmBoxArtistType.Location = new Point(336, 157);
            cmBoxArtistType.Name = "cmBoxArtistType";
            cmBoxArtistType.Size = new Size(156, 23);
            cmBoxArtistType.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(59, 121);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(61, 21);
            label4.TabIndex = 2;
            label4.Text = "Image:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.UseMnemonic = false;
            // 
            // txtBoxImage
            // 
            txtBoxImage.Location = new Point(336, 125);
            txtBoxImage.Name = "txtBoxImage";
            txtBoxImage.Size = new Size(156, 23);
            txtBoxImage.TabIndex = 9;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Top;
            lblName.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(1063, 32);
            lblName.TabIndex = 1;
            lblName.Text = "Kendrick Lamar";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.UseMnemonic = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(460, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 23);
            textBox3.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 137, 149);
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(907, 119);
            button2.Name = "button2";
            button2.Size = new Size(87, 27);
            button2.TabIndex = 6;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(52, 265);
            label5.Name = "label5";
            label5.Size = new Size(144, 27);
            label5.TabIndex = 5;
            label5.Text = "Discography";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(52, 295);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(942, 327);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(24, 137, 149);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(52, 35);
            button4.Name = "button4";
            button4.Size = new Size(63, 30);
            button4.TabIndex = 0;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 676);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private TextBox textBox2;
        private Button button3;
        private Label label2;
        private Button btnCreateAlbum;
        private Label label9;
        private Label label3;
        private Label lblRating;
        private Label lblArtistType;
        private Label lblImage;
        private ComboBox cmBoxArtistType;
        private Label label4;
        private TextBox txtBoxImage;
        private Label lblName;
        private TextBox textBox3;
        private Button button2;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button4;
    }
}