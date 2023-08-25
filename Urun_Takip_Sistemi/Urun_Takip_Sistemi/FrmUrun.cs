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


namespace Urun_Takip_Sistemi
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection1 = new SqlConnection("Data Source =.; Initial Catalog = DbUrun; Integrated Security = True");
        private void btnUrunListele_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select UrunId,UrunAdi,Stok,AlisFiyat,SatisFiyat,KategorıAdi,KategorıId from TblUrunler \r\nInner join TblKategori \r\nON TblUrunler.Kategori=TblKategori.KategorıID", sqlConnection1);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["KategorıID"].Visible = false;
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            // form açılınca direk bütün verilerin combo boxta gelmesidir.

            SqlCommand sqlCommand2 = new SqlCommand("select * from TblKategori",sqlConnection1);
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlCommand2);
            DataTable dataTable1 = new DataTable();
            sqlDataAdapter1.Fill(dataTable1);
            cbxKategori.DisplayMember = "KategorıAdi";
            cbxKategori.ValueMember = "KategorıID";
            cbxKategori.DataSource = dataTable1;  
            
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            SqlCommand sqlCommand3 = new SqlCommand("insert into TblUrunler(UrunAdi,Stok,AlisFiyat,SatisFiyat,Kategori)values(@p1,@p2,@p3,@p4,@p5)",sqlConnection1);
            sqlCommand3.Parameters.AddWithValue("@p1",tbxUrunAd.Text);
            sqlCommand3.Parameters.AddWithValue("@p2",nupdownStok.Value);
            sqlCommand3.Parameters.AddWithValue("@p3", tbxUrunAlıs.Text);
            sqlCommand3.Parameters.AddWithValue("@p4", tbxUrunSatıs.Text);
            sqlCommand3.Parameters.AddWithValue("@p5", cbxKategori.SelectedValue);

            sqlCommand3.ExecuteNonQuery();

            sqlConnection1.Close();
            tbxUrunID.Clear();
            tbxUrunAd.Clear();
            tbxUrunAlıs.Clear();
            tbxUrunSatıs.Clear();
            

            MessageBox.Show("Eklenildi");
            
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            SqlCommand sqlCommand4 = new SqlCommand("delete from TblUrunler where UrunID=@p6",sqlConnection1);
            sqlCommand4.Parameters.AddWithValue("@p6",tbxUrunID.Text);
            sqlCommand4.ExecuteNonQuery();

            sqlConnection1.Close();

            tbxUrunID.Clear();
            tbxUrunAd.Clear();
            tbxUrunAlıs.Clear();
            tbxUrunSatıs.Clear();
            MessageBox.Show("silindi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUrunID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbxUrunAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            nupdownStok.Value =int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            tbxUrunAlıs.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbxUrunSatıs.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbxKategori.SelectedValue= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void btnUrunGüncelle_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            SqlCommand sqlCommand5 = new SqlCommand("update TblUrunler set UrunAdi=@p1,Stok=@p2,AlisFiyat=@p3,SatisFiyat=@p4,Kategori=@p5 where UrunID=@p6", sqlConnection1);
           
            
            sqlCommand5.Parameters.AddWithValue("@p1",tbxUrunAd.Text);
            sqlCommand5.Parameters.AddWithValue("@p2", nupdownStok.Value);
            sqlCommand5.Parameters.AddWithValue("@p3", decimal.Parse(tbxUrunAlıs.Text));
            sqlCommand5.Parameters.AddWithValue("@p4", decimal.Parse(tbxUrunSatıs.Text));
            sqlCommand5.Parameters.AddWithValue("@p5", cbxKategori.SelectedValue);
            sqlCommand5.Parameters.AddWithValue("@p6",tbxUrunID.Text);
            sqlCommand5.ExecuteNonQuery();
            sqlConnection1.Close();
            tbxUrunID.Clear();
            tbxUrunAd.Clear();
            tbxUrunAlıs.Clear();
            tbxUrunSatıs.Clear();

            MessageBox.Show("ürün güncellendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmYönlendirme1 frmYönlendirme1 = new FrmYönlendirme1();
            frmYönlendirme1.Show();
            this.Hide();
        }
    }
}
