
namespace İngilizceKelimeEzberleme
{
    public partial class AnaMenuForm : Form
    {
        public AnaMenuForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PratikMenu Pratik = new PratikMenu();
            Pratik.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormKelimeler KelimeIslemleri = new FormKelimeler();
            KelimeIslemleri.Show();
        }
    }
}