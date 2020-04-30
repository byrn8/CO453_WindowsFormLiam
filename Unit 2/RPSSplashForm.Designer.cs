namespace CO453_WindowsFormLiam.Unit_2
{
    partial class RPSSplashForm
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
            this.UserWelcomeLabel = new System.Windows.Forms.Label();
            this.UserInstructionLabel = new System.Windows.Forms.Label();
            this.RulesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserWelcomeLabel
            // 
            this.UserWelcomeLabel.AutoSize = true;
            this.UserWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserWelcomeLabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.UserWelcomeLabel.Location = new System.Drawing.Point(24, 47);
            this.UserWelcomeLabel.Name = "UserWelcomeLabel";
            this.UserWelcomeLabel.Size = new System.Drawing.Size(551, 31);
            this.UserWelcomeLabel.TabIndex = 0;
            this.UserWelcomeLabel.Text = "Welcome to the Rock, Paper, Scissors game";
            // 
            // UserInstructionLabel
            // 
            this.UserInstructionLabel.AutoSize = true;
            this.UserInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInstructionLabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.UserInstructionLabel.Location = new System.Drawing.Point(102, 143);
            this.UserInstructionLabel.Name = "UserInstructionLabel";
            this.UserInstructionLabel.Size = new System.Drawing.Size(398, 31);
            this.UserInstructionLabel.TabIndex = 1;
            this.UserInstructionLabel.Text = "Click the form to enter the game";
            // 
            // RulesLabel
            // 
            this.RulesLabel.AutoSize = true;
            this.RulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesLabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.RulesLabel.Location = new System.Drawing.Point(170, 240);
            this.RulesLabel.Name = "RulesLabel";
            this.RulesLabel.Size = new System.Drawing.Size(277, 31);
            this.RulesLabel.TabIndex = 2;
            this.RulesLabel.Text = "First to 20 points wins";
            // 
            // RPSSplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(598, 325);
            this.Controls.Add(this.RulesLabel);
            this.Controls.Add(this.UserInstructionLabel);
            this.Controls.Add(this.UserWelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RPSSplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPSSplashForm";
            this.Click += new System.EventHandler(this.RPSSplashForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserWelcomeLabel;
        private System.Windows.Forms.Label UserInstructionLabel;
        private System.Windows.Forms.Label RulesLabel;
    }
}