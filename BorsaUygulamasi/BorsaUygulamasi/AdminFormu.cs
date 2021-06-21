using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;             //Veritabanı bağlantısı için gerekli kütüphane eklendi
using Microsoft.Office.Interop.Excel;        //Verileri excel e aktarmak için gereken kütüphane tanımlandı.
using excel = Microsoft.Office.Interop.Excel;

namespace BorsaUygulamasi
{
    public partial class AdminFormu : Form
    {
        SqlConnection connection = GirisFormu.connection;       //Bağlantımızı giriş formundan alıyoruz.
        string idno = GirisFormu.id;                            //id mizi giriş formundan çekiyoruz.
        DateTime simdi = DateTime.Now;                          //İşlem yapılan tarih ve saati belirlemek için DateTime kullandık.
        public AdminFormu()
        {
            InitializeComponent();
        }

        public void ParaOnayTablosunuGetir()    //Onay tablosundaki bilgiler datagridview e çekilmiştir.
        {
            connection.Close();
            connection.Open();
            SqlCommand command2 = new SqlCommand("select MoneyID as [ID NO], UserID as [KULLANICI ID NO], MoneyAmountApproval as [MİKTAR - TL], MoneyApprovalStatus as [ONAY DURUMU], MoneyDateApproval as [İŞLEM ZAMANI] from MoneyApproval", connection);
            SqlDataAdapter ad2 = new SqlDataAdapter(command2);
            System.Data.DataTable dt2 = new System.Data.DataTable();
            ad2.Fill(dt2);
            dataGridViewParaOnay.DataSource = dt2;
            connection.Close();
        }

        public void UrunOnayTablosunuGetir()         //Onay tablosundaki bilgiler datagridview e çekilmiştir.
        {
            connection.Close();
            connection.Open();
            SqlCommand command = new SqlCommand("select UserItemID as[ID NO],UserID as [KULLANICI ID NO], ItemID as [ÜRÜN ID], ItemAmountApproval as [ÜRÜN MİKTARI], ItemUnitPriceApproval as [BİRİM FİYAT], ItemApprovalStatus as [ONAY DURUMU], ItemDateApproval as [İŞLEM ZAMANI] from UserItemsApproval", connection);
            SqlDataAdapter ad = new SqlDataAdapter(command);
            System.Data.DataTable dt = new System.Data.DataTable();
            ad.Fill(dt);
            dataGridViewUrunOnay.DataSource = dt;
            connection.Close();
        }

        private void btnParaOnayla_Click(object sender, EventArgs e)    //Seçilen satırdaki bilgiler textbox ve combobox a çekilerek onaylama işlemine hazır hale gelir.Onaylanan bilgiler ana tablolara gider.
        {
            connection.Open();
            string sorgu2 = "update MoneyApproval set MoneyApprovalStatus=@money_approval_status, MoneyDateApproval=@date where MoneyID='" + Convert.ToInt32(txtboxIDParaOnay.Text) + "' ";
            SqlCommand komut2 = new SqlCommand(sorgu2, connection);
            komut2.Parameters.AddWithValue("@money_approval_status", cmbParaOnayDurumu.SelectedItem);
            komut2.Parameters.AddWithValue("@date", simdi);
            komut2.ExecuteNonQuery();
            SqlCommand onaykomutu2 = new SqlCommand("insert into Money (MoneyID,UserID,MoneyAmount,MoneyDate) select MoneyID,UserID,MoneyAmountApproval,MoneyDateApproval from MoneyApproval where MoneyApproval.MoneyApprovalStatus='onaylandı' and MoneyApproval.MoneyID=@moneyid", connection);
            onaykomutu2.Parameters.AddWithValue("@moneyid", dataGridViewParaOnay.SelectedCells[0].Value);
            onaykomutu2.ExecuteNonQuery();
            connection.Close();
            ParaOnayTablosunuGetir();
        }

