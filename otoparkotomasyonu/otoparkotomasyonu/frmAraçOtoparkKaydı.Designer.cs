
namespace otoparkotomasyonu
{
    partial class frmAraçOtoparkKaydı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtTc = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.ComboMarka = new System.Windows.Forms.ComboBox();
            this.ComboSeri = new System.Windows.Forms.ComboBox();
            this.TxtRenk = new System.Windows.Forms.TextBox();
            this.ComboParkyeri = new System.Windows.Forms.ComboBox();
            this.grupKişi = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Gruparaç = new System.Windows.Forms.GroupBox();
            this.BtnSeri = new System.Windows.Forms.Button();
            this.BtnMarka = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grupKişi.SuspendLayout();
            this.Gruparaç.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(142, 20);
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(100, 22);
            this.TxtTc.TabIndex = 0;
            this.TxtTc.TextChanged += new System.EventHandler(this.TxtTc_TextChanged);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(142, 62);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 22);
            this.TxtAd.TabIndex = 1;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(142, 104);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(100, 22);
            this.TxtSoyad.TabIndex = 2;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(142, 146);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(100, 22);
            this.TxtTel.TabIndex = 3;
            this.TxtTel.TextChanged += new System.EventHandler(this.TxtTel_TextChanged);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(142, 188);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 22);
            this.TxtEmail.TabIndex = 4;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.Location = new System.Drawing.Point(140, 30);
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(100, 22);
            this.TxtPlaka.TabIndex = 5;
            // 
            // ComboMarka
            // 
            this.ComboMarka.FormattingEnabled = true;
            this.ComboMarka.Location = new System.Drawing.Point(140, 67);
            this.ComboMarka.Name = "ComboMarka";
            this.ComboMarka.Size = new System.Drawing.Size(121, 24);
            this.ComboMarka.TabIndex = 6;
            this.ComboMarka.SelectedIndexChanged += new System.EventHandler(this.ComboMarka_SelectedIndexChanged);
            // 
            // ComboSeri
            // 
            this.ComboSeri.FormattingEnabled = true;
            this.ComboSeri.Location = new System.Drawing.Point(140, 106);
            this.ComboSeri.Name = "ComboSeri";
            this.ComboSeri.Size = new System.Drawing.Size(121, 24);
            this.ComboSeri.TabIndex = 7;
            // 
            // TxtRenk
            // 
            this.TxtRenk.Location = new System.Drawing.Point(140, 145);
            this.TxtRenk.Name = "TxtRenk";
            this.TxtRenk.Size = new System.Drawing.Size(100, 22);
            this.TxtRenk.TabIndex = 8;
            // 
            // ComboParkyeri
            // 
            this.ComboParkyeri.FormattingEnabled = true;
            this.ComboParkyeri.Location = new System.Drawing.Point(140, 182);
            this.ComboParkyeri.Name = "ComboParkyeri";
            this.ComboParkyeri.Size = new System.Drawing.Size(121, 24);
            this.ComboParkyeri.TabIndex = 9;
            // 
            // grupKişi
            // 
            this.grupKişi.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.grupKişi.Controls.Add(this.label5);
            this.grupKişi.Controls.Add(this.label4);
            this.grupKişi.Controls.Add(this.label3);
            this.grupKişi.Controls.Add(this.label2);
            this.grupKişi.Controls.Add(this.label1);
            this.grupKişi.Controls.Add(this.TxtSoyad);
            this.grupKişi.Controls.Add(this.TxtTc);
            this.grupKişi.Controls.Add(this.TxtAd);
            this.grupKişi.Controls.Add(this.TxtTel);
            this.grupKişi.Controls.Add(this.TxtEmail);
            this.grupKişi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grupKişi.Location = new System.Drawing.Point(12, 29);
            this.grupKişi.Name = "grupKişi";
            this.grupKişi.Size = new System.Drawing.Size(262, 252);
            this.grupKişi.TabIndex = 10;
            this.grupKişi.TabStop = false;
            this.grupKişi.Text = "Kişi Bilgileri";
            this.grupKişi.Enter += new System.EventHandler(this.grupKişi_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tc";
            // 
            // Gruparaç
            // 
            this.Gruparaç.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Gruparaç.Controls.Add(this.BtnSeri);
            this.Gruparaç.Controls.Add(this.BtnMarka);
            this.Gruparaç.Controls.Add(this.label10);
            this.Gruparaç.Controls.Add(this.label9);
            this.Gruparaç.Controls.Add(this.label8);
            this.Gruparaç.Controls.Add(this.label7);
            this.Gruparaç.Controls.Add(this.label6);
            this.Gruparaç.Controls.Add(this.TxtPlaka);
            this.Gruparaç.Controls.Add(this.ComboMarka);
            this.Gruparaç.Controls.Add(this.ComboParkyeri);
            this.Gruparaç.Controls.Add(this.ComboSeri);
            this.Gruparaç.Controls.Add(this.TxtRenk);
            this.Gruparaç.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Gruparaç.Location = new System.Drawing.Point(303, 29);
            this.Gruparaç.Name = "Gruparaç";
            this.Gruparaç.Size = new System.Drawing.Size(355, 252);
            this.Gruparaç.TabIndex = 11;
            this.Gruparaç.TabStop = false;
            this.Gruparaç.Text = "Araç Bilgileri";
            // 
            // BtnSeri
            // 
            this.BtnSeri.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnSeri.Location = new System.Drawing.Point(274, 102);
            this.BtnSeri.Name = "BtnSeri";
            this.BtnSeri.Size = new System.Drawing.Size(75, 23);
            this.BtnSeri.TabIndex = 18;
            this.BtnSeri.Text = "Ekle";
            this.BtnSeri.UseVisualStyleBackColor = true;
            this.BtnSeri.Click += new System.EventHandler(this.BtnSeri_Click);
            // 
            // BtnMarka
            // 
            this.BtnMarka.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnMarka.Location = new System.Drawing.Point(274, 65);
            this.BtnMarka.Name = "BtnMarka";
            this.BtnMarka.Size = new System.Drawing.Size(75, 23);
            this.BtnMarka.TabIndex = 17;
            this.BtnMarka.Text = "Ekle";
            this.BtnMarka.UseVisualStyleBackColor = true;
            this.BtnMarka.Click += new System.EventHandler(this.BtnMarka_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Park Yeri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Renk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Seri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Marka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Plaka";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAraçOtoparkKaydı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::otoparkotomasyonu.Properties.Resources.otopark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Gruparaç);
            this.Controls.Add(this.grupKişi);
            this.Name = "frmAraçOtoparkKaydı";
            this.Text = "frmAraçOtoparkKaydı";
            this.Load += new System.EventHandler(this.frmAraçOtoparkKaydı_Load);
            this.grupKişi.ResumeLayout(false);
            this.grupKişi.PerformLayout();
            this.Gruparaç.ResumeLayout(false);
            this.Gruparaç.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTc;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPlaka;
        private System.Windows.Forms.ComboBox ComboMarka;
        private System.Windows.Forms.ComboBox ComboSeri;
        private System.Windows.Forms.TextBox TxtRenk;
        private System.Windows.Forms.ComboBox ComboParkyeri;
        private System.Windows.Forms.GroupBox grupKişi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gruparaç;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnSeri;
        private System.Windows.Forms.Button BtnMarka;
    }
}