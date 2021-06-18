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
using System.Xml;

namespace BorsaUygulamasi
{
    public partial class KullaniciFormu : Form
    {
        SqlConnection connection = GirisFormu.connection;
        string idno = GirisFormu.id;
        //string moneyid = AdminFormu.money_id;

        public KullaniciFormu()
        {
            InitializeComponent();
        }

        void BilgileriGetir()
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

        /*void ParaBilgileriniGetir()
        {
            connection.Close();
            connection.Open();
            SqlCommand mcommand = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("select MoneyID as [ID NO], UserID as [KULLANICI ID NO], MoneyAmount as [MİKTAR - TL]  from Money where convert(char,UserID) like '%" + idno + "%' ",connection);
            DataTable moneytable = new DataTable();
            da.Fill(moneytable);
            dataGridViewParaHareketleri.DataSource = moneytable;
            connection.Close();
        }*/

        double Exchange(double donusen_para)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            string USD = xmldoc.SelectSingleNode("Tarih_Date /Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            string EUR = xmldoc.SelectSingleNode("Tarih_Date /Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            string GBP = xmldoc.SelectSingleNode("Tarih_Date /Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
            string currency_unit=cmbParaBirimi.SelectedItem.ToString();
            //string usd = String.Format("{0:0.00}", Math.Round(Convert.ToDouble(USD), 2));


            if (currency_unit == "USD")
            {
                 donusen_para = Convert.ToDouble(txtboxParaMiktari.Text) * Convert.ToDouble(USD);
            }
            else if (currency_unit == "EUR")
            {
                donusen_para = Convert.ToDouble(txtboxParaMiktari.Text) * Convert.ToDouble(EUR);
            }
            else if (currency_unit == "GBP")
            {
                donusen_para = Convert.ToDouble(txtboxParaMiktari.Text) * Convert.ToDouble(GBP);
            }
            return donusen_para;
        }

        /*public bool OnaylananParayiEkle() 
        {
            connection.Close();
            connection.Open();
            SqlCommand onaykomutu2 = new SqlCommand("insert into Money (UserID,MoneyAmount) select UserID,MoneyAmountApproval from MoneyApproval where MoneyApproval.MoneyApprovalStatus='onaylandı'", connection);
            onaykomutu2.ExecuteNonQuery();
            connection.Close();
            return true;
        }*/
       
        public void KullanicininParasiniGetir()
        {
           // if (OnaylananParayiEkle())
            //{
                connection.Close();
                connection.Open();
                SqlCommand command2 = new SqlCommand("select * from Money where convert(char,UserID) like '%" + idno + "%' ", connection);
                SqlDataAdapter ad2 = new SqlDataAdapter(command2);
                DataTable dt2 = new DataTable();
                ad2.Fill(dt2);
                dataGridViewParaHareketleri.DataSource = dt2;
                connection.Close();
           // }
           // else
            //    MessageBox.Show("Sistemde çıkan bir hata nedeniyle para ekleme talebiniz onaylanamadı..");
            double Para_miktari = 0;
            for (int i = 0; i < dataGridViewParaHareketleri.Rows.Count - 1; i++)
                Para_miktari = Para_miktari + double.Parse(dataGridViewParaHareketleri.Rows[i].Cells[2].Value.ToString());
            lblBakiyeDeger.Text = Para_miktari.ToString();
        }

        public void KullanicininUrunleriniGetir()
        {
                connection.Close();
                connection.Open();
                SqlCommand command3 = new SqlCommand("Select * from UserItems where convert(char,UserID) like '%" + idno + "%' ", connection);
                SqlDataAdapter ad = new SqlDataAdapter(command3);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridViewUrunHareketleri.DataSource = dt;
                connection.Close();
        }

        /*private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/


        public void TumUrunleriGetir()
        {
            connection.Close();
            connection.Open();
            SqlCommand command3 = new SqlCommand("Select * from UserItems where convert(char,UserID) not like '%" + idno + "%' order by ItemUnitPrice", connection);
            SqlDataAdapter ad3 = new SqlDataAdapter(command3);
            DataTable dt3 = new DataTable();
            ad3.Fill(dt3);
            dataGridViewSatistakiUrunler.DataSource = dt3;
            connection.Close();
        }
        void BilgileriTopla()
        {
           

        }
        int paraAlacakKisiID=0, paraVerecekKisiID=0;
       
        public void AlimYap()
        {
            int alinacak_urun = Convert.ToInt32(cmbAlinacakUrunAdi.SelectedValue.ToString());
            double urun_miktari = Convert.ToDouble(txtboxAlinacakUrunMiktari.Text);
            double istenen_birim_fiyat = Convert.ToDouble(txtboxAlinacakBirimFiyat.Text);
            connection.Close();
            connection.Open();
            string sqlkodu = "select * from UserItems where (ItemID=@itemid) and (ItemAmount=@itemamount) and (ItemUnitPrice=@itemunitprice) ";
            SqlCommand islem = new SqlCommand(sqlkodu, connection);
            SqlDataReader oku;
            islem.Parameters.AddWithValue("@itemid", alinacak_urun);
            islem.Parameters.AddWithValue("@itemamount", urun_miktari);
            islem.Parameters.AddWithValue("@itemunitprice", istenen_birim_fiyat);
            oku = islem.ExecuteReader();
            if (oku.Read())
            {
                paraAlacakKisiID = Convert.ToInt16(oku[1]);
                if (Convert.ToInt32(oku[4]) > istenen_birim_fiyat)
                {
                    MessageBox.Show("İstediğiniz birim fiyatta bir ürün yoktur!", "Hata");
                }
                else
                {
                    //sqlkodu = "update UserItems set [UserID]=@userid,[ItemAmount]=@itemamount where UserItemID=@useritemid";
                    sqlkodu = "update UserItems set [UserID]=@userid where UserItemID=@useritemid";
                    islem = new SqlCommand(sqlkodu, connection);
                    paraVerecekKisiID = Convert.ToInt32(idno);
                    islem.Parameters.AddWithValue("@userid", Convert.ToInt32(idno));
                    //islem.Parameters.AddWithValue("@itemamount", 0);
                    islem.Parameters.AddWithValue("@useritemid", oku[0]);
                    //islem.ExecuteNonQuery();
                }
            }
            connection.Close();
            paraEkleme();
            paraCikarma();
        }
        private void paraEkleme()
        {
            int alinacak_urun = Convert.ToInt32(cmbAlinacakUrunAdi.SelectedValue.ToString());
            double urun_miktari = Convert.ToDouble(txtboxAlinacakUrunMiktari.Text);
            double istenen_birim_fiyat = Convert.ToDouble(txtboxAlinacakBirimFiyat.Text);
            connection.Open();
            string sqlkodu = "select * from Money where UserID=@userid";
            SqlCommand islem;
            islem = new SqlCommand(sqlkodu, connection);
            SqlDataReader oku;
            islem.Parameters.AddWithValue("@userid", paraAlacakKisiID);
            oku = islem.ExecuteReader();
            if (oku.Read())
            {
                paraAlacakKisiID = Convert.ToInt16(oku[1]);
                //sqlkodu = "update Money set [MoneyAmount]=@moneyamount where UserID=@userid";
                sqlkodu = "insert into Money (MoneyID,UserID,MoneyAmount) values (@moneyid,@id,@money_amount)";
                islem = new SqlCommand(sqlkodu, connection);
                islem.Parameters.AddWithValue("@moneyid",Convert.ToInt32(oku[0]));
                islem.Parameters.AddWithValue("@userid", paraAlacakKisiID);
                islem.Parameters.AddWithValue("@moneyamount",(istenen_birim_fiyat * urun_miktari));
                //islem.ExecuteNonQuery();
            }
            connection.Close();
        }
        private void paraCikarma()
        {
            int alinacak_urun = Convert.ToInt32(cmbAlinacakUrunAdi.SelectedValue.ToString());
            double urun_miktari = Convert.ToDouble(txtboxAlinacakUrunMiktari.Text);
            double istenen_birim_fiyat = Convert.ToDouble(txtboxAlinacakBirimFiyat.Text);
            connection.Open();
            string sqlkodu = "select * from Money where UserID=@userid";
            SqlCommand islem;
            islem = new SqlCommand(sqlkodu, connection);
            SqlDataReader oku;
            islem.Parameters.AddWithValue("@userid", paraVerecekKisiID);
            oku = islem.ExecuteReader();
            if (oku.Read())
            {
                paraAlacakKisiID = Convert.ToInt16(oku[1]);
                //sqlkodu = "update Money set [MoneyAmount]=@moneyamount where UserID=@userid";
                sqlkodu = "delete from Money where MoneyID=@moneyid and UserID=@userid ";
                islem = new SqlCommand(sqlkodu, connection);
                islem.Parameters.AddWithValue("@moneyid", Convert.ToDouble(oku[0]));
                islem.Parameters.AddWithValue("@userid", Convert.ToInt32(idno));
                //islem.ExecuteNonQuery();
            }
            connection.Close();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                connection.Open();                                                                                                                                                                                                                                                                                                                                      //where convert(char,UserID) like '%" + idno + "%' "
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

        private void tabPageBilgiler_Click(object sender, EventArgs e)
        {
            
        }

        private void KullaniciFormu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'planlamaOyunuDataSet.Item' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.itemTableAdapter.Fill(this.planlamaOyunuDataSet.Item);
            BilgileriGetir();
            KullanicininParasiniGetir();
            KullanicininUrunleriniGetir();
            TumUrunleriGetir();
            
        }
        


        private void btnParaEkle_Click(object sender, EventArgs e) 
        {
            string idno = GirisFormu.id;
            connection.Open();
            string parakayit = "insert into MoneyApproval (UserID,MoneyAmountApproval,MoneyApprovalStatus) values (@id,@money_amount,@money_approval_status)";
            SqlCommand addmcommand = new SqlCommand(parakayit, connection);
            addmcommand.Parameters.AddWithValue("@id", Convert.ToInt32(idno));
            addmcommand.Parameters.AddWithValue("@money_amount", Exchange(Convert.ToDouble(txtboxParaMiktari.Text)));
            addmcommand.Parameters.AddWithValue("@money_approval_status", "onaylanmadı");
            addmcommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Para ekleme talebiniz alındı..");
            //MessageBox.Show(moneyid);
        }

        private void btnCikisKB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCikisB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCikisU_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCikisA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            string idno = GirisFormu.id;
            connection.Open();
            string urunkayit = "insert into UserItemsApproval (UserID,ItemID,ItemAmountApproval,ItemUnitPriceApproval,ItemApprovalStatus) values(@id,@item_id,@item_amount,@item_unit_price,@item_approval_status)";
            SqlCommand addicommand = new SqlCommand(urunkayit, connection);
            addicommand.Parameters.AddWithValue("@id", Convert.ToInt32(idno));
            addicommand.Parameters.AddWithValue("@item_id", Convert.ToInt32(cmbEklenecekUrunAdi.SelectedValue.ToString()));
            addicommand.Parameters.AddWithValue("@item_amount", Convert.ToDouble(txtboxUrunMiktari.Text));
            addicommand.Parameters.AddWithValue("@item_unit_price", Convert.ToDouble(txtboxBirimFiyat.Text));
            addicommand.Parameters.AddWithValue("@item_approval_status", "onaylanmadı");
            addicommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ürün ekleme talebiniz alındı..");
        }

        private void btnUrunuAl_Click(object sender, EventArgs e)
        {
            AlimYap();
        }
    }
}
