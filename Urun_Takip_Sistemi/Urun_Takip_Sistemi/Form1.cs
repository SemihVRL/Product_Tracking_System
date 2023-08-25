using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//sql kütüphanesi

namespace Urun_Takip_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source =.; Initial Catalog = DbUrun; Integrated Security = True");
        private void btnListele_Click(object sender, EventArgs e)
        {
           
            SqlCommand sqlCommand = new SqlCommand("Select * from TblKategori",sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);//fill doldurmak anlamına geliyor data base ise veri tablosu demek yani veri tablosunu listele
            dataGridView1.DataSource= dataTable;


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            //c# da @ değeri parametre görevi yapar
            //sqlda kaydet görevi yapan komut insert komutudur.

            sqlConnection.Open();
            SqlCommand sqlCommand2 = new SqlCommand("insert into TblKategori(KategorıAdi)values(@p1)", sqlConnection);
            sqlCommand2.Parameters.AddWithValue("@p1", tbxKategoriAd.Text);
           
            sqlCommand2.ExecuteNonQuery();
            tbxKategoriAd.Clear();
            tbxSil.Clear();
           
            sqlConnection.Close();
            
            MessageBox.Show("Kategoriniz eklendi");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand3 = new SqlCommand("delete from TblKategori where KategorıID=@p1", sqlConnection);
            sqlCommand3.Parameters.AddWithValue("@p1",tbxSil.Text);
            
            sqlCommand3.ExecuteNonQuery();
            tbxKategoriAd.Clear();
            tbxSil.Clear();
           
            sqlConnection.Close();
            
            MessageBox.Show("Kategoriniz silindi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand4 = new SqlCommand("update TblKategori set KategorıAdi=@p1 where KategorıID=@p2", sqlConnection);
            sqlCommand4.Parameters.AddWithValue("@p1", tbxKategoriAd.Text); 
            sqlCommand4.Parameters.AddWithValue("@p2", tbxSil.Text);
            sqlCommand4.ExecuteNonQuery();
            tbxKategoriAd.Clear();
            tbxSil.Clear();
            sqlConnection.Close();
            MessageBox.Show("Güncellendi");

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            
            SqlCommand sqlCommand5 = new SqlCommand("Select * from TblKategori where KategorıAdi=@p1", sqlConnection);
            
            sqlCommand5.Parameters.AddWithValue("@p1", tbxKategoriAd.Text);

            //sql dataadapter yazmamızın sebebi veritabanını forma getirmek
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand5);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);//fill doldurmak anlamına geliyor data base ise veri tablosu demek yani veri tablosunu listele
           
            dataGridView1.DataSource = dataTable;
            tbxKategoriAd.Clear();
            tbxSil.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmYönlendirme1 frmYönlendirme1=new FrmYönlendirme1();
            frmYönlendirme1.Show();
            this.Hide();
        }
    }
}
//Data Source =.; Initial Catalog = DbUrun; Integrated Security = True