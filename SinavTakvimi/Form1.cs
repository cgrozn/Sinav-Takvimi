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

namespace SinavTakvimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"data source=.;initial catalog=SinavHazirlama;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

   

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select *from tblHoca where  Ad='" + textBox1.Text + "' and Sifre='" + textBox2.Text + "'", baglan);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Sinav sinav = new Sinav();
                sinav.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yanlis Sifre");
            }
            baglan.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
