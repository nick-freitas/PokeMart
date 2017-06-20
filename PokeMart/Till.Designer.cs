namespace PokeMart
{
    partial class Till
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
            this.listBoxProductList = new System.Windows.Forms.ListBox();
            this.tabControlTypes = new System.Windows.Forms.TabControl();
            this.textBoxInformationBox = new System.Windows.Forms.TextBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxTransactionTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxProductList
            // 
            this.listBoxProductList.Font = new System.Drawing.Font("Courier New", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProductList.FormattingEnabled = true;
            this.listBoxProductList.ItemHeight = 30;
            this.listBoxProductList.Location = new System.Drawing.Point(749, 12);
            this.listBoxProductList.Name = "listBoxProductList";
            this.listBoxProductList.Size = new System.Drawing.Size(656, 814);
            this.listBoxProductList.TabIndex = 0;
            this.listBoxProductList.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            this.listBoxProductList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ListBoxProductList_Format);
            // 
            // tabControlTypes
            // 
            this.tabControlTypes.Location = new System.Drawing.Point(12, 84);
            this.tabControlTypes.Name = "tabControlTypes";
            this.tabControlTypes.SelectedIndex = 0;
            this.tabControlTypes.Size = new System.Drawing.Size(731, 743);
            this.tabControlTypes.TabIndex = 1;
            this.tabControlTypes.SelectedIndexChanged += new System.EventHandler(this.TabControlTypes_SelectedIndexChanged);
            // 
            // textBoxInformationBox
            // 
            this.textBoxInformationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInformationBox.Location = new System.Drawing.Point(13, 12);
            this.textBoxInformationBox.Name = "textBoxInformationBox";
            this.textBoxInformationBox.ReadOnly = true;
            this.textBoxInformationBox.Size = new System.Drawing.Size(730, 53);
            this.textBoxInformationBox.TabIndex = 2;
            this.textBoxInformationBox.Text = "Welcome To The PokeMart";
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonPay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPay.Location = new System.Drawing.Point(13, 833);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(730, 63);
            this.buttonPay.TabIndex = 3;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(749, 833);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(353, 63);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxTransactionTotal
            // 
            this.textBoxTransactionTotal.Location = new System.Drawing.Point(1108, 846);
            this.textBoxTransactionTotal.Name = "textBoxTransactionTotal";
            this.textBoxTransactionTotal.Size = new System.Drawing.Size(297, 38);
            this.textBoxTransactionTotal.TabIndex = 5;
            // 
            // Till
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1417, 908);
            this.Controls.Add(this.textBoxTransactionTotal);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.textBoxInformationBox);
            this.Controls.Add(this.tabControlTypes);
            this.Controls.Add(this.listBoxProductList);
            this.Name = "Till";
            this.Text = "Till";
            this.Load += new System.EventHandler(this.Till_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProductList;
        private System.Windows.Forms.TabControl tabControlTypes;
        private System.Windows.Forms.TextBox textBoxInformationBox;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxTransactionTotal;
    }
}