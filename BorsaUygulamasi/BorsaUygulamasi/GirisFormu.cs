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

namespace BorsaUygulamasi
{
    public partial class GirisFormu : Form
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VRLGKMH\\SQLEXPRESS; Initial Catalog=PlanlamaOyunu; Integrated Security=TRUE");
        User user = new User();
        public static string id;

        public GirisFormu()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                user.K_adi = txtboxKullaniciAdi.Text;
                user.K_sifresi = txtboxSifre.Text;
                connection.Open();
                SqlCommand command = new SqlCommand("Select * from Users", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetValue(0).ToString().TrimEnd();
                    if (user.K_adi == Cryptology.Decryption(reader["UserName"].ToString().TrimEnd(), 2) && user.K_sifresi == Cryptology.Decryption(reader["UserPassword"].ToString().TrimEnd(), 2))
                    {

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
                MessageBox.Show("Girdiğiniz bilgiler hatalı veya kaydınız bulunamamaktadır, lütfen kontrol ediniz !");
            }
        }

        private void linkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            KayitOlmaFormu frm = new KayitOlmaFormu();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
