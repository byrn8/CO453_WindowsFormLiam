namespace CO453_WindowsFormLiam.Unit_3
{
    partial class PoshNoshForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoshNoshForm));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.StarterGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalCostGroupBox = new System.Windows.Forms.GroupBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.StarterListBox = new System.Windows.Forms.ListBox();
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.DessertGroupBox = new System.Windows.Forms.GroupBox();
            this.MainListBox = new System.Windows.Forms.ListBox();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.DessertComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.StarterGroupBox.SuspendLayout();
            this.TotalCostGroupBox.SuspendLayout();
            this.MainGroupBox.SuspendLayout();
            this.DessertGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(249, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(200, 200);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // StarterGroupBox
            // 
            this.StarterGroupBox.Controls.Add(this.StarterListBox);
            this.StarterGroupBox.Location = new System.Drawing.Point(12, 12);
            this.StarterGroupBox.Name = "StarterGroupBox";
            this.StarterGroupBox.Size = new System.Drawing.Size(218, 79);
            this.StarterGroupBox.TabIndex = 1;
            this.StarterGroupBox.TabStop = false;
            this.StarterGroupBox.Text = "Starter";
            // 
            // TotalCostGroupBox
            // 
            this.TotalCostGroupBox.Controls.Add(this.TotalCostLabel);
            this.TotalCostGroupBox.Location = new System.Drawing.Point(249, 218);
            this.TotalCostGroupBox.Name = "TotalCostGroupBox";
            this.TotalCostGroupBox.Size = new System.Drawing.Size(116, 62);
            this.TotalCostGroupBox.TabIndex = 2;
            this.TotalCostGroupBox.TabStop = false;
            this.TotalCostGroupBox.Text = "Total Cost";
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.Location = new System.Drawing.Point(374, 220);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 60);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // StarterListBox
            // 
            this.StarterListBox.FormattingEnabled = true;
            this.StarterListBox.Items.AddRange(new object[] {
            "Soup of the Day",
            "Chilli Fish Cakes",
            "Garlic Bread w/ Cheese",
            "Calamari",
            "Fried Chicken w/ BBQ Dip",
            "Prosciutto",
            "Sweet Potato Fries"});
            this.StarterListBox.Location = new System.Drawing.Point(7, 20);
            this.StarterListBox.Name = "StarterListBox";
            this.StarterListBox.Size = new System.Drawing.Size(205, 43);
            this.StarterListBox.TabIndex = 0;
            this.StarterListBox.SelectedIndexChanged += new System.EventHandler(this.StarterListBox_SelectedIndexChanged);
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.MainListBox);
            this.MainGroupBox.Location = new System.Drawing.Point(12, 107);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(218, 79);
            this.MainGroupBox.TabIndex = 4;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "Main Course";
            // 
            // DessertGroupBox
            // 
            this.DessertGroupBox.Controls.Add(this.DessertComboBox);
            this.DessertGroupBox.Location = new System.Drawing.Point(12, 201);
            this.DessertGroupBox.Name = "DessertGroupBox";
            this.DessertGroupBox.Size = new System.Drawing.Size(218, 79);
            this.DessertGroupBox.TabIndex = 5;
            this.DessertGroupBox.TabStop = false;
            this.DessertGroupBox.Text = "Dessert";
            // 
            // MainListBox
            // 
            this.MainListBox.FormattingEnabled = true;
            this.MainListBox.Items.AddRange(new object[] {
            "Chicken Lasagne",
            "Fish and Chips",
            "Steak and Chips",
            "Vegetable Curry"});
            this.MainListBox.Location = new System.Drawing.Point(7, 20);
            this.MainListBox.Name = "MainListBox";
            this.MainListBox.Size = new System.Drawing.Size(205, 43);
            this.MainListBox.Sorted = true;
            this.MainListBox.TabIndex = 0;
            this.MainListBox.SelectedIndexChanged += new System.EventHandler(this.MainListBox_SelectedIndexChanged);
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(6, 27);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(0, 13);
            this.TotalCostLabel.TabIndex = 0;
            // 
            // DessertComboBox
            // 
            this.DessertComboBox.FormattingEnabled = true;
            this.DessertComboBox.Items.AddRange(new object[] {
            "Cheesecake",
            "Hot Chocolate Cake",
            "Ice Cream Sundae",
            "Chocolate Fudge Brownie"});
            this.DessertComboBox.Location = new System.Drawing.Point(7, 19);
            this.DessertComboBox.Name = "DessertComboBox";
            this.DessertComboBox.Size = new System.Drawing.Size(205, 21);
            this.DessertComboBox.TabIndex = 0;
            this.DessertComboBox.Text = "Dessert Choices";
            this.DessertComboBox.SelectedIndexChanged += new System.EventHandler(this.DessertComboBox_SelectedIndexChanged);
            // 
            // PoshNoshForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(469, 297);
            this.Controls.Add(this.DessertGroupBox);
            this.Controls.Add(this.MainGroupBox);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.TotalCostGroupBox);
            this.Controls.Add(this.StarterGroupBox);
            this.Controls.Add(this.PictureBox);
            this.Name = "PoshNoshForm";
            this.Text = "Posh Noshers Menu Selection";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.StarterGroupBox.ResumeLayout(false);
            this.TotalCostGroupBox.ResumeLayout(false);
            this.TotalCostGroupBox.PerformLayout();
            this.MainGroupBox.ResumeLayout(false);
            this.DessertGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.GroupBox StarterGroupBox;
        private System.Windows.Forms.GroupBox TotalCostGroupBox;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.ListBox StarterListBox;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.ListBox MainListBox;
        private System.Windows.Forms.GroupBox DessertGroupBox;
        private System.Windows.Forms.ComboBox DessertComboBox;
    }
}