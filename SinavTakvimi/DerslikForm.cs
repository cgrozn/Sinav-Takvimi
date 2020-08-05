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
    public partial class DerslikForm : Form
    {
        public DerslikForm()
        {
            InitializeComponent();
        }

        private void DerslikForm_Load(object sender, EventArgs e)
        {
            DerslikListe();

        }
        SqlConnection baglan = new SqlConnection(@"data source=.;initial catalog=SinavHazirlama;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        void DerslikListe()
        {
            baglan.Open();


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from tblSinif", baglan);

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglan.Open();

            SqlCommand cmd = new SqlCommand("insert into tblSinif(Ad,Kapasite) values('" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "')", baglan);

            cmd.ExecuteNonQuery();

            baglan.Close();
            DerslikListe();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("update tblSinif set Ad='" + textBox2.Text.ToString() + "',Kapasite='" + textBox3.Text.ToString() + "' where Id='"+ textBox1.Text.ToString() + "'", baglan);
            cmd.ExecuteNonQuery();

            baglan.Close();
            DerslikListe();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("delete from tblSinif where Id='" + textBox1.Text + "'", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
            DerslikListe();

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
