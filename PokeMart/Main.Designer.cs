namespace PokeMart
{
    partial class Main
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
			this.buttonManageProduct = new System.Windows.Forms.Button();
			this.buttonOpenTill = new System.Windows.Forms.Button();
			this.buttonSalesGraph = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonManageProduct
			// 
			this.buttonManageProduct.Location = new System.Drawing.Point(12, 18);
			this.buttonManageProduct.Name = "buttonManageProduct";
			this.buttonManageProduct.Size = new System.Drawing.Size(1864, 150);
			this.buttonManageProduct.TabIndex = 0;
			this.buttonManageProduct.Text = "Manage Products";
			this.buttonManageProduct.UseVisualStyleBackColor = true;
			this.buttonManageProduct.UseWaitCursor = true;
			this.buttonManageProduct.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// buttonOpenTill
			// 
			this.buttonOpenTill.Location = new System.Drawing.Point(12, 330);
			this.buttonOpenTill.Name = "buttonOpenTill";
			this.buttonOpenTill.Size = new System.Drawing.Size(1864, 150);
			this.buttonOpenTill.TabIndex = 1;
			this.buttonOpenTill.Text = "Open Till";
			this.buttonOpenTill.UseVisualStyleBackColor = true;
			this.buttonOpenTill.UseWaitCursor = true;
			this.buttonOpenTill.Click += new System.EventHandler(this.buttonOpenTill_Click);
			// 
			// buttonSalesGraph
			// 
			this.buttonSalesGraph.Location = new System.Drawing.Point(12, 174);
			this.buttonSalesGraph.Name = "buttonSalesGraph";
			this.buttonSalesGraph.Size = new System.Drawing.Size(1864, 150);
			this.buttonSalesGraph.TabIndex = 2;
			this.buttonSalesGraph.Text = "Sales Graph";
			this.buttonSalesGraph.UseVisualStyleBackColor = true;
			this.buttonSalesGraph.UseWaitCursor = true;
			this.buttonSalesGraph.Click += new System.EventHandler(this.buttonSalesGraph_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1888, 992);
			this.Controls.Add(this.buttonSalesGraph);
			this.Controls.Add(this.buttonOpenTill);
			this.Controls.Add(this.buttonManageProduct);
			this.Name = "Main";
			this.Text = "PokeMart";
			this.UseWaitCursor = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

        }

        #endregion
        private PokeMartDataSet pokeMartDataSet1;
        private System.Windows.Forms.Button buttonManageProduct;
        private System.Windows.Forms.Button buttonOpenTill;
		private System.Windows.Forms.Button buttonSalesGraph;
	}
}

