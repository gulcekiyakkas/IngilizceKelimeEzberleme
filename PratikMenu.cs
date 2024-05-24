using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   // kullanıcı giriş kısmı - KELİME DEPOSUNDA KALDIK EN SON
using System.Windows.Forms;

namespace İngilizceKelimeEzberleme
{
    public partial class PratikMenu : Form
    {
        VeriTabanı veriTabanı;
        bool Aktiflik = false;
        public PratikMenu()
        {
            InitializeComponent();
            veriTabanı = new VeriTabanı();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aktiflik = true;
            // Veritabanındaki Öğrenilmemiş Kelimelerden Rastgele Kelime Seç
            veriTabanı.RastgeleGetir(this.IngTxt);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KontrolBtn_Click(object sender, EventArgs e)
        {
            // Kelimenin Anlamı İcin Verilen Cevabı Kontrol Et
            bool durum = true;
            if (Aktiflik == false)
            {
                MessageBox.Show("Önce Çalışmayı Başlatmalısın.");
            }
            else
            {
                durum = veriTabanı.Dogrula(IngTxt.Text.Trim().ToString(), trTxt.Text.Trim().ToString());

                if (durum == true)
                {
                    MessageBox.Show("Tekrar Denemelisin. İyi Düşün.");
                }
                else
                {
                    veriTabanı.DurumGuncelle(IngTxt.Text.ToString());
                    MessageBox.Show("Tebrikler! Devam Et.");
                    trTxt.Clear();
                    veriTabanı.RastgeleGetir(IngTxt);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Aktiflik == false)
            {
                MessageBox.Show("Önce Çalışmaya Başlamalısın.");
            }
            else
            {
                veriTabanı.RastgeleGetir(this.IngTxt);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Aktiflik == false)
            {
                MessageBox.Show("Önce Çalışmayı Başlatmalısın.");
            }
            else
            {
                MessageBox.Show("Seni Bekliyoruz. Çok Ara Verme.");
                Aktiflik = false;
                IngTxt.Clear();
                trTxt.Clear();
                this.Close();
            }
        }
    }
}
