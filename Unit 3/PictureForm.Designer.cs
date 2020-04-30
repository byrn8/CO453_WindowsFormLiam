namespace CO453_WindowsFormLiam.Unit_3
{
    partial class PictureForm
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
            this.QuitButton = new System.Windows.Forms.Button();
            this.ChoiceCBox = new System.Windows.Forms.ComboBox();
            this.ChoicePBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChoicePBox)).BeginInit();
            this.SuspendLayout();
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(323, 226);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 0;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // ChoiceCBox
            // 
            this.ChoiceCBox.FormattingEnabled = true;
            this.ChoiceCBox.Items.AddRange(new object[] {
            "King Kong",
            "Big Foot",
            "Mogwai",
            "Loch Ness Monster",
            "Alien",
            "Godzilla"});
            this.ChoiceCBox.Location = new System.Drawing.Point(35, 48);
            this.ChoiceCBox.Name = "ChoiceCBox";
            this.ChoiceCBox.Size = new System.Drawing.Size(121, 21);
            this.ChoiceCBox.TabIndex = 1;
            this.ChoiceCBox.SelectedIndexChanged += new System.EventHandler(this.ChoiceCBox_SelectedIndexChanged);
            // 
            // ChoicePBox
            // 
            this.ChoicePBox.Location = new System.Drawing.Point(198, 12);
            this.ChoicePBox.Name = "ChoicePBox";
            this.ChoicePBox.Size = new System.Drawing.Size(200, 200);
            this.ChoicePBox.TabIndex = 2;
            this.ChoicePBox.TabStop = false;
            // 
            // PictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(410, 261);
            this.Controls.Add(this.ChoicePBox);
            this.Controls.Add(this.ChoiceCBox);
            this.Controls.Add(this.QuitButton);
            this.Name = "PictureForm";
            this.Text = "PictureForm";
            ((System.ComponentModel.ISupportInitialize)(this.ChoicePBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.ComboBox ChoiceCBox;
        private System.Windows.Forms.PictureBox ChoicePBox;
    }
}