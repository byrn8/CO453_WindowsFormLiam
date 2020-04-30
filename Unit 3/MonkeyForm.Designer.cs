namespace CO453_WindowsFormLiam.Unit_3
{
    partial class MonkeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonkeyForm));
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.ScoreGroupBox = new System.Windows.Forms.GroupBox();
            this.MissNumberLabel = new System.Windows.Forms.Label();
            this.MissTitleLabel = new System.Windows.Forms.Label();
            this.HitsNumberLabel = new System.Windows.Forms.Label();
            this.HitsTitleLabel = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.Timer3 = new System.Windows.Forms.Timer(this.components);
            this.Timer4 = new System.Windows.Forms.Timer(this.components);
            this.Timer5 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.ScoreGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
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
            // Timer1
            // 
            this.Timer1.Interval = 600;
            this.Timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(143, 183);
            this.PictureBox1.TabIndex = 3;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox_Click);
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
            this.ScoreGroupBox.TabIndex = 4;
            this.ScoreGroupBox.TabStop = false;
            this.ScoreGroupBox.Text = "Hits and Misses";
            // 
            // MissNumberLabel
            // 
            this.MissNumberLabel.AutoSize = true;
            this.MissNumberLabel.Location = new System.Drawing.Point(108, 65);
            this.MissNumberLabel.Name = "MissNumberLabel";
            this.MissNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.MissNumberLabel.TabIndex = 3;
            // 
            // MissTitleLabel
            // 
            this.MissTitleLabel.AutoSize = true;
            this.MissTitleLabel.Location = new System.Drawing.Point(108, 31);
            this.MissTitleLabel.Name = "MissTitleLabel";
            this.MissTitleLabel.Size = new System.Drawing.Size(39, 13);
            this.MissTitleLabel.TabIndex = 2;
            this.MissTitleLabel.Text = "Misses";
            // 
            // HitsNumberLabel
            // 
            this.HitsNumberLabel.AutoSize = true;
            this.HitsNumberLabel.Location = new System.Drawing.Point(7, 65);
            this.HitsNumberLabel.Name = "HitsNumberLabel";
            this.HitsNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.HitsNumberLabel.TabIndex = 1;
            // 
            // HitsTitleLabel
            // 
            this.HitsTitleLabel.AutoSize = true;
            this.HitsTitleLabel.Location = new System.Drawing.Point(7, 31);
            this.HitsTitleLabel.Name = "HitsTitleLabel";
            this.HitsTitleLabel.Size = new System.Drawing.Size(25, 13);
            this.HitsTitleLabel.TabIndex = 0;
            this.HitsTitleLabel.Text = "Hits";
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(161, 12);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(143, 183);
            this.PictureBox2.TabIndex = 5;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(310, 12);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(143, 183);
            this.PictureBox3.TabIndex = 6;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // PictureBox4
            // 
            this.PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox4.Image")));
            this.PictureBox4.Location = new System.Drawing.Point(459, 12);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(143, 183);
            this.PictureBox4.TabIndex = 7;
            this.PictureBox4.TabStop = false;
            this.PictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // PictureBox5
            // 
            this.PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox5.Image")));
            this.PictureBox5.Location = new System.Drawing.Point(608, 12);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(143, 183);
            this.PictureBox5.TabIndex = 8;
            this.PictureBox5.TabStop = false;
            this.PictureBox5.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // Timer2
            // 
            this.Timer2.Interval = 400;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Timer3
            // 
            this.Timer3.Interval = 500;
            this.Timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // Timer4
            // 
            this.Timer4.Interval = 700;
            this.Timer4.Tick += new System.EventHandler(this.Timer4_Tick);
            // 
            // Timer5
            // 
            this.Timer5.Interval = 800;
            this.Timer5.Tick += new System.EventHandler(this.Timer5_Tick);
            // 
            // MonkeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 562);
            this.Controls.Add(this.PictureBox5);
            this.Controls.Add(this.PictureBox4);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.ScoreGroupBox);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MonkeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monkey Bash";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MonkeyForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ScoreGroupBox.ResumeLayout(false);
            this.ScoreGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.GroupBox ScoreGroupBox;
        private System.Windows.Forms.Label MissNumberLabel;
        private System.Windows.Forms.Label MissTitleLabel;
        private System.Windows.Forms.Label HitsNumberLabel;
        private System.Windows.Forms.Label HitsTitleLabel;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.PictureBox PictureBox3;
        private System.Windows.Forms.PictureBox PictureBox4;
        private System.Windows.Forms.PictureBox PictureBox5;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.Timer Timer3;
        private System.Windows.Forms.Timer Timer4;
        private System.Windows.Forms.Timer Timer5;
    }
}