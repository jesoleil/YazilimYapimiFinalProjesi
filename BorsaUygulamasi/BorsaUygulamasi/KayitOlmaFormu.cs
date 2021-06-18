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
    public partial class KayitOlmaFormu : Form
    {
        SqlConnection connection = GirisFormu.connection;
        public KayitOlmaFormu()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into Users (UserType,UserName,UserPassword,UserGivenName,UserSurname,UserTcNumber,UserPhoneNumber,UserEmail,UserAdress) values ('" + "client" + "','" + Cryptology.Encryption(txtboxUsername.Text, 2) + "','" + Cryptology.Encryption(txtboxPassword.Text, 2) + "','" + txtboxAd.Text + "','" + txtboxSoyad.Text + "','" + txtboxTcNo.Text + "','" + txtboxtTelNo.Text + "','" + txtboxEmail.Text + "','" + txtboxAdres.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kaydınız Başarıyla Oluşturuldu !", "Hoş geldiniz..");
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            GirisFormu gfrm = new GirisFormu();
            this.Hide();
            gfrm.Show();
        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {
            txtboxPassword.PasswordChar = '*';
        }

        private void txtboxTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
