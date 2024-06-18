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
    public partial class frmSeri : Form
    {
        public frmSeri()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\danda\\Documents\\OtoparkOtomasyon.accdb;Persist Security Info=False;");


        private void frmSeri_Load(object sender, EventArgs e)
        {
            marka();
        }

        private void marka()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select marka  from markabilgileri ", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into seribilgileri(marka, seri) values ('" + comboBox1.Text + "', '" + textBox1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç Serisi Eklendi");
            textBox1.Clear();
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            marka();
        }
    }
}
