namespace CO453_WindowsFormLiam.Unit_2
{
    partial class RPSGameForm
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
            this.UserChoiceBox = new System.Windows.Forms.GroupBox();
            this.UserPBox = new System.Windows.Forms.PictureBox();
            this.ScissorsRButton = new System.Windows.Forms.RadioButton();
            this.PaperRButton = new System.Windows.Forms.RadioButton();
            this.RockRButton = new System.Windows.Forms.RadioButton();
            this.CompChoiceBox = new System.Windows.Forms.GroupBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ComputerPBox = new System.Windows.Forms.PictureBox();
            this.ResultBox = new System.Windows.Forms.GroupBox();
            this.CompScoreLabel = new System.Windows.Forms.Label();
            this.UserScoreLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.UserTitleLabel = new System.Windows.Forms.Label();
            this.CompTitleLabel = new System.Windows.Forms.Label();
            this.UserChoiceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPBox)).BeginInit();
            this.CompChoiceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPBox)).BeginInit();
            this.ResultBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserChoiceBox
            // 
            this.UserChoiceBox.Controls.Add(this.UserPBox);
            this.UserChoiceBox.Controls.Add(this.ScissorsRButton);
            this.UserChoiceBox.Controls.Add(this.PaperRButton);
            this.UserChoiceBox.Controls.Add(this.RockRButton);
            this.UserChoiceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserChoiceBox.Location = new System.Drawing.Point(12, 12);
            this.UserChoiceBox.Name = "UserChoiceBox";
            this.UserChoiceBox.Size = new System.Drawing.Size(257, 363);
            this.UserChoiceBox.TabIndex = 0;
            this.UserChoiceBox.TabStop = false;
            this.UserChoiceBox.Text = "User Choice";
            // 
            // UserPBox
            // 
            this.UserPBox.Location = new System.Drawing.Point(28, 25);
            this.UserPBox.Name = "UserPBox";
            this.UserPBox.Size = new System.Drawing.Size(200, 200);
            this.UserPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPBox.TabIndex = 3;
            this.UserPBox.TabStop = false;
            // 
            // ScissorsRButton
            // 
            this.ScissorsRButton.AutoSize = true;
            this.ScissorsRButton.Location = new System.Drawing.Point(6, 333);
            this.ScissorsRButton.Name = "ScissorsRButton";
            this.ScissorsRButton.Size = new System.Drawing.Size(87, 24);
            this.ScissorsRButton.TabIndex = 2;
            this.ScissorsRButton.Text = "Scissors";
            this.ScissorsRButton.UseVisualStyleBackColor = true;
            this.ScissorsRButton.CheckedChanged += new System.EventHandler(this.ScissorsRButton_CheckedChanged);
            // 
            // PaperRButton
            // 
            this.PaperRButton.AutoSize = true;
            this.PaperRButton.Location = new System.Drawing.Point(6, 303);
            this.PaperRButton.Name = "PaperRButton";
            this.PaperRButton.Size = new System.Drawing.Size(69, 24);
            this.PaperRButton.TabIndex = 1;
            this.PaperRButton.Text = "Paper";
            this.PaperRButton.UseVisualStyleBackColor = true;
            this.PaperRButton.CheckedChanged += new System.EventHandler(this.PaperRButton_CheckedChanged);
            // 
            // RockRButton
            // 
            this.RockRButton.AutoSize = true;
            this.RockRButton.Location = new System.Drawing.Point(6, 273);
            this.RockRButton.Name = "RockRButton";
            this.RockRButton.Size = new System.Drawing.Size(64, 24);
            this.RockRButton.TabIndex = 0;
            this.RockRButton.Text = "Rock";
            this.RockRButton.UseVisualStyleBackColor = true;
            this.RockRButton.CheckedChanged += new System.EventHandler(this.RockRButton_CheckedChanged);
            // 
            // CompChoiceBox
            // 
            this.CompChoiceBox.Controls.Add(this.PlayButton);
            this.CompChoiceBox.Controls.Add(this.ComputerPBox);
            this.CompChoiceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompChoiceBox.Location = new System.Drawing.Point(299, 12);
            this.CompChoiceBox.Name = "CompChoiceBox";
            this.CompChoiceBox.Size = new System.Drawing.Size(257, 363);
            this.CompChoiceBox.TabIndex = 1;
            this.CompChoiceBox.TabStop = false;
            this.CompChoiceBox.Text = "Computer Choice";
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(90, 273);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 39);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ComputerPBox
            // 
            this.ComputerPBox.Location = new System.Drawing.Point(29, 25);
            this.ComputerPBox.Name = "ComputerPBox";
            this.ComputerPBox.Size = new System.Drawing.Size(200, 200);
            this.ComputerPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ComputerPBox.TabIndex = 0;
            this.ComputerPBox.TabStop = false;
            // 
            // ResultBox
            // 
            this.ResultBox.Controls.Add(this.CompTitleLabel);
            this.ResultBox.Controls.Add(this.UserTitleLabel);
            this.ResultBox.Controls.Add(this.CompScoreLabel);
            this.ResultBox.Controls.Add(this.UserScoreLabel);
            this.ResultBox.Controls.Add(this.ResultLabel);
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBox.Location = new System.Drawing.Point(586, 12);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(257, 225);
            this.ResultBox.TabIndex = 2;
            this.ResultBox.TabStop = false;
            this.ResultBox.Text = "Result";
            // 
            // CompScoreLabel
            // 
            this.CompScoreLabel.AutoSize = true;
            this.CompScoreLabel.Location = new System.Drawing.Point(122, 173);
            this.CompScoreLabel.Name = "CompScoreLabel";
            this.CompScoreLabel.Size = new System.Drawing.Size(0, 20);
            this.CompScoreLabel.TabIndex = 2;
            // 
            // UserScoreLabel
            // 
            this.UserScoreLabel.AutoSize = true;
            this.UserScoreLabel.Location = new System.Drawing.Point(122, 114);
            this.UserScoreLabel.Name = "UserScoreLabel";
            this.UserScoreLabel.Size = new System.Drawing.Size(0, 20);
            this.UserScoreLabel.TabIndex = 1;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Location = new System.Drawing.Point(89, 35);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(108, 31);
            this.ResultLabel.TabIndex = 0;
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.Location = new System.Drawing.Point(679, 286);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 39);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // UserTitleLabel
            // 
            this.UserTitleLabel.AutoSize = true;
            this.UserTitleLabel.Location = new System.Drawing.Point(89, 84);
            this.UserTitleLabel.Name = "UserTitleLabel";
            this.UserTitleLabel.Size = new System.Drawing.Size(89, 20);
            this.UserTitleLabel.TabIndex = 3;
            this.UserTitleLabel.Text = "User Score";
            // 
            // CompTitleLabel
            // 
            this.CompTitleLabel.AutoSize = true;
            this.CompTitleLabel.Location = new System.Drawing.Point(89, 143);
            this.CompTitleLabel.Name = "CompTitleLabel";
            this.CompTitleLabel.Size = new System.Drawing.Size(125, 20);
            this.CompTitleLabel.TabIndex = 4;
            this.CompTitleLabel.Text = "Computer Score";
            // 
            // RPSGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(874, 401);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.CompChoiceBox);
            this.Controls.Add(this.UserChoiceBox);
            this.Name = "RPSGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors Game";
            this.Load += new System.EventHandler(this.RPSGameForm_Load);
            this.UserChoiceBox.ResumeLayout(false);
            this.UserChoiceBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPBox)).EndInit();
            this.CompChoiceBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPBox)).EndInit();
            this.ResultBox.ResumeLayout(false);
            this.ResultBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserChoiceBox;
        private System.Windows.Forms.PictureBox UserPBox;
        private System.Windows.Forms.RadioButton ScissorsRButton;
        private System.Windows.Forms.RadioButton PaperRButton;
        private System.Windows.Forms.RadioButton RockRButton;
        private System.Windows.Forms.GroupBox CompChoiceBox;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.PictureBox ComputerPBox;
        private System.Windows.Forms.GroupBox ResultBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label CompScoreLabel;
        private System.Windows.Forms.Label UserScoreLabel;
        private System.Windows.Forms.Label CompTitleLabel;
        private System.Windows.Forms.Label UserTitleLabel;
    }
}