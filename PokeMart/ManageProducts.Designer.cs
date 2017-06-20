namespace PokeMart
{
    partial class ManageProducts
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
            this.dataGridViewProductList = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelAddProduct = new System.Windows.Forms.Panel();
            this.buttonUploadPhoto = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.radioButtonMinBadge8 = new System.Windows.Forms.RadioButton();
            this.radioButtonMinBadge7 = new System.Windows.Forms.RadioButton();
            this.radioButtonMinBadge6 = new System.Windows.Forms.RadioButton();
            this.radioButtonMinBadge5 = new System.Windows.Forms.RadioButton();
            this.radioButtonMinBadge4 = new System.Windows.Forms.RadioButton();
            this.radioButtonMinBadge3 = new System.Windows.Forms.RadioButton();
            this.radioButtonMinBadge2 = new System.Windows.Forms.RadioButton();
            this.radioButtonMinBadge1 = new System.Windows.Forms.RadioButton();
            this.radioButtonMinBadge0 = new System.Windows.Forms.RadioButton();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelMinBadges = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddProduct = new System.Windows.Forms.Label();
            this.openFileDialogUploadPhoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).BeginInit();
            this.panelAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductList
            // 
            this.dataGridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductList.Location = new System.Drawing.Point(12, 714);
            this.dataGridViewProductList.Name = "dataGridViewProductList";
            this.dataGridViewProductList.RowTemplate.Height = 40;
            this.dataGridViewProductList.Size = new System.Drawing.Size(1408, 332);
            this.dataGridViewProductList.TabIndex = 0;
            this.dataGridViewProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1273, 1052);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(147, 51);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelAddProduct
            // 
            this.panelAddProduct.Controls.Add(this.buttonUploadPhoto);
            this.panelAddProduct.Controls.Add(this.buttonAddProduct);
            this.panelAddProduct.Controls.Add(this.pictureBoxPhoto);
            this.panelAddProduct.Controls.Add(this.labelPhoto);
            this.panelAddProduct.Controls.Add(this.richTextBoxDescription);
            this.panelAddProduct.Controls.Add(this.labelDescription);
            this.panelAddProduct.Controls.Add(this.radioButtonMinBadge8);
            this.panelAddProduct.Controls.Add(this.radioButtonMinBadge7);
            this.panelAddProduct.Controls.Add(this.radioButtonMinBadge6);
            this.panelAddProduct.Controls.Add(this.radioButtonMinBadge5);
            this.panelAddProduct.Controls.Add(this.radioButtonMinBadge4);
            this.panelAddProduct.Controls.Add(this.radioButtonMinBadge3);
            this.panelAddProduct.Controls.Add(this.radioButtonMinBadge2);
            this.panelAddProduct.Controls.Add(this.radioButtonMinBadge1);
            this.panelAddProduct.Controls.Add(this.radioButtonMinBadge0);
            this.panelAddProduct.Controls.Add(this.textBoxPrice);
            this.panelAddProduct.Controls.Add(this.labelMinBadges);
            this.panelAddProduct.Controls.Add(this.labelPrice);
            this.panelAddProduct.Controls.Add(this.comboBoxType);
            this.panelAddProduct.Controls.Add(this.labelType);
            this.panelAddProduct.Controls.Add(this.textBoxName);
            this.panelAddProduct.Controls.Add(this.labelName);
            this.panelAddProduct.Controls.Add(this.labelAddProduct);
            this.panelAddProduct.Location = new System.Drawing.Point(13, 12);
            this.panelAddProduct.Name = "panelAddProduct";
            this.panelAddProduct.Size = new System.Drawing.Size(1407, 696);
            this.panelAddProduct.TabIndex = 2;
            // 
            // buttonUploadPhoto
            // 
            this.buttonUploadPhoto.Location = new System.Drawing.Point(1203, 544);
            this.buttonUploadPhoto.Name = "buttonUploadPhoto";
            this.buttonUploadPhoto.Size = new System.Drawing.Size(147, 47);
            this.buttonUploadPhoto.TabIndex = 22;
            this.buttonUploadPhoto.Text = "Upload";
            this.buttonUploadPhoto.UseVisualStyleBackColor = true;
            this.buttonUploadPhoto.Click += new System.EventHandler(this.buttonUploadPhoto_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(18, 627);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(136, 58);
            this.buttonAddProduct.TabIndex = 21;
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(916, 153);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(450, 450);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 20;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(910, 101);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(90, 32);
            this.labelPhoto.TabIndex = 19;
            this.labelPhoto.Text = "Photo";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(199, 408);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(658, 194);
            this.richTextBoxDescription.TabIndex = 18;
            this.richTextBoxDescription.Text = "";
            this.richTextBoxDescription.TextChanged += new System.EventHandler(this.richTextBoxDescription_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(13, 408);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(158, 32);
            this.labelDescription.TabIndex = 17;
            this.labelDescription.Text = "Description";
            // 
            // radioButtonMinBadge8
            // 
            this.radioButtonMinBadge8.AutoSize = true;
            this.radioButtonMinBadge8.Location = new System.Drawing.Point(529, 351);
            this.radioButtonMinBadge8.Name = "radioButtonMinBadge8";
            this.radioButtonMinBadge8.Size = new System.Drawing.Size(68, 36);
            this.radioButtonMinBadge8.TabIndex = 16;
            this.radioButtonMinBadge8.TabStop = true;
            this.radioButtonMinBadge8.Text = "8";
            this.radioButtonMinBadge8.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinBadge7
            // 
            this.radioButtonMinBadge7.AutoSize = true;
            this.radioButtonMinBadge7.Location = new System.Drawing.Point(367, 351);
            this.radioButtonMinBadge7.Name = "radioButtonMinBadge7";
            this.radioButtonMinBadge7.Size = new System.Drawing.Size(68, 36);
            this.radioButtonMinBadge7.TabIndex = 15;
            this.radioButtonMinBadge7.TabStop = true;
            this.radioButtonMinBadge7.Text = "7";
            this.radioButtonMinBadge7.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinBadge6
            // 
            this.radioButtonMinBadge6.AutoSize = true;
            this.radioButtonMinBadge6.Location = new System.Drawing.Point(199, 351);
            this.radioButtonMinBadge6.Name = "radioButtonMinBadge6";
            this.radioButtonMinBadge6.Size = new System.Drawing.Size(68, 36);
            this.radioButtonMinBadge6.TabIndex = 14;
            this.radioButtonMinBadge6.TabStop = true;
            this.radioButtonMinBadge6.Text = "6";
            this.radioButtonMinBadge6.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinBadge5
            // 
            this.radioButtonMinBadge5.AutoSize = true;
            this.radioButtonMinBadge5.Location = new System.Drawing.Point(529, 309);
            this.radioButtonMinBadge5.Name = "radioButtonMinBadge5";
            this.radioButtonMinBadge5.Size = new System.Drawing.Size(68, 36);
            this.radioButtonMinBadge5.TabIndex = 13;
            this.radioButtonMinBadge5.TabStop = true;
            this.radioButtonMinBadge5.Text = "5";
            this.radioButtonMinBadge5.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinBadge4
            // 
            this.radioButtonMinBadge4.AutoSize = true;
            this.radioButtonMinBadge4.Location = new System.Drawing.Point(365, 309);
            this.radioButtonMinBadge4.Name = "radioButtonMinBadge4";
            this.radioButtonMinBadge4.Size = new System.Drawing.Size(68, 36);
            this.radioButtonMinBadge4.TabIndex = 12;
            this.radioButtonMinBadge4.TabStop = true;
            this.radioButtonMinBadge4.Text = "4";
            this.radioButtonMinBadge4.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinBadge3
            // 
            this.radioButtonMinBadge3.AutoSize = true;
            this.radioButtonMinBadge3.Location = new System.Drawing.Point(199, 309);
            this.radioButtonMinBadge3.Name = "radioButtonMinBadge3";
            this.radioButtonMinBadge3.Size = new System.Drawing.Size(68, 36);
            this.radioButtonMinBadge3.TabIndex = 11;
            this.radioButtonMinBadge3.TabStop = true;
            this.radioButtonMinBadge3.Text = "3";
            this.radioButtonMinBadge3.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinBadge2
            // 
            this.radioButtonMinBadge2.AutoSize = true;
            this.radioButtonMinBadge2.Location = new System.Drawing.Point(529, 267);
            this.radioButtonMinBadge2.Name = "radioButtonMinBadge2";
            this.radioButtonMinBadge2.Size = new System.Drawing.Size(68, 36);
            this.radioButtonMinBadge2.TabIndex = 10;
            this.radioButtonMinBadge2.TabStop = true;
            this.radioButtonMinBadge2.Text = "2";
            this.radioButtonMinBadge2.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinBadge1
            // 
            this.radioButtonMinBadge1.AutoSize = true;
            this.radioButtonMinBadge1.Location = new System.Drawing.Point(367, 267);
            this.radioButtonMinBadge1.Name = "radioButtonMinBadge1";
            this.radioButtonMinBadge1.Size = new System.Drawing.Size(68, 36);
            this.radioButtonMinBadge1.TabIndex = 9;
            this.radioButtonMinBadge1.TabStop = true;
            this.radioButtonMinBadge1.Text = "1";
            this.radioButtonMinBadge1.UseVisualStyleBackColor = true;
            this.radioButtonMinBadge1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonMinBadge0
            // 
            this.radioButtonMinBadge0.AutoSize = true;
            this.radioButtonMinBadge0.Location = new System.Drawing.Point(199, 267);
            this.radioButtonMinBadge0.Name = "radioButtonMinBadge0";
            this.radioButtonMinBadge0.Size = new System.Drawing.Size(68, 36);
            this.radioButtonMinBadge0.TabIndex = 8;
            this.radioButtonMinBadge0.TabStop = true;
            this.radioButtonMinBadge0.Text = "0";
            this.radioButtonMinBadge0.UseVisualStyleBackColor = true;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(199, 213);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(658, 38);
            this.textBoxPrice.TabIndex = 7;
            // 
            // labelMinBadges
            // 
            this.labelMinBadges.AutoSize = true;
            this.labelMinBadges.Location = new System.Drawing.Point(12, 267);
            this.labelMinBadges.Name = "labelMinBadges";
            this.labelMinBadges.Size = new System.Drawing.Size(165, 32);
            this.labelMinBadges.TabIndex = 6;
            this.labelMinBadges.Text = "Min Badges";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(13, 213);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(80, 32);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Price";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(199, 154);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(658, 39);
            this.comboBoxType.TabIndex = 4;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(13, 163);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(78, 32);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Type";
            this.labelType.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(199, 101);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(658, 38);
            this.textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 107);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(90, 32);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelAddProduct
            // 
            this.labelAddProduct.AutoSize = true;
            this.labelAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddProduct.Location = new System.Drawing.Point(10, 10);
            this.labelAddProduct.Name = "labelAddProduct";
            this.labelAddProduct.Size = new System.Drawing.Size(241, 46);
            this.labelAddProduct.TabIndex = 0;
            this.labelAddProduct.Text = "Add Product";
            this.labelAddProduct.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialogUploadPhoto
            // 
            this.openFileDialogUploadPhoto.FileName = "photo";
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1432, 1115);
            this.Controls.Add(this.panelAddProduct);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewProductList);
            this.Name = "ManageProducts";
            this.Text = "Manage Products";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).EndInit();
            this.panelAddProduct.ResumeLayout(false);
            this.panelAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductList;
        private PokeMartDataSet pokeMartDataSet;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelAddProduct;
        private System.Windows.Forms.Label labelAddProduct;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.RadioButton radioButtonMinBadge2;
        private System.Windows.Forms.RadioButton radioButtonMinBadge1;
        private System.Windows.Forms.RadioButton radioButtonMinBadge0;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelMinBadges;
        private System.Windows.Forms.Button buttonUploadPhoto;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RadioButton radioButtonMinBadge8;
        private System.Windows.Forms.RadioButton radioButtonMinBadge7;
        private System.Windows.Forms.RadioButton radioButtonMinBadge6;
        private System.Windows.Forms.RadioButton radioButtonMinBadge5;
        private System.Windows.Forms.RadioButton radioButtonMinBadge4;
        private System.Windows.Forms.RadioButton radioButtonMinBadge3;
        private System.Windows.Forms.OpenFileDialog openFileDialogUploadPhoto;
    }
}