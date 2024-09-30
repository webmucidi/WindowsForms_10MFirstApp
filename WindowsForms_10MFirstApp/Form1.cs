using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_10MFirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Değişkenleri global olarak tanımladık.
        string ad, meslek;
        byte yas;
        private void buttonBaslat_Click(object sender, EventArgs e)
        {
            //Değişkenlere veri aktardık.
            ad = textBoxAdSoyad.Text;
            meslek = comboBoxMeslek.SelectedText;
            yas = Convert.ToByte(textBoxYas.Text);

            //Hesaplamaları/işlemleri yaptık.
            if (yas <15) {
                int yasFarki = 15 - yas;
                MessageBox.Show("Büyü de gel! " + ad+" yani "+yasFarki +" yıl sonra!");
            }
            else
            {
                if (comboBoxMeslek.SelectedIndex == 0)
                {
                    listBoxOgretmen.Items.Add(ad + meslek + yas);
                }
                else if (comboBoxMeslek.SelectedIndex == 1)
                {
                    listBoxIdareciler.Items.Add(ad + meslek + yas);
                }
                else if (comboBoxMeslek.SelectedIndex == 2)
                {
                    listBoxPersonel.Items.Add(ad + meslek + yas);
                }
                else if (comboBoxMeslek.SelectedIndex == 3)
                {
                    listBoxOgrenciler.Items.Add(ad + meslek + yas);
                }   
            }
            //Sonucu yazdırdık.
            for (int i = 0; i < 5; i++) {
                labelSonuc.Text = labelSonuc.Text + ad;
            }
                     
        }
    }
}
