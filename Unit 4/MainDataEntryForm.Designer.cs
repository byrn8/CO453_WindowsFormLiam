namespace CO453_WindowsFormLiam.Unit_4
{
    partial class MainDataEntryForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.SchoolLabel = new System.Windows.Forms.Label();
            this.SchoolCombobox = new System.Windows.Forms.ComboBox();
            this.DiningGroupbox = new System.Windows.Forms.GroupBox();
            this.DiningCombobox = new System.Windows.Forms.ComboBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.TotalButton = new System.Windows.Forms.Button();
            this.SeeBillButton = new System.Windows.Forms.Button();
            this.DiningGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 40);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name :";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(89, 37);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(100, 20);
            this.NameTextbox.TabIndex = 1;
            // 
            // SchoolLabel
            // 
            this.SchoolLabel.AutoSize = true;
            this.SchoolLabel.Location = new System.Drawing.Point(13, 90);
            this.SchoolLabel.Name = "SchoolLabel";
            this.SchoolLabel.Size = new System.Drawing.Size(46, 13);
            this.SchoolLabel.TabIndex = 2;
            this.SchoolLabel.Text = "School :";
            // 
            // SchoolCombobox
            // 
            this.SchoolCombobox.FormattingEnabled = true;
            this.SchoolCombobox.Items.AddRange(new object[] {
            "The Beaconsfield School",
            "The Highcrest Academy",
            "Bourne End Academy"});
            this.SchoolCombobox.Location = new System.Drawing.Point(89, 87);
            this.SchoolCombobox.Name = "SchoolCombobox";
            this.SchoolCombobox.Size = new System.Drawing.Size(166, 21);
            this.SchoolCombobox.TabIndex = 3;
            // 
            // DiningGroupbox
            // 
            this.DiningGroupbox.Controls.Add(this.DiningCombobox);
            this.DiningGroupbox.Location = new System.Drawing.Point(15, 139);
            this.DiningGroupbox.Name = "DiningGroupbox";
            this.DiningGroupbox.Size = new System.Drawing.Size(200, 100);
            this.DiningGroupbox.TabIndex = 4;
            this.DiningGroupbox.TabStop = false;
            this.DiningGroupbox.Text = "Dining :";
            // 
            // DiningCombobox
            // 
            this.DiningCombobox.FormattingEnabled = true;
            this.DiningCombobox.Items.AddRange(new object[] {
            "None",
            "Lunch",
            "Dinner",
            "Lunch + Dinner"});
            this.DiningCombobox.Location = new System.Drawing.Point(6, 19);
            this.DiningCombobox.Name = "DiningCombobox";
            this.DiningCombobox.Size = new System.Drawing.Size(188, 21);
            this.DiningCombobox.TabIndex = 0;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(383, 214);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // TotalButton
            // 
            this.TotalButton.Location = new System.Drawing.Point(302, 214);
            this.TotalButton.Name = "TotalButton";
            this.TotalButton.Size = new System.Drawing.Size(75, 23);
            this.TotalButton.TabIndex = 6;
            this.TotalButton.Text = "Total";
            this.TotalButton.UseVisualStyleBackColor = true;
            this.TotalButton.Click += new System.EventHandler(this.TotalButton_Click);
            // 
            // SeeBillButton
            // 
            this.SeeBillButton.Location = new System.Drawing.Point(221, 214);
            this.SeeBillButton.Name = "SeeBillButton";
            this.SeeBillButton.Size = new System.Drawing.Size(75, 23);
            this.SeeBillButton.TabIndex = 7;
            this.SeeBillButton.Text = "See Bill";
            this.SeeBillButton.UseVisualStyleBackColor = true;
            this.SeeBillButton.Click += new System.EventHandler(this.SeeBillButton_Click);
            // 
            // MainDataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(470, 249);
            this.Controls.Add(this.SeeBillButton);
            this.Controls.Add(this.TotalButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.DiningGroupbox);
            this.Controls.Add(this.SchoolCombobox);
            this.Controls.Add(this.SchoolLabel);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.NameLabel);
            this.Name = "MainDataEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Entry Form";
            this.DiningGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label SchoolLabel;
        private System.Windows.Forms.ComboBox SchoolCombobox;
        private System.Windows.Forms.GroupBox DiningGroupbox;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button TotalButton;
        private System.Windows.Forms.Button SeeBillButton;
        private System.Windows.Forms.ComboBox DiningCombobox;
    }
}