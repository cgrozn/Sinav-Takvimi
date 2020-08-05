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
    public partial class DersEkle : Form
    {
        public DersEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"data source=.;initial catalog=SinavHazirlama;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        private void DersEkle_Load(object sender, EventArgs e)
        {
            HocaListe();

        }
         void HocaListe()
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("select ad from tblHoca ", baglan);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            baglan.Close();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd =new SqlCommand("insert into tblDersler(Ad,Hoca,IdHoca,Sinif) values('"+textBox1.Text.ToString()+ "','" + comboBox1.Text.ToString() + "','"+textBox2.Text.ToString()+"','"+comboBox2.Text.ToString()+"')", baglan);

      

            cmd.ExecuteNonQuery();
            baglan.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd2 = new SqlCommand("Select   *from tblHoca where Id=@p1", baglan);
            cmd2.Parameters.AddWithValue("@p1", comboBox1.SelectedIndex + 1);

            SqlDataReader dr = cmd2.ExecuteReader();

            while (dr.Read())
            {
                textBox2.Text = dr[0].ToString();
            }
            baglan.Close();
        }

        //private void DersEkle_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    Sinav sinav = (Sinav)Application.OpenForms["Sinav"];
        //    sinav.dersListe();
        //}
    }
}
