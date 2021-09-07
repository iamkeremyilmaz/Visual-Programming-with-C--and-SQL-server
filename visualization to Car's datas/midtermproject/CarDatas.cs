using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace midtermproject
{
    public partial class CarDatas : Form
    {
        public CarDatas()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-G4CLP0B;Initial Catalog=VISUAL PROGRAMMING;Integrated Security=True");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand delete = new SqlCommand("delete from Models where id=@id", connection);
            delete.Parameters.AddWithValue("@id", carid.Text);
            delete.ExecuteNonQuery();
            MessageBox.Show("specified datas are deleted.");

            connection.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand add = new SqlCommand("insert into Models values(@ChassisNumber,+@Model,@Price,@Features)", connection);
            add.Parameters.AddWithValue("@ChassisNumber", chassis.Text);
            add.Parameters.AddWithValue("@Model", model.Text);
            add.Parameters.AddWithValue("@Price", price.Text);
            add.Parameters.AddWithValue("@Features", feature.Text);
           
            add.ExecuteNonQuery();


            MessageBox.Show("Datas are added.", "Information", MessageBoxButtons.OK);
            connection.Close();
        }

        private void Listbtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Models", connection);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            da2.Fill(dt);
            
            
            connection.Close();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand update = new SqlCommand("update Models set ChassisNumber=@CNO,Model=@Model, Price=@Price, Features=@Features where id=@id", connection);
            update.Parameters.AddWithValue("@CNO", carid.Text);
            update.Parameters.AddWithValue("@Model", model.Text);
            update.Parameters.AddWithValue("@Price", price.Text);
            update.Parameters.AddWithValue("@Features", feature.Text);
            update.Parameters.AddWithValue("@id", carid.Text);
            update.ExecuteNonQuery();
            MessageBox.Show("Datas are updated.");

            connection.Close();
        }

        private void CarDatas_Load(object sender, EventArgs e)
        {

        }
    }
}
