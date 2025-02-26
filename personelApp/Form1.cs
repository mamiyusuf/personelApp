using System.ComponentModel;
using System.Text.Json;

namespace personelApp
{
    public partial class Form1 : Form
    {
        BindingList<personel> liste = new();
        personel gosterilenPersonel;
        public Form1()
        {
            InitializeComponent();

            if (File.Exists("bilgiler.txt"))//dosya var mý?
            {
                string metin = File.ReadAllText("bilgiler.txt");

                var okunanListe = JsonSerializer.Deserialize<List<personel>>(metin);
                liste = new(okunanListe);//okunan listeyi binding liste koy
            }



            lbpersoneller.DataSource = liste;
            lbpersoneller.DisplayMember = "Ad";

        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (gosterilenPersonel == null)

                YeniEkle();



            else

                Guncelle();






        }
        void YeniEkle()
        {
            personel yeniPers = new();
            yeniPers.Ad = txtAd.Text;
            yeniPers.Soyad = txtSoyad.Text;
            yeniPers.Yas = Convert.ToInt32(txtYas.Text);
            yeniPers.Tel = txtTel.Text;
            yeniPers.Adres = txtAdres.Text;



            liste.Add(yeniPers);

            txtAd.Clear();
            txtSoyad.Clear();
            txtYas.Clear();
            txtTel.Clear();
            txtAdres.Clear();

            txtAd.Focus();



        }
        void Guncelle()
        {
            gosterilenPersonel.Ad = txtAd.Text;
            gosterilenPersonel.Soyad = txtSoyad.Text;
            gosterilenPersonel.Yas = Convert.ToInt32(txtYas.Text);
            gosterilenPersonel.Tel = txtTel.Text;
            gosterilenPersonel.Adres = txtAdres.Text;

            //Listeyi yenile
            liste.ResetBindings();
        }

        private void lbpersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            personel pers = lbpersoneller.SelectedItem as personel;
            if (pers != null)
            {
                txtAd.Text = pers.Ad;
                txtSoyad.Text = pers.Soyad;
                txtYas.Text = pers.Yas.ToString();
                txtTel.Text = pers.Tel;
                txtAdres.Text = pers.Adres;

                gosterilenPersonel = pers;

                pbyeni.Visible = false;//yeni personel deðil bu
            }

            else
            {
                gosterilenPersonel = null;
                pbyeni.Visible = true;//bu yeni personel
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            //Seçili personeli kaldýr, yani yeni personel ekleyeceðim
            lbpersoneller.SelectedIndex = -1;
            //alanlarý temizle
            txtAd.Clear();
            txtSoyad.Clear();
            txtYas.Clear();
            txtTel.Clear();
            txtAdres.Clear();
            //ilk kontrole TtxtAd odaklan
            txtAd.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = JsonSerializer.Serialize(liste);

            File.WriteAllText("bilgiler.txt", metin);

            MessageBox.Show("Bilgiler kayýt edildi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gosterilenPersonel != null)
            {
                DialogResult result = MessageBox.Show("Seçili personeli silmek istediğinize emin misiniz?",
                                                      "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    liste.Remove(gosterilenPersonel);
                    liste.ResetBindings(); // Listeyi güncelle ok
                    gosterilenPersonel = null;

                    // Alanları temizle
                    txtAd.Clear();
                    txtSoyad.Clear();
                    txtYas.Clear();
                    txtTel.Clear();
                    txtAdres.Clear();

                    MessageBox.Show("Personel başarıyla silindi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir personel seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
    }
}