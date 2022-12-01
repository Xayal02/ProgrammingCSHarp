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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    pictureBox2.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\proqrammirovaie\dog.jpg");
        //}

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form();
            
        }

        private void mscdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Form2 form = new Form2();
            //form.Show();
        }

        private void salamToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 form = new Form2();
            form.Show();
            
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void saolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
