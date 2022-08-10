using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hospital_System
{
    public partial class Cardiology : Form
    {
        SqlConnection con = new SqlConnection("server=MOHAMED\\SQLEXPRESS;database=H_M_S;integrated security=true");
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        int index;
        public Cardiology()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string sql = "insert into Cardiology values (@ID,@Patient_Name,@Blood_Type,@Date_Of_Entry,@Depature_Date,@Age,@Number)";
            if (textBox3.Text != "" && textBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", textBox3.Text);
                cmd.Parameters.AddWithValue("@Patient_Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Blood_Type", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Date_Of_Entry", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@Depature_Date", dateTimePicker2.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@Age", textBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@Number", textBox4.Text.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done");
                dt.Clear();
                da.Fill(dt);
            }
            else
            {
                string str = "";
                if (textBox3.Text=="")
                    str += "ID cannot be empty \n";
                
                if (textBox1.Text == "")
                    str += "Name cannot be empty\n";
                if (textBox4.Text == "")
                    str += "Number cannot be empty\n";
                if (textBox2.Text == "")
                    str += "Age cannot be empty\n";
                if (comboBox1.Text == "")
                    str += "Blood Type cannot be empty";
                MessageBox.Show(str);
            }
            con.Close();
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select * from Cardiology where ID=@ID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ID", textBox3.Text);
            SqlDataReader r;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    textBox1.Text = r["Patient_Name"].ToString();
                    comboBox1.Text = r["Blood_Type"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(r["Date_Of_Entry"]);
                    dateTimePicker2.Value = Convert.ToDateTime(r["Depature_Date"]);
                    textBox2.Text = r["Age"].ToString();
                    textBox4.Text = r["Number"].ToString();

                }
            }
            else { MessageBox.Show("The patient is not present "); }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

                string sql = "update Cardiology set ID=@ID, Patient_Name = @Patient_Name, Blood_Type = @Blood_Type, Date_Of_Entry = @Date_Of_Entry, Depature_Date = @Depature_Date, Age =@Age, Number =@Number where ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", textBox3.Text);
                cmd.Parameters.AddWithValue("@Patient_Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Blood_Type", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Date_Of_Entry", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@Depature_Date", dateTimePicker2.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@Age", textBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@Number", textBox4.Text.ToString());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Done");
                DataGridViewRow newdata = dataGridView1.Rows[index];
                newdata.Cells[0].Value = textBox3.Text;
                newdata.Cells[1].Value = textBox1.Text;
                newdata.Cells[2].Value = comboBox1.SelectedItem;
                newdata.Cells[3].Value = dateTimePicker1.Value;
                newdata.Cells[4].Value = dateTimePicker2.Value;
                newdata.Cells[5].Value = textBox2.Text;
                newdata.Cells[6].Value = textBox4.Text;

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string sql = "delete  from Cardiology where ID=@ID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", textBox3.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
            textBox3.Clear();
            textBox1.Clear();
            comboBox1.Text = "";
            textBox2.Clear();
            textBox4.Clear();




        }

        private void Cardiology_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select * from Cardiology", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox3.Text = row.Cells[0].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
            comboBox1.Text = row.Cells[2].Value.ToString();
            textBox2.Text = row.Cells[5].Value.ToString();
            textBox4.Text = row.Cells[6].Value.ToString();
        }
    }
}
