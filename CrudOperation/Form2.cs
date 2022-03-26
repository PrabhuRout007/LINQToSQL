using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudOperation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyDBDataContext dc = new CompanyDBDataContext();
            Employee obj = new Employee(); // Instance of the class.

            // Start assigning the values.

            obj.Eno = int.Parse(textBox1.Text);
            obj.Ename = textBox2.Text;
            obj.Job = textBox3.Text;
            obj.Salary = textBox4.Text;
            obj.Dname = textBox5.Text;

            // Ad this record to the table.

            dc.Employees.InsertOnSubmit(obj);  // Add the data in pending insert stage

            // then commit the data.

            dc.SubmitChanges();
            MessageBox.Show("Record Inserted into the Table");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = ctrl as TextBox;
                    tb.Clear();
                }
            }
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
