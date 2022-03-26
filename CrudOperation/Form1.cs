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
  
    public partial class Form1 : Form
    {
        CompanyDBDataContext dc;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dc = new CompanyDBDataContext();
            dgView.DataSource = dc.Employees;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            dc = new CompanyDBDataContext();
            dgView.DataSource = dc.Employees;
        }
    }
}
