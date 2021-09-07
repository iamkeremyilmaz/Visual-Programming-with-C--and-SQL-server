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
    public partial class branchess : Form
    {
        public branchess()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-G4CLP0B;Initial Catalog=VISUAL PROGRAMMING;Integrated Security=True");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand add = new SqlCommand("insert into Branches values(@BranchNo,+@BranchLocation,@BranchServices,@BranchCost)", connection);
            add.Parameters.AddWithValue("@BranchNo", textBox5.Text);
            add.Parameters.AddWithValue("@BranchLocation", textBox4.Text);
            add.Parameters.AddWithValue("@BranchServices", textBox3.Text);
            add.Parameters.AddWithValue("@BranchCost", textBox2.Text);

            add.ExecuteNonQuery();


            MessageBox.Show("Datas are added.", "Information", MessageBoxButtons.OK);
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter da3 = new SqlDataAdapter("select * from Branches", connection);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            da3.Fill(dt);


            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand delete = new SqlCommand("delete from Models where id=@id", connection);
            delete.Parameters.AddWithValue("@id", textBox1.Text);
            delete.ExecuteNonQuery();
            MessageBox.Show("specified datas are deleted.");

            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand update = new SqlCommand("update Branches set(BranchNo=@BranchNo, BranchLocation=@BranchLocation,BranchServices=@BranchServices,BranchCost=@BranchCost where id=@id)", connection);
            update.Parameters.AddWithValue("@BranchNo", textBox5.Text);
            update.Parameters.AddWithValue("@BranchLocation", textBox4.Text);
            update.Parameters.AddWithValue("@BranchServices", textBox3.Text);
            update.Parameters.AddWithValue("@BranchCost", textBox2.Text);

            update.ExecuteNonQuery();
            MessageBox.Show("Datas are updated.");

            connection.Close();
        }

        private void branchess_Load(object sender, EventArgs e)
        {

        }
    }
}
