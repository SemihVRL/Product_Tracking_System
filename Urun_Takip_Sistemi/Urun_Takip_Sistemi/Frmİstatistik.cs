using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Urun_Takip_Sistemi
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source =.; Initial Catalog = DbUrun; Integrated Security = True");
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {

            //Toplam kategori sayısı
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select count(*) from TblKategori",sqlConnection);
            //tblurunler tablosunda 16 tane aşama var 
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //sqldatareader okuma yapan komuttur //executereader ise çalıştırıp okuma görevi yapar
            while (sqlDataReader.Read())
            {
                label2.Text = sqlDataReader[0].ToString();
            }

            sqlConnection.Close();

            //toplam ürün sayısı

            sqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("select count(*) from TblUrunler", sqlConnection);
            SqlDataReader sqlDataReader1= sqlCommand1.ExecuteReader();
            while (sqlDataReader1.Read())
            {

                label3.Text = sqlDataReader1[0].ToString();

            }
            sqlConnection.Close(); 

            //min ve max urun sayıları
            sqlConnection.Open();
            SqlCommand sqlCommand2 = new SqlCommand("select UrunAdi,stok from TblUrunler where stok=(select min(stok) from TblUrunler)", sqlConnection);
            SqlDataReader sqlDataReader2= sqlCommand2.ExecuteReader();
            while (sqlDataReader2.Read())
            {
                label5.Text = sqlDataReader2[0].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand sqlCommand3 = new SqlCommand("select UrunAdi, stok from TblUrunler where stok = (select max(stok) from TblUrunler)", sqlConnection);
            SqlDataReader sqlDataReader3 = sqlCommand3.ExecuteReader();
            while (sqlDataReader3.Read())
            {
                label7.Text = sqlDataReader3[0].ToString();
            }
            sqlConnection.Close();


            sqlConnection.Open();
            SqlCommand sqlCommand4 = new SqlCommand("select count(*) from TblUrunler where Kategori=(select KategorıID from TblKategori where KategorıAdi='Küçük Ev Aletleri')", sqlConnection);
            SqlDataReader sqlDataReader4 = sqlCommand4.ExecuteReader();
            while (sqlDataReader4.Read())
            {
                label15.Text = sqlDataReader4[0].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand sqlCommand5 = new SqlCommand("select avg((SatisFiyat-AlisFiyat)*(Stok)) from TblUrunler where UrunAdi='laptop'", sqlConnection);
            SqlDataReader sqlDataReader5 = sqlCommand5.ExecuteReader();
            while (sqlDataReader5.Read())
            {
                label13.Text = sqlDataReader5[0].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand sqlCommand6 = new SqlCommand("select avg((SatisFiyat-AlisFiyat)*(Stok) )from TblUrunler where Kategori=(select KategorıID from TblKategori where KategorıAdi='Beyaz eşya')", sqlConnection);
            SqlDataReader sqlDataReader6 = sqlCommand6.ExecuteReader();
            while (sqlDataReader6.Read())
            {
                label11.Text = sqlDataReader6[0].ToString();
            }
            sqlConnection.Close();

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmYönlendirme1 frmYönlendirme1 = new FrmYönlendirme1();
            frmYönlendirme1.Show();
            this.Hide();
        }
    }
}
