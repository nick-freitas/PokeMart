using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeMart
{
    public partial class Payment : Form
    {

        public delegate void PaymentMadeEvent(object sender, PaymentMadeEventArgs e);

        public event PaymentMadeEvent PaymentMade;

        private decimal paymentAmount;
        public decimal PaymentAmount
        {
            get => paymentAmount; set
            {
                paymentAmount = value;
                textBoxAmountToPay.Text = String.Format("{0:c}", paymentAmount);
            }
        }

        public Payment()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amountToPay = decimal.Parse(textBoxAmountToPay.Text.TrimStart('$'));
                decimal paymentAmount = decimal.Parse(textBoxPayment.Text);
                decimal newAmountToPay = amountToPay - paymentAmount;

                if (newAmountToPay > 0)
                {
                    textBoxAmountToPay.Text = newAmountToPay.ToString();
                }
                else
                {
                    string changeMessage = String.Format("Change: {0:c}", newAmountToPay);
                    MessageBox.Show(changeMessage);
                    PaymentMade(this, new PaymentMadeEventArgs() { PaymentSuccess = true });
                    Close();
                }
            }
            catch
            {

                MessageBox.Show("Payment Amount is not valid");
            }
            
        }
    }

    public class PaymentMadeEventArgs : EventArgs
    {
        private bool paymentSuccess;

        public bool PaymentSuccess { get => paymentSuccess; set => paymentSuccess = value; }
    }

}
