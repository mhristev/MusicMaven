namespace Desktop_Application
{
    partial class AlbumControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAlbumName = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblAlbumName
            // 
            lblAlbumName.AutoSize = true;
            lblAlbumName.ForeColor = Color.White;
            lblAlbumName.Location = new Point(20, 49);
            lblAlbumName.Name = "lblAlbumName";
            lblAlbumName.Size = new Size(51, 15);
            lblAlbumName.TabIndex = 0;
            lblAlbumName.Text = "Nameee";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.BackgroundImage = Properties.Resources.icons8_delete_100__1_;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(105, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(28, 29);
            btnDelete.TabIndex = 1;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // AlbumControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 93, 140);
            Controls.Add(btnDelete);
            Controls.Add(lblAlbumName);
            Name = "AlbumControl";
            Size = new Size(139, 106);
            Click += AlbumControl_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlbumName;
        private Button btnDelete;
    }
}
