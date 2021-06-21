
namespace BorsaUygulamasi
{
    partial class KullaniciFormu
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
            this.components = new System.ComponentModel.Container();
            this.tabControlKullanici = new System.Windows.Forms.TabControl();
            this.tabPageBilgiler = new System.Windows.Forms.TabPage();
            this.tbxYetki = new System.Windows.Forms.TextBox();
            this.lblYetki = new System.Windows.Forms.Label();
            this.btnCikisKB = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txbAdres = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbTelNo = new System.Windows.Forms.TextBox();
            this.txbTcNo = new System.Windows.Forms.TextBox();
            this.txbSoyad = new System.Windows.Forms.TextBox();
            this.txbAd = new System.Windows.Forms.TextBox();
            this.txbSifre = new System.Windows.Forms.TextBox();
            this.txbKAdi = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKAdi = new System.Windows.Forms.Label();
            this.tabPageBakiye = new System.Windows.Forms.TabPage();
            this.btnRaporAl = new System.Windows.Forms.Button();
            this.lblBakiyeDeger = new System.Windows.Forms.Label();
            this.lblKalanParaDeger = new System.Windows.Forms.Label();
            this.cmbParaBirimi = new System.Windows.Forms.ComboBox();
            this.lblParaBirimi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblKalanPara = new System.Windows.Forms.Label();
            this.btnParaEkle = new System.Windows.Forms.Button();
            this.txtboxParaMiktari = new System.Windows.Forms.TextBox();
            this.lblParaMiktari = new System.Windows.Forms.Label();
            this.dataGridViewParaHareketleri = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCikisB = new System.Windows.Forms.Button();
            this.tabPageUrunler = new System.Windows.Forms.TabPage();
            this.btnUrunRapor = new System.Windows.Forms.Button();
            this.btnCikisU = new System.Windows.Forms.Button();
            this.txtboxBirimFiyat = new System.Windows.Forms.TextBox();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.lblUrunMiktar = new System.Windows.Forms.Label();
            this.txtboxUrunMiktari = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.cmbEklenecekUrunAdi = new System.Windows.Forms.ComboBox();
            this.ıtemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planlamaOyunuDataSet = new BorsaUygulamasi.PlanlamaOyunuDataSet();
            this.dataGridViewUrunHareketleri = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageAlisveris = new System.Windows.Forms.TabPage();
            this.btnRapor = new System.Windows.Forms.Button();
            this.txtboxAlinacakBirimFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUrunuAl = new System.Windows.Forms.Button();
            this.txtboxAlinacakUrunMiktari = new System.Windows.Forms.TextBox();
            this.cmbAlinacakUrunAdi = new System.Windows.Forms.ComboBox();
            this.lblAlinacakUrunMiktari = new System.Windows.Forms.Label();
            this.lblAlinacakUrun = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewSatistakiUrunler = new System.Windows.Forms.DataGridView();
            this.btnCikisA = new System.Windows.Forms.Button();
            this.itemTableAdapter = new BorsaUygulamasi.PlanlamaOyunuDataSetTableAdapters.ItemTableAdapter();
            this.tabControlKullanici.SuspendLayout();
            this.tabPageBilgiler.SuspendLayout();
            this.tabPageBakiye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParaHareketleri)).BeginInit();
            this.tabPageUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıtemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planlamaOyunuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunHareketleri)).BeginInit();
            this.tabPageAlisveris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatistakiUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlKullanici
            // 
            this.tabControlKullanici.Controls.Add(this.tabPageBilgiler);
            this.tabControlKullanici.Controls.Add(this.tabPageBakiye);
            this.tabControlKullanici.Controls.Add(this.tabPageUrunler);
            this.tabControlKullanici.Controls.Add(this.tabPageAlisveris);
            this.tabControlKullanici.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControlKullanici.Location = new System.Drawing.Point(12, 13);
            this.tabControlKullanici.Name = "tabControlKullanici";
            this.tabControlKullanici.SelectedIndex = 0;
            this.tabControlKullanici.Size = new System.Drawing.Size(1080, 598);
            this.tabControlKullanici.TabIndex = 0;
            // 
            // tabPageBilgiler
            // 
            this.tabPageBilgiler.BackColor = System.Drawing.Color.LightCyan;
            this.tabPageBilgiler.Controls.Add(this.tbxYetki);
            this.tabPageBilgiler.Controls.Add(this.lblYetki);
            this.tabPageBilgiler.Controls.Add(this.btnCikisKB);
            this.tabPageBilgiler.Controls.Add(this.btnGuncelle);
            this.tabPageBilgiler.Controls.Add(this.txbAdres);
            this.tabPageBilgiler.Controls.Add(this.txbEmail);
            this.tabPageBilgiler.Controls.Add(this.txbTelNo);
            this.tabPageBilgiler.Controls.Add(this.txbTcNo);
            this.tabPageBilgiler.Controls.Add(this.txbSoyad);
            this.tabPageBilgiler.Controls.Add(this.txbAd);
            this.tabPageBilgiler.Controls.Add(this.txbSifre);
            this.tabPageBilgiler.Controls.Add(this.txbKAdi);
            this.tabPageBilgiler.Controls.Add(this.lblAdres);
            this.tabPageBilgiler.Controls.Add(this.lblEmail);
            this.tabPageBilgiler.Controls.Add(this.lblTelNo);
            this.tabPageBilgiler.Controls.Add(this.lblTcNo);
            this.tabPageBilgiler.Controls.Add(this.lblSoyad);
            this.tabPageBilgiler.Controls.Add(this.lblAd);
            this.tabPageBilgiler.Controls.Add(this.lblSifre);
            this.tabPageBilgiler.Controls.Add(this.lblKAdi);
            this.tabPageBilgiler.Location = new System.Drawing.Point(4, 32);
            this.tabPageBilgiler.Name = "tabPageBilgiler";
            this.tabPageBilgiler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBilgiler.Size = new System.Drawing.Size(1072, 562);
            this.tabPageBilgiler.TabIndex = 0;
            this.tabPageBilgiler.Text = "Bilgilerim";
            // 
            // tbxYetki
            // 
            this.tbxYetki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxYetki.Enabled = false;
            this.tbxYetki.Location = new System.Drawing.Point(868, 36);
            this.tbxYetki.Name = "tbxYetki";
            this.tbxYetki.Size = new System.Drawing.Size(181, 30);
            this.tbxYetki.TabIndex = 27;
            this.tbxYetki.Text = "Kullanıcı";
            this.tbxYetki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetki.Location = new System.Drawing.Point(749, 46);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(71, 23);
            this.lblYetki.TabIndex = 26;
            this.lblYetki.Text = "Yetki : ";
            // 
            // btnCikisKB
            // 
            this.btnCikisKB.BackgroundImage = global::BorsaUygulamasi.Properties.Resources.cikis_ikon;
            this.btnCikisKB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikisKB.Location = new System.Drawing.Point(979, 481);
            this.btnCikisKB.Name = "btnCikisKB";
            this.btnCikisKB.Size = new System.Drawing.Size(70, 67);
            this.btnCikisKB.TabIndex = 25;
            this.btnCikisKB.UseVisualStyleBackColor = true;
            this.btnCikisKB.Click += new System.EventHandler(this.btnCikisKB_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuncelle.Location = new System.Drawing.Point(753, 481);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(204, 67);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "BİLGİLERİMİ GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txbAdres
            // 
            this.txbAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbAdres.Location = new System.Drawing.Point(252, 505);
            this.txbAdres.Name = "txbAdres";
            this.txbAdres.Size = new System.Drawing.Size(182, 30);
            this.txbAdres.TabIndex = 1;
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbEmail.Location = new System.Drawing.Point(252, 442);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(182, 30);
            this.txbEmail.TabIndex = 1;
            // 
            // txbTelNo
            // 
            this.txbTelNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbTelNo.Location = new System.Drawing.Point(253, 376);
            this.txbTelNo.Name = "txbTelNo";
            this.txbTelNo.Size = new System.Drawing.Size(181, 30);
            this.txbTelNo.TabIndex = 1;
            // 
            // txbTcNo
            // 
            this.txbTcNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbTcNo.Location = new System.Drawing.Point(253, 306);
            this.txbTcNo.Name = "txbTcNo";
            this.txbTcNo.Size = new System.Drawing.Size(181, 30);
            this.txbTcNo.TabIndex = 1;
            // 
            // txbSoyad
            // 
            this.txbSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbSoyad.Location = new System.Drawing.Point(253, 238);
            this.txbSoyad.Name = "txbSoyad";
            this.txbSoyad.Size = new System.Drawing.Size(181, 30);
            this.txbSoyad.TabIndex = 1;
            // 
            // txbAd
            // 
            this.txbAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbAd.Location = new System.Drawing.Point(252, 175);
            this.txbAd.Name = "txbAd";
            this.txbAd.Size = new System.Drawing.Size(182, 30);
            this.txbAd.TabIndex = 1;
            // 
            // txbSifre
            // 
            this.txbSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbSifre.Location = new System.Drawing.Point(252, 103);
            this.txbSifre.Name = "txbSifre";
            this.txbSifre.Size = new System.Drawing.Size(182, 30);
            this.txbSifre.TabIndex = 1;
            // 
            // txbKAdi
            // 
            this.txbKAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbKAdi.Location = new System.Drawing.Point(252, 39);
            this.txbKAdi.Name = "txbKAdi";
            this.txbKAdi.Size = new System.Drawing.Size(182, 30);
            this.txbKAdi.TabIndex = 1;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(62, 505);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(77, 23);
            this.lblAdres.TabIndex = 0;
            this.lblAdres.Text = "Adres : ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(61, 442);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 23);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail : ";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelNo.Location = new System.Drawing.Point(62, 374);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(82, 23);
            this.lblTelNo.TabIndex = 0;
            this.lblTelNo.Text = "Tel No : ";
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcNo.Location = new System.Drawing.Point(63, 306);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(83, 23);
            this.lblTcNo.TabIndex = 0;
            this.lblTcNo.Text = "TC No : ";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(62, 237);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(78, 23);
            this.lblSoyad.TabIndex = 0;
            this.lblSoyad.Text = "Soyad : ";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(62, 173);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(51, 23);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad : ";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(62, 103);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(68, 23);
            this.lblSifre.TabIndex = 0;
            this.lblSifre.Text = "Şifre : ";
            // 
            // lblKAdi
            // 
            this.lblKAdi.AutoSize = true;
            this.lblKAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKAdi.Location = new System.Drawing.Point(62, 36);
            this.lblKAdi.Name = "lblKAdi";
            this.lblKAdi.Size = new System.Drawing.Size(133, 23);
            this.lblKAdi.TabIndex = 0;
            this.lblKAdi.Text = "Kullanıcı Adı : ";
            // 
            // tabPageBakiye
            // 
            this.tabPageBakiye.BackColor = System.Drawing.Color.LightCyan;
            this.tabPageBakiye.Controls.Add(this.btnRaporAl);
            this.tabPageBakiye.Controls.Add(this.lblBakiyeDeger);
            this.tabPageBakiye.Controls.Add(this.lblKalanParaDeger);
            this.tabPageBakiye.Controls.Add(this.cmbParaBirimi);
            this.tabPageBakiye.Controls.Add(this.lblParaBirimi);
            this.tabPageBakiye.Controls.Add(this.label2);
            this.tabPageBakiye.Controls.Add(this.label1);
            this.tabPageBakiye.Controls.Add(this.lblBakiye);
            this.tabPageBakiye.Controls.Add(this.lblKalanPara);
            this.tabPageBakiye.Controls.Add(this.btnParaEkle);
            this.tabPageBakiye.Controls.Add(this.txtboxParaMiktari);
            this.tabPageBakiye.Controls.Add(this.lblParaMiktari);
            this.tabPageBakiye.Controls.Add(this.dataGridViewParaHareketleri);
            this.tabPageBakiye.Controls.Add(this.label5);
            this.tabPageBakiye.Controls.Add(this.btnCikisB);
            this.tabPageBakiye.Location = new System.Drawing.Point(4, 32);
            this.tabPageBakiye.Name = "tabPageBakiye";
            this.tabPageBakiye.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBakiye.Size = new System.Drawing.Size(1072, 562);
            this.tabPageBakiye.TabIndex = 1;
            this.tabPageBakiye.Text = "Bakiyem";
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRaporAl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporAl.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRaporAl.Location = new System.Drawing.Point(698, 478);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(191, 58);
            this.btnRaporAl.TabIndex = 43;
            this.btnRaporAl.Text = "EXCEL\'E AKTAR";
            this.btnRaporAl.UseVisualStyleBackColor = false;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // lblBakiyeDeger
            // 
            this.lblBakiyeDeger.AutoSize = true;
            this.lblBakiyeDeger.Location = new System.Drawing.Point(889, 255);
            this.lblBakiyeDeger.Name = "lblBakiyeDeger";
            this.lblBakiyeDeger.Size = new System.Drawing.Size(0, 23);
            this.lblBakiyeDeger.TabIndex = 42;
            // 
            // lblKalanParaDeger
            // 
            this.lblKalanParaDeger.AutoSize = true;
            this.lblKalanParaDeger.Location = new System.Drawing.Point(695, 58);
            this.lblKalanParaDeger.Name = "lblKalanParaDeger";
            this.lblKalanParaDeger.Size = new System.Drawing.Size(0, 23);
            this.lblKalanParaDeger.TabIndex = 41;
            // 
            // cmbParaBirimi
            // 
            this.cmbParaBirimi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbParaBirimi.FormattingEnabled = true;
            this.cmbParaBirimi.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "TL"});
            this.cmbParaBirimi.Location = new System.Drawing.Point(871, 112);
            this.cmbParaBirimi.Name = "cmbParaBirimi";
            this.cmbParaBirimi.Size = new System.Drawing.Size(181, 31);
            this.cmbParaBirimi.TabIndex = 40;
            // 
            // lblParaBirimi
            // 
            this.lblParaBirimi.AutoSize = true;
            this.lblParaBirimi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaBirimi.Location = new System.Drawing.Point(701, 120);
            this.lblParaBirimi.Name = "lblParaBirimi";
            this.lblParaBirimi.Size = new System.Drawing.Size(123, 23);
            this.lblParaBirimi.TabIndex = 39;
            this.lblParaBirimi.Text = "Para Birimi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(988, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(306, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 36;
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.BackColor = System.Drawing.Color.Transparent;
            this.lblBakiye.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(701, 255);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(86, 23);
            this.lblBakiye.TabIndex = 35;
            this.lblBakiye.Text = "Bakiye : ";
            // 
            // lblKalanPara
            // 
            this.lblKalanPara.AutoSize = true;
            this.lblKalanPara.BackColor = System.Drawing.Color.Transparent;
            this.lblKalanPara.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanPara.Location = new System.Drawing.Point(701, 206);
            this.lblKalanPara.Name = "lblKalanPara";
            this.lblKalanPara.Size = new System.Drawing.Size(121, 23);
            this.lblKalanPara.TabIndex = 34;
            this.lblKalanPara.Text = "Kalan Para : ";
            // 
            // btnParaEkle
            // 
            this.btnParaEkle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnParaEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnParaEkle.Location = new System.Drawing.Point(698, 384);
            this.btnParaEkle.Name = "btnParaEkle";
            this.btnParaEkle.Size = new System.Drawing.Size(191, 59);
            this.btnParaEkle.TabIndex = 33;
            this.btnParaEkle.Text = "YATIR";
            this.btnParaEkle.UseVisualStyleBackColor = false;
            this.btnParaEkle.Click += new System.EventHandler(this.btnParaEkle_Click);
            // 
            // txtboxParaMiktari
            // 
            this.txtboxParaMiktari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtboxParaMiktari.Location = new System.Drawing.Point(871, 60);
            this.txtboxParaMiktari.Name = "txtboxParaMiktari";
            this.txtboxParaMiktari.Size = new System.Drawing.Size(181, 30);
            this.txtboxParaMiktari.TabIndex = 32;
            // 
            // lblParaMiktari
            // 
            this.lblParaMiktari.AutoSize = true;
            this.lblParaMiktari.BackColor = System.Drawing.Color.Transparent;
            this.lblParaMiktari.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaMiktari.Location = new System.Drawing.Point(701, 58);
            this.lblParaMiktari.Name = "lblParaMiktari";
            this.lblParaMiktari.Size = new System.Drawing.Size(136, 23);
            this.lblParaMiktari.TabIndex = 31;
            this.lblParaMiktari.Text = "Para Miktarı : ";
            // 
            // dataGridViewParaHareketleri
            // 
            this.dataGridViewParaHareketleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParaHareketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParaHareketleri.Location = new System.Drawing.Point(16, 58);
            this.dataGridViewParaHareketleri.Name = "dataGridViewParaHareketleri";
            this.dataGridViewParaHareketleri.RowHeadersWidth = 51;
            this.dataGridViewParaHareketleri.RowTemplate.Height = 24;
            this.dataGridViewParaHareketleri.Size = new System.Drawing.Size(648, 478);
            this.dataGridViewParaHareketleri.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "PARA HAREKETLERİM";
            // 
            // btnCikisB
            // 
            this.btnCikisB.BackgroundImage = global::BorsaUygulamasi.Properties.Resources.cikis_ikon;
            this.btnCikisB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikisB.Location = new System.Drawing.Point(983, 478);
            this.btnCikisB.Name = "btnCikisB";
            this.btnCikisB.Size = new System.Drawing.Size(69, 59);
            this.btnCikisB.TabIndex = 38;
            this.btnCikisB.UseVisualStyleBackColor = true;
            this.btnCikisB.Click += new System.EventHandler(this.btnCikisB_Click);
            // 
            // tabPageUrunler
            // 
            this.tabPageUrunler.BackColor = System.Drawing.Color.LightCyan;
            this.tabPageUrunler.Controls.Add(this.btnUrunRapor);
            this.tabPageUrunler.Controls.Add(this.btnCikisU);
            this.tabPageUrunler.Controls.Add(this.txtboxBirimFiyat);
            this.tabPageUrunler.Controls.Add(this.lblBirimFiyat);
            this.tabPageUrunler.Controls.Add(this.btnUrunEkle);
            this.tabPageUrunler.Controls.Add(this.lblUrunMiktar);
            this.tabPageUrunler.Controls.Add(this.txtboxUrunMiktari);
            this.tabPageUrunler.Controls.Add(this.lblUrunAdi);
            this.tabPageUrunler.Controls.Add(this.cmbEklenecekUrunAdi);
            this.tabPageUrunler.Controls.Add(this.dataGridViewUrunHareketleri);
            this.tabPageUrunler.Controls.Add(this.label3);
            this.tabPageUrunler.Location = new System.Drawing.Point(4, 32);
            this.tabPageUrunler.Name = "tabPageUrunler";
            this.tabPageUrunler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunler.Size = new System.Drawing.Size(1072, 562);
            this.tabPageUrunler.TabIndex = 2;
            this.tabPageUrunler.Text = "Ürünlerim";
            // 
            // btnUrunRapor
            // 
            this.btnUrunRapor.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUrunRapor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunRapor.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUrunRapor.Location = new System.Drawing.Point(728, 486);
            this.btnUrunRapor.Name = "btnUrunRapor";
            this.btnUrunRapor.Size = new System.Drawing.Size(148, 60);
            this.btnUrunRapor.TabIndex = 44;
            this.btnUrunRapor.Text = "EXCEL\'E AKTAR";
            this.btnUrunRapor.UseVisualStyleBackColor = false;
            this.btnUrunRapor.Click += new System.EventHandler(this.btnUrunRapor_Click);
            // 
            // btnCikisU
            // 
            this.btnCikisU.BackgroundImage = global::BorsaUygulamasi.Properties.Resources.cikis_ikon;
            this.btnCikisU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikisU.Location = new System.Drawing.Point(982, 486);
            this.btnCikisU.Name = "btnCikisU";
            this.btnCikisU.Size = new System.Drawing.Size(69, 60);
            this.btnCikisU.TabIndex = 36;
            this.btnCikisU.UseVisualStyleBackColor = true;
            this.btnCikisU.Click += new System.EventHandler(this.btnCikisU_Click);
            // 
            // txtboxBirimFiyat
            // 
            this.txtboxBirimFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtboxBirimFiyat.Location = new System.Drawing.Point(894, 173);
            this.txtboxBirimFiyat.Name = "txtboxBirimFiyat";
            this.txtboxBirimFiyat.Size = new System.Drawing.Size(157, 30);
            this.txtboxBirimFiyat.TabIndex = 35;
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.BackColor = System.Drawing.Color.Transparent;
            this.lblBirimFiyat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirimFiyat.Location = new System.Drawing.Point(724, 176);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(121, 23);
            this.lblBirimFiyat.TabIndex = 34;
            this.lblBirimFiyat.Text = "Birim Fiyat : ";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUrunEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUrunEkle.Location = new System.Drawing.Point(728, 401);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(148, 55);
            this.btnUrunEkle.TabIndex = 33;
            this.btnUrunEkle.Text = "SATIŞA KOY";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // lblUrunMiktar
            // 
            this.lblUrunMiktar.AutoSize = true;
            this.lblUrunMiktar.BackColor = System.Drawing.Color.Transparent;
            this.lblUrunMiktar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunMiktar.Location = new System.Drawing.Point(724, 117);
            this.lblUrunMiktar.Name = "lblUrunMiktar";
            this.lblUrunMiktar.Size = new System.Drawing.Size(115, 23);
            this.lblUrunMiktar.TabIndex = 32;
            this.lblUrunMiktar.Text = "Miktar (g) : ";
            // 
            // txtboxUrunMiktari
            // 
            this.txtboxUrunMiktari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtboxUrunMiktari.Location = new System.Drawing.Point(894, 117);
            this.txtboxUrunMiktari.Name = "txtboxUrunMiktari";
            this.txtboxUrunMiktari.Size = new System.Drawing.Size(157, 30);
            this.txtboxUrunMiktari.TabIndex = 31;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblUrunAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(724, 60);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(103, 23);
            this.lblUrunAdi.TabIndex = 30;
            this.lblUrunAdi.Text = "Ürün Adı : ";
            // 
            // cmbEklenecekUrunAdi
            // 
            this.cmbEklenecekUrunAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbEklenecekUrunAdi.DataSource = this.ıtemBindingSource;
            this.cmbEklenecekUrunAdi.DisplayMember = "ItemName";
            this.cmbEklenecekUrunAdi.FormattingEnabled = true;
            this.cmbEklenecekUrunAdi.Location = new System.Drawing.Point(894, 62);
            this.cmbEklenecekUrunAdi.Name = "cmbEklenecekUrunAdi";
            this.cmbEklenecekUrunAdi.Size = new System.Drawing.Size(157, 31);
            this.cmbEklenecekUrunAdi.TabIndex = 29;
            this.cmbEklenecekUrunAdi.ValueMember = "ItemID";
            // 
            // ıtemBindingSource
            // 
            this.ıtemBindingSource.DataMember = "Item";
            this.ıtemBindingSource.DataSource = this.planlamaOyunuDataSet;
            // 
            // planlamaOyunuDataSet
            // 
            this.planlamaOyunuDataSet.DataSetName = "PlanlamaOyunuDataSet";
            this.planlamaOyunuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewUrunHareketleri
            // 
            this.dataGridViewUrunHareketleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUrunHareketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunHareketleri.Location = new System.Drawing.Point(10, 62);
            this.dataGridViewUrunHareketleri.Name = "dataGridViewUrunHareketleri";
            this.dataGridViewUrunHareketleri.RowHeadersWidth = 51;
            this.dataGridViewUrunHareketleri.RowTemplate.Height = 24;
            this.dataGridViewUrunHareketleri.Size = new System.Drawing.Size(682, 484);
            this.dataGridViewUrunHareketleri.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "ÜRÜN HAREKETLERİM";
            // 
            // tabPageAlisveris
            // 
            this.tabPageAlisveris.BackColor = System.Drawing.Color.LightCyan;
            this.tabPageAlisveris.Controls.Add(this.btnRapor);
            this.tabPageAlisveris.Controls.Add(this.txtboxAlinacakBirimFiyat);
            this.tabPageAlisveris.Controls.Add(this.label6);
            this.tabPageAlisveris.Controls.Add(this.btnUrunuAl);
            this.tabPageAlisveris.Controls.Add(this.txtboxAlinacakUrunMiktari);
            this.tabPageAlisveris.Controls.Add(this.cmbAlinacakUrunAdi);
            this.tabPageAlisveris.Controls.Add(this.lblAlinacakUrunMiktari);
            this.tabPageAlisveris.Controls.Add(this.lblAlinacakUrun);
            this.tabPageAlisveris.Controls.Add(this.label4);
            this.tabPageAlisveris.Controls.Add(this.dataGridViewSatistakiUrunler);
            this.tabPageAlisveris.Controls.Add(this.btnCikisA);
            this.tabPageAlisveris.Location = new System.Drawing.Point(4, 32);
            this.tabPageAlisveris.Name = "tabPageAlisveris";
            this.tabPageAlisveris.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlisveris.Size = new System.Drawing.Size(1072, 562);
            this.tabPageAlisveris.TabIndex = 3;
            this.tabPageAlisveris.Text = "Alışveriş";
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRapor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRapor.Location = new System.Drawing.Point(835, 417);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(218, 51);
            this.btnRapor.TabIndex = 38;
            this.btnRapor.Text = "RAPORLA";
            this.btnRapor.UseVisualStyleBackColor = false;
            // 
            // txtboxAlinacakBirimFiyat
            // 
            this.txtboxAlinacakBirimFiyat.BackColor = System.Drawing.Color.LightGray;
            this.txtboxAlinacakBirimFiyat.Location = new System.Drawing.Point(336, 517);
            this.txtboxAlinacakBirimFiyat.Name = "txtboxAlinacakBirimFiyat";
            this.txtboxAlinacakBirimFiyat.Size = new System.Drawing.Size(175, 30);
            this.txtboxAlinacakBirimFiyat.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Alınmak İstenen Birim Fiyat : ";
            // 
            // btnUrunuAl
            // 
            this.btnUrunuAl.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUrunuAl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunuAl.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUrunuAl.Location = new System.Drawing.Point(835, 489);
            this.btnUrunuAl.Name = "btnUrunuAl";
            this.btnUrunuAl.Size = new System.Drawing.Size(121, 55);
            this.btnUrunuAl.TabIndex = 34;
            this.btnUrunuAl.Text = "AL";
            this.btnUrunuAl.UseVisualStyleBackColor = false;
            this.btnUrunuAl.Click += new System.EventHandler(this.btnUrunuAl_Click);
            // 
            // txtboxAlinacakUrunMiktari
            // 
            this.txtboxAlinacakUrunMiktari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtboxAlinacakUrunMiktari.Location = new System.Drawing.Point(336, 471);
            this.txtboxAlinacakUrunMiktari.Name = "txtboxAlinacakUrunMiktari";
            this.txtboxAlinacakUrunMiktari.Size = new System.Drawing.Size(175, 30);
            this.txtboxAlinacakUrunMiktari.TabIndex = 33;
            // 
            // cmbAlinacakUrunAdi
            // 
            this.cmbAlinacakUrunAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbAlinacakUrunAdi.DataSource = this.ıtemBindingSource;
            this.cmbAlinacakUrunAdi.DisplayMember = "ItemName";
            this.cmbAlinacakUrunAdi.FormattingEnabled = true;
            this.cmbAlinacakUrunAdi.Location = new System.Drawing.Point(336, 423);
            this.cmbAlinacakUrunAdi.Name = "cmbAlinacakUrunAdi";
            this.cmbAlinacakUrunAdi.Size = new System.Drawing.Size(175, 31);
            this.cmbAlinacakUrunAdi.TabIndex = 32;
            this.cmbAlinacakUrunAdi.ValueMember = "ItemID";
            // 
            // lblAlinacakUrunMiktari
            // 
            this.lblAlinacakUrunMiktari.AutoSize = true;
            this.lblAlinacakUrunMiktari.BackColor = System.Drawing.Color.Transparent;
            this.lblAlinacakUrunMiktari.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlinacakUrunMiktari.Location = new System.Drawing.Point(19, 470);
            this.lblAlinacakUrunMiktari.Name = "lblAlinacakUrunMiktari";
            this.lblAlinacakUrunMiktari.Size = new System.Drawing.Size(139, 23);
            this.lblAlinacakUrunMiktari.TabIndex = 31;
            this.lblAlinacakUrunMiktari.Text = "Ürün Miktarı : ";
            // 
            // lblAlinacakUrun
            // 
            this.lblAlinacakUrun.AutoSize = true;
            this.lblAlinacakUrun.BackColor = System.Drawing.Color.Transparent;
            this.lblAlinacakUrun.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlinacakUrun.Location = new System.Drawing.Point(19, 424);
            this.lblAlinacakUrun.Name = "lblAlinacakUrun";
            this.lblAlinacakUrun.Size = new System.Drawing.Size(149, 23);
            this.lblAlinacakUrun.TabIndex = 30;
            this.lblAlinacakUrun.Text = "Alınacak Ürün : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "SATIŞTAKİ ÜRÜNLER";
            // 
            // dataGridViewSatistakiUrunler
            // 
            this.dataGridViewSatistakiUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSatistakiUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSatistakiUrunler.Location = new System.Drawing.Point(12, 54);
            this.dataGridViewSatistakiUrunler.Name = "dataGridViewSatistakiUrunler";
            this.dataGridViewSatistakiUrunler.RowHeadersWidth = 51;
            this.dataGridViewSatistakiUrunler.RowTemplate.Height = 24;
            this.dataGridViewSatistakiUrunler.Size = new System.Drawing.Size(1041, 333);
            this.dataGridViewSatistakiUrunler.TabIndex = 28;
            // 
            // btnCikisA
            // 
            this.btnCikisA.BackgroundImage = global::BorsaUygulamasi.Properties.Resources.cikis_ikon;
            this.btnCikisA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikisA.Location = new System.Drawing.Point(984, 489);
            this.btnCikisA.Name = "btnCikisA";
            this.btnCikisA.Size = new System.Drawing.Size(69, 55);
            this.btnCikisA.TabIndex = 35;
            this.btnCikisA.UseVisualStyleBackColor = true;
            this.btnCikisA.Click += new System.EventHandler(this.btnCikisA_Click);
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // KullaniciFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1116, 623);
            this.Controls.Add(this.tabControlKullanici);
            this.Name = "KullaniciFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Sayfası";
            this.Load += new System.EventHandler(this.KullaniciFormu_Load);
            this.tabControlKullanici.ResumeLayout(false);
            this.tabPageBilgiler.ResumeLayout(false);
            this.tabPageBilgiler.PerformLayout();
            this.tabPageBakiye.ResumeLayout(false);
            this.tabPageBakiye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParaHareketleri)).EndInit();
            this.tabPageUrunler.ResumeLayout(false);
            this.tabPageUrunler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıtemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planlamaOyunuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunHareketleri)).EndInit();
            this.tabPageAlisveris.ResumeLayout(false);
            this.tabPageAlisveris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatistakiUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlKullanici;
        private System.Windows.Forms.TabPage tabPageBilgiler;
        private System.Windows.Forms.TabPage tabPageBakiye;
        private System.Windows.Forms.DataGridView dataGridViewParaHareketleri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPageUrunler;
        private System.Windows.Forms.TabPage tabPageAlisveris;
        private System.Windows.Forms.Button btnCikisB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblKalanPara;
        private System.Windows.Forms.Button btnParaEkle;
        private System.Windows.Forms.TextBox txtboxParaMiktari;
        private System.Windows.Forms.Label lblParaMiktari;
        private System.Windows.Forms.Button btnCikisU;
        private System.Windows.Forms.TextBox txtboxBirimFiyat;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Label lblUrunMiktar;
        private System.Windows.Forms.TextBox txtboxUrunMiktari;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.ComboBox cmbEklenecekUrunAdi;
        private System.Windows.Forms.DataGridView dataGridViewUrunHareketleri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxAlinacakBirimFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCikisA;
        private System.Windows.Forms.Button btnUrunuAl;
        private System.Windows.Forms.TextBox txtboxAlinacakUrunMiktari;
        private System.Windows.Forms.ComboBox cmbAlinacakUrunAdi;
        private System.Windows.Forms.Label lblAlinacakUrunMiktari;
        private System.Windows.Forms.Label lblAlinacakUrun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewSatistakiUrunler;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.ComboBox cmbParaBirimi;
        private System.Windows.Forms.Label lblParaBirimi;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKAdi;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txbAdres;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbTelNo;
        private System.Windows.Forms.TextBox txbTcNo;
        private System.Windows.Forms.TextBox txbSoyad;
        private System.Windows.Forms.TextBox txbAd;
        private System.Windows.Forms.TextBox txbSifre;
        private System.Windows.Forms.TextBox txbKAdi;
        private System.Windows.Forms.TextBox tbxYetki;
        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.Button btnCikisKB;
        private System.Windows.Forms.Label lblBakiyeDeger;
        private System.Windows.Forms.Label lblKalanParaDeger;
        private PlanlamaOyunuDataSet planlamaOyunuDataSet;
        private System.Windows.Forms.BindingSource ıtemBindingSource;
        private PlanlamaOyunuDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.Button btnRaporAl;
        private System.Windows.Forms.Button btnUrunRapor;
    }
}