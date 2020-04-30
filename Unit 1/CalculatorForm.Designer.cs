namespace CO453_WindowsFormLiam.Unit1
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.FirstNumTextBox = new System.Windows.Forms.TextBox();
            this.SecNumTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.ResultLabel2 = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.FirstNumberLabel = new System.Windows.Forms.Label();
            this.SecNumberLabel = new System.Windows.Forms.Label();
            this.ResultLabel1 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AverageButton = new System.Windows.Forms.Button();
            this.PowerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNumTextBox
            // 
            this.FirstNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNumTextBox.Location = new System.Drawing.Point(267, 59);
            this.FirstNumTextBox.Name = "FirstNumTextBox";
            this.FirstNumTextBox.Size = new System.Drawing.Size(100, 44);
            this.FirstNumTextBox.TabIndex = 0;
            // 
            // SecNumTextBox
            // 
            this.SecNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecNumTextBox.Location = new System.Drawing.Point(267, 109);
            this.SecNumTextBox.Name = "SecNumTextBox";
            this.SecNumTextBox.Size = new System.Drawing.Size(100, 44);
            this.SecNumTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(383, 53);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 50);
            this.AddButton.TabIndex = 2;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubtractButton.BackgroundImage")));
            this.SubtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractButton.Location = new System.Drawing.Point(439, 53);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(50, 50);
            this.SubtractButton.TabIndex = 3;
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MultiplyButton.BackgroundImage")));
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.Location = new System.Drawing.Point(383, 109);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(50, 50);
            this.MultiplyButton.TabIndex = 4;
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DivideButton.BackgroundImage")));
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.Location = new System.Drawing.Point(439, 109);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(50, 50);
            this.DivideButton.TabIndex = 5;
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // ResultLabel2
            // 
            this.ResultLabel2.AutoSize = true;
            this.ResultLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ResultLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel2.Location = new System.Drawing.Point(227, 162);
            this.ResultLabel2.Name = "ResultLabel2";
            this.ResultLabel2.Size = new System.Drawing.Size(0, 37);
            this.ResultLabel2.TabIndex = 6;
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.Location = new System.Drawing.Point(117, 212);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 33);
            this.QuitButton.TabIndex = 7;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // FirstNumberLabel
            // 
            this.FirstNumberLabel.AutoSize = true;
            this.FirstNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNumberLabel.Location = new System.Drawing.Point(113, 59);
            this.FirstNumberLabel.Name = "FirstNumberLabel";
            this.FirstNumberLabel.Size = new System.Drawing.Size(104, 20);
            this.FirstNumberLabel.TabIndex = 8;
            this.FirstNumberLabel.Text = "First Number:";
            // 
            // SecNumberLabel
            // 
            this.SecNumberLabel.AutoSize = true;
            this.SecNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecNumberLabel.Location = new System.Drawing.Point(113, 109);
            this.SecNumberLabel.Name = "SecNumberLabel";
            this.SecNumberLabel.Size = new System.Drawing.Size(128, 20);
            this.SecNumberLabel.TabIndex = 9;
            this.SecNumberLabel.Text = "Second Number:";
            // 
            // ResultLabel1
            // 
            this.ResultLabel1.AutoSize = true;
            this.ResultLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel1.Location = new System.Drawing.Point(113, 162);
            this.ResultLabel1.Name = "ResultLabel1";
            this.ResultLabel1.Size = new System.Drawing.Size(59, 20);
            this.ResultLabel1.TabIndex = 10;
            this.ResultLabel1.Text = "Result:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(110, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(268, 37);
            this.TitleLabel.TabIndex = 11;
            this.TitleLabel.Text = "Simple Calculator";
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(495, 131);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(95, 33);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AverageButton
            // 
            this.AverageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageButton.Location = new System.Drawing.Point(495, 92);
            this.AverageButton.Name = "AverageButton";
            this.AverageButton.Size = new System.Drawing.Size(95, 33);
            this.AverageButton.TabIndex = 13;
            this.AverageButton.Text = "Average";
            this.AverageButton.UseVisualStyleBackColor = true;
            this.AverageButton.Click += new System.EventHandler(this.AverageButton_Click);
            // 
            // PowerButton
            // 
            this.PowerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerButton.Location = new System.Drawing.Point(495, 53);
            this.PowerButton.Name = "PowerButton";
            this.PowerButton.Size = new System.Drawing.Size(95, 33);
            this.PowerButton.TabIndex = 14;
            this.PowerButton.Text = "Power";
            this.PowerButton.UseVisualStyleBackColor = true;
            this.PowerButton.Click += new System.EventHandler(this.PowerButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(651, 283);
            this.Controls.Add(this.PowerButton);
            this.Controls.Add(this.AverageButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ResultLabel1);
            this.Controls.Add(this.SecNumberLabel);
            this.Controls.Add(this.FirstNumberLabel);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ResultLabel2);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SecNumTextBox);
            this.Controls.Add(this.FirstNumTextBox);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNumTextBox;
        private System.Windows.Forms.TextBox SecNumTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Label ResultLabel2;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label FirstNumberLabel;
        private System.Windows.Forms.Label SecNumberLabel;
        private System.Windows.Forms.Label ResultLabel1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AverageButton;
        private System.Windows.Forms.Button PowerButton;
    }
}