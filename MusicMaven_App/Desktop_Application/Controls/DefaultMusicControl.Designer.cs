namespace Desktop_Application
{
    partial class DefaultMusicControl
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
            lblName = new Label();
            lblType = new Label();
            lblRating = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(21, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 15);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.ForeColor = Color.White;
            lblType.Location = new Point(705, 20);
            lblType.Name = "lblType";
            lblType.Size = new Size(38, 15);
            lblType.TabIndex = 1;
            lblType.Text = "label1";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.ForeColor = Color.White;
            lblRating.Location = new Point(882, 20);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(38, 15);
            lblRating.TabIndex = 2;
            lblRating.Text = "label1";
            // 
            // DefaultMusicControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 93, 140);
            Controls.Add(lblRating);
            Controls.Add(lblType);
            Controls.Add(lblName);
            MaximumSize = new Size(950, 50);
            MinimumSize = new Size(950, 50);
            Name = "DefaultMusicControl";
            Size = new Size(950, 50);
            Click += DefaultMusicControl_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblType;
        private Label lblRating;
    }
}
