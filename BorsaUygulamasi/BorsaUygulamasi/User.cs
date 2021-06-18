using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaUygulamasi
{
    class User
    {
        private string k_adi, k_sifresi;
        private string ad, soyad, tc_no, tel_no, email, adres;
        public string K_adi
        {
            get { return k_adi; }
            set { k_adi = value; }
        }
        public string K_sifresi
        {
            get { return k_sifresi; }
            set { k_sifresi = value; }
        }
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string Tc_no
        {
            get { return tc_no; }
            set { tc_no = value; }
        }
        public string Tel_no
        {
            get { return tel_no; }
            set { tel_no = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

    }
}
