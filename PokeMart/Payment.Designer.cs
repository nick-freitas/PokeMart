namespace PokeMart
{
    partial class Payment
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
            this.labelAmountToPay = new System.Windows.Forms.Label();
            this.textBoxAmountToPay = new System.Windows.Forms.TextBox();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.labelPayment = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAmountToPay
            // 
            this.labelAmountToPay.AutoSize = true;
            this.labelAmountToPay.Location = new System.Drawing.Point(33, 32);
            this.labelAmountToPay.Name = "labelAmountToPay";
            this.labelAmountToPay.Size = new System.Drawing.Size(209, 32);
            this.labelAmountToPay.TabIndex = 0;
            this.labelAmountToPay.Text = "Amount To Pay";
            this.labelAmountToPay.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxAmountToPay
            // 
            this.textBoxAmountToPay.Location = new System.Drawing.Point(271, 29);
            this.textBoxAmountToPay.Name = "textBoxAmountToPay";
            this.textBoxAmountToPay.ReadOnly = true;
            this.textBoxAmountToPay.Size = new System.Drawing.Size(510, 38);
            this.textBoxAmountToPay.TabIndex = 1;
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Location = new System.Drawing.Point(271, 98);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(510, 38);
            this.textBoxPayment.TabIndex = 2;
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Location = new System.Drawing.Point(115, 98);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(127, 32);
            this.labelPayment.TabIndex = 3;
            this.labelPayment.Text = "Payment";
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(271, 167);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(510, 47);
            this.buttonPay.TabIndex = 4;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 267);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.labelPayment);
            this.Controls.Add(this.textBoxPayment);
            this.Controls.Add(this.textBoxAmountToPay);
            this.Controls.Add(this.labelAmountToPay);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAmountToPay;
        private System.Windows.Forms.TextBox textBoxAmountToPay;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Button buttonPay;
    }
}