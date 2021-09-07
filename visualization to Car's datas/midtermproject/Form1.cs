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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-G4CLP0B;Initial Catalog=VISUAL PROGRAMMING;Integrated Security=True");


        public static object PROGRAMMING { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sql = "Select * from USERS where Username=@username AND Password=@password";
                SqlParameter prm1 = new SqlParameter("username", textBox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("password", textBox2.Text.Trim());
                SqlCommand cmnd = new SqlCommand(sql, connection);
                cmnd.Parameters.Add(prm1);
                cmnd.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmnd);
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {

                    Form2 fr = new Form2();
                    fr.Show();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("wrong password or username, try it again");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
