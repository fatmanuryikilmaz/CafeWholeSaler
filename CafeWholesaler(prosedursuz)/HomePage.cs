using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeWholesaler_prosedursuz_
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void BtnProductAddUpdate_Click(object sender, EventArgs e)
        {
            Product go = new Product();
            go.Show();
            this.Hide();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            OrderPage orderPage = new OrderPage();
            orderPage.Show();
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Admin go=new Admin();
            go.Show();
            this.Close();
        }

        private void BtnOrderDetails_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails = new OrderDetails();
            orderDetails.Show();
            this.Close();
        }

        private void BtnCustomerAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Close();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
