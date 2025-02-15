using HotelMangagementSystem;
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

namespace HostelMangagementSystem
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=HostelMgmt;Integrated Security=True;");

        void FillStudentDGV()
        {
            Con.Open();
            string myquery = " Select * from Student_tbl";
            SqlDataAdapter da = new SqlDataAdapter(myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StudentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        void FillRoomCombobox()
        {
            Con.Open();
            string query = " Select * from Room_tbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomNum", typeof(int));
            dt.Load(rdr);
            StudRoomCb.ValueMember = "RoomNum";
            StudRoomCb.DataSource = dt;
            Con.Close();
        }
        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (StudUsn.Text == "" || StudName.Text == "" || FatherName.Text == "" || MotherName.Text == "" || Addresstb.Text == "" || College.Text == "")
            {
                MessageBox.Show("No Empty Filled Accepted");
            }
            else
            {
                Con.Open();
                String query = "insert into Student_tbl values('" + StudUsn.Text + "','" + StudName.Text + "','" + FatherName.Text + "','" + MotherName.Text + "','" + Addresstb.Text + "','" + College.Text + "','" + StudRoomCb.SelectedValue?.ToString() + "' ,'" + StudStatusCb.SelectedItem?.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Added");
                Con.Close();
                FillStudentDGV();
            }
        }
        private void Student_Load(object sender, EventArgs e)
        {
            FillStudentDGV();
            FillRoomCombobox();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {

        }
    }
}
