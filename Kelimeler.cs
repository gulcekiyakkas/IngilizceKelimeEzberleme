using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İngilizceKelimeEzberleme
{
    public class Kelimeler//kelimeler için sınıf oluşturduk ve değişkenleri tanımladık.
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Anlam { get; set; }
        public bool EzberDurum { get; set; }
    }
}
