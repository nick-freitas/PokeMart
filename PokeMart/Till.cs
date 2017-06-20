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
    public partial class Till : Form
    {
        private const int BUTTON_SIZE = 100;

        private BindingList<Product> products;
        private PokeMartEntities dbContext;
        private decimal transactionTotal;

        public decimal TransactionTotal
        {
            get { return transactionTotal; }
            set
            {
                transactionTotal = value;
                textBoxTransactionTotal.Text = String.Format("{0:c}", transactionTotal);
            }
        }

        public Till()
        {
            InitializeComponent();

            TransactionTotal = 0;
            dbContext = new PokeMartEntities();
            products = new BindingList<Product>();
            listBoxProductList.DataSource = products;
            listBoxProductList.DisplayMember = "Name";

            CreateTypeTabs();
            AddProductsToTabs();
        }

        private void CreateTypeTabs()
        {
            foreach (Type type in dbContext.Types)
            {
                TabPage tabPage = new TabPage(type.Name);
                tabPage.Name = type.Id.ToString();
                tabControlTypes.TabPages.Add(tabPage);
            }
        }

        private void AddProductsToTabs()
        {
            foreach (TabPage tabPage in tabControlTypes.TabPages)
            {
                int typeId = Int32.Parse(tabPage.Name);

                IEnumerable<Product> products = from product in dbContext.Products
                                                where product.Type == typeId
                                                select product;

                FlowLayoutPanel layoutPanel = new FlowLayoutPanel();
                layoutPanel.Dock = DockStyle.Fill;

                foreach (Product product in products)
                {
                    Button button = new Button();
                    button.Size = new Size(BUTTON_SIZE, BUTTON_SIZE);
                    button.Text = product.Name;
                    button.Tag = product;
                    button.Font = new Font(FontFamily.GenericMonospace, 12, FontStyle.Bold);
                    button.TextAlign = ContentAlignment.BottomCenter;
                    if (product.Image != null)
                    {
                        button.BackgroundImage = Image.FromStream(new MemoryStream(product.Image));
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    button.Click += new EventHandler(UpdateProductList);

                    layoutPanel.Controls.Add(button);
                }

                tabPage.Controls.Add(layoutPanel);
            }
        }

        private void UpdateProductList(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Product product = (Product)button.Tag;

            products.Add(product);
            TransactionTotal += (decimal)product.Price;
            UpdateInformationPanel(product);

            listBoxProductList.SelectedIndex = listBoxProductList.Items.Count - 1;
        }

        private void UpdateInformationPanel(Product product)
        {
            textBoxInformationBox.Text = GetFormattedProductNameAndPrice(product);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBoxProductList_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = GetFormattedProductNameAndPrice((Product)e.ListItem);
        }

        private string GetFormattedProductNameAndPrice(Product product)
        {
            string productName = product.Name.PadRight(20);
            decimal productPrice = (decimal)product.Price;

            return String.Format("{0}{1:c}", productName, productPrice);
        }

        private void TabControlTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();

            payment.PaymentMade += new Payment.PaymentMadeEvent(paymentMade);
            payment.PaymentAmount = TransactionTotal;

            payment.ShowDialog();
        }

        private void paymentMade(object sender, PaymentMadeEventArgs e)
        {
            Sale sale = new Sale();
            sale.Date = DateTime.Now;

            if (e.PaymentSuccess == false)
            {
                return;
            }

            foreach (Product product in products)
            {
                sale.SaleProducts.Add(new SaleProduct() { Product = product.Id });
            }

            dbContext.Sales.Add(sale);
            dbContext.SaveChanges();

            textBoxInformationBox.Text = String.Format("Paid {0:c}", TransactionTotal);
            products.Clear();
        }

        private void Till_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Product product = (Product)listBoxProductList.SelectedItem;

            products.Remove(product);
            TransactionTotal -= (Decimal)product.Price;
            textBoxInformationBox.Text = String.Format("{0}{1}", "Deleted ", GetFormattedProductNameAndPrice(product));
        }

        private void textBoxInformationBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
