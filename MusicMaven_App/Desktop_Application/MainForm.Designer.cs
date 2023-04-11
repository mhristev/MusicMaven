namespace Desktop_Application
{
    partial class MainForm
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
            sidebarPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            btnMusic = new Button();
            btnUsers = new Button();
            btnLogout = new Button();
            panel2 = new Panel();
            sidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(53, 47, 95);
            sidebarPanel.Controls.Add(panel1);
            sidebarPanel.Controls.Add(btnMusic);
            sidebarPanel.Controls.Add(btnUsers);
            sidebarPanel.Controls.Add(btnLogout);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(2, 1, 2, 1);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(123, 761);
            sidebarPanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Location = new Point(2, 1);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(121, 183);
            panel1.TabIndex = 0;
            // 
            // btnMusic
            // 
            btnMusic.BackColor = Color.Transparent;
            btnMusic.FlatAppearance.BorderSize = 0;
            btnMusic.FlatStyle = FlatStyle.Flat;
            btnMusic.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnMusic.ForeColor = Color.White;
            btnMusic.ImageAlign = ContentAlignment.MiddleLeft;
            btnMusic.Location = new Point(2, 186);
            btnMusic.Margin = new Padding(2, 1, 2, 1);
            btnMusic.Name = "btnMusic";
            btnMusic.Size = new Size(121, 54);
            btnMusic.TabIndex = 2;
            btnMusic.Text = "Music";
            btnMusic.TextAlign = ContentAlignment.MiddleLeft;
            btnMusic.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMusic.UseVisualStyleBackColor = false;
            btnMusic.Click += btnUsers_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Transparent;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsers.ForeColor = Color.White;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(2, 242);
            btnUsers.Margin = new Padding(2, 1, 2, 1);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(121, 54);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(2, 298);
            btnLogout.Margin = new Padding(2, 1, 2, 1);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(121, 54);
            btnLogout.TabIndex = 3;
            btnLogout.Text = " Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(78, 71, 108);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(123, 0);
            panel2.MaximumSize = new Size(1063, 761);
            panel2.MinimumSize = new Size(1063, 761);
            panel2.Name = "panel2";
            panel2.Size = new Size(1063, 761);
            panel2.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(panel2);
            Controls.Add(sidebarPanel);
            Name = "MainForm";
            Text = "Form1";
            sidebarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebarPanel;
        private Panel panel1;
        private Button btnMusic;
        private Button btnUsers;
        private Button btnLogout;
        private Panel panel2;
    }
}