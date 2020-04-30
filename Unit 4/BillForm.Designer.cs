namespace CO453_WindowsFormLiam.Unit_4
{
    partial class BillForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameResultLabel = new System.Windows.Forms.Label();
            this.SchoolLabel = new System.Windows.Forms.Label();
            this.SchoolResultLabel = new System.Windows.Forms.Label();
            this.TotalBillLabel = new System.Windows.Forms.Label();
            this.TBResultLabel = new System.Windows.Forms.Label();
            this.AcceptBillButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(383, 214);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(13, 25);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(80, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name :";
            // 
            // NameResultLabel
            // 
            this.NameResultLabel.AutoSize = true;
            this.NameResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameResultLabel.Location = new System.Drawing.Point(128, 25);
            this.NameResultLabel.Name = "NameResultLabel";
            this.NameResultLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameResultLabel.Size = new System.Drawing.Size(2, 27);
            this.NameResultLabel.TabIndex = 2;
            // 
            // SchoolLabel
            // 
            this.SchoolLabel.AutoSize = true;
            this.SchoolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchoolLabel.Location = new System.Drawing.Point(12, 69);
            this.SchoolLabel.Name = "SchoolLabel";
            this.SchoolLabel.Size = new System.Drawing.Size(90, 25);
            this.SchoolLabel.TabIndex = 3;
            this.SchoolLabel.Text = "School :";
            // 
            // SchoolResultLabel
            // 
            this.SchoolResultLabel.AutoSize = true;
            this.SchoolResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SchoolResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchoolResultLabel.Location = new System.Drawing.Point(128, 69);
            this.SchoolResultLabel.Name = "SchoolResultLabel";
            this.SchoolResultLabel.Size = new System.Drawing.Size(2, 27);
            this.SchoolResultLabel.TabIndex = 4;
            // 
            // TotalBillLabel
            // 
            this.TotalBillLabel.AutoSize = true;
            this.TotalBillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBillLabel.Location = new System.Drawing.Point(13, 133);
            this.TotalBillLabel.Name = "TotalBillLabel";
            this.TotalBillLabel.Size = new System.Drawing.Size(107, 25);
            this.TotalBillLabel.TabIndex = 5;
            this.TotalBillLabel.Text = "Total Bill :";
            // 
            // TBResultLabel
            // 
            this.TBResultLabel.AutoSize = true;
            this.TBResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBResultLabel.Location = new System.Drawing.Point(128, 133);
            this.TBResultLabel.Name = "TBResultLabel";
            this.TBResultLabel.Size = new System.Drawing.Size(2, 27);
            this.TBResultLabel.TabIndex = 6;
            // 
            // AcceptBillButton
            // 
            this.AcceptBillButton.Location = new System.Drawing.Point(302, 214);
            this.AcceptBillButton.Name = "AcceptBillButton";
            this.AcceptBillButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptBillButton.TabIndex = 7;
            this.AcceptBillButton.Text = "Accept Bill";
            this.AcceptBillButton.UseVisualStyleBackColor = true;
            this.AcceptBillButton.Click += new System.EventHandler(this.AcceptBillButton_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(470, 249);
            this.Controls.Add(this.AcceptBillButton);
            this.Controls.Add(this.TBResultLabel);
            this.Controls.Add(this.TotalBillLabel);
            this.Controls.Add(this.SchoolResultLabel);
            this.Controls.Add(this.SchoolLabel);
            this.Controls.Add(this.NameResultLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CloseButton);
            this.Name = "BillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SchoolLabel;
        private System.Windows.Forms.Label TotalBillLabel;
        public System.Windows.Forms.Label NameResultLabel;
        public System.Windows.Forms.Label SchoolResultLabel;
        public System.Windows.Forms.Label TBResultLabel;
        private System.Windows.Forms.Button AcceptBillButton;
    }
}