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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PAJQIUB;Initial Catalog=Bankdb;Integrated Security=True");
        public int C_serial;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Next Cus = new Next();
            Cus.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            GetCustomerRecordsRecord();

        }
        private void GetCustomerRecordsRecord()
        {




            SqlCommand cmd = new SqlCommand("Select * from Customer_TB1", con);



            DataTable dt = new DataTable();
            con.Open();



            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();



            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
         if (C_serial > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE Customer_TB1 WHERE C_serial = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.C_serial); con.Open();
                cmd.ExecuteNonQuery();
                con.Close(); MessageBox.Show("Customer is deleted from the record ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCustomerRecordsRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please, select Customer to delete", "slected?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Customer_TB1 VALUES (@Cname, @Cnid, @Coccupation,@Caddress, @Cphone_no,@Cincome,@Ceducation)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Cname", txtCusName.Text);
                cmd.Parameters.AddWithValue("@Cnid", txtCusNid.Text);
                cmd.Parameters.AddWithValue("@Coccupation", txtCusOcc.Text);
                cmd.Parameters.AddWithValue("@Caddress", txtCusAdd.Text);
                cmd.Parameters.AddWithValue("@Cphone_no", txtCusPho.Text);
                cmd.Parameters.AddWithValue("@Cincome", txtCusInc.Text);
                cmd.Parameters.AddWithValue("@Ceducation", txtCusEdu.Text);




                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



                MessageBox.Show("New Customer inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCustomerRecordsRecord();
                ResetFormControls();
            }
        }
            private bool isValid()
            {
                if (txtCusName.Text == string.Empty)
                {
                    MessageBox.Show("Customer name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            C_serial = 0;
            txtCusName.Clear();
            txtCusNid.Clear();
            txtCusOcc.Clear();
            txtCusAdd.Clear();
            txtCusPho.Clear();
            txtCusInc.Clear();
            txtCusEdu.Clear();
            txtCusName.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (C_serial > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Customer_TB1 SET Cname = @Cname, Cnid = @Cnid, Coccupation = @Coccupation, Caddress = @Caddress,Cphone_no= @Cphone_no,Cincome=@Cincome,Ceducation=@Ceducation WHERE C_serial = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Cname", txtCusName.Text);
                cmd.Parameters.AddWithValue("@Cnid", txtCusNid.Text);
                cmd.Parameters.AddWithValue("@Coccupation", txtCusOcc.Text);
                cmd.Parameters.AddWithValue("@Caddress", txtCusAdd.Text);
                cmd.Parameters.AddWithValue("@Cphone_no", txtCusPho.Text);
                cmd.Parameters.AddWithValue("@Cincome", txtCusInc.Text);
                cmd.Parameters.AddWithValue("@Ceducation", txtCusEdu.Text);
                cmd.Parameters.AddWithValue("@ID", this.C_serial);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



                MessageBox.Show("Customer info updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCustomerRecordsRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please, select Customer to update", "slected?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.C_serial = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtCusName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtCusNid.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtCusOcc.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtCusAdd.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtCusPho.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtCusInc.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtCusEdu.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            
        }
    }
}
