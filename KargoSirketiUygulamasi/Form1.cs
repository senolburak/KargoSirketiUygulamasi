using KargoSirketiUygulamasi.Data;

namespace KargoSirketiUygulamasi
{
    public partial class Form1 : Form
    {
        Nakliyat nakliyat = new Nakliyat();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNoEkle_Click(object sender, EventArgs e)
        {
            try
            {
                KargoSirketi kargoSirketi = new KargoSirketi();
                kargoSirketi.DagitimaCikar += nakliyat.KargoyuTasi;
                kargoSirketi.KargoNo = txtKargo.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
