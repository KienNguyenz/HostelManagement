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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=HostelMgmt;Integrated Security=True;");
        public void fillUsnCb()
        {
            Con.Open();
            string query = " Select StuUsn from Student_tbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StuUsn", typeof(string));
            dt.Load(rdr);
            UsnCb.ValueMember = "StuUsn";
            UsnCb.DataSource = dt;
            Con.Close();
        }
        public string studname, roomname;
        public void fetchdata()
        {
            Con.Open();
            string query = "select * from Student_tbl where StuUsn = '" + UsnCb.SelectedValue?.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                studname = dr["StdName"].ToString();
                roomname = dr["StdRoom"].ToString();
                StudentNameTb.Text = studname;
                RoomNumTb.Text = roomname;
            }
            Con.Close();
        }
        void FillFeesDGV()
        {
            Con.Open();
            string myquery = " Select * from Fees_tbl";
            SqlDataAdapter da = new SqlDataAdapter(myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];
            Con.Close();
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

        private void Fees_Load(object sender, EventArgs e)
        {
            fillUsnCb();
            FillFeesDGV();

        }
        string paymentperiode;
        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (PaymentIdTb.Text == "" || UsnCb.Text == "" || StudentNameTb.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("Enter The Payment Id");
            }
            else
            {
                Con.Open();
                paymentperiode = period.Value.Month.ToString() + period.Value.Year.ToString();
                //Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Fees_tbl where StudentUSN = '" + UsnCb.SelectedValue?.ToString() + "' and PaymentMonth = '" + paymentperiode.ToString() + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("There is No Due for this Month");
                }
                else
                {

                    //Con.Open();
                    String query = "insert into Fees_tbl values('" + PaymentIdTb.Text + "','" + UsnCb.SelectedValue?.ToString() + "','" + StudentNameTb.Text + "'," + RoomNumTb.Text + ",'" + paymentperiode + "' ," + AmountTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment Successfully Added");

                }
                Con.Close();
                FillFeesDGV();


            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (PaymentIdTb.Text == "")
            {
                MessageBox.Show("Enter The Payment Id");
            }
            else
            {
            Con.Open();
            paymentperiode = period.Value.Month.ToString() + period.Value.Year.ToString();
            //Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Fees_tbl where StudentUSN = '" + UsnCb.SelectedValue?.ToString() + "' and PaymentMonth = '" + paymentperiode.ToString() + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("There is No Due for this Month");
            }
                {
                    
                    paymentperiode = period.Value.Month.ToString() + period.Value.Year.ToString();

                    String query = "Update Fees_tbl set StudentUSN='" + UsnCb.SelectedValue?.ToString() + "',StudentName='" + StudentNameTb.Text + "',StdRoom='" + RoomNumTb.Text + "',PaymentMonth='" + paymentperiode + "',Amount='" + AmountTb.Text + "' where PaymentId='" + PaymentIdTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment Successfully Updated");
                    Con.Close();
                    FillFeesDGV();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (PaymentIdTb.Text == "")
            {
                MessageBox.Show("Enter The Student Number");
            }
            else
            {
                Con.Open();
                String query = "Delete from Fees_tbl where  PaymentId="+PaymentIdTb.Text+"";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fees Successfully Deleted");
                Con.Close();
                FillFeesDGV();
            }
        }

        private void UsnCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchdata();
        }

        private void PaymentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PaymentIdTb.Text = PaymentDGV.SelectedRows[0].Cells[0].Value.ToString();
            UsnCb.SelectedItem = PaymentDGV.SelectedRows[0].Cells[1].Value.ToString();
            StudentNameTb.Text = PaymentDGV.SelectedRows[0].Cells[2].Value.ToString();
            RoomNumTb.Text = PaymentDGV.SelectedRows[0].Cells[3].Value.ToString();
            AmountTb.Text = PaymentDGV.SelectedRows[0].Cells[5].Value.ToString();
            
        }
    }
}
