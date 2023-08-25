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
    public partial class FormGrafik : Form
    {
        public FormGrafik()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source =.; Initial Catalog = DbUrun; Integrated Security = True");
        private void FormGrafik_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select KategorıAdi,COUNT(*) from TblUrunler inner join TblKategori\r\non TblUrunler.Kategori=TblKategori.KategorıID group by KategorıAdi", sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {

                chart1.Series["Kategori"].Points.AddXY(reader[0], reader[1 ]);
            }
            sqlConnection.Close();


     }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmYönlendirme1 frmYönlendirme1 = new FrmYönlendirme1();
            frmYönlendirme1.Show();
            this.Hide();
        }
    }
}
