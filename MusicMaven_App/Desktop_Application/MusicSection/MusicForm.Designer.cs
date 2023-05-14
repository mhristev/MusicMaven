namespace Desktop_Application
{
    partial class MusicForm
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
            btnCreateArtist = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbBoxArtistType = new ComboBox();
            txtBoxArtistImageURL = new TextBox();
            txtBoxArtistName = new TextBox();
            btnSearch = new Button();
            txtboxSearch = new TextBox();
            flowPanelMusicUnits = new FlowLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateArtist
            // 
            btnCreateArtist.BackColor = Color.FromArgb(24, 137, 149);
            btnCreateArtist.FlatAppearance.BorderSize = 0;
            btnCreateArtist.FlatStyle = FlatStyle.Flat;
            btnCreateArtist.ForeColor = Color.White;
            btnCreateArtist.Location = new Point(772, 80);
            btnCreateArtist.Name = "btnCreateArtist";
            btnCreateArtist.Size = new Size(190, 27);
            btnCreateArtist.TabIndex = 2;
            btnCreateArtist.Text = "Create Artist";
            btnCreateArtist.UseVisualStyleBackColor = false;
            btnCreateArtist.Click += btnCreateArtist_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -2);
            panel1.MaximumSize = new Size(1063, 761);
            panel1.MinimumSize = new Size(1063, 761);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(1063, 761);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(68, 61, 97);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(txtboxSearch);
            panel3.Controls.Add(flowPanelMusicUnits);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(1063, 694);
            panel3.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(24, 137, 149);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(602, 167);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(47, 29);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbBoxArtistType);
            groupBox1.Controls.Add(txtBoxArtistImageURL);
            groupBox1.Controls.Add(btnCreateArtist);
            groupBox1.Controls.Add(txtBoxArtistName);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(50, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(968, 114);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Artist";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 39);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 11;
            label4.Text = "Artist Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 80);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 10;
            label3.Text = "Image URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 39);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // cmbBoxArtistType
            // 
            cmbBoxArtistType.FormattingEnabled = true;
            cmbBoxArtistType.Location = new Point(547, 31);
            cmbBoxArtistType.Name = "cmbBoxArtistType";
            cmbBoxArtistType.Size = new Size(190, 23);
            cmbBoxArtistType.TabIndex = 7;
            // 
            // txtBoxArtistImageURL
            // 
            txtBoxArtistImageURL.Location = new Point(94, 72);
            txtBoxArtistImageURL.Name = "txtBoxArtistImageURL";
            txtBoxArtistImageURL.Size = new Size(315, 23);
            txtBoxArtistImageURL.TabIndex = 8;
            // 
            // txtBoxArtistName
            // 
            txtBoxArtistName.Location = new Point(94, 31);
            txtBoxArtistName.Name = "txtBoxArtistName";
            txtBoxArtistName.Size = new Size(315, 23);
            txtBoxArtistName.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(24, 137, 149);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(513, 167);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(83, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtboxSearch
            // 
            txtboxSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxSearch.Location = new Point(50, 167);
            txtboxSearch.Multiline = true;
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.RightToLeft = RightToLeft.No;
            txtboxSearch.Size = new Size(457, 29);
            txtboxSearch.TabIndex = 5;
            // 
            // flowPanelMusicUnits
            // 
            flowPanelMusicUnits.AutoScroll = true;
            flowPanelMusicUnits.Location = new Point(50, 202);
            flowPanelMusicUnits.Name = "flowPanelMusicUnits";
            flowPanelMusicUnits.RightToLeft = RightToLeft.No;
            flowPanelMusicUnits.Size = new Size(968, 481);
            flowPanelMusicUnits.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(53, 47, 95);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1063, 67);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Semibold", 31F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 57);
            label1.TabIndex = 0;
            label1.Text = "Music";
            // 
            // MusicForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 61, 97);
            ClientSize = new Size(1061, 722);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            MaximizeBox = false;
            MinimumSize = new Size(1077, 761);
            Name = "MusicForm";
            Text = "Test";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCreateArtist;
        private Panel panel1;
        private FlowLayoutPanel flowPanelMusicUnits;
        private Panel panel2;
        private Label label1;
        private TextBox txtboxSearch;
        private Panel panel3;
        private Button btnSearch;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbBoxArtistType;
        private TextBox txtBoxArtistImageURL;
        private TextBox txtBoxArtistName;
        private Button btnClear;
    }
}