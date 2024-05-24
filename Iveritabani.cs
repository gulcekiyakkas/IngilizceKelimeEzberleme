using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İngilizceKelimeEzberleme
{
    internal interface Iveritabani//veri tabanı interface ile metotları tanımladık
    {
        void Baglan();
        void Listele();
        void Ekle(Kelimeler eklenecek);
        void Ara(Kelimeler aranan);
        void Guncelle(Kelimeler eski, Kelimeler yeni);
        void Sil(Kelimeler silinecek);
    }
}
