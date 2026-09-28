using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotKayit
{
    public partial class ÖğrenciNotKayıt : Form
    {
        public ÖğrenciNotKayıt()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public void buttonHesapla_Click(object sender, EventArgs e)
        {
            int not1 = Convert.ToInt32(textSınavBir.Text);
            int not2 = Convert.ToInt32(textSınavİki.Text);
            int not3 = Convert.ToInt32(textSınavÜç.Text);

            if(not1>100||not2>100 || not3 > 100)
            {
                textDurum.Text = "100 den büyük not girişi yapma!";
            }
            else
            {

            
            int hesap = (not1 + not2 + not3) / 3;

            textOrt.Text = hesap.ToString();

            if (hesap >= 50)
            {
                textDurum.Text = "Geçti";
            }

            else
            {
                textDurum.Text = "Kaldı";
            }
            }
        }

        private void textSınavBir_TextChanged(object sender, EventArgs e)
        {

        }

        private void textOrt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDurum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxDers.Items.Clear();
            if (comboBoxSınıf.SelectedItem.ToString() == "9.Sınıf")
            {
                comboBoxDers.Items.Add("Edebiyat");
                comboBoxDers.Items.Add("Matematik");
                comboBoxDers.Items.Add("İngilizce");
                comboBoxDers.Items.Add("Fizik");
                comboBoxDers.Items.Add("Kimya");
                comboBoxDers.Items.Add("Biyoloji");
                comboBoxDers.Items.Add("Beden Eğitimi");
                comboBoxDers.Items.Add("Din Kültürü ve Ahlak Bilgisi");
                comboBoxDers.Items.Add("Almanca");
                comboBoxDers.Items.Add("Tarih");
            }

            else if (comboBoxSınıf.SelectedItem.ToString() == "10.Sınıf")
            {
                comboBoxDers.Items.Add("Edebiyat");
                comboBoxDers.Items.Add("Matematik");
                comboBoxDers.Items.Add("İngilizce");
                comboBoxDers.Items.Add("Fizik");
                comboBoxDers.Items.Add("Kimya");
                comboBoxDers.Items.Add("Biyoloji");
                comboBoxDers.Items.Add("Beden Eğitim");
                comboBoxDers.Items.Add("Felsefe");
                comboBoxDers.Items.Add("Din Kültürü ve Ahlak Bilgisi");
                comboBoxDers.Items.Add("Tarih");
            }

            else if (comboBoxSınıf.SelectedItem.ToString() == "11.Sınıf")
            {
                comboBoxDers.Items.Add("Edebiyat");
                comboBoxDers.Items.Add("Matematik");
                comboBoxDers.Items.Add("Yabancı Dil");
                comboBoxDers.Items.Add("Fizik");
                comboBoxDers.Items.Add("Kimya");
                comboBoxDers.Items.Add("Sağlık Bilgisi");
                comboBoxDers.Items.Add("Beden Eğitim");
                comboBoxDers.Items.Add("Felsefe");
                comboBoxDers.Items.Add("Din Kültürü ve Ahlak Bilgisi");
                comboBoxDers.Items.Add("Tarih");
            }

            else if (comboBoxSınıf.SelectedItem.ToString() == "12.Sınıf")

            {
                comboBoxDers.Items.Add("Edebiyat");
                comboBoxDers.Items.Add("Matematik");
                comboBoxDers.Items.Add("Yabacı Dil");
                comboBoxDers.Items.Add("Fizik");
                comboBoxDers.Items.Add("Kimya");
                comboBoxDers.Items.Add("Biyoloji");
                comboBoxDers.Items.Add("Beden Eğitim");
                comboBoxDers.Items.Add("Felsefe");
                comboBoxDers.Items.Add("Din Kültürü ve Ahlak Bilgisi");
                comboBoxDers.Items.Add("İnkilap Tarihi");
            }
        }

        private void comboBoxSınıf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (textDurum.Text == "" && textOrt.Text=="") {
                MessageBox.Show("Lütfen ortalama ve durumu hesaplattıktan sonra bu işlemi yapın", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                
                string adsoy = textAdSoyad.Text;
                string no = maskedTextBox1.Text;
                string ders = comboBoxDers.Text;

                listBox1.Items.Add($"{adsoy} , {no} İsimli ve numaralı öğrencinin dersi:{comboBoxDers.SelectedItem.ToString()} ders ortalaması: {textOrt.Text} Geçme durumu: {textDurum.Text} ");
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        int sayac = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            sayac++;
            label11.Text = sayac.ToString();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textAdSoyad.Text = "";
            textDurum.Text = "";
            maskedTextBox1.Text = "";
            textSınavBir.Text = "";
            textSınavİki.Text = "";
            textSınavÜç.Text = "";
            textOrt.Text = "";

            comboBoxSınıf.SelectedIndex = -1;
            comboBoxDers.SelectedIndex = -1;
            textAdSoyad.Focus();
        }

        private void buttonMesaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya","Mesaj Kutusu",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation); // mesaj,başlık,tuş,ikon
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonFor_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i < 10; i++)
            {
                listBox2.Items.Add(i+"-Merhaba");
            }
        }

        private void buttonFor2_Click(object sender, EventArgs e)
        {
            for (int a = 1; a < 21; a++)
            {
                listBox2.Items.Add(a);
            }

        }

        private void buttonTemiz_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear(); //listboxu temizlemek için kullanılır.
        }

        private void buttonWhile_Click(object sender, EventArgs e)
        {
            int s = 0;
            while (s <= 9)
            {
                s++;
                listBox2.Items.Add(s+"Araba");
            }
        }

        private void buttonDizi_Click(object sender, EventArgs e)
        {
            string[] sehirler = {"İstanbul", "Ankara", "İzmir"}; //dizi oluşturma
            listBox2.Items.Add(sehirler[0]); 
        }

        private void buttonDizi2_Click(object sender, EventArgs e)
        {
            int[] sayı = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            foreach(int sayılar in sayı)
            {
                listBox2.Items.Add(sayılar);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textSınavİki_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
