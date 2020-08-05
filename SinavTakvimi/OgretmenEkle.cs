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
    public partial class OgretmenEkle : Form
    {
        public OgretmenEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"data source=.;initial catalog=SinavHazirlama;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("insert into tblHoca(Ad,Sifre) values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
            OgretmenListe();


        }

        private void OgretmenEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            Sinav sinav = (Sinav)Application.OpenForms["Sinav"];
            sinav.HocaListe();
        }
        void OgretmenListe()
        {
            baglan.Open();
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("select *from tblHoca", baglan);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglan.Close();
          
        }

        private void OgretmenEkle_Load(object sender, EventArgs e)
        {
            OgretmenListe();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("delete from tblHoca where Id='" + textBox3.Text + "'", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
            OgretmenListe();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("update tblHoca set Ad=@p1,Sifre=@p2 where Id=@p3", baglan);
            cmd.Parameters.AddWithValue("p1", textBox1.Text);
            cmd.Parameters.AddWithValue("p2", textBox2.Text);
            cmd.Parameters.AddWithValue("p3", textBox3.Text);

            cmd.ExecuteNonQuery();
            baglan.Close();
            OgretmenListe();

        }
    }
}
