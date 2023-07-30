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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeWholesaler_prosedursuz_
{
    public partial class OrderPage : Form
    {
        public OrderPage()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=NURYKLMZ;Database=CafeWholesalerDb;Integrated security=true;");


        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Close();
        }

        private void OrderPage_Load(object sender, EventArgs e)
        {
            Fatura.Hide();
            connection.Open();
            SqlCommand command = new SqlCommand("select*from Product where isActive != 0", connection);//aktif olmayanları çekme yöntemi
            SqlDataReader reader = command.ExecuteReader();
            CmbProduct.DisplayMember = "Text";
            CmbProduct.ValueMember = "Value";
            while (reader.Read())
            {
                CmbProduct.Items.Add(new { Text = reader["ProductName"], Value= reader["ProductID"] });//productname göster ama value olarak productıd de tut, combobox içini elle yazma databaseden çek
            }
            connection.Close();
            connection.Open();
            SqlCommand command2 = new SqlCommand("select*from Customer", connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            CmbCustomer.DisplayMember = "Text";
            CmbCustomer.ValueMember = "Value";
            while (reader2.Read())
            {
                CmbCustomer.Items.Add(new { Text = reader2["CustomerName"], Value = reader2["CustomerID"] });
            }
            connection.Close();


        }

        private void CmbProduct_SelectedIndexChanged(object sender, EventArgs e)//combobox içeriği değiştiğinde mevcut fiyat databaseden bulunup yanına gelsin
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select Price from Product where ProductID = @ProductID", connection);
            cmd.Parameters.AddWithValue("@ProductID", (CmbProduct.SelectedItem as dynamic).Value);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TxtPrice.Text = reader["Price"].ToString();
            }
            connection.Close();
        }
        List<Order> orders = new List<Order>();//bi yerde tutulan sipariş listelerini database e kaydetmeden elde tutmak için
        private void BtnOrder_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Orders (CustomerID, IsFinished) OUTPUT INSERTED.OrderID values (@CustomerID,0) ", connection);
            cmd.Parameters.AddWithValue("@CustomerID", (CmbCustomer.SelectedItem as dynamic).Value);
            int id = (int)cmd.ExecuteScalar();//sqlin oluşturduğu order id yi output olarak alabiliyor
            connection.Close();

            foreach (var item in orders)//sepetteki her bir item ı al döndür
            {
                connection.Open();
                SqlCommand cmd2 = new SqlCommand("insert into OrderDetails (ProductID, OrderID, Count,ProductPrice) values (@ProductID,@OrderID, @Count, @ProductPrice)", connection);
                cmd2.Parameters.AddWithValue("@ProductID", item.ProductID);
                cmd2.Parameters.AddWithValue("@OrderID", id);
                cmd2.Parameters.AddWithValue("@Count", item.Count);
                cmd2.Parameters.AddWithValue("@ProductPrice", item.Price);
                cmd2.ExecuteNonQueryAsync();
                connection.Close();

            }
            GetBill(id);
            orders = new List<Order>();
            dataGridView1.DataSource = null;
        }
        public void GetBill(int id)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select o.OrderID,p.ProductName,od.Count,od.ProductPrice,c.CompanyName,c.CustomerName,c.CustomerAddress from Orders o join OrderDetails od on o.OrderID=od.OrderID join Product p on p.ProductID=od.ProductID join Customer c on c.CustomerID=o.CustomerID where o.OrderID=@OrderID", connection);
            cmd.Parameters.AddWithValue("@OrderID", id);
            SqlDataReader reader = cmd.ExecuteReader();
            bool isFirst = true;
            Fatura.Show();
            double totalPrice = 0;
            while (reader.Read())
            {
                if (isFirst)
                {
                    Fatura.Items.Add("Müşteri Bilgileri");
                    Fatura.Items.Add("Sipariş Numarası: " + reader["OrderID"].ToString());
                    Fatura.Items.Add("Firma Adı: " + reader["CompanyName"].ToString());
                    Fatura.Items.Add("Müşteri Adı: " + reader["CustomerName"].ToString());
                    Fatura.Items.Add("Firma Adresi: " + reader["CustomerAddress"].ToString());
                    isFirst = false;
                }
                Fatura.Items.Add("Ürün Adı: " + reader["ProductName"].ToString());
                Fatura.Items.Add("Ürün Adedi: " + reader["Count"].ToString());
                Fatura.Items.Add("Ürün Fiyatı: " + reader["ProductPrice"].ToString());
                Fatura.Items.Add("***********************************************");
                totalPrice += Convert.ToDouble(reader["ProductPrice"]) * Convert.ToDouble(reader["Count"]);

            }
            Fatura.Items.Add("Toplam Tutar: " + totalPrice + " TL");

            connection.Close();
                
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            orders.Add(new Order
            {
                Count = Convert.ToInt32(TxtCount.Text),
                ProductID = Convert.ToInt32((CmbProduct.SelectedItem as dynamic).Value),
                ProductName = CmbProduct.Text,
                Price = TxtPrice.Text != "" ? Convert.ToDouble(TxtPrice.Text) : 0,
            }); 
            CmbProduct.SelectedIndex = 0;
            TxtCount.Text = "";
            var bindingList = new BindingList<Order>(orders);
            var source = new BindingSource(bindingList,null);
            dataGridView1.DataSource = source;
        }


        private void BtnGoHomePage_Click(object sender, EventArgs e)
        {
            HomePage homePage= new HomePage();
            homePage.Show();
            this.Close();
        }
    }

    public class Order // lazım olanları elimde tutmak için alan bi class
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
    }
}
