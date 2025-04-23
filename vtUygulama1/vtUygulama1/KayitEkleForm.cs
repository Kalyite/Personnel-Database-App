using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vtUygulama1
{
    public partial class KayitEkleForm : Form
    {
        public KayitEkleForm()
        {
            InitializeComponent();
        }

        public void KayitEkle()
        {
            try
            {
                Form1.BaglantiAc();

                string Sorgu = "Insert Into Personel (TC,Ad,Soyad,Cinsiyet,Birim,DogumY,DogumT,Tel) Values (@TC,@Ad,@Soyad,@Cinsiyet,@Birim,@DogumY,@DogumT,@Tel)";

                SqlCommand EkleKomut = new SqlCommand(Sorgu, Form1.baglanti);

                EkleKomut.Parameters.AddWithValue("@TC", txtTcNo.Text);

                EkleKomut.Parameters.AddWithValue("@Ad", txtAd.Text);

                EkleKomut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);

                if(radErkek.Checked == true) 
                {
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", "Erkek");
                }
                else if (radKadin.Checked == true)
                {
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", "Kadın");
                }

                EkleKomut.Parameters.AddWithValue("@Birim", cmbBirim.Text);

                EkleKomut.Parameters.AddWithValue("@DogumY", cmbDyeri.Text);

                EkleKomut.Parameters.AddWithValue("DogumT", dTarih.Value);

                EkleKomut.Parameters.AddWithValue("@Tel", txtTel.Text);

                if (EkleKomut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt Eklendi", "Veri Girişi");
                }

                Form1.baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Hatası");
            }
        }

        public bool BoslukKontrol()
        {
            bool bos = false; //bos alan yok

            txtSoyad.BackColor = Color.White;

            txtTcNo.BackColor = Color.White;

            txtAd.BackColor = Color.White;

            lblHata.Visible = false;

            cmbBirim.BackColor = Color.White;

            cmbDyeri.BackColor = Color.White;

            txtTel.BackColor = Color.White;

            lbltrh.Visible = false;

            if (txtTel.Text.Length < 14)
            {
                txtTel.BackColor = Color.Red;
                txtTel.Focus();
                bos = true;
            }

            if(dTarih.Value.Date == DateTime.Today.Date)
            {
                lbltrh.Visible = true;
                bos = true;
            }
            
            if(cmbBirim.Text == "" || cmbBirim.Text == "Birim Seçiniz")
            {
                cmbBirim.BackColor = Color.Red;
                cmbBirim.Focus();
                bos = true;
            }

            if (cmbDyeri.Text == "" || cmbDyeri.Text == "Şehir Seçiniz")
            {
                cmbBirim.BackColor = Color.Red;
                cmbDyeri.Focus();
                bos = true;
            }

            if (txtTcNo.Text.Length < 11)
            {
                txtTcNo.BackColor = Color.Red;
                txtTcNo.Focus();
                bos = true;
            }

            if (txtAd.Text == "")
            {
                txtAd.BackColor = Color.Red;
                txtAd.Focus();
                bos = true;
            }

            if (txtSoyad.Text == "")
            {
                txtSoyad.BackColor = Color.Red;
                txtSoyad.Focus();
                bos = true;
            }

            if(radErkek.Checked == false && radKadin.Checked == false)
            {
                lblHata.Visible = true;
                lblHata.Focus();
                bos = true;
            }

            return bos;
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            if(BoslukKontrol()==true)
                MessageBox.Show("İşaretli Alanlar Boş Bırakılamaz","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Information);

            KayitEkle();
        }
    }
}
