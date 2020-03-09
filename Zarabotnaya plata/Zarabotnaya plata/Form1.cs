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


namespace Zarabotnaya_plata
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source = 303-6\\SQLSERVER; Initial Catalog = Zarplati ; Integrated Security = true;");


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand($"Select [FIO_manager] From manager where Login_manager = '{textBox1.Text}' and Password ='{textBox2.Text}'",con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();           
                MessageBox.Show("Вход выполнен");
                Form2 fm = new Form2();
                dr.Close();
                con.Close();
                fm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Неверно введен пароль или логин");

           if (con.State == ConnectionState.Open)
                con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
