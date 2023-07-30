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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection connection=new SqlConnection("Server=NURYKLMZ;Database=CafeWholesalerDb;Integrated security=true;");
        // Fatmanur 1111

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void BtnEntrance_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select*from Admin where AdminName=@AdminName and AdminPassword=@AdminPassword", connection);
            command.Parameters.AddWithValue("@AdminName", TxtName.Text);
            command.Parameters.AddWithValue("@AdminPassword", TxtPassword.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                //MessageBox.Show("Giriş Başarılı");
                TxtName.Clear();
                TxtPassword.Clear();
                //başarılı olursa bu sayfa hide olacak ve müşteri bilgi sayfasına yönlenecek
                HomePage go = new HomePage();
                go.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
                TxtName.Clear();
                TxtPassword.Clear();
            }


            connection.Close();
        }
    }
}
