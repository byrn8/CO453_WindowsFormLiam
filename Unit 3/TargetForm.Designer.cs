namespace CO453_WindowsFormLiam.Unit_3
{
    partial class TargetForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TargetForm));
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.ScoreGroupBox = new System.Windows.Forms.GroupBox();
            this.HitsTitleLabel = new System.Windows.Forms.Label();
            this.HitsNumberLabel = new System.Windows.Forms.Label();
            this.MissTitleLabel = new System.Windows.Forms.Label();
            this.MissNumberLabel = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ScoreGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(12, 515);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(85, 35);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(103, 515);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(85, 35);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.Location = new System.Drawing.Point(194, 515);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(85, 35);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // ScoreGroupBox
            // 
            this.ScoreGroupBox.Controls.Add(this.MissNumberLabel);
            this.ScoreGroupBox.Controls.Add(this.MissTitleLabel);
            this.ScoreGroupBox.Controls.Add(this.HitsNumberLabel);
            this.ScoreGroupBox.Controls.Add(this.HitsTitleLabel);
            this.ScoreGroupBox.Location = new System.Drawing.Point(551, 450);
            this.ScoreGroupBox.Name = "ScoreGroupBox";
            this.ScoreGroupBox.Size = new System.Drawing.Size(200, 100);
            this.ScoreGroupBox.TabIndex = 3;
            this.ScoreGroupBox.TabStop = false;
            this.ScoreGroupBox.Text = "Hits and Misses";
            // 
            // HitsTitleLabel
            // 
            this.HitsTitleLabel.AutoSize = true;
            this.HitsTitleLabel.Location = new System.Drawing.Point(7, 20);
            this.HitsTitleLabel.Name = "HitsTitleLabel";
            this.HitsTitleLabel.Size = new System.Drawing.Size(25, 13);
            this.HitsTitleLabel.TabIndex = 0;
            this.HitsTitleLabel.Text = "Hits";
            // 
            // HitsNumberLabel
            // 
            this.HitsNumberLabel.AutoSize = true;
            this.HitsNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HitsNumberLabel.Location = new System.Drawing.Point(7, 55);
            this.HitsNumberLabel.Name = "HitsNumberLabel";
            this.HitsNumberLabel.Size = new System.Drawing.Size(2, 15);
            this.HitsNumberLabel.TabIndex = 1;
            // 
            // MissTitleLabel
            // 
            this.MissTitleLabel.AutoSize = true;
            this.MissTitleLabel.Location = new System.Drawing.Point(106, 20);
            this.MissTitleLabel.Name = "MissTitleLabel";
            this.MissTitleLabel.Size = new System.Drawing.Size(39, 13);
            this.MissTitleLabel.TabIndex = 2;
            this.MissTitleLabel.Text = "Misses";
            // 
            // MissNumberLabel
            // 
            this.MissNumberLabel.AutoSize = true;
            this.MissNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MissNumberLabel.Location = new System.Drawing.Point(106, 55);
            this.MissNumberLabel.Name = "MissNumberLabel";
            this.MissNumberLabel.Size = new System.Drawing.Size(2, 15);
            this.MissNumberLabel.TabIndex = 3;
            // 
            // PictureBox
            // 
            this.PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox.BackgroundImage")));
            this.PictureBox.Location = new System.Drawing.Point(210, 56);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(220, 220);
            this.PictureBox.TabIndex = 4;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 400;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TargetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 562);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.ScoreGroupBox);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "TargetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Target Form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TargetForm_MouseDown);
            this.ScoreGroupBox.ResumeLayout(false);
            this.ScoreGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.GroupBox ScoreGroupBox;
        private System.Windows.Forms.Label MissNumberLabel;
        private System.Windows.Forms.Label MissTitleLabel;
        private System.Windows.Forms.Label HitsNumberLabel;
        private System.Windows.Forms.Label HitsTitleLabel;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Timer Timer;
    }
}