namespace CO453_WindowsFormLiam.Unit_3
{
    partial class CurrencyConverterForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CosmeticPanel = new System.Windows.Forms.Panel();
            this.UKMoneyLabel = new System.Windows.Forms.Label();
            this.ConvertedTitleLabel = new System.Windows.Forms.Label();
            this.UKMoneyTextBox = new System.Windows.Forms.TextBox();
            this.ConvertedMoneyLabel = new System.Windows.Forms.Label();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.DollarsButton = new System.Windows.Forms.RadioButton();
            this.EurosButton = new System.Windows.Forms.RadioButton();
            this.RupeesButton = new System.Windows.Forms.RadioButton();
            this.QuitButton = new System.Windows.Forms.Button();
            this.ContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(252, 31);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Currency Converter";
            // 
            // CosmeticPanel
            // 
            this.CosmeticPanel.BackColor = System.Drawing.Color.Black;
            this.CosmeticPanel.Location = new System.Drawing.Point(12, 43);
            this.CosmeticPanel.Name = "CosmeticPanel";
            this.CosmeticPanel.Size = new System.Drawing.Size(335, 16);
            this.CosmeticPanel.TabIndex = 1;
            // 
            // UKMoneyLabel
            // 
            this.UKMoneyLabel.AutoSize = true;
            this.UKMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UKMoneyLabel.Location = new System.Drawing.Point(82, 87);
            this.UKMoneyLabel.Name = "UKMoneyLabel";
            this.UKMoneyLabel.Size = new System.Drawing.Size(126, 25);
            this.UKMoneyLabel.TabIndex = 2;
            this.UKMoneyLabel.Text = "UK Pounds:";
            // 
            // ConvertedTitleLabel
            // 
            this.ConvertedTitleLabel.AutoSize = true;
            this.ConvertedTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertedTitleLabel.Location = new System.Drawing.Point(12, 136);
            this.ConvertedTitleLabel.Name = "ConvertedTitleLabel";
            this.ConvertedTitleLabel.Size = new System.Drawing.Size(196, 25);
            this.ConvertedTitleLabel.TabIndex = 3;
            this.ConvertedTitleLabel.Text = "Converted Amount:";
            // 
            // UKMoneyTextBox
            // 
            this.UKMoneyTextBox.Location = new System.Drawing.Point(214, 92);
            this.UKMoneyTextBox.Name = "UKMoneyTextBox";
            this.UKMoneyTextBox.Size = new System.Drawing.Size(133, 20);
            this.UKMoneyTextBox.TabIndex = 4;
            // 
            // ConvertedMoneyLabel
            // 
            this.ConvertedMoneyLabel.AutoSize = true;
            this.ConvertedMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertedMoneyLabel.Location = new System.Drawing.Point(214, 136);
            this.ConvertedMoneyLabel.Name = "ConvertedMoneyLabel";
            this.ConvertedMoneyLabel.Size = new System.Drawing.Size(33, 25);
            this.ConvertedMoneyLabel.TabIndex = 5;
            this.ConvertedMoneyLabel.Text = "---";
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Controls.Add(this.RupeesButton);
            this.ContainerPanel.Controls.Add(this.EurosButton);
            this.ContainerPanel.Controls.Add(this.DollarsButton);
            this.ContainerPanel.Location = new System.Drawing.Point(364, 43);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(109, 69);
            this.ContainerPanel.TabIndex = 6;
            // 
            // DollarsButton
            // 
            this.DollarsButton.AutoSize = true;
            this.DollarsButton.Location = new System.Drawing.Point(11, 3);
            this.DollarsButton.Name = "DollarsButton";
            this.DollarsButton.Size = new System.Drawing.Size(57, 17);
            this.DollarsButton.TabIndex = 0;
            this.DollarsButton.TabStop = true;
            this.DollarsButton.Text = "Dollars";
            this.DollarsButton.UseVisualStyleBackColor = true;
            this.DollarsButton.CheckedChanged += new System.EventHandler(this.DollarsButton_CheckedChanged);
            // 
            // EurosButton
            // 
            this.EurosButton.AutoSize = true;
            this.EurosButton.Location = new System.Drawing.Point(11, 26);
            this.EurosButton.Name = "EurosButton";
            this.EurosButton.Size = new System.Drawing.Size(52, 17);
            this.EurosButton.TabIndex = 1;
            this.EurosButton.TabStop = true;
            this.EurosButton.Text = "Euros";
            this.EurosButton.UseVisualStyleBackColor = true;
            this.EurosButton.CheckedChanged += new System.EventHandler(this.EurosButton_CheckedChanged);
            // 
            // RupeesButton
            // 
            this.RupeesButton.AutoSize = true;
            this.RupeesButton.Location = new System.Drawing.Point(11, 49);
            this.RupeesButton.Name = "RupeesButton";
            this.RupeesButton.Size = new System.Drawing.Size(62, 17);
            this.RupeesButton.TabIndex = 2;
            this.RupeesButton.TabStop = true;
            this.RupeesButton.Text = "Rupees";
            this.RupeesButton.UseVisualStyleBackColor = true;
            this.RupeesButton.CheckedChanged += new System.EventHandler(this.RupeesButton_CheckedChanged);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(364, 138);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(109, 23);
            this.QuitButton.TabIndex = 7;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CurrencyConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(498, 181);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.ConvertedMoneyLabel);
            this.Controls.Add(this.UKMoneyTextBox);
            this.Controls.Add(this.ConvertedTitleLabel);
            this.Controls.Add(this.UKMoneyLabel);
            this.Controls.Add(this.CosmeticPanel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "CurrencyConverterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrencyConverterForm";
            this.ContainerPanel.ResumeLayout(false);
            this.ContainerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel CosmeticPanel;
        private System.Windows.Forms.Label UKMoneyLabel;
        private System.Windows.Forms.Label ConvertedTitleLabel;
        private System.Windows.Forms.TextBox UKMoneyTextBox;
        private System.Windows.Forms.Label ConvertedMoneyLabel;
        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.RadioButton RupeesButton;
        private System.Windows.Forms.RadioButton EurosButton;
        private System.Windows.Forms.RadioButton DollarsButton;
        private System.Windows.Forms.Button QuitButton;
    }
}