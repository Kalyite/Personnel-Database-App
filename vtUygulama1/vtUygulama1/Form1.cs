using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  //Ado.Net SqlServer Veritabanı Kütüphanesi

namespace vtUygulama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=vt2A;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        
        public static void BaglantiAc()
        {
            try
            {
                //Veritabanı Bağlantısı Aç
                if(baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
            }
            catch(Exception Hata)
            {
                //Sistem hata mesajı göster
                MessageBox.Show(Hata.Message, "Bağlantı Açma Hata Penceresi");
            }
        }

        //Personel tablosundaki verileri DataGridView de göstericek
        public void kayitlistele()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * From Personel";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu,baglanti);
                da.Fill(ds,"Personel");
                dataGridView1.DataSource = ds.Tables["Personel"];
                baglanti.Close();
            }
            catch(Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Bağlantı Açma Hata Penceresi");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAraSoyad.Enabled = false;
            txtAraAd.Enabled = false;
            kayitlistele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KayitEkleForm ekform = new KayitEkleForm();
            ekform.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            KayitSilForm silform = new KayitSilForm();
            

            silform.txtKayitNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            silform.txtSAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            silform.txtTcNoS.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            silform.txtSoyadS.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            silform.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            baglanti.Close();
            kayitlistele();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            KayitDegistirForm KayitD = new KayitDegistirForm();

            KayitD.KayıtDno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            KayitD.txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            KayitD.txtTcNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            KayitD.txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Erkek")
            {
                KayitD.radErkek.Checked = true;
            }
            else
            {
                KayitD.radKadin.Checked = true;
            }

            KayitD.cmbBirim.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
            KayitD.cmbDyeri.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            KayitD.dTarih.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            KayitD.txtTel.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();


            KayitD.ShowDialog();
        }

        private void txtAraAd_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txtAraSoyad_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void chkAd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAd.Checked == true)
            {
                txtAraAd.Enabled = true;
                txtAraAd.Focus();
            }
            else
            {
                txtAraAd.Clear();
                txtAraAd.Enabled = false;
            }
        }

        private void chkSoyad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSoyad.Checked == true)
            {
                txtAraSoyad.Enabled = true;
                txtAraSoyad.Focus();
            }
            else
            {
                txtAraSoyad.Clear();
                txtAraSoyad.Enabled = false;
            }
        }

        public void KayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * From Personel";
                string SorguAd = "Select * From Personel Where Ad ='"+ txtAraAd.Text +"'";
                string SorguSoyad = "Select * From Personel Where Soyad='" + txtAraSoyad.Text + "'";
                string SorguAdSoyad = "Select * From Personel Where Soyad='"+txtAraSoyad.Text+"' And Ad='"+txtAraAd.Text+"'";
                string SorguBirimAd = "Select * From Personel Where Birim='" + cmbBirim.Text + "' And Ad='" + txtAraAd.Text + "'";
                string SorguBirimSoyad = "Select * From Personel Where Birim='" + cmbBirim.Text + "' And Soyad='" + txtAraSoyad.Text + "'";
                string SorguBirim = "Select * From Personel Where Birim='"+cmbBirim.Text+"'";

                if(chkSoyad.Checked == true && chkAd.Checked == true)
                {
                    SorguTum = SorguAdSoyad;
                }
                else if(chkBirim.Checked == true && chkAd.Checked == true)
                {
                    SorguTum = SorguBirimAd;
                }
                else if(chkBirim.Checked == true && chkSoyad.Checked == true)
                {
                    SorguTum = SorguBirimSoyad;
                }
                else if(chkAd.Checked == true)
                {
                    SorguTum = SorguAd;
                }
                else if(chkSoyad.Checked == true)
                {
                    SorguTum = SorguSoyad;
                }
                else if (chkBirim.Checked == true)
                {
                    SorguTum = SorguBirim;
                }

                SqlDataAdapter da = new SqlDataAdapter(SorguTum, baglanti);
                da.Fill(ds, "Personel");
                dataGridView1.DataSource = ds.Tables["Personel"];
                baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hatası");
            }

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void chkBirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBirim.Checked == true)
            {
                cmbBirim.Enabled = true;
                cmbBirim.Focus();
            }
            else
            {
                cmbBirim.Enabled = false;
            }
        }
    }
}
