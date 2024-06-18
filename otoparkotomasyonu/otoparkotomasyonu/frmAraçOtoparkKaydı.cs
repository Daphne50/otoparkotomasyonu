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
    public partial class frmAraçOtoparkKaydı : Form
    {
        public frmAraçOtoparkKaydı()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\danda\\Documents\\OtoparkOtomasyon.accdb;Persist Security Info=False;");

        private void frmAraçOtoparkKaydı_Load(object sender, EventArgs e)
        {
            boşaraçlar();
            marka();
            TxtTc.MaxLength = 11; // Maksimum 11 karakter girilebilir
            TxtTc.KeyPress += TxtTc_KeyPress;
            TxtTel.KeyPress += TxtTel_KeyPress;
            TxtTel.TextChanged += TxtTel_TextChanged;
        }

        private void TxtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTel_TextChanged(object sender, EventArgs e)
        {
            // Check if the length is greater than 10 or if the first character is '0'
            if (TxtTel.Text.Length > 10 || (TxtTel.Text.Length > 0 && TxtTel.Text[0] == '0'))
            {
                // Show a warning and reset the textbox
                MessageBox.Show("Telefon numarası 0 ile başlamamalı ve 10 haneli olmalıdır.", "Geçersiz Telefon Numarası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtTel.Text = ""; // Reset the text
            }
        }

        private void marka()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select marka from markabilgileri", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ComboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void boşaraçlar()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from araç_durum WHERE durum='BOŞ'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ComboParkyeri.Items.Add(read["park_yeri"].ToString());
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Email kontrolü
            if (!TxtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email adresinde '@' karakteri bulunmalıdır.", "Geçersiz Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("INSERT INTO araç_otopark_kaydı(tc,ad,soyad,telefon,email,plaka,marka,seri,renk,parkyeri,tarih) values(@tc,@ad,@soyad,@telefon,@email,@plaka,@marka,@seri,@renk,@parkyeri,@tarih) ", baglanti);
                komut.Parameters.AddWithValue("@tc", TxtTc.Text);
                komut.Parameters.AddWithValue("@ad", TxtAd.Text);
                komut.Parameters.AddWithValue("@soyad", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", TxtTel.Text);
                komut.Parameters.AddWithValue("@email", TxtEmail.Text);
                komut.Parameters.AddWithValue("@plaka", TxtPlaka.Text);
                komut.Parameters.AddWithValue("@marka", ComboMarka.Text);
                komut.Parameters.AddWithValue("@seri", ComboSeri.Text);
                komut.Parameters.AddWithValue("@renk", TxtRenk.Text);
                komut.Parameters.AddWithValue("@parkyeri", ComboParkyeri.Text);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                komut.ExecuteNonQuery();

                OleDbCommand komut_2 = new OleDbCommand("update araç_durum set durum='DOLU' where park_yeri='" + ComboParkyeri.SelectedItem + "'", baglanti);
                komut_2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }

            MessageBox.Show("Araç Kaydı Başarılı", "Kayıt");
            ComboParkyeri.Items.Clear();
            boşaraçlar();
            ComboMarka.Items.Clear();
            marka();
            ComboSeri.Items.Clear();

            foreach (Control item in grupKişi.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in Gruparaç.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in Gruparaç.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void BtnMarka_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void BtnSeri_Click(object sender, EventArgs e)
        {
            frmSeri seri = new frmSeri();
            seri.ShowDialog();
        }

        private void ComboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboSeri.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select marka,seri from seribilgileri where marka='" + ComboMarka.SelectedItem + "'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ComboSeri.Items.Add(read["seri"].ToString());
            }
            baglanti.Close();
        }

        private void TxtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void grupKişi_Enter(object sender, EventArgs e)
        {

        }
    }
}
