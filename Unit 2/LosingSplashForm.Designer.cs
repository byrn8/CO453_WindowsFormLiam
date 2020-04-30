namespace CO453_WindowsFormLiam.Unit_2
{
    partial class LosingSplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LosingSplashForm));
            this.LosingLabel1 = new System.Windows.Forms.Label();
            this.LosingLabel2 = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.LosingIcon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LosingLabel1
            // 
            this.LosingLabel1.AutoSize = true;
            this.LosingLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LosingLabel1.Location = new System.Drawing.Point(270, 90);
            this.LosingLabel1.Name = "LosingLabel1";
            this.LosingLabel1.Size = new System.Drawing.Size(112, 31);
            this.LosingLabel1.TabIndex = 0;
            this.LosingLabel1.Text = "Unlucky";
            // 
            // LosingLabel2
            // 
            this.LosingLabel2.AutoSize = true;
            this.LosingLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LosingLabel2.Location = new System.Drawing.Point(270, 150);
            this.LosingLabel2.Name = "LosingLabel2";
            this.LosingLabel2.Size = new System.Drawing.Size(121, 31);
            this.LosingLabel2.TabIndex = 1;
            this.LosingLabel2.Text = "You Lost";
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
            // LosingIcon
            // 
            this.LosingIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LosingIcon.BackgroundImage")));
            this.LosingIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LosingIcon.Location = new System.Drawing.Point(30, 40);
            this.LosingIcon.Name = "LosingIcon";
            this.LosingIcon.Size = new System.Drawing.Size(200, 200);
            this.LosingIcon.TabIndex = 3;
            this.LosingIcon.UseVisualStyleBackColor = true;
            // 
            // LosingSplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.LosingIcon);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.LosingLabel2);
            this.Controls.Add(this.LosingLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LosingSplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LosingSplashForm";
            this.Click += new System.EventHandler(this.LosingSplashForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LosingLabel1;
        private System.Windows.Forms.Label LosingLabel2;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Button LosingIcon;
    }
}