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
    public partial class AdminFormu : Form
    {
        SqlConnection connection = GirisFormu.connection;
        string idno = GirisFormu.id;

        public AdminFormu()
        {
            InitializeComponent();
        }


       /* public static string money_id;
        string MoneyId()
        {
            connection.Close();
            connection.Open();
            SqlCommand command = new SqlCommand("Select MoneyID from MoneyApproval", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                money_id = reader.GetValue(0).ToString().TrimEnd();
                break;
            }
            connection.Close();
            return money_id;
        }*/
        public void ParaOnayTablosunuGetir()
        {
            connection.Close();
            connection.Open();
            SqlCommand command2 = new SqlCommand("select * from MoneyApproval", connection);
            SqlDataAdapter ad2 = new SqlDataAdapter(command2);
            DataTable dt2 = new DataTable();
            ad2.Fill(dt2);
            dataGridViewParaOnay.DataSource = dt2;
            connection.Close();
        }

        public void UrunOnayTablosunuGetir()
        {
            connection.Close();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from UserItemsApproval", connection);
            SqlDataAdapter ad = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridViewUrunOnay.DataSource = dt;
            connection.Close();

        }

        /*private void dataGridViewParaOnay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxIDParaOnay.Text = dataGridViewParaOnay.CurrentRow.Cells[0].Value.ToString();
            txtboxParaOnayDurumu.Text = dataGridViewParaOnay.CurrentRow.Cells[2].Value.ToString();
        }*/


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnParaOnayla_Click(object sender, EventArgs e) //***
        {
            connection.Open();
            string sorgu2 = "update MoneyApproval set MoneyApprovalStatus=@money_approval_status where MoneyID='" + Convert.ToInt32(txtboxIDParaOnay.Text) + "' ";
            SqlCommand komut2 = new SqlCommand(sorgu2, connection);
            komut2.Parameters.AddWithValue("@money_approval_status", txtboxParaOnayDurumu.Text);
            komut2.ExecuteNonQuery();
            /*connection.Close();
            connection.Close();
            connection.Open();*/
            SqlCommand onaykomutu2 = new SqlCommand("insert into Money (MoneyID,UserID,MoneyAmount) select MoneyID,UserID,MoneyAmountApproval from MoneyApproval where MoneyApproval.MoneyApprovalStatus='onaylandı' and MoneyApproval.MoneyID=@moneyid", connection);
            // onaykomutu2.Parameters.AddWithValue("@moneyid",Convert.ToInt32(money_id));
            onaykomutu2.Parameters.AddWithValue("@moneyid", dataGridViewParaOnay.SelectedCells[0].Value);
            onaykomutu2.ExecuteNonQuery();
            connection.Close();
            ParaOnayTablosunuGetir();
        }

        private void AdminFormu_Load(object sender, EventArgs e)
        {
            ParaOnayTablosunuGetir();
            UrunOnayTablosunuGetir();
        }

        private void btnCikisUO_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCikisPO_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUrunOnayla_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sorgu = "update UserItemsApproval set ItemApprovalStatus=@item_approval_status where UserItemID='" + Convert.ToInt32(txtboxIDUrunOnay.Text) + "'  ";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@item_approval_status", txtboxUrunOnayDurumu.Text);
            komut.ExecuteNonQuery();
            SqlCommand onaykomutu3 = new SqlCommand("insert into UserItems (UserItemID,UserID,ItemID,ItemAmount,ItemUnitPrice) select UserItemID,UserID,ItemID,ItemAmountApproval,ItemUnitPriceApproval from UserItemsApproval where UserItemsApproval.ItemApprovalStatus='onaylandı' and UserItemsApproval.UserItemID=@useritemid", connection);
            //insert into UserItems (UserID,ItemID,ItemAmount,ItemUnitPrice) select UserID,ItemID,ItemAmountApproval,ItemUnitPriceApproval from UserItemsApproval where UserItemsApproval.ItemApprovalStatus='onaylandı'", connection);
            onaykomutu3.Parameters.AddWithValue("@useritemid", dataGridViewUrunOnay.SelectedCells[0].Value);
            onaykomutu3.ExecuteNonQuery();
            connection.Close();
            UrunOnayTablosunuGetir();
        }

        private void dataGridViewUrunOnay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxIDUrunOnay.Text = dataGridViewUrunOnay.CurrentRow.Cells[0].Value.ToString();
            txtboxUrunOnayDurumu.Text = dataGridViewUrunOnay.CurrentRow.Cells[5].Value.ToString();
        }

        private void dataGridViewParaOnay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtboxIDParaOnay.Text = dataGridViewParaOnay.CurrentRow.Cells[0].Value.ToString();
            txtboxParaOnayDurumu.Text = dataGridViewParaOnay.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
