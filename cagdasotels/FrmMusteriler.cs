using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace cagdasotels
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EAR3I4G;Initial Catalog=CagdasOtel;Integrated Security=True;");
        private void verilerigoster()
        {
            listView1.Items.Clear(); // ListView'i temizle
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriİD"].ToString(); // Ana sütun
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle); // ListView'e ekleniyor

            }
            baglanti.Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ThemeManager.ApplyTheme(this);
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            verilerigoster();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add your logic here for handling the SelectedIndexChanged event
        }
        int id = 0; // Seçilen müşteri ID'si
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text); // Seçilen müşteri ID'sini alss
        }
    }
}
