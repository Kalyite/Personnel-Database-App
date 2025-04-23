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

namespace vtUygulama1
{
    public partial class KayitSilForm : Form
    {
        public KayitSilForm()
        {
            InitializeComponent();
        }
        
        public void KayitSil()
        {
            try
            {
                Form1.BaglantiAc();

                string Sorgu = "Delete from Personel where KayitNO="+txtKayitNo.Text;

                SqlCommand SilKomut = new SqlCommand(Sorgu,Form1.baglanti);

                if (SilKomut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt Silindi");
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Hatası");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KayitSil();
        }
    }
}
