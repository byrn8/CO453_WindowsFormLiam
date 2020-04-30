namespace CO453_WindowsFormLiam.Unit_2
{
    partial class WinningSplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinningSplashForm));
            this.WinningLabel1 = new System.Windows.Forms.Label();
            this.WinningLabel2 = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.WinningIcon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WinningLabel1
            // 
            this.WinningLabel1.AutoSize = true;
            this.WinningLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinningLabel1.Location = new System.Drawing.Point(270, 90);
            this.WinningLabel1.Name = "WinningLabel1";
            this.WinningLabel1.Size = new System.Drawing.Size(146, 31);
            this.WinningLabel1.TabIndex = 0;
            this.WinningLabel1.Text = "Well Done!";
            // 
            // WinningLabel2
            // 
            this.WinningLabel2.AutoSize = true;
            this.WinningLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinningLabel2.Location = new System.Drawing.Point(270, 150);
            this.WinningLabel2.Name = "WinningLabel2";
            this.WinningLabel2.Size = new System.Drawing.Size(132, 31);
            this.WinningLabel2.TabIndex = 1;
            this.WinningLabel2.Text = "You Won!";
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.Location = new System.Drawing.Point(229, 260);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(259, 31);
            this.ExitLabel.TabIndex = 2;
            this.ExitLabel.Text = "Click the form to exit";
            // 
            // WinningIcon
            // 
            this.WinningIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WinningIcon.BackgroundImage")));
            this.WinningIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WinningIcon.Location = new System.Drawing.Point(30, 40);
            this.WinningIcon.Name = "WinningIcon";
            this.WinningIcon.Size = new System.Drawing.Size(200, 200);
            this.WinningIcon.TabIndex = 3;
            this.WinningIcon.UseVisualStyleBackColor = true;
            // 
            // WinningSplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.WinningIcon);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.WinningLabel2);
            this.Controls.Add(this.WinningLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinningSplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinningSplashForm";
            this.Click += new System.EventHandler(this.WinningSplashForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WinningLabel1;
        private System.Windows.Forms.Label WinningLabel2;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Button WinningIcon;
    }
}