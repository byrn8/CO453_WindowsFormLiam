namespace CO453_WindowsFormLiam
{
    partial class WelcomeForm
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
            this.GreetingLabel = new System.Windows.Forms.Label();
            this.BragLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.ShowButton1 = new System.Windows.Forms.Button();
            this.ShowButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GreetingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreetingLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GreetingLabel.Location = new System.Drawing.Point(100, 30);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(370, 40);
            this.GreetingLabel.TabIndex = 0;
            this.GreetingLabel.Text = "Welcome to SuperSoft";
            this.GreetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BragLabel
            // 
            this.BragLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BragLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BragLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BragLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BragLabel.Location = new System.Drawing.Point(100, 90);
            this.BragLabel.Name = "BragLabel";
            this.BragLabel.Size = new System.Drawing.Size(310, 70);
            this.BragLabel.TabIndex = 1;
            this.BragLabel.Text = "The BEST Prices";
            this.BragLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(100, 212);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // ShowButton1
            // 
            this.ShowButton1.Location = new System.Drawing.Point(226, 211);
            this.ShowButton1.Name = "ShowButton1";
            this.ShowButton1.Size = new System.Drawing.Size(84, 23);
            this.ShowButton1.TabIndex = 3;
            this.ShowButton1.Text = "Best Computer";
            this.ShowButton1.UseVisualStyleBackColor = true;
            this.ShowButton1.Click += new System.EventHandler(this.ShowButton1_Click);
            // 
            // ShowButton2
            // 
            this.ShowButton2.Location = new System.Drawing.Point(355, 211);
            this.ShowButton2.Name = "ShowButton2";
            this.ShowButton2.Size = new System.Drawing.Size(81, 23);
            this.ShowButton2.TabIndex = 4;
            this.ShowButton2.Text = "Best Software";
            this.ShowButton2.UseVisualStyleBackColor = true;
            this.ShowButton2.Click += new System.EventHandler(this.ShowButton2_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(580, 307);
            this.Controls.Add(this.ShowButton2);
            this.Controls.Add(this.ShowButton1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.BragLabel);
            this.Controls.Add(this.GreetingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperSoft Software co.";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GreetingLabel;
        private System.Windows.Forms.Label BragLabel;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button ShowButton1;
        private System.Windows.Forms.Button ShowButton2;
    }
}

