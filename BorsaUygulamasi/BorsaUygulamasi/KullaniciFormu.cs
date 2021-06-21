using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    //Veritabanı bağlantısı için gerekli kütüphane eklendi
using System.Xml;               //Web sitesinden veri çekmek için xml kütüphanesini kullandık
using Microsoft.Office.Interop.Excel;   //Verileri excel e aktarmak için gereken kütüphane tanımlandı.
using excel = Microsoft.Office.Interop.Excel;

namespace BorsaUygulamasi
{
    public partial class KullaniciFormu : Form
    {
        SqlConnection connection = GirisFormu.connection;   //Bağlantımızı giriş formundan alıyoruz.
        string idno = GirisFormu.id;                        //id mizi giriş formundan çekiyoruz.
        DateTime simdi = DateTime.Now;                      //İşlem yapılan tarih ve saati belirlemek için DateTime kullandık.
       
        public KullaniciFormu()
        {
            InitializeComponent();
        }

        void BilgileriGetir()   //Bu blokta veritabanından giriş yapan kullanıcının id sine göre kullanıcı bilgileri çekilerek textbox lara aktarılmıştır. 
        {
            connection.Close();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Users where convert(char,UserID) like '%" + idno + "%' ", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txbKAdi.Text = Cryptology.Decryption(read["UserName"].ToString().TrimEnd(), 2);
                txbSifre.Text = Cryptology.Decryption(read["UserPassword"].ToString().TrimEnd(),2);
                txbAd.Text = read["UserGivenName"].ToString().TrimEnd();
                txbSoyad.Text = read["UserSurname"].ToString().TrimEnd();
                txbTcNo.Text = read["UserTcNumber"].ToString().TrimEnd();
                txbTelNo.Text = read["UserPhoneNumber"].ToString().TrimEnd();
                txbEmail.Text= read["UserEmail"].ToString().TrimEnd();
                txbAdres.Text = read["UserAdress"].ToString().TrimEnd();
            }
            connection.Close();
        }

