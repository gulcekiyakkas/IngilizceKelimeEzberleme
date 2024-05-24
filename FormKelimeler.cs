using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İngilizceKelimeEzberleme
{
    public partial class FormKelimeler : Form
    {
        VeriTabanı veriTabanı;
        public FormKelimeler()
        {
            InitializeComponent();
            veriTabanı = new VeriTabanı(dataGridView1);
        }
         
        private void FormKelimeler_Load(object sender, EventArgs e)
        {
            veriTabanı.Listele();
        }
        public void TemizleTextBox(Control kontrol)
        {
            foreach (Control child in kontrol.Controls)
            {
                if (child is TextBox)
                {
                    (child as TextBox).Text = "";
                }
                else
                {
                    TemizleTextBox(child);
                }
            }
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            panelButon.Visible = false;
            panelEkle.Visible = true;
        }

        private void btnEkleOnay_Click_1(object sender, EventArgs e)
        {
            //TODO: Veritabanına Yeni Kelime Ekle
            Kelimeler eklenecek = new Kelimeler();
            eklenecek.Ad = txtEkleAd.Text;
            eklenecek.Anlam = txtEkleAnlam.Text;


            veriTabanı.Ekle(eklenecek);

            dataGridView1.Visible = true;
            panelButon.Visible = true;
            panelEkle.Visible = false;
            TemizleTextBox(this);
        }

        private void btnEkleIptal_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            panelButon.Visible = true;
            panelEkle.Visible = false;
            TemizleTextBox(this);
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            panelButon.Visible = false;
            silPanel.Visible = true;
        }

        private void silOnaybtn_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: Veritabanından Sil
                Kelimeler silinecek = new Kelimeler();
                silinecek.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                veriTabanı.Sil(silinecek);

                panelButon.Visible = true;
                silPanel.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşleminde Bir Hata Oluştu.");
            }
        }

        private void silIptalbtn_Click(object sender, EventArgs e)
        {
            panelButon.Visible = true;
            silPanel.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GoruntuleBtn_Click(object sender, EventArgs e)
        {
            veriTabanı.Listele();
        }
    }
}
