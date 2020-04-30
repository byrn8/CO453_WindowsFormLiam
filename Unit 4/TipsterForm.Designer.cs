namespace CO453_WindowsFormLiam.Unit_4
{
    partial class TipsterForm
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
            this.BillTextbox = new System.Windows.Forms.TextBox();
            this.PeopleListbox = new System.Windows.Forms.ListBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.BillLabel = new System.Windows.Forms.Label();
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.TipGroupbox = new System.Windows.Forms.GroupBox();
            this.NoneButton = new System.Windows.Forms.RadioButton();
            this.GenerousButton = new System.Windows.Forms.RadioButton();
            this.NormalButton = new System.Windows.Forms.RadioButton();
            this.MadButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.TipGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BillTextbox
            // 
            this.BillTextbox.Location = new System.Drawing.Point(55, 31);
            this.BillTextbox.Name = "BillTextbox";
            this.BillTextbox.Size = new System.Drawing.Size(152, 20);
            this.BillTextbox.TabIndex = 0;
            // 
            // PeopleListbox
            // 
            this.PeopleListbox.FormattingEnabled = true;
            this.PeopleListbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.PeopleListbox.Location = new System.Drawing.Point(162, 139);
            this.PeopleListbox.Name = "PeopleListbox";
            this.PeopleListbox.Size = new System.Drawing.Size(45, 95);
            this.PeopleListbox.TabIndex = 1;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(232, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(200, 200);
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(232, 218);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(357, 218);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // BillLabel
            // 
            this.BillLabel.AutoSize = true;
            this.BillLabel.Location = new System.Drawing.Point(13, 31);
            this.BillLabel.Name = "BillLabel";
            this.BillLabel.Size = new System.Drawing.Size(20, 13);
            this.BillLabel.TabIndex = 5;
            this.BillLabel.Text = "Bill";
            // 
            // PeopleLabel
            // 
            this.PeopleLabel.AutoSize = true;
            this.PeopleLabel.Location = new System.Drawing.Point(13, 139);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(92, 13);
            this.PeopleLabel.TabIndex = 6;
            this.PeopleLabel.Text = "Number of People";
            // 
            // TipGroupbox
            // 
            this.TipGroupbox.Controls.Add(this.MadButton);
            this.TipGroupbox.Controls.Add(this.NormalButton);
            this.TipGroupbox.Controls.Add(this.GenerousButton);
            this.TipGroupbox.Controls.Add(this.NoneButton);
            this.TipGroupbox.Location = new System.Drawing.Point(16, 57);
            this.TipGroupbox.Name = "TipGroupbox";
            this.TipGroupbox.Size = new System.Drawing.Size(191, 70);
            this.TipGroupbox.TabIndex = 7;
            this.TipGroupbox.TabStop = false;
            this.TipGroupbox.Text = "Tip";
            // 
            // NoneButton
            // 
            this.NoneButton.AutoSize = true;
            this.NoneButton.Location = new System.Drawing.Point(7, 20);
            this.NoneButton.Name = "NoneButton";
            this.NoneButton.Size = new System.Drawing.Size(51, 17);
            this.NoneButton.TabIndex = 0;
            this.NoneButton.TabStop = true;
            this.NoneButton.Text = "None";
            this.NoneButton.UseVisualStyleBackColor = true;
            // 
            // GenerousButton
            // 
            this.GenerousButton.AutoSize = true;
            this.GenerousButton.Location = new System.Drawing.Point(7, 43);
            this.GenerousButton.Name = "GenerousButton";
            this.GenerousButton.Size = new System.Drawing.Size(71, 17);
            this.GenerousButton.TabIndex = 1;
            this.GenerousButton.TabStop = true;
            this.GenerousButton.Text = "Generous";
            this.GenerousButton.UseVisualStyleBackColor = true;
            // 
            // NormalButton
            // 
            this.NormalButton.AutoSize = true;
            this.NormalButton.Location = new System.Drawing.Point(99, 20);
            this.NormalButton.Name = "NormalButton";
            this.NormalButton.Size = new System.Drawing.Size(58, 17);
            this.NormalButton.TabIndex = 2;
            this.NormalButton.TabStop = true;
            this.NormalButton.Text = "Normal";
            this.NormalButton.UseVisualStyleBackColor = true;
            // 
            // MadButton
            // 
            this.MadButton.AutoSize = true;
            this.MadButton.Location = new System.Drawing.Point(99, 43);
            this.MadButton.Name = "MadButton";
            this.MadButton.Size = new System.Drawing.Size(46, 17);
            this.MadButton.TabIndex = 3;
            this.MadButton.TabStop = true;
            this.MadButton.Text = "Mad";
            this.MadButton.UseVisualStyleBackColor = true;
            // 
            // TipsterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 246);
            this.Controls.Add(this.TipGroupbox);
            this.Controls.Add(this.PeopleLabel);
            this.Controls.Add(this.BillLabel);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.PeopleListbox);
            this.Controls.Add(this.BillTextbox);
            this.Name = "TipsterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipster Data Entry";
            this.Load += new System.EventHandler(this.TipsterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.TipGroupbox.ResumeLayout(false);
            this.TipGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BillTextbox;
        private System.Windows.Forms.ListBox PeopleListbox;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label BillLabel;
        private System.Windows.Forms.Label PeopleLabel;
        private System.Windows.Forms.GroupBox TipGroupbox;
        private System.Windows.Forms.RadioButton MadButton;
        private System.Windows.Forms.RadioButton NormalButton;
        private System.Windows.Forms.RadioButton GenerousButton;
        private System.Windows.Forms.RadioButton NoneButton;
    }
}