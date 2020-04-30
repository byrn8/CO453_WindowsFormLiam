namespace CO453_WindowsFormLiam.Unit_2
{
    partial class DrawingSplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingSplashForm));
            this.DrawingLabel1 = new System.Windows.Forms.Label();
            this.DrawingLabel2 = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.DrawingIcon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrawingLabel1
            // 
            this.DrawingLabel1.AutoSize = true;
            this.DrawingLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawingLabel1.Location = new System.Drawing.Point(270, 90);
            this.DrawingLabel1.Name = "DrawingLabel1";
            this.DrawingLabel1.Size = new System.Drawing.Size(156, 31);
            this.DrawingLabel1.TabIndex = 0;
            this.DrawingLabel1.Text = "Well Played";
            // 
            // DrawingLabel2
            // 
            this.DrawingLabel2.AutoSize = true;
            this.DrawingLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawingLabel2.Location = new System.Drawing.Point(270, 150);
            this.DrawingLabel2.Name = "DrawingLabel2";
            this.DrawingLabel2.Size = new System.Drawing.Size(133, 31);
            this.DrawingLabel2.TabIndex = 1;
            this.DrawingLabel2.Text = "You Drew";
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
            // DrawingIcon
            // 
            this.DrawingIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DrawingIcon.BackgroundImage")));
            this.DrawingIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DrawingIcon.Location = new System.Drawing.Point(30, 40);
            this.DrawingIcon.Name = "DrawingIcon";
            this.DrawingIcon.Size = new System.Drawing.Size(200, 200);
            this.DrawingIcon.TabIndex = 3;
            this.DrawingIcon.UseVisualStyleBackColor = true;
            // 
            // DrawingSplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.DrawingIcon);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.DrawingLabel2);
            this.Controls.Add(this.DrawingLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrawingSplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawingSplashForm";
            this.Click += new System.EventHandler(this.DrawingSplashForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DrawingLabel1;
        private System.Windows.Forms.Label DrawingLabel2;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Button DrawingIcon;
    }
}