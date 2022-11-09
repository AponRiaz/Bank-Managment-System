using Bank_Management_System;
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

namespace Banking_Management_System

{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(" Enter the Username and Password ");




            }
            else
            {
                if (comboBox1.SelectedIndex > -1)
                {
                    if (comboBox1.SelectedItem.ToString() == "Admin")
                    {
                        if (textBox1.Text == "Admin" && textBox2.Text == "AAAbank1234")
                        {
                            Next Pro = new Next();
                            Pro.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are the Admin, Enter The correct Id and Password");



                        }





                    }
                    else
                    {
                        //MessageBox.Show(" You are in The seller Section ")
                    }
                }
                else
                {
                    MessageBox.Show("Select A role ");
                }
            }





            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(" Enter the Username and Password ");




            }
            else
            {
                if (comboBox1.SelectedIndex > -1)
                {
                    if (comboBox1.SelectedItem.ToString() == "User")
                    {
                        if (textBox1.Text == "User" && textBox2.Text == "1234")
                        {
                            Form8 Cus = new Form8();
                            Cus.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are the User, Enter The correct Id and Password");




                        }





                    }
                    else
                    {
                        //MessageBox.Show(" You are in !!! ")
                    }
                }
                else
                {
                    MessageBox.Show("Select A role ");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
