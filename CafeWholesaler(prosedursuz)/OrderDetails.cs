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

namespace CafeWholesaler_prosedursuz_
{
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=NURYKLMZ;Database=CafeWholesalerDb;Integrated security=true;");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            connection.Open();
            //ihtiyaç duyulan kolonları çağırmak için joinle sorgu yazıldı.
            SqlCommand cmd = new SqlCommand("select o.OrderID,p.ProductName,od.Count,od.ProductPrice,c.CompanyName,c.CustomerName,c.CustomerAddress from Orders o join OrderDetails od on o.OrderID=od.OrderID join Product p on p.ProductID=od.ProductID join Customer c on c.CustomerID=o.CustomerID ", connection);
            //SqlDataReader:verilere ulaşır ve okur ulaşmak istemezsen executeNonquery
            SqlDataReader reader = cmd.ExecuteReader();
            //datatable datasource içine konmak için 
            DataTable dataTable = new DataTable();
            //rowlar ve bu add değerlerin adları değiştirilebilir onlar tabloda görünecek
            dataTable.Columns.Add("OrderID");
            dataTable.Columns.Add("ProductName");
            dataTable.Columns.Add("Count");
            dataTable.Columns.Add("ProductPrice");
            dataTable.Columns.Add("CompanyName");
            dataTable.Columns.Add("CustomerName");
            dataTable.Columns.Add("CustomerAddress");

            while (reader.Read())
            {
                DataRow row = dataTable.NewRow();

               row["OrderID"] = reader["OrderID"];
                row["CompanyName"] = reader["CompanyName"];
                row["CustomerName"] = reader["CustomerName"];
                row["CustomerAddress"] = reader["CustomerAddress"];
                row["ProductName"] = reader["ProductName"];
                row["Count"] = reader["Count"];
                row["ProductPrice"] = reader["ProductPrice"];
                dataTable.Rows.Add(row);
            }
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }
    }
}
