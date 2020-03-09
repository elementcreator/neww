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
    public partial class Form2 : Form

    {
        SqlConnection con = new SqlConnection("Data Source = 303-6\\SQLSERVER; Initial Catalog = Zarplati ; Integrated Security = true;");


        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        public int id;
        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand($"Select * From coeefs, grade Where coeefs.id='{id}' AND coeefs.id=grade.id",con);
            SqlDataReader dr = com.ExecuteReader(); 
            if (dr.HasRows)
            {
                dr.Read();
                textBox1.Text = dr["Junior"].ToString();
                textBox2.Text = dr["Middle"].ToString();
                textBox3.Text = dr["Senior"].ToString();
                textBox4.Text = dr["Koef_Analiz"].ToString();
                textBox5.Text = dr["Koef_device"].ToString();
                textBox6.Text= dr["Koef_servicez"].ToString();
                textBox7.Text= dr["Koef_time"].ToString();
                textBox8.Text= dr["coef_complexity"].ToString();
                textBox9.Text = dr["Koef_money"].ToString();
                dr.Close();
            }

            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
