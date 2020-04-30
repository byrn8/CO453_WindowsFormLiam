namespace CO453_WindowsFormLiam.Unit_4
{
    partial class TotalForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.TotalTeachersLabel = new System.Windows.Forms.Label();
            this.TTResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(383, 214);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TotalTeachersLabel
            // 
            this.TotalTeachersLabel.AutoSize = true;
            this.TotalTeachersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTeachersLabel.Location = new System.Drawing.Point(13, 31);
            this.TotalTeachersLabel.Name = "TotalTeachersLabel";
            this.TotalTeachersLabel.Size = new System.Drawing.Size(168, 25);
            this.TotalTeachersLabel.TabIndex = 1;
            this.TotalTeachersLabel.Text = "Total Teachers :";
            // 
            // TTResultLabel
            // 
            this.TTResultLabel.AutoSize = true;
            this.TTResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TTResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTResultLabel.Location = new System.Drawing.Point(209, 31);
            this.TTResultLabel.Name = "TTResultLabel";
            this.TTResultLabel.Size = new System.Drawing.Size(2, 27);
            this.TTResultLabel.TabIndex = 2;
            // 
            // TotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(470, 249);
            this.Controls.Add(this.TTResultLabel);
            this.Controls.Add(this.TotalTeachersLabel);
            this.Controls.Add(this.CloseButton);
            this.Name = "TotalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label TotalTeachersLabel;
        public System.Windows.Forms.Label TTResultLabel;
    }
}