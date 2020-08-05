namespace SinavTakvimi
{
    partial class Sinav
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sinav));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_hafta = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_ders = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_derslik = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.combo_ogret = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.combo_sinif = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ogr_sayi = new System.Windows.Forms.NumericUpDown();
            this.Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.combo_hafta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_ders.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_derslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_ogret.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogr_sayi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(179, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(179, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hafta";
            // 
            // combo_hafta
            // 
            this.combo_hafta.Location = new System.Drawing.Point(274, 174);
            this.combo_hafta.Name = "combo_hafta";
            this.combo_hafta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combo_hafta.Properties.Items.AddRange(new object[] {
            "1 Hafta",
            "2 Hafta"});
            this.combo_hafta.Size = new System.Drawing.Size(200, 20);
            this.combo_hafta.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(620, 154);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 32);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Oluştur";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(179, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dersler";
            // 
            // combo_ders
            // 
            this.combo_ders.Location = new System.Drawing.Point(274, 24);
            this.combo_ders.Name = "combo_ders";
            this.combo_ders.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combo_ders.Size = new System.Drawing.Size(137, 20);
            this.combo_ders.TabIndex = 8;
            this.combo_ders.SelectedIndexChanged += new System.EventHandler(this.combo_ders_SelectedIndexChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(434, 47);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(158, 32);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "Ders Ekle";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(140, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Öğretmenler";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(434, 5);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(158, 36);
            this.simpleButton3.TabIndex = 12;
            this.simpleButton3.Text = "Öğretmen Ekle";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(163, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Derslikler";
            // 
            // combo_derslik
            // 
            this.combo_derslik.Location = new System.Drawing.Point(274, 74);
            this.combo_derslik.Name = "combo_derslik";
            this.combo_derslik.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combo_derslik.Size = new System.Drawing.Size(65, 20);
            this.combo_derslik.TabIndex = 14;
            this.combo_derslik.SelectedIndexChanged += new System.EventHandler(this.combo_derslik_SelectedIndexChanged);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(434, 91);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(158, 33);
            this.simpleButton4.TabIndex = 15;
            this.simpleButton4.Text = "Derslik Ekle";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // combo_ogret
            // 
            this.combo_ogret.Location = new System.Drawing.Point(274, 2);
            this.combo_ogret.Name = "combo_ogret";
            this.combo_ogret.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combo_ogret.Size = new System.Drawing.Size(137, 20);
            this.combo_ogret.TabIndex = 16;
            this.combo_ogret.SelectedIndexChanged += new System.EventHandler(this.combo_ogret_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(274, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2020, 8, 3, 23, 49, 29, 0);
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.dateTimePicker1_CloseUp);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(24, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 436);
            this.panel1.TabIndex = 19;
            // 
            // combo_sinif
            // 
            this.combo_sinif.FormattingEnabled = true;
            this.combo_sinif.Items.AddRange(new object[] {
            "1.SINIF SARI ",
            "2.SINIF YEŞİL",
            "3.SINIF TURUNCU",
            "4.SINIF MOR"});
            this.combo_sinif.Location = new System.Drawing.Point(274, 47);
            this.combo_sinif.Name = "combo_sinif";
            this.combo_sinif.Size = new System.Drawing.Size(137, 21);
            this.combo_sinif.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(198, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Sınıf";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(129, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "Öğrenci Sayısı";
            // 
            // ogr_sayi
            // 
            this.ogr_sayi.Location = new System.Drawing.Point(274, 108);
            this.ogr_sayi.Name = "ogr_sayi";
            this.ogr_sayi.Size = new System.Drawing.Size(120, 20);
            this.ogr_sayi.TabIndex = 29;
            this.ogr_sayi.ValueChanged += new System.EventHandler(this.ogr_sayi_ValueChanged);
            // 
            // Kaydet
            // 
            this.Kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kaydet.Appearance.Options.UseFont = true;
            this.Kaydet.Location = new System.Drawing.Point(721, 154);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(85, 32);
            this.Kaydet.TabIndex = 30;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(610, 47);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(178, 32);
            this.simpleButton5.TabIndex = 31;
            this.simpleButton5.Text = "Ders Update";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // Sinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 679);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.ogr_sayi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combo_sinif);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.combo_ogret);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.combo_derslik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.combo_ders);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.combo_hafta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sinav";
            this.Load += new System.EventHandler(this.Sinav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.combo_hafta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_ders.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_derslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_ogret.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogr_sayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit combo_hafta;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ComboBoxEdit combo_ders;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ComboBoxEdit combo_derslik;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.ComboBoxEdit combo_ogret;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combo_sinif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown ogr_sayi;
        private DevExpress.XtraEditors.SimpleButton Kaydet;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
    }
}