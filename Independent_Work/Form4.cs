using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Independent_Work
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
        {
           "admin"
        };
            txtlog.AutoCompleteCustomSource = source;
            txtlog.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtlog.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtlog.Text=="admin"&&txtpassword.Text=="admin123")
            {
                label2.Visible = false;
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                label2.Visible =true;
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }

        }
    }
}
