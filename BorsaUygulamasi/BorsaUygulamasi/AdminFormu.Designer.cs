
namespace BorsaUygulamasi
{
    partial class AdminFormu
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
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPageUrunOnay = new System.Windows.Forms.TabPage();
            this.btnCikisUO = new System.Windows.Forms.Button();
            this.btnUrunOnayla = new System.Windows.Forms.Button();
            this.txtboxUrunOnayDurumu = new System.Windows.Forms.TextBox();
            this.lblOnayDurumuUrun = new System.Windows.Forms.Label();
            this.lblUserIdUrun = new System.Windows.Forms.Label();
            this.txtboxIDUrunOnay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUrunOnay = new System.Windows.Forms.DataGridView();
            this.tabPageParaOnay = new System.Windows.Forms.TabPage();
            this.btnCikisPO = new System.Windows.Forms.Button();
            this.btnParaOnayla = new System.Windows.Forms.Button();
            this.txtboxParaOnayDurumu = new System.Windows.Forms.TextBox();
            this.lblParaOnayDurumu = new System.Windows.Forms.Label();
            this.txtboxIDParaOnay = new System.Windows.Forms.TextBox();
            this.lblUserIdPara = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewParaOnay = new System.Windows.Forms.DataGridView();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageUrunOnay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunOnay)).BeginInit();
            this.tabPageParaOnay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParaOnay)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPageUrunOnay);
            this.tabControlAdmin.Controls.Add(this.tabPageParaOnay);
            this.tabControlAdmin.Location = new System.Drawing.Point(23, 13);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(751, 425);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // tabPageUrunOnay
            // 
            this.tabPageUrunOnay.Controls.Add(this.btnCikisUO);
            this.tabPageUrunOnay.Controls.Add(this.btnUrunOnayla);
            this.tabPageUrunOnay.Controls.Add(this.txtboxUrunOnayDurumu);
            this.tabPageUrunOnay.Controls.Add(this.lblOnayDurumuUrun);
            this.tabPageUrunOnay.Controls.Add(this.lblUserIdUrun);
            this.tabPageUrunOnay.Controls.Add(this.txtboxIDUrunOnay);
            this.tabPageUrunOnay.Controls.Add(this.label1);
            this.tabPageUrunOnay.Controls.Add(this.dataGridViewUrunOnay);
            this.tabPageUrunOnay.Location = new System.Drawing.Point(4, 25);
            this.tabPageUrunOnay.Name = "tabPageUrunOnay";
            this.tabPageUrunOnay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunOnay.Size = new System.Drawing.Size(743, 396);
            this.tabPageUrunOnay.TabIndex = 0;
            this.tabPageUrunOnay.Text = "Ürün Onay";
            this.tabPageUrunOnay.UseVisualStyleBackColor = true;
            // 
            // btnCikisUO
            // 
            this.btnCikisUO.BackgroundImage = global::BorsaUygulamasi.Properties.Resources.cikis_ikon;
            this.btnCikisUO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikisUO.Location = new System.Drawing.Point(671, 302);
            this.btnCikisUO.Name = "btnCikisUO";
            this.btnCikisUO.Size = new System.Drawing.Size(49, 46);
            this.btnCikisUO.TabIndex = 24;
            this.btnCikisUO.UseVisualStyleBackColor = true;
            this.btnCikisUO.Click += new System.EventHandler(this.btnCikisUO_Click);
            // 
            // btnUrunOnayla
            // 
            this.btnUrunOnayla.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUrunOnayla.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunOnayla.Location = new System.Drawing.Point(24, 298);
            this.btnUrunOnayla.Name = "btnUrunOnayla";
            this.btnUrunOnayla.Size = new System.Drawing.Size(349, 50);
            this.btnUrunOnayla.TabIndex = 21;
            this.btnUrunOnayla.Text = "Ürün Onay Durumunu Güncelle";
            this.btnUrunOnayla.UseVisualStyleBackColor = false;
            this.btnUrunOnayla.Click += new System.EventHandler(this.btnUrunOnayla_Click);
            // 
            // txtboxUrunOnayDurumu
            // 
            this.txtboxUrunOnayDurumu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtboxUrunOnayDurumu.Location = new System.Drawing.Point(256, 249);
            this.txtboxUrunOnayDurumu.Name = "txtboxUrunOnayDurumu";
            this.txtboxUrunOnayDurumu.Size = new System.Drawing.Size(117, 22);
            this.txtboxUrunOnayDurumu.TabIndex = 20;
            // 
            // lblOnayDurumuUrun
            // 
            this.lblOnayDurumuUrun.AutoSize = true;
            this.lblOnayDurumuUrun.BackColor = System.Drawing.Color.Transparent;
            this.lblOnayDurumuUrun.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOnayDurumuUrun.Location = new System.Drawing.Point(20, 248);
            this.lblOnayDurumuUrun.Name = "lblOnayDurumuUrun";
            this.lblOnayDurumuUrun.Size = new System.Drawing.Size(193, 23);
            this.lblOnayDurumuUrun.TabIndex = 19;
            this.lblOnayDurumuUrun.Text = "Ürün Onay Durumu : ";
            // 
            // lblUserIdUrun
            // 
            this.lblUserIdUrun.AutoSize = true;
            this.lblUserIdUrun.BackColor = System.Drawing.Color.Transparent;
            this.lblUserIdUrun.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserIdUrun.Location = new System.Drawing.Point(20, 192);
            this.lblUserIdUrun.Name = "lblUserIdUrun";
            this.lblUserIdUrun.Size = new System.Drawing.Size(48, 23);
            this.lblUserIdUrun.TabIndex = 18;
            this.lblUserIdUrun.Text = "ID : ";
            // 
            // txtboxIDUrunOnay
            // 
            this.txtboxIDUrunOnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtboxIDUrunOnay.Location = new System.Drawing.Point(256, 187);
            this.txtboxIDUrunOnay.Name = "txtboxIDUrunOnay";
            this.txtboxIDUrunOnay.Size = new System.Drawing.Size(117, 22);
            this.txtboxIDUrunOnay.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "KULLANICI ÜRÜN EKLEME TALEPLERİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewUrunOnay
            // 
            this.dataGridViewUrunOnay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunOnay.Location = new System.Drawing.Point(6, 48);
            this.dataGridViewUrunOnay.Name = "dataGridViewUrunOnay";
            this.dataGridViewUrunOnay.RowHeadersWidth = 51;
            this.dataGridViewUrunOnay.RowTemplate.Height = 24;
            this.dataGridViewUrunOnay.Size = new System.Drawing.Size(632, 117);
            this.dataGridViewUrunOnay.TabIndex = 15;
            this.dataGridViewUrunOnay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUrunOnay_CellClick);
            // 
            // tabPageParaOnay
            // 
            this.tabPageParaOnay.Controls.Add(this.btnCikisPO);
            this.tabPageParaOnay.Controls.Add(this.btnParaOnayla);
            this.tabPageParaOnay.Controls.Add(this.txtboxParaOnayDurumu);
            this.tabPageParaOnay.Controls.Add(this.lblParaOnayDurumu);
            this.tabPageParaOnay.Controls.Add(this.txtboxIDParaOnay);
            this.tabPageParaOnay.Controls.Add(this.lblUserIdPara);
            this.tabPageParaOnay.Controls.Add(this.label2);
            this.tabPageParaOnay.Controls.Add(this.dataGridViewParaOnay);
            this.tabPageParaOnay.Location = new System.Drawing.Point(4, 25);
            this.tabPageParaOnay.Name = "tabPageParaOnay";
            this.tabPageParaOnay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParaOnay.Size = new System.Drawing.Size(743, 396);
            this.tabPageParaOnay.TabIndex = 1;
            this.tabPageParaOnay.Text = "Para Onay";
            this.tabPageParaOnay.UseVisualStyleBackColor = true;
            // 
            // btnCikisPO
            // 
            this.btnCikisPO.BackgroundImage = global::BorsaUygulamasi.Properties.Resources.cikis_ikon;
            this.btnCikisPO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikisPO.Location = new System.Drawing.Point(673, 311);
            this.btnCikisPO.Name = "btnCikisPO";
            this.btnCikisPO.Size = new System.Drawing.Size(49, 46);
            this.btnCikisPO.TabIndex = 23;
            this.btnCikisPO.UseVisualStyleBackColor = true;
            this.btnCikisPO.Click += new System.EventHandler(this.btnCikisPO_Click);
            // 
            // btnParaOnayla
            // 
            this.btnParaOnayla.BackColor = System.Drawing.Color.DarkCyan;
            this.btnParaOnayla.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaOnayla.Location = new System.Drawing.Point(22, 311);
            this.btnParaOnayla.Name = "btnParaOnayla";
            this.btnParaOnayla.Size = new System.Drawing.Size(351, 50);
            this.btnParaOnayla.TabIndex = 22;
            this.btnParaOnayla.Text = "Para Onay Durumunu Güncelle";
            this.btnParaOnayla.UseVisualStyleBackColor = false;
            this.btnParaOnayla.Click += new System.EventHandler(this.btnParaOnayla_Click);
            // 
            // txtboxParaOnayDurumu
            // 
            this.txtboxParaOnayDurumu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtboxParaOnayDurumu.Location = new System.Drawing.Point(256, 268);
            this.txtboxParaOnayDurumu.Name = "txtboxParaOnayDurumu";
            this.txtboxParaOnayDurumu.Size = new System.Drawing.Size(117, 22);
            this.txtboxParaOnayDurumu.TabIndex = 21;
            // 
            // lblParaOnayDurumu
            // 
            this.lblParaOnayDurumu.AutoSize = true;
            this.lblParaOnayDurumu.BackColor = System.Drawing.Color.Transparent;
            this.lblParaOnayDurumu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaOnayDurumu.Location = new System.Drawing.Point(18, 267);
            this.lblParaOnayDurumu.Name = "lblParaOnayDurumu";
            this.lblParaOnayDurumu.Size = new System.Drawing.Size(190, 23);
            this.lblParaOnayDurumu.TabIndex = 20;
            this.lblParaOnayDurumu.Text = "Para Onay Durumu : ";
            // 
            // txtboxIDParaOnay
            // 
            this.txtboxIDParaOnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtboxIDParaOnay.Location = new System.Drawing.Point(256, 216);
            this.txtboxIDParaOnay.Name = "txtboxIDParaOnay";
            this.txtboxIDParaOnay.Size = new System.Drawing.Size(117, 22);
            this.txtboxIDParaOnay.TabIndex = 19;
            // 
            // lblUserIdPara
            // 
            this.lblUserIdPara.AutoSize = true;
            this.lblUserIdPara.BackColor = System.Drawing.Color.Transparent;
            this.lblUserIdPara.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserIdPara.Location = new System.Drawing.Point(18, 216);
            this.lblUserIdPara.Name = "lblUserIdPara";
            this.lblUserIdPara.Size = new System.Drawing.Size(48, 23);
            this.lblUserIdPara.TabIndex = 18;
            this.lblUserIdPara.Text = "ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "KULLANICI PARA EKLEME TALEPLERİ";
            // 
            // dataGridViewParaOnay
            // 
            this.dataGridViewParaOnay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParaOnay.Location = new System.Drawing.Point(3, 48);
            this.dataGridViewParaOnay.Name = "dataGridViewParaOnay";
            this.dataGridViewParaOnay.RowHeadersWidth = 51;
            this.dataGridViewParaOnay.RowTemplate.Height = 24;
            this.dataGridViewParaOnay.Size = new System.Drawing.Size(623, 150);
            this.dataGridViewParaOnay.TabIndex = 16;
            this.dataGridViewParaOnay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParaOnay_CellClick);
            // 
            // AdminFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "AdminFormu";
            this.Text = "Yönetici Sayfası";
            this.Load += new System.EventHandler(this.AdminFormu_Load);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageUrunOnay.ResumeLayout(false);
            this.tabPageUrunOnay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunOnay)).EndInit();
            this.tabPageParaOnay.ResumeLayout(false);
            this.tabPageParaOnay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParaOnay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPageUrunOnay;
        private System.Windows.Forms.TabPage tabPageParaOnay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUrunOnay;
        private System.Windows.Forms.Button btnCikisUO;
        private System.Windows.Forms.Button btnUrunOnayla;
        private System.Windows.Forms.TextBox txtboxUrunOnayDurumu;
        private System.Windows.Forms.Label lblOnayDurumuUrun;
        private System.Windows.Forms.Label lblUserIdUrun;
        private System.Windows.Forms.TextBox txtboxIDUrunOnay;
        private System.Windows.Forms.Button btnCikisPO;
        private System.Windows.Forms.Button btnParaOnayla;
        private System.Windows.Forms.TextBox txtboxParaOnayDurumu;
        private System.Windows.Forms.Label lblParaOnayDurumu;
        private System.Windows.Forms.TextBox txtboxIDParaOnay;
        private System.Windows.Forms.Label lblUserIdPara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewParaOnay;
    }
}