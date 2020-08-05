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
    public partial class DersDuzenle : Form
    {
        public DersDuzenle()
        {
            InitializeComponent();
        }

        private void DersDuzenle_Load(object sender, EventArgs e)
        {
            DersListe();
        }
        SqlConnection baglan = new SqlConnection(@"data source=.;initial catalog=SinavHazirlama;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        void DersListe()
        {
            baglan.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from tblDersler", baglan);

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("update tblDersler set Ad=@p1,Hoca=@p2,Sinif=@p3 where Id=@p4", baglan);
            cmd.Parameters.AddWithValue("p1", textBox1.Text);
            cmd.Parameters.AddWithValue("p2", textBox2.Text);
            cmd.Parameters.AddWithValue("p3", textBox3.Text);
            cmd.Parameters.AddWithValue("p4", textBox4.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            DersListe();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("delete from tblDersler where Id='" + textBox4.Text + "'", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