        private void btnUrunOnayla_Click(object sender, EventArgs e)     //Onaylama işlemi zamanı tutulur. Onaylanan bilgiler ana tablolara gider.
        {
            connection.Open();
            string sorgu = "update UserItemsApproval set ItemApprovalStatus=@item_approval_status,ItemDateApproval=@date where UserItemID='" + Convert.ToInt32(txtboxIDUrunOnay.Text) + "'  ";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@item_approval_status", cmbUrunOnayDurumu.SelectedItem);
            komut.Parameters.AddWithValue("@date", simdi);
            komut.ExecuteNonQuery();
            SqlCommand onaykomutu3 = new SqlCommand("insert into UserItems (UserItemID,UserID,ItemID,ItemAmount,ItemUnitPrice,ItemDate) select UserItemID,UserID,ItemID,ItemAmountApproval,ItemUnitPriceApproval,ItemDateApproval from UserItemsApproval where UserItemsApproval.ItemApprovalStatus='onaylandı' and UserItemsApproval.UserItemID=@useritemid", connection);
            onaykomutu3.Parameters.AddWithValue("@useritemid", dataGridViewUrunOnay.SelectedCells[0].Value);
            onaykomutu3.ExecuteNonQuery();
            connection.Close();
            UrunOnayTablosunuGetir();
        }

        private void dataGridViewUrunOnay_CellClick(object sender, DataGridViewCellEventArgs e) //Seçilen satırdaki bilgiler textbox ve combobox a çekilerek onaylama işlemine hazır hale gelir.
        {
            txtboxIDUrunOnay.Text = dataGridViewUrunOnay.CurrentRow.Cells[0].Value.ToString();
            cmbUrunOnayDurumu.Text = dataGridViewUrunOnay.CurrentRow.Cells[5].Value.ToString();
        }

        private void dataGridViewParaOnay_CellClick(object sender, DataGridViewCellEventArgs e) //Seçilen satırdaki bilgiler textbox ve combobox a çekilerek onaylama işlemine hazır hale gelir.
        {
            txtboxIDParaOnay.Text = dataGridViewParaOnay.CurrentRow.Cells[0].Value.ToString();
            cmbParaOnayDurumu.Text = dataGridViewParaOnay.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUrunOnayRapor_Click(object sender, EventArgs e)         //Onay tablosundaki bilgiler excel e aktarılmıştır.
        {
            excel.Application app = new excel.Application();                    //excel sınıfından nesne üretildi.
            app.Visible = true;
            Workbook urun = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sayfa = (Worksheet)urun.Sheets[1];                        //excel in hangi sayfasına aktarım yapılacağı belirtildi.
            for (int i = 0; i < dataGridViewUrunOnay.Columns.Count; i++)
            {
                Range alan = (Range)sayfa.Cells[1, 1];                          //Datagridview deki sütunlar kadar yer ayrıldı ve başlıklar eklendi.
                alan.Cells[1, i + 1] = dataGridViewUrunOnay.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridViewUrunOnay.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridViewUrunOnay.Rows.Count; j++)
                {
                    Range alan2 = (Range)sayfa.Cells[j + 1, i + 1];             //Sütun ve satır okumaları yapılıp excel de ayrılan alana eklendi.
                    alan2.Cells[2, 1] = dataGridViewUrunOnay[i, j].Value;
                }
            }
        }

        private void btnParaOnayRapor_Click(object sender, EventArgs e)     //Onay tablosundaki bilgiler excel e aktarılmıştır.
        {
            excel.Application app = new excel.Application();
            app.Visible = true;
            Workbook urun = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sayfa = (Worksheet)urun.Sheets[1];
            for (int i = 0; i < dataGridViewParaOnay.Columns.Count; i++)
            {
                Range alan = (Range)sayfa.Cells[1, 1];
                alan.Cells[1, i + 1] = dataGridViewParaOnay.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridViewParaOnay.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridViewParaOnay.Rows.Count; j++)
                {
                    Range alan2 = (Range)sayfa.Cells[j + 1, i + 1];
                    alan2.Cells[2, 1] = dataGridViewParaOnay[i, j].Value;
                }
            }
        }

        private void AdminFormu_Load(object sender, EventArgs e)
        {
            ParaOnayTablosunuGetir();
            UrunOnayTablosunuGetir();
        }

        private void btnCikisUO_Click(object sender, EventArgs e)   //Programı sonlandırmak için
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnCikisPO_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
