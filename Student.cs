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
            string query = " Select * from Room_tbl where RoomStatus = '" + "Active"+ "' and Booked= '"+"Free" + "' ";
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
                FillRoomCombobox();

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
        void updateBookedStatusOnDelete()
        {
            Con.Open();
            String query = " update Room_tbl set Booked= '" + "Free" + "' where RoomNum=" + StudRoomCb.SelectedValue?.ToString() + "";
            SqlCommand cmd= new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Room Successfully Updated");
            Con.Close();
        }
        void updateBookedStatus()
        {
            Con.Open();
            String query = " update Room_tbl set Booked= '" + "Busy" + "' where RoomNum=" + StudRoomCb.SelectedValue?.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Room Successfully Updated");
            Con.Close();
        }
        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            if (StudUsn.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
            }
            else
            {
                Con.Open();
                String query = "Update Student_tbl set StuUsn='" + StudName.Text + "',FatherName='" + FatherName.Text + "',MotherName='" + MotherName.Text + "',StdAddress='" + Addresstb.Text + "',College='" + College.Text + "',StdRoom=" + StudRoomCb.SelectedValue?.ToString() + ",StdStatus='" + StudStatusCb.SelectedItem?.ToString() + "' where StuUsn='" + StudUsn.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Updated");
                Con.Close();
                FillStudentDGV();
                FillRoomCombobox();
            }
        }
        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            if (StudUsn.Text == "")
            {
                MessageBox.Show("Enter The Student Number");
            }
            else
            {
                Con.Open();
                String query = "Delete from Student_tbl where  StuUsn='" + StudUsn.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Deleted");
                Con.Close();
                updateBookedStatusOnDelete();
                FillStudentDGV();
                FillRoomCombobox();
                
            }
        }

        private void StudentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudUsn.Text = StudentDGV.SelectedRows[0].Cells[0].Value.ToString();
            StudName.Text = StudentDGV.SelectedRows[0].Cells[1].Value.ToString();
            FatherName.Text = StudentDGV.SelectedRows[0].Cells[2].Value.ToString();
            MotherName.Text = StudentDGV.SelectedRows[0].Cells[3].Value.ToString();
            Addresstb.Text = StudentDGV.SelectedRows[0].Cells[4].Value.ToString();
            College.Text = StudentDGV.SelectedRows[0].Cells[5].Value.ToString();

        }
    }
}
