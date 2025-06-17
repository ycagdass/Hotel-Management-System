using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace cagdasotels
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EAR3I4G;Initial Catalog=CagdasOtel;Integrated Security=True;");


        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
        }


        private void BtnOda105_Click_1(object sender, EventArgs e)
        {
            // Oda numarasını 105 yap
            TxtOdaNo.Text = "105";

            // İstersen başka işlemler de ekleyebilirsin
            // Örneğin: Buton rengini değiştir, müşteri bilgilerini getir vb.
        }
        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dolu Odaları Gösterir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boş Odaları Gösterir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DtpCikisTrh_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTrh.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTrh.Text);

            TimeSpan sonuc = BuyukTarih - KucukTarih;
            label11.Text = sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label11.Text) * 1850; // Günlük ücret 1850 TL olarak varsayıldı
            txtUcret.Text = Ucret.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa frm = new AnaSayfa();
            frm.Show(); // Yeni formu aç
            this.Visible = false; // Mevcut formu gizle
        }

        private void BtnKydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO MusteriEkle (Adi, Soyadi, Cinsiyet, Telefon, Mail, TC, OdaNo, Ucret, GirisTarihi, CikisTarihi) VALUES ('" + TxtAdi.Text + "','" + TxtSoyAdi.Text + "','" + comboBox1.Text + "','" + MskTxtTel.Text + "','" + TxtMail.Text + "','" + MskTxtTC.Text + "','" + TxtOdaNo.Text + "','" + txtUcret.Text + "','" + DtpGirisTrh.Value.ToString("yyyy-MM-dd") + "','" + DtpCikisTrh.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

//Data Source=DESKTOP-EAR3I4G;Initial Catalog=CagdasOtel;Integrated Security=True;Trust Server Certificate=True