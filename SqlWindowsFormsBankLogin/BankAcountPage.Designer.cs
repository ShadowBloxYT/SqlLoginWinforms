namespace SqlWindowsFormsBankLogin
{
    partial class BankAcountPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankAcountPage));
            this.withdrawButton = new System.Windows.Forms.PictureBox();
            this.depositButton = new System.Windows.Forms.PictureBox();
            this.withdrawAmount = new System.Windows.Forms.TextBox();
            this.depositAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositButton)).BeginInit();
            this.SuspendLayout();
            // 
            // withdrawButton
            // 
            this.withdrawButton.Image = global::SqlWindowsFormsBankLogin.Properties.Resources.withdraw;
            this.withdrawButton.Location = new System.Drawing.Point(74, 119);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(234, 65);
            this.withdrawButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.withdrawButton.TabIndex = 0;
            this.withdrawButton.TabStop = false;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Image = global::SqlWindowsFormsBankLogin.Properties.Resources.deposic;
            this.depositButton.Location = new System.Drawing.Point(1043, 119);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(234, 65);
            this.depositButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.depositButton.TabIndex = 1;
            this.depositButton.TabStop = false;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawAmount
            // 
            this.withdrawAmount.BackColor = System.Drawing.Color.Black;
            this.withdrawAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.withdrawAmount.ForeColor = System.Drawing.Color.Red;
            this.withdrawAmount.Location = new System.Drawing.Point(74, 44);
            this.withdrawAmount.Multiline = true;
            this.withdrawAmount.Name = "withdrawAmount";
            this.withdrawAmount.Size = new System.Drawing.Size(234, 32);
            this.withdrawAmount.TabIndex = 2;
            // 
            // depositAmount
            // 
            this.depositAmount.BackColor = System.Drawing.Color.Black;
            this.depositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.depositAmount.ForeColor = System.Drawing.Color.Red;
            this.depositAmount.Location = new System.Drawing.Point(1043, 44);
            this.depositAmount.Multiline = true;
            this.depositAmount.Name = "depositAmount";
            this.depositAmount.Size = new System.Drawing.Size(234, 32);
            this.depositAmount.TabIndex = 3;
            // 
            // BankAcountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SqlWindowsFormsBankLogin.Properties.Resources.lamborghini_huracan_raining_reflection_cgi_supercars;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.depositAmount);
            this.Controls.Add(this.withdrawAmount);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.withdrawButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BankAcountPage";
            this.Text = "Windows";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.isItClosed);
            ((System.ComponentModel.ISupportInitialize)(this.withdrawButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox withdrawButton;
        private System.Windows.Forms.PictureBox depositButton;
        private System.Windows.Forms.TextBox withdrawAmount;
        private System.Windows.Forms.TextBox depositAmount;
    }
}