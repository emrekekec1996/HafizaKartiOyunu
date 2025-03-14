using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing; // Renk ayarlamak için gerekli

namespace HafizaKartiOyunu.UI
{
    public partial class Form1 : Form
    {
        private List<Button> kartButonlari = new List<Button>();
        private List<string> kartDegerleri;
        private Button ilkSecilenKart, ikinciSecilenKart;
        private int skor = 0;
        private int eslesmeSayisi = 0;
        private int toplamYanlisTahmin = 0; // Toplam yanlış tahmin sayacı

        public Form1()
        {
            InitializeComponent();
            KartlariOlustur();
            KartlariKaristir();
        }

        private void KartlariOlustur()
        {
            int x = 50, y = 100;
            for (int i = 0; i < 16; i++)
            {
                Button btn = new Button
                {
                    Size = new System.Drawing.Size(100, 100),
                    Location = new System.Drawing.Point(x, y),
                    Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold),
                    Text = "?",
                    BackColor = Color.LightGray // Varsayılan kart rengi
                };
                btn.Click += KartButonu_Click;
                kartButonlari.Add(btn);
                this.Controls.Add(btn);

                x += 120;
                if ((i + 1) % 4 == 0)
                {
                    x = 50;
                    y += 120;
                }
            }
        }

        private void KartlariKaristir()
        {
            string[] kartlar = { "A", "A", "B", "B", "C", "C", "D", "D",
                                 "E", "E", "F", "F", "G", "G", "H", "H" };

            kartDegerleri = kartlar.OrderBy(k => Guid.NewGuid()).ToList();
        }

        private void KartButonu_Click(object sender, EventArgs e)
        {
            if (toplamYanlisTahmin >= 8) return; // Eğer oyun kaybedildiyse kartlara basmayı engelle

            Button tiklananKart = sender as Button;
            int kartIndex = kartButonlari.IndexOf(tiklananKart);

            if (tiklananKart == null || tiklananKart == ilkSecilenKart) return;

            tiklananKart.Text = kartDegerleri[kartIndex];

            if (ilkSecilenKart == null)
            {
                ilkSecilenKart = tiklananKart;
            }
            else
            {
                ikinciSecilenKart = tiklananKart;
                this.Refresh();
                System.Threading.Tasks.Task.Delay(1000).Wait(); // Bekleme süresi

                if (ilkSecilenKart.Text == ikinciSecilenKart.Text)
                {
                    //Eşleşen kartların rengini **yeşil** yap
                    ilkSecilenKart.BackColor = Color.LightGreen;
                    ikinciSecilenKart.BackColor = Color.LightGreen;

                    skor += 10;
                    eslesmeSayisi++;
                    lblSkor.Text = "Skor: " + skor;
                    lblEslesmeSayisi.Text = "Eşleşme: " + eslesmeSayisi;
                    ilkSecilenKart.Enabled = false;
                    ikinciSecilenKart.Enabled = false;

                    //**Doğru bildiğimizde hata yapma sayısını 1 azaltalım
                    if (toplamYanlisTahmin > 0)
                    {
                        toplamYanlisTahmin--;
                    }
                }
                else
                {
                    ilkSecilenKart.Text = "?";
                    ikinciSecilenKart.Text = "?";
                    toplamYanlisTahmin++; // Yanlış tahmin sayısını artır

                    if (toplamYanlisTahmin >= 8)
                    {
                        MessageBox.Show("Maalesef kaybettiniz! 8 yanlış tahmin yaptınız. Kartlar açılıyor...", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TumKartlariAc();
                        return;
                    }
                }

                ilkSecilenKart = null;
                ikinciSecilenKart = null;
            }

            if (eslesmeSayisi == 8)
            {
                MessageBox.Show("Tebrikler! Tüm kartları eşleştirdiniz! Kartlar yeniden karıştırılıyor.", "Oyun Devam Ediyor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KartlariYenidenBaslat();
            }
        }


        private void BtnYenidenBaslat_Click(object sender, EventArgs e)
        {
            YenidenBaslat();
        }

        private void YenidenBaslat()
        {
            foreach (Button btn in kartButonlari)
            {
                btn.Text = "?";
                btn.Enabled = true;
                btn.BackColor = Color.LightGray; // Kartları eski rengine döndür
            }

            // **Skor ve Yanlış Tahmin Sayacı Sıfırlanıyor**
            skor = 0;
            eslesmeSayisi = 0;
            toplamYanlisTahmin = 0;
            ilkSecilenKart = null;
            ikinciSecilenKart = null;

            lblSkor.Text = "Skor: 0";
            lblEslesmeSayisi.Text = "Eşleşme: 0";

            KartlariKaristir();
        }


        private void KartlariYenidenBaslat()
        {
            foreach (Button btn in kartButonlari)
            {
                btn.Text = "?";
                btn.Enabled = true;
                btn.BackColor = Color.LightGray; // Kartları eski rengine döndür
            }

            eslesmeSayisi = 0;
            toplamYanlisTahmin = 0; // Hata sayacını sıfırla
            KartlariKaristir();
        }


        private void TumKartlariAc()
        {
            for (int i = 0; i < kartButonlari.Count; i++)
            {
                kartButonlari[i].Text = kartDegerleri[i];
                kartButonlari[i].BackColor = Color.Red; // Yanlış kartlar kırmızı olacak
            }
        }
    }
}
