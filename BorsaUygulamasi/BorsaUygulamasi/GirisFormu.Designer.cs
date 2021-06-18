
namespace BorsaUygulamasi
{
    partial class GirisFormu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.linkKayitOl = new System.Windows.Forms.LinkLabel();
            this.txtboxSifre = new System.Windows.Forms.TextBox();
            this.txtboxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.Location = new System.Drawing.Point(224, 206);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(68, 23);
            this.lblSifre.TabIndex = 12;
            this.lblSifre.Text = "Şifre : ";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(224, 121);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(133, 23);
            this.lblKullaniciAdi.TabIndex = 11;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı : ";
            // 
            // linkKayitOl
            // 
            this.linkKayitOl.AutoSize = true;
            this.linkKayitOl.BackColor = System.Drawing.Color.Transparent;
            this.linkKayitOl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkKayitOl.LinkColor = System.Drawing.Color.MediumBlue;
            this.linkKayitOl.Location = new System.Drawing.Point(224, 313);
            this.linkKayitOl.Name = "linkKayitOl";
            this.linkKayitOl.Size = new System.Drawing.Size(82, 23);
            this.linkKayitOl.TabIndex = 10;
            this.linkKayitOl.TabStop = true;
            this.linkKayitOl.Text = "Kayıt Ol";
            this.linkKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkKayitOl_LinkClicked);
            // 
            // txtboxSifre
            // 
            this.txtboxSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtboxSifre.Location = new System.Drawing.Point(422, 202);
            this.txtboxSifre.Name = "txtboxSifre";
            this.txtboxSifre.Size = new System.Drawing.Size(154, 22);
            this.txtboxSifre.TabIndex = 8;
            // 
            // txtboxKullaniciAdi
            // 
            this.txtboxKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtboxKullaniciAdi.Location = new System.Drawing.Point(422, 115);
            this.txtboxKullaniciAdi.Name = "txtboxKullaniciAdi";
            this.txtboxKullaniciAdi.Size = new System.Drawing.Size(154, 22);
            this.txtboxKullaniciAdi.TabIndex = 7;
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = global::BorsaUygulamasi.Properties.Resources.cikis_ikon;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(512, 277);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(64, 59);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGiris.BackgroundImage = global::BorsaUygulamasi.Properties.Resources.giris_ikon;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.Location = new System.Drawing.Point(422, 277);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(62, 59);
            this.btnGiris.TabIndex = 9;
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // GirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.linkKayitOl);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtboxSifre);
            this.Controls.Add(this.txtboxKullaniciAdi);
            this.Name = "GirisFormu";
            this.Text = "Giriş Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.LinkLabel linkKayitOl;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtboxSifre;
        private System.Windows.Forms.TextBox txtboxKullaniciAdi;
    }
}

