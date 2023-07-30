using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeWholesaler_prosedursuz_
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=NURYKLMZ;Database=CafeWholesalerDb;Integrated security=true;");


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void BtnCustomerEntrance_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Customer (CustomerName, CompanyName, CustomerAddress) values (@CustomerName,@CompanyName, @CustomerAddress)",connection);
            cmd.Parameters.AddWithValue("@CustomerName", TxtCustomerName.Text);
            cmd.Parameters.AddWithValue("@CompanyName", TxtCompanyName.Text);
            cmd.Parameters.AddWithValue("@CustomerAddress", TxtCustomerAddress.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            TxtCompanyName.Clear();
            TxtCustomerAddress.Clear();
            TxtCustomerName.Clear();
            MessageBox.Show("Kayıt Başarılı");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
            this.Hide();
        }
    }
}
