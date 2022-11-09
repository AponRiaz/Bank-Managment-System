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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PAJQIUB;Initial Catalog=Bankdb;Integrated Security=True");
        float Balanc;
        private void CheckBalance1()
        {
            con.Open();
            string Query = "select * from Account_TB1 where Anumber ="+ CheckBALTb.Text + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BalanceLb1.Text = dr["Abalance"].ToString();
               
            }


            con.Close();
        }
         private void GetNewBalance()
        {
            con.Open();
            string Query = "select * from Account_TB1 where Anumber =" + CheckBALTb.Text + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
               
                Balanc = Convert.ToInt32(dr["Abalance"].ToString());
            }


            con.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

            if (WdAccountTb.Text == "" || WdAmtTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                
                GetNewBalance();
                Withdraw();
                if (Balanc < Convert.ToInt32(WdAmtTb.Text))
                {
                    MessageBox.Show("Insufficient Balance");

                }else

                {
                    float newBal = Balanc - Convert.ToInt32(WdAmtTb.Text);
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Update Account_Tb1 set Abalance=@Abalance Where Anumber=@Anumber", con);
                        cmd.Parameters.AddWithValue("@Abalance", newBal);
                        cmd.Parameters.AddWithValue("@Anumber", WdAccountTb.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Money Withdraw!!!");
                        con.Close();
                        WdAmtTb.Text = "";
                        WdAccountTb.Text = "";
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }

               
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Next Cus = new Next();
            Cus.Show();
        }

        private void CheckBalance_Click(object sender, EventArgs e)
        {
            if (CheckBALTb.Text == "")
            {
                MessageBox.Show("Enter Account Number");
            }
            else
            {
                CheckBalance1();
                if(BalanceLb1.Text == "YourBalance")
                {
                    MessageBox.Show("Account Not Found");
                    CheckBALTb.Text = "";
                    
                }
            }
        }
        private void Deposit()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into TransactionTb1(TName,TDate,TAmt,TACNum)values(@TN,@TD,@TA,@TAC)",  con);
                cmd.Parameters.AddWithValue("@TN", "Deposit");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", DepAmtTb.Text);
                cmd.Parameters.AddWithValue("@TAC", DepAmtTb.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void Withdraw()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into TransactionTb1(TName,TDate,TAmt,TACNum)values(@TN,@TD,@TA,@TAC)", con);
                cmd.Parameters.AddWithValue("@TN", "Withdrawn");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", DepAmtTb.Text);
                cmd.Parameters.AddWithValue("@TAC", DepAmtTb.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        } 
        private void BalanceLb1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (DepAccountTb.Text== "" || DepAmtTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Deposit();
                GetNewBalance();
                float newBal = Balanc + Convert.ToInt32(DepAmtTb.Text);

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Account_Tb1 set Abalance=@Abalance Where Anumber=@Anumber", con);
                       cmd.Parameters.AddWithValue("@Abalance", newBal);
                    cmd.Parameters.AddWithValue("@Anumber", DepAccountTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money Deposit!!!");
                    con.Close();
                    DepAmtTb.Text = "";
                    DepAccountTb.Text = "";
                    }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBALTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }
        private void ResetFormControls()
        {

            CheckBALTb.Clear();

            CheckBALTb.Focus();
        }
    }
}
