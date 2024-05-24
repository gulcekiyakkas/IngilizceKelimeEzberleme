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

namespace İngilizceKelimeEzberleme
{
    public partial class FormKullanıcıKayıtGiris : Form
    {
        SqlConnection sql;
        VeriTabanı veritabani;
        public FormKullanıcıKayıtGiris()
        {
            InitializeComponent();
            veritabani = new VeriTabanı();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kaydolBtn_Click(object sender, EventArgs e)
        {
            KytOlpanel.Visible = true;
        }

        private void KytKayıt_Click(object sender, EventArgs e)
        {
            KullaniciBilgileri eklenecek = new KullaniciBilgileri();
            eklenecek.KullaniciAdi = kytKullaniciAdi.Text;
            if (KytSifre.Text == KytSifreTkr.Text)
            {
                eklenecek.Sifre = KytSifre.Text;
                veritabani.Kaydol(eklenecek);
                MessageBox.Show("Başarıyla kaydoldunuz lütfen giriş yapınız.");
                KytOlpanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Sifre girişleri uyuşmuyor lütfen tekrar giriniz.");
            }

        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
         if( veritabani.Giris(KullaniciAdi.Text,Sifre.Text))
            {
                AnaMenuForm anamenu = new AnaMenuForm();
                anamenu.Show();
                this.Hide();    
            }
         else
            {
                MessageBox.Show("Hatalı giriş yaptınız lütfen tekrar deneyin.");
            }


        }

        private void KytSifre_TextChanged(object sender, EventArgs e)
        {

        }
        private void KytSifreTkr_TextChanged(object sender, EventArgs e)
        {
            
        }
       
    }
}
