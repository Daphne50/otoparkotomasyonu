using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otoparkotomasyonu
{
    public partial class farmsatis : Form
    {
        public farmsatis()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\danda\\Documents\\OtoparkOtomasyon.accdb;Persist Security Info=False;");
        DataSet daset = new DataSet();

        private void farmsatis_Load(object sender, EventArgs e)
        {
            satislerilistele();
            hESAPLA();

        }

        private void hESAPLA()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select sum(tutar)from satis ", baglanti);
            label1.Text = "Toplam Tutar" + komut.ExecuteScalar() + "TL";
            baglanti.Close();
        }

        private void satislerilistele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from satis ", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];
            baglanti.Close();
        }
    }
}
