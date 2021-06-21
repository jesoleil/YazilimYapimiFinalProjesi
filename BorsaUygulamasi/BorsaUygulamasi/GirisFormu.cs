using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sql bağlantısı için gerekli kütüphane tanımlandı

namespace BorsaUygulamasi
{
    public partial class GirisFormu : Form
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VRLGKMH\\SQLEXPRESS; Initial Catalog=PlanlamaOyunu; Integrated Security=TRUE"); //Bağlantı adresimiz verildi.
        User user = new User(); //User sınıfından user nesnemiz oluşturuldu.
        public static string id; //Kayıt olduğumuzda bize otomatik atanan id numaramızı bir değişkende tutmak ve formlar arası aktarım için static olarak oluşturuldu.

        public GirisFormu()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtboxKullaniciAdi.Text=="" || txtboxSifre.Text=="")     //Girilen alanların boş olup olmadığı kontrol edildi.
                MessageBox.Show("Lütfen alanları boş bırakmayınız !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    user.K_adi = txtboxKullaniciAdi.Text;       //Textbox lardaki değerler değişkenlere atandı.
                    user.K_sifresi = txtboxSifre.Text;
                    connection.Open();
                    SqlCommand command = new SqlCommand("Select * from Users", connection);  //Burada veritabanındaki kullanıcı bilgilerinin tutulduğu tablodan okuma yapılarak bilgiler eşleşiyorsa giriş sağlandı.
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetValue(0).ToString().TrimEnd(); //Veritabanı okuması yapılırken kişinin id si çekilerek id değişkeninde tutuldu.
                        if (user.K_adi == Cryptology.Decryption(reader["UserName"].ToString().TrimEnd(), 2) && user.K_sifresi == Cryptology.Decryption(reader["UserPassword"].ToString().TrimEnd(), 2))
                        { //Kullanıcı adı ve şifre Sezar algoritması ve anahtar ile şifrelenerek veritabanında tutuluyor.
                          //Kullanıcı tipine göre giriş işlemi doğrulanıyor.
                            if (reader["UserType"].ToString().TrimEnd() == "client")
                            {
                                MessageBox.Show("Hoş geldiniz..", "Kullanıcı girişi.");
                                KullaniciFormu frm = new KullaniciFormu();
                                frm.Show();
                                this.Hide();
                                break;
                            }
                            else if (reader["UserType"].ToString().TrimEnd() == "admin")
                            {
                                MessageBox.Show("Hoş geldiniz..", "Yönetici girişi.");
                                AdminFormu frm2 = new AdminFormu();
                                frm2.Show();
                                this.Hide();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Bağlantıda bir hata oluştu");
                                break;
                            }
                        }
                    }
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Girdiğiniz bilgiler hatalı veya kaydınız bulunamamaktadır, lütfen kontrol ediniz !","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        private void linkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();    //Kayıt sayfası açılacaktır.
            KayitOlmaFormu frm = new KayitOlmaFormu();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Programı sonlandırmak için tanımlandı.
        }

        private void txtboxSifre_TextChanged(object sender, EventArgs e)
        {
            txtboxSifre.PasswordChar = '*';     //Şifrenin gözükmemesi için tanımlandı.
        }
    }
}
