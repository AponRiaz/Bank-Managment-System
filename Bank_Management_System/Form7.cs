using Banking_Managment_System;
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
namespace Bank_Management_System
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PAJQIUB;Initial Catalog=Bankdb;Integrated Security=True");
 public int A_serial;


        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Next Cus = new Next();
            Cus.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            GetAccountRecordsRecord();
        }
        private void GetAccountRecordsRecord()
        {




            SqlCommand cmd = new SqlCommand("Select * from Account_TB1", con);



            DataTable dt = new DataTable();
            con.Open();



            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();



            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (A_serial > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE Account_TB1 WHERE A_serial = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.A_serial);



                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



                MessageBox.Show("Account  is deleted from the record ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAccountRecordsRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please, select Account to delete", "slected?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Account_TB1 VALUES (@ANumber, @AType, @ABalance,@ATY,@AIR)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ANumber", txtAccNumber.Text);
                cmd.Parameters.AddWithValue("@AType", txtAccType.Text);
                cmd.Parameters.AddWithValue("@ABalance", txtAccBalance.Text);
                cmd.Parameters.AddWithValue("@ATY", txtAccTY.Text);
                cmd.Parameters.AddWithValue("@AIR", txtAccIR.Text);

                


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



                MessageBox.Show("New Account inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAccountRecordsRecord();
                ResetFormControls();
            }
        }
        private bool isValid()
        {
            if (txtAccNumber.Text == string.Empty)
            {
                MessageBox.Show("Account name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }
        private void ResetFormControls()
        {
            A_serial = 0;
            txtAccNumber.Clear();
            txtAccType.Clear();
            txtAccBalance.Clear();
            txtAccTY.Clear();
            txtAccIR.Clear();
            txtAccNumber.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (A_serial > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Account_TB1 SET Anumber = @ANumber, Atype = @AType, Abalance = @ABalance, Atenureyear = @ATY,Ainterestrate = @AIR WHERE A_serial = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ANumber", txtAccNumber.Text);
                cmd.Parameters.AddWithValue("@AType", txtAccType.Text);
                cmd.Parameters.AddWithValue("@ABalance", txtAccBalance.Text);
                cmd.Parameters.AddWithValue("@ATY", txtAccTY.Text);
                cmd.Parameters.AddWithValue("@AIR", txtAccIR.Text);
                cmd.Parameters.AddWithValue("@ID", this.A_serial);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



                MessageBox.Show("Account info updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAccountRecordsRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please, select Account to update", "slected?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.A_serial = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtAccNumber.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtAccType.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtAccBalance.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtAccTY.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtAccIR.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
