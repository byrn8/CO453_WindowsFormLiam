namespace CO453_WindowsFormLiam.Unit_3
{
    partial class PizzaShopForm
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
            this.PizzaTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.SmallRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumRadioButton = new System.Windows.Forms.RadioButton();
            this.LargeRadioButton = new System.Windows.Forms.RadioButton();
            this.PizzaCostGroupBox = new System.Windows.Forms.GroupBox();
            this.PizzaCostLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.ToppingGroupBox = new System.Windows.Forms.GroupBox();
            this.CB4 = new System.Windows.Forms.CheckBox();
            this.CB3 = new System.Windows.Forms.CheckBox();
            this.CB2 = new System.Windows.Forms.CheckBox();
            this.CB1 = new System.Windows.Forms.CheckBox();
            this.PizzaTypeGroupBox.SuspendLayout();
            this.PizzaCostGroupBox.SuspendLayout();
            this.ToppingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PizzaTypeGroupBox
            // 
            this.PizzaTypeGroupBox.Controls.Add(this.SmallRadioButton);
            this.PizzaTypeGroupBox.Controls.Add(this.MediumRadioButton);
            this.PizzaTypeGroupBox.Controls.Add(this.LargeRadioButton);
            this.PizzaTypeGroupBox.Location = new System.Drawing.Point(31, 42);
            this.PizzaTypeGroupBox.Name = "PizzaTypeGroupBox";
            this.PizzaTypeGroupBox.Size = new System.Drawing.Size(84, 98);
            this.PizzaTypeGroupBox.TabIndex = 0;
            this.PizzaTypeGroupBox.TabStop = false;
            this.PizzaTypeGroupBox.Text = "Pizza Type";
            // 
            // SmallRadioButton
            // 
            this.SmallRadioButton.AutoSize = true;
            this.SmallRadioButton.Location = new System.Drawing.Point(7, 68);
            this.SmallRadioButton.Name = "SmallRadioButton";
            this.SmallRadioButton.Size = new System.Drawing.Size(50, 17);
            this.SmallRadioButton.TabIndex = 2;
            this.SmallRadioButton.TabStop = true;
            this.SmallRadioButton.Text = "Small";
            this.SmallRadioButton.UseVisualStyleBackColor = true;
            this.SmallRadioButton.CheckedChanged += new System.EventHandler(this.SmallRadioButton_CheckedChanged);
            // 
            // MediumRadioButton
            // 
            this.MediumRadioButton.AutoSize = true;
            this.MediumRadioButton.Location = new System.Drawing.Point(7, 44);
            this.MediumRadioButton.Name = "MediumRadioButton";
            this.MediumRadioButton.Size = new System.Drawing.Size(62, 17);
            this.MediumRadioButton.TabIndex = 1;
            this.MediumRadioButton.TabStop = true;
            this.MediumRadioButton.Text = "Medium";
            this.MediumRadioButton.UseVisualStyleBackColor = true;
            this.MediumRadioButton.CheckedChanged += new System.EventHandler(this.MediumRadioButton_CheckedChanged);
            // 
            // LargeRadioButton
            // 
            this.LargeRadioButton.AutoSize = true;
            this.LargeRadioButton.Location = new System.Drawing.Point(7, 20);
            this.LargeRadioButton.Name = "LargeRadioButton";
            this.LargeRadioButton.Size = new System.Drawing.Size(52, 17);
            this.LargeRadioButton.TabIndex = 0;
            this.LargeRadioButton.TabStop = true;
            this.LargeRadioButton.Text = "Large";
            this.LargeRadioButton.UseVisualStyleBackColor = true;
            this.LargeRadioButton.CheckedChanged += new System.EventHandler(this.LargeRadioButton_CheckedChanged);
            // 
            // PizzaCostGroupBox
            // 
            this.PizzaCostGroupBox.Controls.Add(this.PizzaCostLabel);
            this.PizzaCostGroupBox.Location = new System.Drawing.Point(31, 162);
            this.PizzaCostGroupBox.Name = "PizzaCostGroupBox";
            this.PizzaCostGroupBox.Size = new System.Drawing.Size(200, 59);
            this.PizzaCostGroupBox.TabIndex = 1;
            this.PizzaCostGroupBox.TabStop = false;
            this.PizzaCostGroupBox.Text = "Pizza Cost";
            // 
            // PizzaCostLabel
            // 
            this.PizzaCostLabel.AutoSize = true;
            this.PizzaCostLabel.Location = new System.Drawing.Point(6, 27);
            this.PizzaCostLabel.Name = "PizzaCostLabel";
            this.PizzaCostLabel.Size = new System.Drawing.Size(0, 13);
            this.PizzaCostLabel.TabIndex = 0;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(249, 198);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // ToppingGroupBox
            // 
            this.ToppingGroupBox.Controls.Add(this.CB4);
            this.ToppingGroupBox.Controls.Add(this.CB3);
            this.ToppingGroupBox.Controls.Add(this.CB2);
            this.ToppingGroupBox.Controls.Add(this.CB1);
            this.ToppingGroupBox.Location = new System.Drawing.Point(136, 42);
            this.ToppingGroupBox.Name = "ToppingGroupBox";
            this.ToppingGroupBox.Size = new System.Drawing.Size(188, 100);
            this.ToppingGroupBox.TabIndex = 3;
            this.ToppingGroupBox.TabStop = false;
            this.ToppingGroupBox.Text = "Toppings";
            // 
            // CB4
            // 
            this.CB4.AutoSize = true;
            this.CB4.Location = new System.Drawing.Point(93, 68);
            this.CB4.Name = "CB4";
            this.CB4.Size = new System.Drawing.Size(82, 17);
            this.CB4.TabIndex = 3;
            this.CB4.Text = "BBQ Sauce";
            this.CB4.UseVisualStyleBackColor = true;
            this.CB4.CheckedChanged += new System.EventHandler(this.CB4_CheckedChanged);
            // 
            // CB3
            // 
            this.CB3.AutoSize = true;
            this.CB3.Location = new System.Drawing.Point(7, 68);
            this.CB3.Name = "CB3";
            this.CB3.Size = new System.Drawing.Size(73, 17);
            this.CB3.TabIndex = 2;
            this.CB3.Text = "Pineapple";
            this.CB3.UseVisualStyleBackColor = true;
            this.CB3.CheckedChanged += new System.EventHandler(this.CB3_CheckedChanged);
            // 
            // CB2
            // 
            this.CB2.AutoSize = true;
            this.CB2.Location = new System.Drawing.Point(93, 19);
            this.CB2.Name = "CB2";
            this.CB2.Size = new System.Drawing.Size(48, 17);
            this.CB2.TabIndex = 1;
            this.CB2.Text = "Ham";
            this.CB2.UseVisualStyleBackColor = true;
            this.CB2.CheckedChanged += new System.EventHandler(this.CB2_CheckedChanged);
            // 
            // CB1
            // 
            this.CB1.AutoSize = true;
            this.CB1.Location = new System.Drawing.Point(7, 20);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(74, 17);
            this.CB1.TabIndex = 0;
            this.CB1.Text = "Pepperoni";
            this.CB1.UseVisualStyleBackColor = true;
            this.CB1.CheckedChanged += new System.EventHandler(this.CB1_CheckedChanged);
            // 
            // PizzaShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(349, 238);
            this.Controls.Add(this.ToppingGroupBox);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.PizzaCostGroupBox);
            this.Controls.Add(this.PizzaTypeGroupBox);
            this.Name = "PizzaShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Shop Selection Screen";
            this.PizzaTypeGroupBox.ResumeLayout(false);
            this.PizzaTypeGroupBox.PerformLayout();
            this.PizzaCostGroupBox.ResumeLayout(false);
            this.PizzaCostGroupBox.PerformLayout();
            this.ToppingGroupBox.ResumeLayout(false);
            this.ToppingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PizzaTypeGroupBox;
        private System.Windows.Forms.GroupBox PizzaCostGroupBox;
        private System.Windows.Forms.RadioButton SmallRadioButton;
        private System.Windows.Forms.RadioButton MediumRadioButton;
        private System.Windows.Forms.RadioButton LargeRadioButton;
        private System.Windows.Forms.Label PizzaCostLabel;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.GroupBox ToppingGroupBox;
        private System.Windows.Forms.CheckBox CB4;
        private System.Windows.Forms.CheckBox CB3;
        private System.Windows.Forms.CheckBox CB2;
        private System.Windows.Forms.CheckBox CB1;
    }
}