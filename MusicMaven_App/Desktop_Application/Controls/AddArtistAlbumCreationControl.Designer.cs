namespace Desktop_Application.Controls
{
    partial class AddArtistAlbumCreationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArtistAlbumCreationControl));
            cmBoxArtist = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // cmBoxArtist
            // 
            cmBoxArtist.BackColor = Color.FromArgb(101, 93, 140);
            cmBoxArtist.FlatStyle = FlatStyle.Flat;
            cmBoxArtist.ForeColor = Color.White;
            cmBoxArtist.FormattingEnabled = true;
            cmBoxArtist.Location = new Point(0, 0);
            cmBoxArtist.Name = "cmBoxArtist";
            cmBoxArtist.Size = new Size(144, 23);
            cmBoxArtist.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(150, 0);
            button1.Name = "button1";
            button1.Size = new Size(22, 23);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddArtistAlbumCreationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button1);
            Controls.Add(cmBoxArtist);
            Name = "AddArtistAlbumCreationControl";
            Size = new Size(174, 23);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmBoxArtist;
        private Button button1;
    }
}
