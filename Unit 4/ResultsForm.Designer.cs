namespace CO453_WindowsFormLiam.Unit_4
{
    partial class ResultsForm
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
            this.BillGroupbox = new System.Windows.Forms.GroupBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TotalBillLabel = new System.Windows.Forms.Label();
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.TBResultLabel = new System.Windows.Forms.Label();
            this.PeopleResultLabel = new System.Windows.Forms.Label();
            this.EachPaysLabel = new System.Windows.Forms.Label();
            this.EPResultLabel = new System.Windows.Forms.Label();
            this.BillGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BillGroupbox
            // 
            this.BillGroupbox.Controls.Add(this.PeopleResultLabel);
            this.BillGroupbox.Controls.Add(this.TBResultLabel);
            this.BillGroupbox.Controls.Add(this.PeopleLabel);
            this.BillGroupbox.Controls.Add(this.TotalBillLabel);
            this.BillGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillGroupbox.Location = new System.Drawing.Point(13, 13);
            this.BillGroupbox.Name = "BillGroupbox";
            this.BillGroupbox.Size = new System.Drawing.Size(180, 100);
            this.BillGroupbox.TabIndex = 0;
            this.BillGroupbox.TabStop = false;
            this.BillGroupbox.Text = "Bill Details";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(266, 191);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TotalBillLabel
            // 
            this.TotalBillLabel.AutoSize = true;
            this.TotalBillLabel.Location = new System.Drawing.Point(6, 22);
            this.TotalBillLabel.Name = "TotalBillLabel";
            this.TotalBillLabel.Size = new System.Drawing.Size(76, 20);
            this.TotalBillLabel.TabIndex = 0;
            this.TotalBillLabel.Text = "Total Bill :";
            // 
            // PeopleLabel
            // 
            this.PeopleLabel.AutoSize = true;
            this.PeopleLabel.Location = new System.Drawing.Point(6, 66);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(66, 20);
            this.PeopleLabel.TabIndex = 1;
            this.PeopleLabel.Text = "People :";
            // 
            // TBResultLabel
            // 
            this.TBResultLabel.AutoSize = true;
            this.TBResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBResultLabel.Location = new System.Drawing.Point(104, 20);
            this.TBResultLabel.Name = "TBResultLabel";
            this.TBResultLabel.Size = new System.Drawing.Size(2, 22);
            this.TBResultLabel.TabIndex = 2;
            // 
            // PeopleResultLabel
            // 
            this.PeopleResultLabel.AutoSize = true;
            this.PeopleResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PeopleResultLabel.Location = new System.Drawing.Point(104, 66);
            this.PeopleResultLabel.Name = "PeopleResultLabel";
            this.PeopleResultLabel.Size = new System.Drawing.Size(2, 22);
            this.PeopleResultLabel.TabIndex = 3;
            // 
            // EachPaysLabel
            // 
            this.EachPaysLabel.AutoSize = true;
            this.EachPaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EachPaysLabel.Location = new System.Drawing.Point(19, 161);
            this.EachPaysLabel.Name = "EachPaysLabel";
            this.EachPaysLabel.Size = new System.Drawing.Size(92, 20);
            this.EachPaysLabel.TabIndex = 2;
            this.EachPaysLabel.Text = "Each Pays :";
            // 
            // EPResultLabel
            // 
            this.EPResultLabel.AutoSize = true;
            this.EPResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EPResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPResultLabel.Location = new System.Drawing.Point(117, 161);
            this.EPResultLabel.Name = "EPResultLabel";
            this.EPResultLabel.Size = new System.Drawing.Size(2, 22);
            this.EPResultLabel.TabIndex = 3;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 226);
            this.Controls.Add(this.EPResultLabel);
            this.Controls.Add(this.EachPaysLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BillGroupbox);
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.BillGroupbox.ResumeLayout(false);
            this.BillGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BillGroupbox;
        private System.Windows.Forms.Label PeopleLabel;
        private System.Windows.Forms.Label TotalBillLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label EachPaysLabel;
        public System.Windows.Forms.Label PeopleResultLabel;
        public System.Windows.Forms.Label TBResultLabel;
        public System.Windows.Forms.Label EPResultLabel;
    }
}