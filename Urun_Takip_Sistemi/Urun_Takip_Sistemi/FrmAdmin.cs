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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source =.; Initial Catalog = DbUrun; Integrated Security = True");

        private void BtnGiriş_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from TblAdmin where KullaniciAdi=@p8 and KullaniciSifre=@p9", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p8", tbxKullanıcıAdi.Text);
            sqlCommand.Parameters.AddWithValue("@p9", tbxSifre.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                
                FrmYönlendirme1 frmYönlendirme1=new FrmYönlendirme1();
                frmYönlendirme1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya şifre yablış"," ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            sqlConnection.Close();

        }

        private void btnUye_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into TblAdmin(KullaniciAdi,KullaniciAdi)values(@p8,p9)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p8", tbxKullanıcıAdi.Text);
            sqlCommand.Parameters.AddWithValue("@p9", tbxSifre.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Yeni Kayıt Yapıldı", "Üye ol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
