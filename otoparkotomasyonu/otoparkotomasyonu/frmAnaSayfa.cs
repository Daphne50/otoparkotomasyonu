using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otoparkotomasyonu
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAraçOtoparkYerleri frm = new frmAraçOtoparkYerleri();
         //   this.Close();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAraçOtoparkKaydı frm = new frmAraçOtoparkKaydı();
          //  this.Close();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAraçOtoparkcikis frm = new frmAraçOtoparkcikis();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            farmsatis satis = new farmsatis();
            satis.ShowDialog();
        }
    }
}
