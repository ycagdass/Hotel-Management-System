using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cagdasotels
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show(); // Yeni formu aç
            this.Visible = false; // Mevcut formu gizle
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FrmYeniMusteri frm = new FrmYeniMusteri();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}\n{ex.StackTrace}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriler frm = new FrmMusteriler();
            frm.Show();
            this.Hide();
        }
    }

    public static class ThemeManager
    {
        public static bool IsDarkMode { get; private set; } = false;

        public static void SetTheme(bool darkMode)
        {
            IsDarkMode = darkMode;
        }

        public static void ApplyTheme(Form form)
        {
            Color backColor = IsDarkMode ? Color.FromArgb(45, 45, 48) : SystemColors.Control;
            Color foreColor = IsDarkMode ? Color.White : Color.Black;

            form.BackColor = backColor;
            form.ForeColor = foreColor;

            foreach (Control ctrl in form.Controls)
            {
                ctrl.BackColor = backColor;
                ctrl.ForeColor = foreColor;
            }
        }
    }
}
