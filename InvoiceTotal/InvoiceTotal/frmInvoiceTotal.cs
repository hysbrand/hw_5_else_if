using System.Diagnostics.Eventing.Reader;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string customerType = txtCustomerType.Text.Trim().ToUpper();
            decimal invoiceSubtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = 0m;

            if (customerType == "R")
            {
                if (invoiceSubtotal >= 500)
                    discountPercent = .30m;
                else if (invoiceSubtotal >= 250)
                    discountPercent = .25m;
                else
                    discountPercent = 0m;
            }
            else if (customerType == "C")
            {
                discountPercent = .20m;
            }
            else if (customerType == "T")
            {
                if (invoiceSubtotal >= 500)
                    discountPercent = .50m;
                else
                    discountPercent = .40m;
            }
            else
            {
                discountPercent = .10m;
            }

            decimal discountAmount = invoiceSubtotal * discountPercent;
            decimal total = invoiceSubtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = total.ToString("c");

            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
