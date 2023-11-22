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

namespace HotelOpgaveAlexander
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=LAPTOP-FJPJDN26;Initial Catalog=HotelOpgaveAlexander;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void button1_Click(object sender, EventArgs e) //CREATE
        {
            string query = $"insert into dbo.DemoFacility values('{Facility_ID_Textbox.Text.ToString()}','{Hotel_No_Textbox.Text.ToString()}','{Facility_Name_Textbox.Text}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata();
        }

        private void cleardata()
        {
            Facility_ID_Textbox.Clear();
            Hotel_No_Textbox.Clear();
            Facility_Name_Textbox.Clear();
        }

        private void button2_Click(object sender, EventArgs e) //Update
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update dbo.DemoFacility set Facility_Name='" + Facility_Name_Textbox + "',Hotel_No='" + Hotel_No_Textbox.Text.ToString() + "' where Facility_ID='" + Facility_ID_Textbox.Text.ToString() + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();
            displaydata();
            cleardata();
        }

        private void button4_Click(object sender, EventArgs e) // READ
        {
            displaydata();
        }

        private void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dbo.DemoFacility";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e) // DELETE
        {
            string query = $"delete dbo.DemoFacility where Facility_ID='{Facility_ID_Textbox.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = query;
            cleardata();
            conn.Close();
            displaydata();
        }

        private void button7_Click(object sender, EventArgs e) // FIND
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dbo.DemoFacility where Facility_ID='" + Search_Textbox.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Hotel_No_Textbox.Text = dt.ToString();
            Facility_Name_Textbox.Text = dt.ToString();;
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


