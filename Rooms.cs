using HotelMangagementSystem;
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
namespace HostelMangagementSystem
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=HostelMgmt;Integrated Security=True;");

        void FillRoomDGV()
        {
            Con.Open();
            string myquery = " Select * from Room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        string RoomBooked;
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            if (RoomNumbertb.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
            }
            else
            {
                if (YesRadio.Checked == true)
                {
                    RoomBooked = "Busy";
                }
                else RoomBooked = "Free";
                Con.Open();
                String query = "Update Room_tbl set RoomStatus='"+RoomStatusCb.SelectedItem?.ToString()+"',Booked='"+ RoomBooked + "' where RoomNum="+RoomNumbertb.Text+""; 
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Successfully Updated");
                Con.Close();
                FillRoomDGV();
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (RoomNumbertb.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
            }
            else
            {
                if (YesRadio.Checked == true)
                {
                    RoomBooked = "Busy";
                }
                else RoomBooked = "Free";
                Con.Open();
                String query = "insert into Room_tbl values(" + RoomNumbertb.Text + ",'" + RoomStatusCb.SelectedItem?.ToString() + "','" + RoomBooked + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Successfully Added");
                Con.Close();
                FillRoomDGV();
            }

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (RoomNumbertb.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
            }
            else
            {
                Con.Open();
                String query = "Delete from Room_tbl where  RoomNum=" + RoomNumbertb.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Successfully Deleted");
                Con.Close();
                FillRoomDGV();
            }
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            FillRoomDGV();
        }

        private void RoomDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomNumbertb.Text = RoomDGV.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