        double Exchange(double donusen_para) //Bu blokta kur dönüşümü yapılmaktadır.
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";  //Fiyatları çekeceğimiz web adresi tanımlandı.
            var xmldoc = new XmlDocument();     //Bilgiler xml formatta çekilmiştir.
            xmldoc.Load(bugun);                 //Değerler işlem gününe bağlı olarak değişmektedir.
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            string USD = xmldoc.SelectSingleNode("Tarih_Date /Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            string EUR = xmldoc.SelectSingleNode("Tarih_Date /Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            string GBP = xmldoc.SelectSingleNode("Tarih_Date /Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
            string currency_unit=cmbParaBirimi.SelectedItem.ToString();
            USD = USD.Replace(".", ",");    
            EUR = EUR.Replace(".", ",");
            GBP = GBP.Replace(".", ",");
           
            if (currency_unit == "USD") //String olarak çekilen değer double a dönüştürülmüştür.
            {
                bool tryParse = Double.TryParse(USD,out donusen_para);
                if(tryParse)
                    donusen_para = Convert.ToDouble(txtboxParaMiktari.Text) * donusen_para;
                MessageBox.Show("Dolar yatırdınız..Yatırdığınız miktar "+USD+" üzerinden TL ye çevrilmiştir.");
            }
            else if (currency_unit == "EUR") //String olarak çekilen değer double a dönüştürülmüştür.
            {
                double euro = Double.Parse(EUR);
                donusen_para = Double.Parse(txtboxParaMiktari.Text) * euro;
                MessageBox.Show("Euro yatırdınız..Yatırdığınız miktar " + EUR + " üzerinden TL ye çevrilmiştir.");
            }
            else if (currency_unit == "GBP")  //String olarak çekilen değer double a dönüştürülmüştür.
            {
                donusen_para = Convert.ToDouble(txtboxParaMiktari.Text) * Convert.ToDouble(GBP);
                MessageBox.Show("Sterlin yatırdınız..Yatırdığınız miktar " + GBP + " üzerinden TL ye çevrilmiştir.");
            }
            return donusen_para;
        }

        public void KullanicininParasiniGetir() //Bu blok id ye göre onaylanmış para tablosundan yatırdığı tüm işlemleri datagridview de gösterir.
        {
            connection.Close();
            connection.Open();
            SqlCommand command2 = new SqlCommand("select MoneyID as [ID NO], UserID as [KULLANICI ID NO], MoneyAmount as [MİKTAR - TL], MoneyDate as [İŞLEM ZAMANI] from Money where convert(char,UserID) like '%" + idno + "%' ", connection);
            SqlDataAdapter ad2 = new SqlDataAdapter(command2);
            System.Data.DataTable dt2 = new System.Data.DataTable();
            ad2.Fill(dt2);
            dataGridViewParaHareketleri.DataSource = dt2;
            connection.Close();
            BakiyeGoruntule();
        }
        void BakiyeGoruntule()  //Bu blok datagridview üzerinde görüntülenen para girişlerini toplayarak bakiyeyi oluşturur.
        {
            double Para_miktari = 0;
            for (int i = 0; i < dataGridViewParaHareketleri.Rows.Count - 1; i++)
                Para_miktari = Para_miktari + double.Parse(dataGridViewParaHareketleri.Rows[i].Cells[2].Value.ToString());

            lblBakiyeDeger.Text = String.Format("{0:0.00}", Para_miktari);
        }
        public void KullanicininUrunleriniGetir()   //Bu blok id ye göre kişinin onaylanan ürün tablosundaki ürünlerini gösterir.
        {
                connection.Close();
                connection.Open();
                SqlCommand command3 = new SqlCommand("Select UserItemID as[ID NO],UserID as [KULLANICI ID NO], ItemID as [ÜRÜN ID], ItemAmount as [ÜRÜN MİKTARI], ItemUnitPrice as [BİRİM FİYAT], ItemDate as [İŞLEM ZAMANI] from UserItems where convert(char,UserID) like '%" + idno + "%' ", connection);
                SqlDataAdapter ad = new SqlDataAdapter(command3);
                System.Data.DataTable dt = new System.Data.DataTable();
                ad.Fill(dt);
                dataGridViewUrunHareketleri.DataSource = dt;
                connection.Close();
        }

        public void SatistakiUrunleriGetir()    //Bu blok kişiye ait olmayan satıştaki diğer tüm onaylı ürünleri datagridview de gösterir.
        {
            connection.Close();
            connection.Open();
            SqlCommand command3 = new SqlCommand("Select  UserItemID as[ID NO],UserID as [KULLANICI ID NO], ItemID as [ÜRÜN ID], ItemAmount as [ÜRÜN MİKTARI], ItemUnitPrice as [BİRİM FİYAT] from UserItems where convert(char,UserID) not like '%" + idno + "%' order by ItemUnitPrice", connection);
            SqlDataAdapter ad3 = new SqlDataAdapter(command3);
            System.Data.DataTable dt3 = new System.Data.DataTable();
            ad3.Fill(dt3);
            dataGridViewSatistakiUrunler.DataSource = dt3;
            connection.Close();
        }

        int paraAlacakKisiID;   //Satın alımı yapıldığında kime paranın gidileceğini belirlemek için tanımlanan değişken
        public void AlimYap()
        {
            int alinacak_urun = Convert.ToInt32(cmbAlinacakUrunAdi.SelectedValue.ToString());   //Seçili değerleri değişkenlerimize atadık.
            double urun_miktari = Convert.ToDouble(txtboxAlinacakUrunMiktari.Text);
            double istenen_birim_fiyat = Convert.ToDouble(txtboxAlinacakBirimFiyat.Text);
            connection.Close();     //Bağlantıyı açıp sorgularımızı yazdık.
            connection.Open();
            //Onaylı ürün tablosundan bilgiler çekildi
            string sqlkodu = "select * from UserItems where (ItemID=@itemid) and (ItemAmount=@itemamount) and (ItemUnitPrice=@itemunitprice) ";
            SqlCommand islem = new SqlCommand(sqlkodu, connection);
            SqlDataReader oku;
            oku = islem.ExecuteReader();
            islem.Parameters.AddWithValue("@itemid", Convert.ToInt32(dataGridViewSatistakiUrunler.CurrentRow.Cells[0].Value));
            islem.Parameters.AddWithValue("@itemamount", Convert.ToDouble(dataGridViewSatistakiUrunler.CurrentRow.Cells[3].Value));
            islem.Parameters.AddWithValue("@itemunitprice", Convert.ToDouble(dataGridViewSatistakiUrunler.CurrentRow.Cells[4].Value));
            //Onay tablosundaki bilgiler de okunuyor.
            string sqlkodu2 = "select * from UserItemsApproval  where (ItemID=@itemid) and (ItemAmountApproval=@itemamountapp) and (ItemUnitPriceApproval=@itemunitpriceapp) ";
            SqlCommand islem2 = new SqlCommand(sqlkodu2, connection);
            SqlDataReader oku2;
            oku2 = islem2.ExecuteReader();
            islem2.Parameters.AddWithValue("@itemid", Convert.ToInt32(dataGridViewSatistakiUrunler.CurrentRow.Cells[0].Value));
            islem2.Parameters.AddWithValue("@itemamountapp", Convert.ToDouble(dataGridViewSatistakiUrunler.CurrentRow.Cells[3].Value));
            islem2.Parameters.AddWithValue("@itemunitpriceapp", Convert.ToDouble(dataGridViewSatistakiUrunler.CurrentRow.Cells[4].Value));

            if (Convert.ToInt32(dataGridViewSatistakiUrunler.CurrentRow.Cells[1].Value) != istenen_birim_fiyat) //Satın almak istediğimiz fiyatın karşılaştırılması
            {
                MessageBox.Show("İstediğiniz birim fiyatta bir ürün yoktur!", "Hata");
            }
            else if (Convert.ToInt32(dataGridViewSatistakiUrunler.CurrentRow.Cells[1].Value) < urun_miktari)    //Ürün miktarının karşılaştırılması
            {
                MessageBox.Show("Yeterli miktarda ürün bulunmamaktadır!", "Hata");
            }
            else
            {
                if (oku.Read()&& oku2.Read())   //BURADA KONTROLLER VE FDENEMELER YAPILDI
                {
                    paraAlacakKisiID = Convert.ToInt32(dataGridViewSatistakiUrunler.CurrentRow.Cells[1].Value);
                    //var useritemid=oku[0];
                    int useritemid = Convert.ToInt32(dataGridViewSatistakiUrunler.CurrentRow.Cells[0].Value);
                    //MessageBox.Show(useritemid.ToString());
                    //sqlkodu = "update UserItems set [UserID]=@userid,[ItemAmount]=@itemamount where UserItemID=@useritemid";
                    //sqlkodu = "update UserItems set [UserID]=@userid where UserItemID=@useritemid";
                    sqlkodu = "delete from UserItems where UserID=@userid and UserItemID=@useritemid";
                    islem = new SqlCommand(sqlkodu, connection);
                    sqlkodu2 = "delete from UserItemsApproval where UserID=@userid and UserItemID=@useritemid";
                    islem2 = new SqlCommand(sqlkodu2, connection);
                    islem2.Parameters.AddWithValue("@userid", paraAlacakKisiID);
                    islem2.Parameters.AddWithValue("@useritemid", useritemid);
                    //paraVerecekKisiID = Convert.ToInt32(idno);
                    islem.Parameters.AddWithValue("@userid", paraAlacakKisiID);
                    //islem.Parameters.AddWithValue("@userid", Convert.ToInt32(idno));
                    //islem.Parameters.AddWithValue("@itemamount", 0);
                    islem.Parameters.AddWithValue("@useritemid", useritemid);
                    //islem.ExecuteNonQuery();
                }
                connection.Close();
                //MessageBox.Show(paraAlacakKisiID.ToString());
                paraCikarma();
                paraEkleme();
            }
        }
        private void paraEkleme() //Ürünü satan kişinin bakiyesine ekleme ve tablosuna para girdisi görüntüleme 
        {
            double urun_miktari = Convert.ToDouble(txtboxAlinacakUrunMiktari.Text); 
            double istenen_birim_fiyat = Convert.ToDouble(txtboxAlinacakBirimFiyat.Text);

            double kesinti = (istenen_birim_fiyat * urun_miktari) * (0.01); //Muhasebe kesintisi toplam ödenecek tutarın %1 i olacak şekilde ayarlandı.
            connection.Open();
            string sqlkodu = "select * from Money where UserID=@userid";
            SqlCommand islem;
            islem = new SqlCommand(sqlkodu, connection);
            SqlDataReader oku;
            islem.Parameters.AddWithValue("@userid", paraAlacakKisiID);
            oku = islem.ExecuteReader();
            if (oku.Read())             //BURADA KONTROLLER VE FDENEMELER YAPILDI
            {
                Random rastgele = new Random();         
                int moneyid = rastgele.Next(100, 300);
                //var moneyid = oku[0];
                //paraAlacakKisiID = Convert.ToInt16(oku[1]);
                //sqlkodu = "update Money set [MoneyAmount]=@moneyamount where UserID=@userid";
                sqlkodu = "insert into Money (MoneyID,UserID,MoneyAmount) values (@moneyid,@id,@money_amount)";
                //sqlkodu = "update Money set [MoneyID]=@moneyid,[UserID]=@id,[MoneyAmount]=@money_amount";
                islem = new SqlCommand(sqlkodu, connection);
                islem.Parameters.AddWithValue("@moneyid",moneyid);
                islem.Parameters.AddWithValue("@userid", paraAlacakKisiID);
                islem.Parameters.AddWithValue("@moneyamount",((istenen_birim_fiyat * urun_miktari)-kesinti));
                //islem.ExecuteNonQuery();
            }
            connection.Close();
        }
        private void paraCikarma()  //BURADA KONTROLLER VE FDENEMELER YAPILDI
        {
            double urun_miktari = Convert.ToDouble(txtboxAlinacakUrunMiktari.Text);
            double istenen_birim_fiyat = Convert.ToDouble(txtboxAlinacakBirimFiyat.Text);

            connection.Open();
            string sqlkodu = "select * from Money where UserID=@userid";
            SqlCommand islem;
            islem = new SqlCommand(sqlkodu, connection);
            SqlDataReader oku;
            islem.Parameters.AddWithValue("@userid", Convert.ToInt32(idno));
            oku = islem.ExecuteReader();
            if (oku.Read())
            {
                //var moneyid = oku[0];
                //paraAlacakKisiID = Convert.ToInt16(oku[1]);
                //sqlkodu = "update Money set [MoneyAmount]=@moneyamount where UserID=@userid";
                //sqlkodu = "delete from Money where MoneyID=@moneyid and UserID=@userid ";
                //islem = new SqlCommand(sqlkodu, connection);
                //islem.Parameters.AddWithValue("@moneyid", moneyid);
                //islem.Parameters.AddWithValue("@userid", Convert.ToInt32(idno));
                //islem.ExecuteNonQuery();

                double kalanpara = Convert.ToDouble(lblBakiyeDeger.Text) - (istenen_birim_fiyat * urun_miktari);    //Kişinin bakiyesinden ödenecek tutar çıkarıldı.
                lblBakiyeDeger.Text = kalanpara.ToString();
                MessageBox.Show("Ürün alındı..Kalan paranız " + lblBakiyeDeger);
            }
            connection.Close();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)  //Burada kişi bilgilerini güncelleme işlemi yapılmaktadır.
        {
            try
            {
                connection.Close();
                connection.Open();                                                                                                                                                                                                                                                                                                                                      
                SqlCommand updatecommand = new SqlCommand("update Users set UserName='" + Cryptology.Encryption(txbKAdi.Text,2) + "',UserPassword='" + Cryptology.Encryption(txbSifre.Text ,2)+ "',UserGivenName='" + txbAd.Text + "',UserSurname='" + txbSoyad.Text + "',UserTcNumber='" + txbTcNo.Text + "',UserPhoneNumber='" + txbTelNo.Text + "',UserEmail='" + txbEmail.Text + "',UserAdress='" + txbAdres.Text + "' where convert(char, UserID) like '%" + idno + "%' ", connection);
                updatecommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Bilgileriniz başarıyla güncellendi !");
                BilgileriGetir();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantıda bir hata oluştu !");
            }    
        }
        private void btnParaEkle_Click(object sender, EventArgs e) //Burada para ekleme işlemi yapılmakta ve eklenecek bilgiler onay tablosuna gönderilmektedir.
        {
            string idno = GirisFormu.id;
            connection.Open();
            string parakayit = "insert into MoneyApproval (UserID,MoneyAmountApproval,MoneyApprovalStatus,MoneyDateApproval) values (@id,@money_amount,@money_approval_status,@date)";
            SqlCommand addmcommand = new SqlCommand(parakayit, connection);
            addmcommand.Parameters.AddWithValue("@id", Convert.ToInt32(idno));
            addmcommand.Parameters.AddWithValue("@money_amount", Exchange(Convert.ToDouble(txtboxParaMiktari.Text)));
            addmcommand.Parameters.AddWithValue("@money_approval_status", "onaylanmadı");
            addmcommand.Parameters.AddWithValue("@date",simdi);
            addmcommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Para ekleme talebiniz alındı..");
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)  //Burada ürün ekleme işlemi yapılmakta ve eklenecek bilgiler onay tablosuna gönderilmektedir.
        {
            string idno = GirisFormu.id;
            connection.Open();
            string urunkayit = "insert into UserItemsApproval (UserID,ItemID,ItemAmountApproval,ItemUnitPriceApproval,ItemApprovalStatus,ItemDateApproval) values(@id,@item_id,@item_amount,@item_unit_price,@item_approval_status,@date)";
            SqlCommand addicommand = new SqlCommand(urunkayit, connection);
            addicommand.Parameters.AddWithValue("@id", Convert.ToInt32(idno));
            addicommand.Parameters.AddWithValue("@item_id", Convert.ToInt32(cmbEklenecekUrunAdi.SelectedValue.ToString()));
            addicommand.Parameters.AddWithValue("@item_amount", Convert.ToDouble(txtboxUrunMiktari.Text));
            addicommand.Parameters.AddWithValue("@item_unit_price", Convert.ToDouble(txtboxBirimFiyat.Text));
            addicommand.Parameters.AddWithValue("@item_approval_status", "onaylanmadı");
            addicommand.Parameters.AddWithValue("@date", simdi);
            addicommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ürün ekleme talebiniz alındı..");
        }

        private void btnRaporAl_Click(object sender, EventArgs e)   //Burada para hareketlerini excel e aktarma işlemi yapılmıştır.
        {
            excel.Application app = new excel.Application();        //excel sınıfından nesne üretildi.
            app.Visible = true;
            Workbook para = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sayfa = (Worksheet)para.Sheets[1];            //excel in hangi sayfasına aktarım yapılacağı belirtildi.
            for(int i=0;i<dataGridViewParaHareketleri.Columns.Count;i++)        //Datagridview deki sütunlar kadar yer ayrıldı ve başlıklar eklendi.
            {
                Range alan = (Range)sayfa.Cells[1, 1];
                alan.Cells[1, i + 1] = dataGridViewParaHareketleri.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridViewParaHareketleri.Columns.Count; i++) //Sütun ve satır okumaları yapılıp excel de ayrılan alana eklendi. 
            {
                for (int j = 0; j < dataGridViewParaHareketleri.Rows.Count; j++)
                {
                    Range alan2 = (Range)sayfa.Cells[j + 1, i + 1];
                    alan2.Cells[2, 1] = dataGridViewParaHareketleri[i, j].Value;
                }
            }
        }

        private void btnUrunRapor_Click(object sender, EventArgs e)     //Burada ürün hareketlerini excel e aktarma işlemi yapılmıştır.
        {
            excel.Application app = new excel.Application();
            app.Visible = true;
            Workbook urun = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sayfa = (Worksheet)urun.Sheets[1];
            for (int i = 0; i < dataGridViewUrunHareketleri.Columns.Count; i++)
            {
                Range alan = (Range)sayfa.Cells[1, 1];
                alan.Cells[1, i + 1] = dataGridViewUrunHareketleri.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridViewUrunHareketleri.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridViewUrunHareketleri.Rows.Count; j++)
                {
                    Range alan2 = (Range)sayfa.Cells[j + 1, i + 1];
                    alan2.Cells[2, 1] = dataGridViewUrunHareketleri[i, j].Value;
                }
            }
        }

        private void btnUrunuAl_Click(object sender, EventArgs e)
        {
            AlimYap();  //Alim işlemi için tanımlanan fonksiyon çağırıldı.
        }


        private void KullaniciFormu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'planlamaOyunuDataSet.Item' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.itemTableAdapter.Fill(this.planlamaOyunuDataSet.Item);
            //BİLGİLER FORMDA GÖSTERİLMEKTEDİR:
            BilgileriGetir();
            KullanicininParasiniGetir();
            BakiyeGoruntule();
            KullanicininUrunleriniGetir();
            SatistakiUrunleriGetir();
        }

        //Programdan çıkış için
        private void btnCikisKB_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnCikisB_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnCikisU_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnCikisA_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
