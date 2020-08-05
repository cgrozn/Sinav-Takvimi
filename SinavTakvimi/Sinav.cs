using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;

using System.Windows.Forms;

namespace SinavTakvimi
{
    public partial class Sinav : Form
    {
        private DateTime dateTime = DateTime.Now;
        private string[] SinavZaman1= new string[] { "08:30 - 10:00", "10:00 - 12:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00" };
        private string[] SinavZaman2 = new string[] { "09:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00" };

       private  int GunSayisi;
        private int timesCount = 5;

        public Sinav()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"data source=.;initial catalog=SinavHazirlama;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        private void Sinav_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 600);

            DerslikListe();
            HocaListe();

            dateTimePicker1.Value = DateTime.Now;
            combo_hafta.Text = combo_hafta.Properties.Items[0].ToString();
            combo_sinif.Text = combo_sinif.Items[0].ToString();

            panel1.HorizontalScroll.Enabled = false;
            panel1.VerticalScroll.Enabled = true;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
        }
     

         public  void HocaListe()
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("select ad from tblHoca ",baglan);

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                combo_ogret.Properties.Items.Add(dr[0].ToString());
            }
            baglan.Close();
        }
         public    void DerslikListe()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select ad,kapasite from tblsinif ", baglan);
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
               // combo_derslik.Properties.Items.Add(dr[0].ToString() +"   "+ dr[1].ToString());
                combo_derslik.Properties.Items.Add(dr[0].ToString());

            }

            baglan.Close();

        }

        

       void PanelAyarla()
        {

            if (combo_hafta.SelectedIndex == 0)
            {
                GunSayisi = 5;
                panel1.Size = new Size(1100, 350);

                this.Size = new Size(1100, 600);
            }
            else
            {
                GunSayisi = 10;
                panel1.Size = new Size(1100, 350);
                this.Size = new Size(1100, 600);
            }
        }

        void GunAyarla()
        {
             string[] times = new string[timesCount];
            times = SinavZaman1;
            if (combo_hafta.SelectedIndex == 1)
            {
                times = SinavZaman2;

            }
            Label[] dayLabel = new Label[GunSayisi];
            Size dayLabelSize = new Size(170, 30);
            int dayLabelX = 5;
            int dayLabelY = 50;

            for (int i = 0; i < dayLabel.Length; i++)
            {
                //gün kontrıl
                if (dateTime.DayOfWeek.ToString() == "Saturday")
                    dateTime = dateTime.AddDays(2);
                else if (dateTime.DayOfWeek.ToString() == "Sunday")
                    dateTime = dateTime.AddDays(1);


                dayLabel[i] = new Label();
                dayLabel[i].Font = new Font("Tahoma", 8, FontStyle.Bold);
                dayLabel[i].AutoSize = false;
                dayLabel[i].Size = dayLabelSize;
                dayLabel[i].Left = dayLabelX;
                dayLabel[i].Top = dayLabelY;
                dayLabel[i].Text = dateTime.ToString("dd/MM/yyyy") + " " + CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)dateTime.DayOfWeek];

                // Pozisyon Ayarla
                dayLabelY += 62;

                // Gün Ayarla
                dateTime = dateTime.AddDays(1);

                // TablePanel e Ekle
                panel1.Controls.Add(dayLabel[i]);
            }
            Label[] timesLabel = new Label[timesCount];
            Size timesLabelSize = new Size(120, 30);
            int timesLabelX = 215;
            int timesLabelY = 5;

            for (int i = 0; i < timesLabel.Length; i++)
            {
                timesLabel[i] = new Label();
                timesLabel[i].Font = new Font("Tahoma", 8, FontStyle.Bold);
                timesLabel[i].AutoSize = false;
                timesLabel[i].Size = timesLabelSize;
                timesLabel[i].Left = timesLabelX;
                timesLabel[i].Top = timesLabelY;
                timesLabel[i].Text = times[i];

                timesLabelX += 150;
                panel1.Controls.Add(timesLabel[i]);



            }
        }
        void ButtonOlustur()
        {
            Button[] buttonOl = new Button[timesCount * GunSayisi];
            Size buttonOlSize = new Size(150, 50);
            int buttonOlX = 190;
            int buttonOlY = 35;

            for (int i = 0; i < buttonOl.Length; i++)
            {
                // Pozisyon Kontrolü
                if (i != 0 && i % 5 == 0)
                {
                    buttonOlX = 190;
                    buttonOlY += 62;
                }

                // examBtns ayarları
                buttonOl[i] = new Button();
                buttonOl[i].Click += new EventHandler(RenkOlustur);
                buttonOl[i].Font = new Font("Tahoma", 10);
                buttonOl[i].BackColor = Color.White;
                buttonOl[i].TabIndex = 10 + i;
                buttonOl[i].TabStop = false;
                buttonOl[i].FlatStyle = FlatStyle.Flat;
                buttonOl[i].FlatAppearance.BorderSize = 0;
                buttonOl[i].AutoSize = false;
                buttonOl[i].Size = buttonOlSize;
                buttonOl[i].Left = buttonOlX;
                buttonOl[i].Top = buttonOlY;
                buttonOl[i].Text = "Sınav Ekle";

                // Pozisyon Ayarla
                buttonOlX += 155;

                // TablePanel e Ekle
                panel1.Controls.Add(buttonOl[i]);
            }
        }


        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
           

            panel1.Controls.Clear();

            PanelAyarla();

            GunAyarla();

            ButtonOlustur();


        }
        private void RenkOlustur(object sender, EventArgs e)
        {
            combo_ders.Focus();

            Button button = sender as Button;

            if (button.BackColor != Color.White) { button.BackColor = Color.White; button.Text = "Sınav Ekle"; }
            else if (combo_ders.Text != "" && combo_ogret.Text != "")
            {

                // Button renk
               switch (combo_sinif.SelectedIndex)
             
                {
                    //sarı
                    case 0:
                        button.BackColor = Color.Yellow;
                        break;
                 
                    case 1:
                        button.BackColor = Color.FromArgb(100, 0, 255, 76);
                        break;
         
                        //turuncu
                    case 2:
                        button.BackColor = Color.Orange;

                        break;
                    // Mor
                    case 3:
                        button.BackColor = Color.FromArgb(100, 171, 0, 255);
                        break;
             
                    
                }

                // Button yazı
                float font_size = 8;

                if ((combo_ders.Text.Length + combo_ogret.Text.Length) + 5 > 32) font_size = 8;
                button.Font = new Font("Tahoma", font_size);

               

                button.Text += combo_ders.Text;
                button.Text += "\n" + combo_ogret.Text;
                  button.Text += "\n - " + combo_derslik.Text.ToString();
            }
            else
                MessageBox.Show("DERS ve ÖĞRETMEN Bilgilerini Girin!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            var dateTimePicker = sender as DateTimePicker;

            if (dateTimePicker.Value.DayOfWeek.ToString() == "Saturday" || dateTimePicker.Value.DayOfWeek.ToString() == "Sunday")
            {
                if (dateTimePicker.Value.DayOfWeek.ToString() == "Saturday")
                    dateTimePicker.Value = dateTimePicker.Value.AddDays(2);
                else
                    dateTimePicker.Value = dateTimePicker.Value.AddDays(1);

                MessageBox.Show("Hafta sonu sınav  günü seçilmez", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else dateTime = dateTimePicker.Value;
        }

        private void combo_ogret_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_ders.Properties.Items.Clear();
            

            baglan.Open();


            SqlCommand cmd = new SqlCommand("select  Ad,sinif from tblDersler where IdHoca=@p1", baglan);
            cmd.Parameters.AddWithValue("@p1", combo_ogret.SelectedIndex+1);

          
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               combo_ders.Properties.Items.Add(dr[0]+"  "+dr[1]+".Sınıf");

            }

            baglan.Close();


        }
        
        private void combo_derslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("select kapasite from tblSinif where ad=@p1", baglan);
            cmd.Parameters.AddWithValue("@p1", combo_derslik.SelectedItem);


            SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
            {
                    label8.Text = dr[0].ToString();

                }

            baglan.Close();
        }

        private void ogr_sayi_ValueChanged(object sender, EventArgs e)
        {
            if (ogr_sayi.Value > (label8.Text[combo_derslik.SelectedIndex]))
            {
                MessageBox.Show("Öğrenci Sayısı Derslik Kapasitesini Aşıyor !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                ResimKaydet(folderName + @"\Tablo" + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".png");
            }
        }
        private void ResimKaydet(string folderName)
        {
            // Ekran görüntüsü modu
            
            panel1.AutoSize = true;
            panel1.Height += 50;

            Label[] labels = new Label[2];

            // Renk Yazısı
            labels[0] = new Label();
            labels[0].Font = new Font("Tahoma", 8, FontStyle.Bold);
            labels[0].Text = "Sınıf 1: Sarı / Sınıf 2: Yeşil / Sınıf 3: Turuncu / Sınıf 4: Mor";
            labels[0].AutoSize = true;
            labels[0].Left = (panel1.Width / 2) - labels[0].Size.Width;
            labels[0].Top = panel1.Height - 45;

            // İşaret Metni
            labels[1] = new Label();
            labels[1].Font = new Font("Tahoma", 8, FontStyle.Bold);
            labels[1].AutoSize = true;
            labels[1].Left = (panel1.Width / 2) - (labels[1].Size.Width * 2);
            labels[1].Top = panel1.Height - 25;

            panel1.Controls.Add(labels[0]);
            panel1.Controls.Add(labels[1]);

            // Ekran görüntüsü al
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            bmp.Save(folderName);

            // Düzenleme modu
          
            panel1.AutoSize = false;
            panel1.Size = new Size(1100, 700);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            OgretmenEkle ogretmen = new OgretmenEkle();
            ogretmen.Show();
            HocaListe();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DersEkle ders = new DersEkle();
            ders.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            DersDuzenle dersDuzenle = new DersDuzenle();
            dersDuzenle.Show();
        }

        private void combo_ders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            DerslikForm derslikForm = new DerslikForm();
            derslikForm.Show();
        }
    }
}
