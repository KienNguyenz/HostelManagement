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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=HostelMgmt;Integrated Security=True;");
        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void FillEmployeeDGV()
        {
            Con.Open();
            string myquery = " Select * from Employee_tbl";
            SqlDataAdapter da = new SqlDataAdapter(myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            EmployeeDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void AddEmp_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpIdTb.Text == "" || EmpPhoneTb.Text == "" || EmpAddTb.Text == "")
            {
                MessageBox.Show("Fill All The  Information");
            }
            else
            {
                Con.Open();
                String query = "insert into Employee_tbl values('" + EmpIdTb.Text + "','" + EmpNameTb.Text + "','" + EmpPhoneTb.Text + "','" + EmpAddTb.Text + "','" + EmpPositionCb.SelectedItem?.ToString() + "' ,'" + EmpStatusCB.SelectedItem?.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Added");
                Con.Close();
                FillEmployeeDGV();

            }
        }

        private void UpdateEmp_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpIdTb.Text == "" || EmpPhoneTb.Text == "" || EmpAddTb.Text == "" || EmpPositionCb.SelectedItem?.ToString() == "" || EmpStatusCB.SelectedItem?.ToString() == "")
            {
                MessageBox.Show("Enter The Room Number");
            }
            else
            {
                Con.Open();
                String query = "Update Employee_tbl set EmpName='" + EmpNameTb.Text + "',EmpPhone='" + EmpPhoneTb.Text + "',EmpAddress='" + EmpAddTb.Text + "',EmpPos='" + EmpPositionCb.SelectedItem?.ToString() + "',EmpStatus='" + EmpStatusCB.SelectedItem?.ToString() + "' where EmpId='" + EmpIdTb.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Updated");
                Con.Close();
                FillEmployeeDGV();

            }
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            FillEmployeeDGV();
        }

        private void EmployeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpIdTb.Text = EmployeeDGV.SelectedRows[0].Cells[0].Value.ToString();
            EmpNameTb.Text = EmployeeDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpPhoneTb.Text = EmployeeDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpAddTb.Text = EmployeeDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpPositionCb.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[4].Value.ToString();
            EmpStatusCB.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void DeleteEmp_Click(object sender, EventArgs e)
        {
            if (EmpIdTb.Text == "")
            {
                MessageBox.Show("Enter The Student Number");
            }
            else
            {
                Con.Open();
                String query = "Delete from Employee_tbl where  EmpId='" + EmpIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Deleted");
                Con.Close();
                FillEmployeeDGV();


            }
        }
    }
}
