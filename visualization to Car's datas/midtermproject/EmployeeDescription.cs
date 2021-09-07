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
    public partial class EmployeeDescription : Form
    {
        public EmployeeDescription()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-G4CLP0B;Initial Catalog=VISUAL PROGRAMMING;Integrated Security=True");
       


        
        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Employee", connection);
            DataTable dt = new DataTable();
            da1.Fill(dt);
            employeelist.DataSource = dt;
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand delete = new SqlCommand("delete from Employee where id=@id", connection);
            delete.Parameters.AddWithValue("@id", textidno.Text);
            delete.ExecuteNonQuery();
            MessageBox.Show("specified datas are deleted.");

            connection.Close();
        }

        private void EmployeeDescription_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand add = new SqlCommand("insert into Employee values(@tcno,+@Name,@Surname,@Task,@UnitHourCost,@MounthlyCost)",connection);
            add.Parameters.AddWithValue("@tcno", textBox1.Text);
            add.Parameters.AddWithValue("@Name", textBox6.Text);
            add.Parameters.AddWithValue("@Surname", textBox5.Text);
            add.Parameters.AddWithValue("@Task", textBox4.Text);
            add.Parameters.AddWithValue("@UnitHourCost", textBox3.Text);
            add.Parameters.AddWithValue("@MounthlyCost", textBox2.Text);
            add.ExecuteNonQuery();

            
            MessageBox.Show("Datas are added.","Information", MessageBoxButtons.OK);
            connection.Close();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeelist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textidno.Text = employeelist.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = employeelist.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox6.Text = employeelist.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox5.Text = employeelist.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = employeelist.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox3.Text = employeelist.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox2.Text = employeelist.Rows[e.RowIndex].Cells[6].Value.ToString();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand update = new SqlCommand("update Employee set tcno=@tcno,Name=@Name, Surname=@Surname, Task=@Task, UnitHourCost=@UnitHourCost, MonthlyCost=@MonthlyCost where id=@id", connection);
            update.Parameters.AddWithValue("@tcno", textBox1.Text);
            update.Parameters.AddWithValue("@Name", textBox6.Text);
            update.Parameters.AddWithValue("@Surname", textBox5.Text);
            update.Parameters.AddWithValue("@Task", textBox4.Text);
            update.Parameters.AddWithValue("@UnitHourCost", textBox3.Text);
            update.Parameters.AddWithValue("@MonthlyCost", textBox2.Text);
            update.Parameters.AddWithValue("@id", textidno.Text);
            update.ExecuteNonQuery();
            MessageBox.Show("Datas are updated.");

            connection.Close();

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter adpter = new SqlDataAdapter("select *from Employee where Name like '%" + textBox7.Text + "%'", connection);
            DataTable table = new DataTable();
            adpter.Fill(table);
            employeelist.DataSource = table;
            connection.Close();


        }
    }
}
