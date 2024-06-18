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
    public partial class frmAraçOtoparkcikis : Form
    {
        public frmAraçOtoparkcikis()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\danda\\Documents\\OtoparkOtomasyon.accdb;Persist Security Info=False;");



        private void frmAraçOtoparkcikis_Load(object sender, EventArgs e)
        {
            Doluyerler();
            Plakalar();
            timer1.Enabled = true;

        }

        private void Plakalar()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from araç_otopark_kaydı ", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ComboPlaka.Items.Add(read["plaka"].ToString());
            }
            baglanti.Close();
        }

        private void Doluyerler()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from araç_durum where durum='DOLU' ", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ComboParkYeri.Items.Add(read["park_yeri"].ToString());
            }
            baglanti.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from araç_otopark_kaydı where plaka='" + ComboPlaka.SelectedItem + "' ", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                TxtParkYeri.Text = read["parkyeri"].ToString();
            }
            baglanti.Close();

        }

        private void ComboParkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from araç_otopark_kaydı where parkyeri='" + ComboParkYeri.SelectedItem + "' ", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                TxtParkYeri2.Text = read["parkyeri"].ToString();
                TxtTc.Text = read["tc"].ToString();
                TxtAd.Text = read["ad"].ToString();
                TxtSoyad.Text = read["soyad"].ToString();
                TxtMarka.Text = read["marka"].ToString();
                TxtSeri.Text = read["seri"].ToString();
                Txtplaka.Text = read["plaka"].ToString();
                lblgeliştarihi.Text = read["tarih"].ToString();
            }
            baglanti.Close();
            DateTime geliş, çıkış;
            geliş = DateTime.Parse(lblgeliştarihi.Text);
            çıkış = DateTime.Parse(lblcıkıstarihi.Text);
            TimeSpan fark;
            fark = çıkış - geliş;
            lblsure.Text = fark.TotalHours.ToString("0.00");
            lblucret.Text = (double.Parse(lblsure.Text) * (0.75)).ToString("0.00");


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Application.Exit();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from araç_otopark_kaydı where plaka='"+Txtplaka.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            OleDbCommand komut2 = new OleDbCommand("update araç_durum set durum='BOŞ' where park_yeri='" + TxtParkYeri2.Text + "'", baglanti);
            komut2.ExecuteNonQuery();
            OleDbCommand komut3 = new OleDbCommand("insert into satis(parkyeri,plaka,geliş_tarihi,çıkış_tarihi,süre,tutar) values(@parkyeri,@plaka,@geliş_tarihi,@çıkış_tarihi,@süre,@tutar)", baglanti);
                komut3.Parameters.AddWithValue("@parkyeri", TxtParkYeri2.Text);
                komut3.Parameters.AddWithValue("@plaka", Txtplaka.Text);
                komut3.Parameters.AddWithValue("@geliş_tarihi", lblgeliştarihi.Text);
                komut3.Parameters.AddWithValue("@çıkış_tarihi", lblcıkıstarihi.Text);
                komut3.Parameters.AddWithValue("@süre", double.Parse (lblsure.Text));
                komut3.Parameters.AddWithValue("@tutar", double.Parse (lblucret.Text));
                komut3.ExecuteNonQuery();



            baglanti.Close();
            MessageBox.Show("Araç Çıkışı Başarılı");
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    TxtParkYeri.Text = "";
                    ComboParkYeri.Text = "";
                    ComboPlaka.Text = "";

                }
            }
            ComboPlaka.Items.Clear();
            ComboParkYeri.Items.Clear();
            Doluyerler();
            Plakalar();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblcıkıstarihi.Text = DateTime.Now.ToString();
         //  lblgeliştarihi.Text = DateTime.Now.ToString();

        }

        private void lblsure_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblgeliştarihi_Click(object sender, EventArgs e)
        {
            // Ensure ComboPlaka has a selected item
            if (ComboPlaka.SelectedItem != null)
            {
                string plaka = ComboPlaka.SelectedItem.ToString();
                try
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand(
                        "SELECT giriş_tarihi FROM araç_otopark_kaydı WHERE plaka = @Plaka",
                        baglanti
                    );
                    komut.Parameters.AddWithValue("@Plaka", plaka);

                    object result = komut.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        lblgeliştarihi.Text = Convert.ToDateTime(result).ToString();
                    }
                    else
                    {
                        lblgeliştarihi.Text = "Giriş tarihi bulunamadı.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir plaka seçin.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            this.Close();
            anasayfa.ShowDialog();
        }


        // ... (rest of your existing code)
    }

}
