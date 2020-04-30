namespace CO453_WindowsFormLiam
{
    partial class DataEntryForm
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.SNameLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.FNameTextBox = new System.Windows.Forms.TextBox();
            this.SNameTextBox = new System.Windows.Forms.TextBox();
            this.MessageButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.UpperButton = new System.Windows.Forms.Button();
            this.LowerButton = new System.Windows.Forms.Button();
            this.ChangeMessageButton = new System.Windows.Forms.Button();
            this.TownLabel = new System.Windows.Forms.Label();
            this.TownTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.MainLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(50, 20);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(295, 39);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "User Details Data Entry";
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(430, 270);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 1;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLabel.Location = new System.Drawing.Point(50, 80);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(89, 23);
            this.FNameLabel.TabIndex = 2;
            this.FNameLabel.Text = "First Name:";
            // 
            // SNameLabel
            // 
            this.SNameLabel.AutoSize = true;
            this.SNameLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNameLabel.Location = new System.Drawing.Point(50, 120);
            this.SNameLabel.Name = "SNameLabel";
            this.SNameLabel.Size = new System.Drawing.Size(78, 23);
            this.SNameLabel.TabIndex = 3;
            this.SNameLabel.Text = "Surname:";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(200, 230);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(2, 25);
            this.MessageLabel.TabIndex = 4;
            // 
            // FNameTextBox
            // 
            this.FNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FNameTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameTextBox.Location = new System.Drawing.Point(200, 85);
            this.FNameTextBox.Name = "FNameTextBox";
            this.FNameTextBox.Size = new System.Drawing.Size(100, 29);
            this.FNameTextBox.TabIndex = 5;
            // 
            // SNameTextBox
            // 
            this.SNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SNameTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNameTextBox.Location = new System.Drawing.Point(200, 125);
            this.SNameTextBox.Name = "SNameTextBox";
            this.SNameTextBox.Size = new System.Drawing.Size(100, 29);
            this.SNameTextBox.TabIndex = 6;
            // 
            // MessageButton
            // 
            this.MessageButton.Location = new System.Drawing.Point(50, 270);
            this.MessageButton.Name = "MessageButton";
            this.MessageButton.Size = new System.Drawing.Size(75, 23);
            this.MessageButton.TabIndex = 7;
            this.MessageButton.Text = "Message";
            this.MessageButton.UseVisualStyleBackColor = true;
            this.MessageButton.Click += new System.EventHandler(this.MessageButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(430, 207);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(99, 23);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear Message";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // UpperButton
            // 
            this.UpperButton.Location = new System.Drawing.Point(430, 85);
            this.UpperButton.Name = "UpperButton";
            this.UpperButton.Size = new System.Drawing.Size(75, 23);
            this.UpperButton.TabIndex = 9;
            this.UpperButton.Text = "Upper Case";
            this.UpperButton.UseVisualStyleBackColor = true;
            this.UpperButton.Click += new System.EventHandler(this.UpperButton_Click);
            // 
            // LowerButton
            // 
            this.LowerButton.Location = new System.Drawing.Point(430, 125);
            this.LowerButton.Name = "LowerButton";
            this.LowerButton.Size = new System.Drawing.Size(75, 23);
            this.LowerButton.TabIndex = 10;
            this.LowerButton.Text = "Lower Case";
            this.LowerButton.UseVisualStyleBackColor = true;
            this.LowerButton.Click += new System.EventHandler(this.LowerButton_Click);
            // 
            // ChangeMessageButton
            // 
            this.ChangeMessageButton.Location = new System.Drawing.Point(430, 165);
            this.ChangeMessageButton.Name = "ChangeMessageButton";
            this.ChangeMessageButton.Size = new System.Drawing.Size(99, 23);
            this.ChangeMessageButton.TabIndex = 11;
            this.ChangeMessageButton.Text = "Change Message";
            this.ChangeMessageButton.UseVisualStyleBackColor = true;
            this.ChangeMessageButton.Click += new System.EventHandler(this.ChangeMessageButton_Click);
            // 
            // TownLabel
            // 
            this.TownLabel.AutoSize = true;
            this.TownLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TownLabel.Location = new System.Drawing.Point(50, 160);
            this.TownLabel.Name = "TownLabel";
            this.TownLabel.Size = new System.Drawing.Size(52, 23);
            this.TownLabel.TabIndex = 12;
            this.TownLabel.Text = "Town:";
            // 
            // TownTextBox
            // 
            this.TownTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TownTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TownTextBox.Location = new System.Drawing.Point(200, 165);
            this.TownTextBox.Name = "TownTextBox";
            this.TownTextBox.Size = new System.Drawing.Size(100, 29);
            this.TownTextBox.TabIndex = 13;
            // 
            // DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.TownTextBox);
            this.Controls.Add(this.TownLabel);
            this.Controls.Add(this.ChangeMessageButton);
            this.Controls.Add(this.LowerButton);
            this.Controls.Add(this.UpperButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.MessageButton);
            this.Controls.Add(this.SNameTextBox);
            this.Controls.Add(this.FNameTextBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.SNameLabel);
            this.Controls.Add(this.FNameLabel);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.MainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DataEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.Label SNameLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox FNameTextBox;
        private System.Windows.Forms.TextBox SNameTextBox;
        private System.Windows.Forms.Button MessageButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button UpperButton;
        private System.Windows.Forms.Button LowerButton;
        private System.Windows.Forms.Button ChangeMessageButton;
        private System.Windows.Forms.Label TownLabel;
        private System.Windows.Forms.TextBox TownTextBox;
    }
}