using System;
using System.Windows.Forms;
using System.Data;
using KotaTakip_BLL;

namespace KotaTakipSistemi.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TabloyuYenile();
            ElementleriDoldur();
        }

      
        private void TabloyuYenile()
        {
            try
            {
                AboneBLL aboneBll = new AboneBLL();
                dgvAboneler.DataSource = aboneBll.AboneListeleBLL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tablo yüklenirken hata oluştu: " + ex.Message);
            }
        }

     
        private void ElementleriDoldur()
        {
            try
            {
                AboneBLL aboneBll = new AboneBLL();

                
                DataTable dtAboneler = aboneBll.HatIcinAboneListeleBLL();
                cmbAboneler.DataSource = dtAboneler;
                cmbAboneler.DisplayMember = "Ad";
                cmbAboneler.ValueMember = "AboneID";

               
                DataTable dtPaketler = new DataTable();
                dtPaketler.Columns.Add("PaketAdi", typeof(string));
                dtPaketler.Columns.Add("PaketID", typeof(int));

                dtPaketler.Rows.Add("20 GB İnternet Paketi", 1);
                dtPaketler.Rows.Add("50 GB İnternet Paketi", 2);
                dtPaketler.Rows.Add("100 GB İnternet Paketi", 3);

                cmbPaketler.DataSource = dtPaketler;
                cmbPaketler.DisplayMember = "PaketAdi";
                cmbPaketler.ValueMember = "PaketID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seçim kutuları doldurulurken hata: " + ex.Message);
            }
        }

       
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                AboneBLL aboneBll = new AboneBLL();
                bool sonuc = aboneBll.AboneEkleBLL(txtAd.Text, txtSoyad.Text, txtTckn.Text, txtTelefon.Text, txtEmail.Text);

                if (sonuc)
                {
                    MessageBox.Show("Abone başarıyla sisteme eklendi!");
                    TabloyuYenile();
                    ElementleriDoldur();
                    txtAd.Clear(); txtSoyad.Clear(); txtTckn.Clear(); txtTelefon.Clear(); txtEmail.Clear();
                }
                else
                {
                    MessageBox.Show("Hata! Lütfen alanları kontrol edin (TCKN 11 hane olmalıdır).");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem Hatası: " + ex.Message);
            }
        }

        
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAboneler.CurrentRow != null)
                {
                    int seciliAboneId = Convert.ToInt32(dgvAboneler.CurrentRow.Cells["AboneID"].Value);
                    DialogResult onay = MessageBox.Show("Bu aboneyi silmek istediğinize emin misiniz?", "Abone Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (onay == DialogResult.Yes)
                    {
                        AboneBLL aboneBll = new AboneBLL();
                        bool sonuc = aboneBll.AboneSilBLL(seciliAboneId);

                        if (sonuc)
                        {
                            MessageBox.Show("Abone başarıyla sistemden silindi!");
                            TabloyuYenile();
                            ElementleriDoldur();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz aboneyi tablodan seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }

       
        private void btnHatTanimla_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("SİSTEM BİLGİSİ: Buton bağlantısı çalışıyor, kod tetiklendi!");

            try
            {
                // 2. AŞAMA: Kutular boş mu kalıyor testi
                if (cmbAboneler.SelectedValue == null)
                {
                    MessageBox.Show("HATA: Abone seçilmemiş veya ComboBox arkada ID'yi yakalayamıyor!");
                    return; // İşlemi durdur
                }

                if (cmbPaketler.SelectedValue == null)
                {
                    MessageBox.Show("HATA: Paket seçilmemiş!");
                    return; 
                }

                int aboneId = Convert.ToInt32(cmbAboneler.SelectedValue);
                int paketId = Convert.ToInt32(cmbPaketler.SelectedValue);
                string rastgeleIP = "192.168.1." + new Random().Next(2, 254);

                AboneBLL aboneBll = new AboneBLL();
                aboneBll.HatTanimlaBLL(aboneId, paketId, rastgeleIP);

                MessageBox.Show($"BAŞARILI! Aboneye {rastgeleIP} IP adresiyle hat tanımlandı!");
                TabloyuYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hat tanımlanırken arka planda hata oluştu: " + ex.Message);
            }
        }

 

        private void btnKotaHarca_Click(object sender, EventArgs e)
        {
  
            MessageBox.Show("SİSTEM BİLGİSİ: Kota Harca butonu bağlantısı çalışıyor, kod tetiklendi!");

            try
            {
          
                if (string.IsNullOrWhiteSpace(txtHarcananMB.Text))
                {
                    MessageBox.Show("HATA: Lütfen harcanacak internet miktarını MB cinsinden kutuya yazın!");
                    return; 
                }

                if (dgvAboneler.CurrentRow == null)
                {
                    MessageBox.Show("HATA: Lütfen tablodan işlem yapmak (kota düşmek) istediğiniz abonenin satırına tıklayıp seçin!");
                    return; 
                }

                int harcanan = Convert.ToInt32(txtHarcananMB.Text);
                int aboneId = Convert.ToInt32(dgvAboneler.CurrentRow.Cells["AboneID"].Value);

                AboneBLL aboneBll = new AboneBLL();
                aboneBll.KullanimEkleBLL(aboneId, harcanan);

                MessageBox.Show($"BAŞARILI! Abonenin hattından {harcanan} MB düşüldü ve kalan kota güncellendi!");

           
                TabloyuYenile();
                txtHarcananMB.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("HATA: Lütfen harcanan MB kısmına sadece rakam girin (Örn: 5000). Harf veya boşluk kullanmayın!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kota harcanırken arka planda hata oluştu: " + ex.Message);
            }
        }

 
    }
}