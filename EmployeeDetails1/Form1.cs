using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDetails1
{
    public partial class Form1 : Form
    {
        CompanyDBDataContext dc;
        List<Employee> Emps;
        int rn = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dc = new CompanyDBDataContext();
            Emps = dc.Employees.ToList();
            ShowData();
        }
        private void ShowData()
        {
            textBox1.Text = Emps[rn].Eno.ToString();
            textBox2.Text = Emps[rn].Ename;
            textBox3.Text = Emps[rn].Job;
            textBox4.Text = Emps[rn].Salary;
            textBox5.Text = Emps[rn].Dname;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rn > 0)
            {
                rn -= 1;
                ShowData();
            }
            else
            {
                MessageBox.Show("First record of the table");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rn < Emps.Count - 1)
            {
                rn += 1;
                ShowData();
            }
            else
            {
                MessageBox.Show("This is Last Record of the table");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
