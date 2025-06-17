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

namespace Ex_01
{
    public partial class frmCRUD_withSP : Form
    {
        string conString = "Data Source=DESKTOP-41N5EUT;Initial Catalog=r62db_cr;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand cmd;
        string stafId = "";
        public frmCRUD_withSP()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter staff name!!");
                txtName.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("Enter city!!");
                txtCity.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtDepartment.Text))
            {
                MessageBox.Show("Enter department!!");
                txtDepartment.Select();
            }
            else if (comboBox1.SelectedIndex <= -1)
            {
                MessageBox.Show("Select gender!!");
                comboBox1.Select();
            }
            else
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    DataTable dtData = new DataTable();
                    cmd = new SqlCommand("spStaffs", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@actionType", "SaveData");
                    cmd.Parameters.AddWithValue("@stafId", stafId);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@city", txtCity.Text);
                    cmd.Parameters.AddWithValue("@department", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@gender", comboBox1.Text);

                    int numRes = cmd.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Data saved successfully!!!");
                        LoadGrid();
                        ClearAll();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        private DataTable ShowAllEmployeeData()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            DataTable dtData = new DataTable();
            cmd = new SqlCommand("spStaffs", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@actionType", "ShowAllData");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtData);
            return dtData;
        }
        private void ClearAll()
        {
            btnSave.Text = "Save";
            txtName.Clear();
            txtCity.Clear();
            txtDepartment.Clear();
            comboBox1.SelectedIndex = -1;
            stafId = "";
            LoadGrid();
        }
        private DataTable ShowEmpRecordById(string stafId)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            DataTable dtData = new DataTable();
            cmd = new SqlCommand("spStaffs", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@actionType", "ShowAllDataById");
            cmd.Parameters.AddWithValue("@stafId", stafId);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtData);
            return dtData;
        }

        //private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        btnSave.Text = "Update";
        //        stafId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        //        DataTable dtData = ShowEmpRecordById(stafId);
        //        if (dtData.Rows.Count > 0)
        //        {
        //            stafId = dtData.Rows[0][0].ToString();
        //            txtName.Text = dtData.Rows[0][1].ToString();
        //            txtCity.Text = dtData.Rows[0][2].ToString();
        //            txtDepartment.Text = dtData.Rows[0][3].ToString();
        //            comboBox1.Text = dtData.Rows[0][4].ToString();
        //        }
        //    }
        //}

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void LoadGrid()
        {
            dataGridView1.DataSource = ShowAllEmployeeData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(stafId))
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    DataTable dtData = new DataTable();
                    cmd = new SqlCommand("spStaffs", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@actionType", "DeleteData");
                    cmd.Parameters.AddWithValue("@stafId", stafId);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    int numRes = cmd.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Data deleted successfully!!!");
                        LoadGrid();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Please try again!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: - " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a record!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnSave.Text = "Update";
                stafId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataTable dtData = ShowEmpRecordById(stafId);
                if (dtData.Rows.Count > 0)
                {
                    stafId = dtData.Rows[0][0].ToString();
                    txtName.Text = dtData.Rows[0][1].ToString();
                    txtCity.Text = dtData.Rows[0][2].ToString();
                    txtDepartment.Text = dtData.Rows[0][3].ToString();
                    comboBox1.Text = dtData.Rows[0][4].ToString();
                }
            }
        }

        private void frmCRUD_withSP_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ShowAllEmployeeData();
        }
    }
}
