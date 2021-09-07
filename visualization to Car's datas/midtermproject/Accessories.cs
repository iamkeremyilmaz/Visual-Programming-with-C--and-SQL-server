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
    public partial class Accessories : Form
    {
        public Accessories()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-G4CLP0B;Initial Catalog=VISUAL PROGRAMMING;Integrated Security=True");





        private void Accessories_Load(object sender, EventArgs e)
        {
            
        }

        private void ADDBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand add = new SqlCommand("insert into Accessory values(@AccessoryCode,+@Accessory,@AccessoryMaterial,@Price,@ShippingTime)", connection);
            add.Parameters.AddWithValue("AccessoryCode", textBox6.Text);
            add.Parameters.AddWithValue("@Accessory", textBox5.Text);
            add.Parameters.AddWithValue("@AccessoryMaterial", textBox4.Text);
            add.Parameters.AddWithValue("@Price", textBox3.Text);
            add.Parameters.AddWithValue("@ShippingTime", textBox2.Text);
            add.ExecuteNonQuery();


            MessageBox.Show("Datas are added.", "Information", MessageBoxButtons.OK);
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Accessory", connection);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            da2.Fill(dt);


            connection.Close();
        }
    }
}
