using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeMart
{
    public partial class ManageProducts : Form
    {
        private PokeMartEntities dbContext;
        private Byte[] uploadedPhoto;

        public ManageProducts()
        {
            InitializeComponent();

            dbContext = new PokeMartEntities();

            comboBoxType.DataSource = dbContext.Types.ToList();
            comboBoxType.DisplayMember = "Name";
            comboBoxType.ValueMember = "Id";
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init() {
            var products = from product in dbContext.Products
                           select new
                           {
                               product.Name,
                               Type = product.Type1.Name,
                               product.Description,
                               Price = product.Price,
                               MinBadges = product.MinLevel,
                               product.Image
                           };

            dataGridViewProductList.DataSource = products.ToList();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonUploadPhoto_Click(object sender, EventArgs e)
        {
            DialogResult uploadPhotoDialogResult = openFileDialogUploadPhoto.ShowDialog();

            switch (uploadPhotoDialogResult)
            {
                case DialogResult.OK:
                    FileStream fsBlobFile = new FileStream(openFileDialogUploadPhoto.FileName, FileMode.Open, FileAccess.Read);

                    uploadedPhoto = new Byte[fsBlobFile.Length];

                    fsBlobFile.Read(uploadedPhoto, 0, uploadedPhoto.Length);
                    fsBlobFile.Close();

                    pictureBoxPhoto.Image = Image.FromStream(new MemoryStream(uploadedPhoto));
                    break;
                default:
                    break;
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    Name = textBoxName.Text,
                    Type = (int)comboBoxType.SelectedValue,
                    Description = richTextBoxDescription.Text,
                    Price = decimal.Parse(textBoxPrice.Text),
                    Image = uploadedPhoto,
                    MinLevel = getSelectedMinBadgeRadioButton()
                };

                dbContext.Products.Add(product);
                dbContext.SaveChanges();

                Init();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private int getSelectedMinBadgeRadioButton()
        {
            if (radioButtonMinBadge0.Checked) return 0;
            if (radioButtonMinBadge1.Checked) return 1;
            if (radioButtonMinBadge2.Checked) return 2;
            if (radioButtonMinBadge3.Checked) return 3;
            if (radioButtonMinBadge4.Checked) return 4;
            if (radioButtonMinBadge5.Checked) return 5;
            if (radioButtonMinBadge6.Checked) return 6;
            if (radioButtonMinBadge7.Checked) return 7;
            if (radioButtonMinBadge8.Checked) return 8;

            throw new Exception("No Min Badge Radio Buttons were selected");
        }

        private void richTextBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
