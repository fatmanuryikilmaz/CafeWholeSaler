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
using System.Xml.Linq;

namespace CafeWholesaler_prosedursuz_
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=NURYKLMZ;Database=CafeWholesalerDb;Integrated security=true;");

        public void Temizle()
        { 
            TxtName.Clear();
            TxtCount.Clear();
            TxtName.Tag=null; 
            TxtPrice.Clear();
        }

        public void Yenile()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select*from Product where isActive != 0", connection);//isactive 0 olmayanları al datatable a ekle onu da datagridview in data source una ekle
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Product ID");
            dataTable.Columns.Add("Product Name");
            dataTable.Columns.Add("Kategori adı");
            dataTable.Columns.Add("Ürün Sayısı");
            dataTable.Columns.Add("Product Price");
            while (reader.Read())
            {
                DataRow row = dataTable.NewRow();
                row["Product ID"] = reader["ProductID"];
                row["Product Name"] = reader["ProductName"];
                row["Product Price"] = reader["Price"];
                row["Kategori adı"] = reader["CategoryName"];
                row["Ürün Sayısı"] = reader["UnitsInStock"];
                dataTable.Rows.Add(row);
            }
            dataGridView1.DataSource =dataTable;
            connection.Close();

        }

        private void BtnAddUpdate_Click(object sender, EventArgs e)
        {
            //tag null sa(boş) yeni product oluşturur,değilse günceller
            connection.Open();
            if (TxtName.Tag==null)
            {
                SqlCommand command = new SqlCommand("insert into Product (ProductName,UnitsInStock,Price,CategoryName,isActive) values (@ProductName,@UnitsInStock,@Price,@CategoryName,1)", connection);
                command.Parameters.AddWithValue("@ProductName", TxtName.Text);
                command.Parameters.AddWithValue("@UnitsInStock", Convert.ToInt32(TxtCount.Text));
                command.Parameters.AddWithValue("@Price", Convert.ToDouble(TxtPrice.Text));
                command.Parameters.AddWithValue("@CategoryName", CmbCategory.SelectedItem);
                SqlDataReader reader = command.ExecuteReader();
            }
            else
            {
                SqlCommand command = new SqlCommand("update Product set ProductName=@ProductName,UnitsInStock=@UnitsInStock, Price=@Price, CategoryName=@CategoryName where ProductID=@ProductID", connection);
                command.Parameters.AddWithValue("@ProductID", Convert.ToInt32(TxtName.Tag));
                command.Parameters.AddWithValue("@ProductName", TxtName.Text);
                command.Parameters.AddWithValue("@UnitsInStock", Convert.ToInt32(TxtCount.Text));
                command.Parameters.AddWithValue("@Price", Convert.ToDouble(TxtPrice.Text));
                command.Parameters.AddWithValue("@CategoryName", CmbCategory.SelectedItem);
                SqlDataReader reader = command.ExecuteReader();
            }
            connection.Close();
            Temizle();
            Yenile();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {//her şeyi textlere taşır
            DataGridViewRow satir = dataGridView1.CurrentRow;//currentrow geçerli satır
            TxtName.Tag = satir.Cells["Product ID"].Value.ToString();
            TxtName.Text = satir.Cells["Product Name"].Value.ToString();
            TxtCount.Text = satir.Cells["Ürün Sayısı"].Value.ToString();
            TxtPrice.Text = satir.Cells["Product Price"].Value.ToString();
            CmbCategory.SelectedItem = satir.Cells["Kategori adı"].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //bağlantılı tablolar olduğundan silmek yerine update ediyoruz.isActive i false yapınca görünmesini istemediğimizden görünmüyor
            connection.Open();
            SqlCommand command = new SqlCommand("update Product set isActive = 0 where ProductID=@ProductID", connection);
            command.Parameters.AddWithValue("@ProductID", TxtName.Tag);
            SqlDataReader reader = command.ExecuteReader();
            connection.Close();
            Yenile();
            Temizle();

        }

        

        private void BtnGoHomePage_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }
    }
}
