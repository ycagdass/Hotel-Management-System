using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cagdasotels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EAR3I4G;Initial Catalog=CagdasOtel;Integrated Security=True;");

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar where KullaniciAdi=@KullaniciAdi AND parola=@parola", baglanti);
            cmd.Parameters.AddWithValue("@KullaniciAdi", TxtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@parola", TxtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader(); // Veritabanından kullanıcı bilgilerini oku

            if (dr.Read())
            {
                baglanti.Close(); // Veritabanı bağlantısını kapat
                AnaSayfa frm = new AnaSayfa(); // Yeni formu oluştur
                frm.Show(); // Yeni formu göster
                this.Visible = false; // Mevcut formu gizle
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); // Hata mesajı göster
            }
        }
    }
}
