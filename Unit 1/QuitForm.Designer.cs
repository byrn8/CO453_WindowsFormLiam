namespace CO453_WindowsFormLiam.Unit1
{
    partial class QuitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuitForm));
            this.GoodByeLabel = new System.Windows.Forms.Label();
            this.QuitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GoodByeLabel
            // 
            this.GoodByeLabel.AutoSize = true;
            this.GoodByeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodByeLabel.Location = new System.Drawing.Point(280, 120);
            this.GoodByeLabel.Name = "GoodByeLabel";
            this.GoodByeLabel.Size = new System.Drawing.Size(89, 24);
            this.GoodByeLabel.TabIndex = 0;
            this.GoodByeLabel.Text = "GoodBye";
            // 
            // QuitLabel
            // 
            this.QuitLabel.AutoSize = true;
            this.QuitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitLabel.Location = new System.Drawing.Point(261, 176);
            this.QuitLabel.Name = "QuitLabel";
            this.QuitLabel.Size = new System.Drawing.Size(126, 24);
            this.QuitLabel.TabIndex = 1;
            this.QuitLabel.Text = "Click to Finish";
            // 
            // QuitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(655, 347);
            this.Controls.Add(this.QuitLabel);
            this.Controls.Add(this.GoodByeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuitForm";
            this.Click += new System.EventHandler(this.QuitForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GoodByeLabel;
        private System.Windows.Forms.Label QuitLabel;
    }
}