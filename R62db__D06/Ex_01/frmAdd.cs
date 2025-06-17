using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_01
{
    public partial class frmAdd : Form
    {
        string currentFile = string.Empty;
        List<SportsDetails> details = new List<SportsDetails>();
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFile = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(currentFile);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            details.Add(new SportsDetails
            {
                sportsName = txtSportsName.Text,
                startDate = dptStartDate.Value,
                endDate = dptEndDate.Value,
                courseFee = numericUpDown1.Value
            });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = details;
        }
        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString))
            {
                con.Open();
                using (SqlTransaction trx = con.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.Transaction = trx;
                        //for image
                        string ext = Path.GetExtension(currentFile);
                        string f = Path.GetFileNameWithoutExtension(DateTime.Now.Ticks.ToString()) + ext;

                        string savePath = @"..\..\Pictures\" + f;
                        MemoryStream ms = new MemoryStream(File.ReadAllBytes(currentFile));
                        byte[] bytes = ms.ToArray();
                        FileStream fs = new FileStream(savePath, FileMode.Create);
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Close();

                        //for data
                        cmd.CommandText = "INSERT INTO players(playerName,dateOfBirth,insideDhaka,picture) VALUES(@sn,@dob,@isd,@pic); SELECT SCOPE_IDENTITY()";
                        cmd.Parameters.AddWithValue("@sn", txtPlayerName.Text);
                        cmd.Parameters.AddWithValue("@dob", dptDob.Value);
                        cmd.Parameters.AddWithValue("@isd", checkBox1.Checked);
                        cmd.Parameters.AddWithValue("@pic", f);

                        try
                        {
                            var sid = cmd.ExecuteScalar();
                            foreach (var s in details)
                            {
                                cmd.CommandText = @"INSERT INTO sports(sportsName,startDate,endDate,courseFee,playerId) VALUES(@cn,@sd,@ed,@cf,@i)";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@cn", s.sportsName);
                                cmd.Parameters.AddWithValue("@sd", s.startDate);
                                cmd.Parameters.AddWithValue("@ed", s.endDate);
                                cmd.Parameters.AddWithValue("@cf", s.courseFee);
                                cmd.Parameters.AddWithValue("@i", sid);
                                cmd.ExecuteNonQuery();
                            }
                            trx.Commit();
                            MessageBox.Show("Data Saved successfully!!");
                            details.Clear();
                        }
                        catch
                        {
                            trx.Rollback();
                        }
                    }
                }
                con.Close();
            }
        }
    }
}
