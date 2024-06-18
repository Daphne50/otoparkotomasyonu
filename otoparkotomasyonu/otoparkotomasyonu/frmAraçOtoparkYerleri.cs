using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace otoparkotomasyonu
{
    public partial class frmAraçOtoparkYerleri : Form
    {
        public frmAraçOtoparkYerleri()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\danda\\Documents\\OtoparkOtomasyon.accdb;Persist Security Info=False;");


        private void frmAraçOtoparkYerleri_Load(object sender, EventArgs e)
        {
            bOŞparkyerleri();
            DoluParkyerleri();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from araç_otopark_kaydı", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["parkyeri"].ToString())
                        {
                            //  item.BackColor = Color.Red;
                            item.Text = read["plaka"].ToString();
                        }
                    }
                }
            }
            baglanti.Close();


        }

        private void DoluParkyerleri()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from araç_durum", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["park_yeri"].ToString() && read["durum"].ToString() == "DOLU")
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
            }
            baglanti.Close();
        }

        private void bOŞparkyerleri()
        {
            int sayac = 1;
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.Text = "P-" + sayac;
                    item.Name = "P-" + sayac;
                    sayac++;

                }
            }
        }
    }
}
