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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=iGhMbi1ma8U&ab_channel=alishev");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                MessageBox.Show("Флажок " + checkBox.Text + "  теперь отмечен");
            }
            else
            {
                MessageBox.Show("Флажок " + checkBox.Text + "  теперь не отмечен");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(comboBox1.SelectedItem)
            if (comboBox1.SelectedItem == "1") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\1.jpeg");
            else if (comboBox1.SelectedItem == "2") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\2.jpeg");
            else if (comboBox1.SelectedItem == "3") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\3.jpeg");
            else if (comboBox1.SelectedItem == "4") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\4.jpeg");
            else if (comboBox1.SelectedItem == "5") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\5.jpeg");
            else if (comboBox1.SelectedItem == "6") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\6.jpeg");
            else if (comboBox1.SelectedItem == "7") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\7.jpeg");
            else if (comboBox1.SelectedItem == "8") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\8.jpeg");
            else if (comboBox1.SelectedItem == "9") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\9.jpeg");
            else if (comboBox1.SelectedItem == "10") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\10.jpeg");
            else if (comboBox1.SelectedItem == "11") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\11.jpeg");
            else if (comboBox1.SelectedItem == "12") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\12.jpeg");
            else if (comboBox1.SelectedItem == "13") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\13.jpeg");
            else if (comboBox1.SelectedItem == "14") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\14.jpeg");
            else if (comboBox1.SelectedItem == "15") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\15.jpeg");
            else if (comboBox1.SelectedItem == "16") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\16.jpeg");
            else if (comboBox1.SelectedItem == "17") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\17.jpeg");
            else if (comboBox1.SelectedItem == "18") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\18.jpeg");
            else if (comboBox1.SelectedItem == "19") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\luxe.jpeg");
            else if (comboBox1.SelectedItem == "20") pictureBox1.Image = Image.FromFile(@"C:\Users\Guven Servis\Desktop\Indepedent Work\luxe2.jpeg");
            else MessageBox.Show("Номер выберен некорректно ");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked) dateTimePicker1.Enabled = false;
            else dateTimePicker1.Enabled = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string connection = "Data Source = .; Initial Catalog = Work; Integrated Security= True;";
            //using (SqlConnection con = new SqlConnection(connection))
            //{
            //    con.Open();
            //    string Query = "Update Rooms set Empty='Free',Expire_Date=' ' Where Empty='2006'";
            //    SqlCommand command = new SqlCommand(Query, con);
            //    command.ExecuteNonQuery();
            //    con.Close();
            //    MessageBox.Show("Test");

            //}

            string connection = "Data Source = .; Initial Catalog = Work; Integrated Security= True;";
            using (SqlConnection con = new SqlConnection(connection))
            {
                string helpener = dateTimePicker1.Value.ToString();
                con.Open();
                int helpener2 = Convert.ToInt32(maskedTextBox1.Text);
                if (helpener2 <= 0 || helpener2 > 20)
                {
                    MessageBox.Show("Номер введен неправильно");
                }
                else
                {
                    if (checkBox1.Checked)
                    {
                        string Query2 = $"Select Empty From Rooms Where Id=@id";
                        SqlCommand command2 = new SqlCommand(Query2, con);
                        command2.Parameters.AddWithValue("@id", helpener2);
                        SqlDataReader reader = command2.ExecuteReader();
                        while(reader.Read())
                        {
                            if (reader[0].ToString() == "Busy") MessageBox.Show("Номер занят!");
                        }
                        reader.Close();
                        string Query = $"Update Rooms set Empty ='Busy', Expire_date=' ' Where Id=@id";
                        
                        SqlCommand command = new SqlCommand(Query, con);
                        command.Parameters.AddWithValue("@id", helpener2);
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Номер зарезервирован!");
                    }
                    else
                    {
                        string Query2 = $"Select Empty From Rooms Where Id=@id";
                        SqlCommand command2 = new SqlCommand(Query2, con);
                        command2.Parameters.AddWithValue("@id", helpener2);
                        SqlDataReader reader = command2.ExecuteReader();
                        reader.Read();

                        if (reader[0].ToString() == "Busy")
                        {
                            MessageBox.Show("Номер уже зарезервирован");
                            reader.Close();


                        }
                        // con.Open();
                        else
                        {
                            reader.Close();
                            string Query = $"Update Rooms set Empty ='Busy', Expire_date=@helpener Where Id=@id";
                            SqlCommand command = new SqlCommand(Query, con);
                            command.Parameters.AddWithValue("@id", helpener2);
                            command.Parameters.AddWithValue("@helpener", helpener);
                            command.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Номер удачно забронирован!!");
                        }
                            
                        
                       
                        
                    }
                }

            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
