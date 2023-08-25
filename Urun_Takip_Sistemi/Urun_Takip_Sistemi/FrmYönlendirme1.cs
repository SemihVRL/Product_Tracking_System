using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urun_Takip_Sistemi
{
    public partial class FrmYönlendirme1 : Form
    {
        public FrmYönlendirme1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FrmUrun frmUrun = new FrmUrun();
            frmUrun.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Frmİstatistik frmİstatistik = new Frmİstatistik();
            frmİstatistik.Show();
            this.Hide();
        }

      

        private void label7_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Hide();

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            FormGrafik formGrafik = new FormGrafik();
            formGrafik.Show();
            this.Hide();
        }
    }
}
