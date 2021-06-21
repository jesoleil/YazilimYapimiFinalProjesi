using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    //Sql bağlantısı için kütüphane tanımlandı.

namespace BorsaUygulamasi
{
    public partial class KayitOlmaFormu : Form
    {
        SqlConnection connection = GirisFormu.connection; //Bağlantı adresi giriş formundan alınıyor.
        public KayitOlmaFormu()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            User user = new User();     //User sınıfından nesne üretilerek textbox lara girilen değerler değişkenlere atandı.
            user.K_adi = txtboxUsername.Text;
            user.K_sifresi = txtboxPassword.Text;
            user.Ad = txtboxAd.Text;
            user.Soyad = txtboxSoyad.Text;
            user.Tc_no = txtboxTcNo.Text;
            user.Tel_no = txtboxtTelNo.Text;
            user.Email = txtboxEmail.Text;
            user.Adres = txtboxAdres.Text;
            if (txtboxTcNo.Text.Length < 11 || txtboxtTelNo.Text.Length < 10 || txtboxPassword.Text.Length < 8) //Tc , Tel numarası ve şifre uzunluğu için kontroller
            {
                MessageBox.Show("Lütfen girdiğiniz bilgileri kontrol ediniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Visible = true;  //Şifre 8 karakterden kısa ise uyarı yazısı beliriyor.
            }
            else
            {   //Girilen bilgiler uygunsa veritabanına yeni kullanıcı bilgileri kullanıcı adı ve şifresi Sezar algoritması ile şifrelenerek ekleniyor.
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into Users (UserType,UserName,UserPassword,UserGivenName,UserSurname,UserTcNumber,UserPhoneNumber,UserEmail,UserAdress) values ('" + "client" + "','" + Cryptology.Encryption(user.K_adi, 2) + "','" + Cryptology.Encryption(user.K_sifresi, 2) + "','" + user.Ad + "','" + user.Soyad + "','" + user.Tc_no+ "','" + user.Tel_no + "','" + user.Email + "','" + user.Adres + "')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kaydınız Başarıyla Oluşturuldu !", "Hoş geldiniz..");
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            GirisFormu gfrm = new GirisFormu(); //Bir önceki sayfaya geri dönme
            this.Hide();
            gfrm.Show();
        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {
            txtboxPassword.PasswordChar = '*';
        }

        private void txtboxTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)  //Tc textbox a rakam dışında başka herhangi bir şey girilmemesi için
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void KayitOlmaFormu_Load(object sender, EventArgs e)
        {
            txtboxTcNo.MaxLength = 11;      //TcNo ve telno max uzunluğu belirlendi.
            txtboxtTelNo.MaxLength = 10;
        }
    }
}
