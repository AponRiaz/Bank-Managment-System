using Bank_Management_System;
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
namespace Banking_Managment_System
{
    public partial class Next : Form
    {
        public Next()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PAJQIUB;Initial Catalog=Bankdb;Integrated Security=True");
        public int E_serial;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 Cus = new Form8();
            Cus.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 Cus = new Form6();
            Cus.Show();
           
        }
        private void GetEmployeeRecordsRecord()
        {




            SqlCommand cmd = new SqlCommand("Select * from Employee_TB1", con);



            DataTable dt = new DataTable();
            con.Open();



            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();



            dataGridView1.DataSource = dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 Cus = new Form7();
            Cus.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Next nx = new Next();
            nx.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee_TB1 VALUES (@EName, @EId, @ESalary,@EContact)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@EName", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@EId", txtEmpId.Text);
                cmd.Parameters.AddWithValue("@ESalary", txtEmpSalary.Text);
                cmd.Parameters.AddWithValue("@EContact", txtEmpContact.Text);




                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



                MessageBox.Show("New Employee inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetEmployeeRecordsRecord();
                ResetFormControls();
            }
        }
        private bool isValid()
        {
            if (txtEmpName.Text == string.Empty)
            {
                MessageBox.Show("Employee name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }
        private void ResetFormControls()
        {
            E_serial = 0;
            txtEmpName.Clear();
            txtEmpId.Clear();
            txtEmpSalary.Clear();
            txtEmpContact.Clear();
            txtEmpName.Focus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (E_serial > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Employee_TB1 SET Ename = @EName, Eid = @EId, Esalary = @ESalary, Econtact = @EContact WHERE E_serial = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@EName", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@EId", txtEmpId.Text);
                cmd.Parameters.AddWithValue("@ESalary", txtEmpSalary.Text);
                cmd.Parameters.AddWithValue("@EContact", txtEmpContact.Text);
                cmd.Parameters.AddWithValue("@ID", this.E_serial);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



                MessageBox.Show("Employee info updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetEmployeeRecordsRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please, select Employee to update", "slected?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
    if (E_serial > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE Employee_TB1 WHERE E_serial = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.E_serial); con.Open();
                cmd.ExecuteNonQuery();
                con.Close(); MessageBox.Show("Employee is deleted from the record ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetEmployeeRecordsRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please, select Employee to delete", "slected?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.E_serial = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtEmpName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtEmpId.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtEmpSalary.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtEmpContact.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
