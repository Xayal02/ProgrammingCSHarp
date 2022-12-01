using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Independent_Work
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "Data Source = .; Initial Catalog = Work; Integrated Security= True;";
            using (SqlConnection con = new SqlConnection(connection))
            {
                string command;
                if (!checkBox1.Checked) command = "select Rooms.Id,Rooms.Price,Rooms.Empty,Rooms.Expire_Date,Rooms_type.Type from Rooms join Rooms_type on Rooms.Type=Rooms_type.Type_id;";
                else command = "select Rooms.Id,Rooms.Price,Rooms_type.Type from Rooms Join Rooms_type on Rooms.Type = Rooms_type.Type_id where Rooms.Empty = 'Free'";
                SqlDataAdapter adapter = new SqlDataAdapter(command,con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void showfree_Click(object sender, EventArgs e)
        {
            string connection = "Data Source =.;Initial Catalog = Work;Integrated Security = True;";
            using(SqlConnection con = new SqlConnection(connection))
            {
                string command = "select Rooms.Id,Rooms.Price,Rooms_type.Type from Rooms Join Rooms_type on Rooms.Type = Rooms_type.Type_id where Rooms.Empty = 'Free'";
                SqlDataAdapter adapter = new SqlDataAdapter(command, con);
                DataSet data = new DataSet();
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
            }
        }

        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    DateTime data = new DateTime(2022, 5, 10); ;
        //    bool helpener = false;
        //    if(dateTimePicker1.Value == data)
        //    {
        //        helpener = true;
        //        if(helpener)
        //        {
        //            MessageBox.Show("Hello!");
        //        }
        //    }
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
           



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
           

            string connection = "Data Source = .;Initial Catalog = Work;Integrated Security = True;";
            using(SqlConnection con = new SqlConnection(connection))
            {
                string Query = "";
                if (!checkBox1.Checked) Query = $"select Rooms.Id,Rooms.Price,Rooms.Empty,Rooms.Expire_Date,Rooms_type.Type from Rooms join Rooms_type on Rooms.Type = Rooms_type.Type_id where Rooms.Price between {minprice.Value} and {maxprice.Value}";
                else Query = $"select Rooms.Id,Rooms.Price,Rooms_type.Type from Rooms join Rooms_type on Rooms.Type = Rooms_type.Type_id where Rooms.Empty='Free' And Rooms.Price between {minprice.Value} and {maxprice.Value} "; 


                    SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    dataGridView1.DataSource = data.Tables[0];
                
                

            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connection = "Data Source = .;Initial Catalog = Work;Integrated Security = True;";
            using (SqlConnection con = new SqlConnection(connection))
            {
                if (comboBox1.SelectedIndex >= 0)
                {
                    string Query;
                    if (!checkBox1.Checked) Query = $"select Rooms.Id,Rooms.Price,Rooms.Empty,Rooms.Expire_Date,Rooms_type.Type from Rooms join Rooms_type on Rooms.Type = Rooms_type.Type_id where Rooms_Type.Type = '{comboBox1.SelectedItem.ToString()}'";
                    else Query = $"select Rooms.Id,Rooms.Price,Rooms_type.Type from Rooms join Rooms_type on Rooms.Type = Rooms_type.Type_id where Rooms.Empty='Free' And Rooms_Type.Type = '{comboBox1.SelectedItem.ToString()}'";

                    SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    dataGridView1.DataSource = data.Tables[0];
                }
                else MessageBox.Show("Вы не выбрали ни одного варианта");



            }
        }

        private void maxprice_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
