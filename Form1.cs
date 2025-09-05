using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Stok_Takip_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-1A66CI4K;Initial Catalog=Stok_Takip;Integrated Security=TrueData Source=LAPTOP-1A66CI4K;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from sepet", baglanti);
            adtr.Fill(daset,"sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            urun_listele list = new urun_listele();
            list.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            musteriListeleme listele = new musteriListeleme();
            listele.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Urun_Ekle ekle = new Urun_Ekle();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategori kat = new kategori();
            kat.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            marka mark = new marka();
            mark.ShowDialog();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplam_fiyati) from sepet", baglanti);
                lblgeneltoplam.Text = komut.ExecuteScalar() + "TL";
                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if(txtTc.Text=="")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from Musteri where tc like '" + txtTc.Text + "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                txtAdSoyad.Text = read["ad_soyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from urun where barkod_no like '" + txtBarkodNo.Text + "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtUrunAdi.Text = read["urun_adi"].ToString();
                txtSatisFiyati.Text = read["satis_fiyatı"].ToString();
            }
            baglanti.Close();
        }

        private void temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtUrunMiktari)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkod_no"].ToString()) 
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(tc,ad_soyad,telefon,barkod_no,urun_adi,miktari,satis_fiyati,toplam_fiyati,tarih)values(@tc,@ad_soyad,@telefon,@barkod_no,@urun_adi,@miktari,@satis_fiyati,@toplam_fiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("tc", txtTc.Text);
                komut.Parameters.AddWithValue("ad_soyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("barkod_no", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("urun_adi", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("miktari", int.Parse(txtUrunMiktari.Text));
                komut.Parameters.AddWithValue("satis_fiyati", double.Parse(txtSatisFiyati.Text));
                komut.Parameters.AddWithValue("toplam_fiyati", double.Parse(txtToplamFiyat.Text));
                komut.Parameters.AddWithValue("tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update sepet miktari=miktari+'"+int.Parse(txtUrunMiktari.Text)+ "' where barkod_no='" + txtBarkodNo.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update sepet toplam_fiyati=miktari*satis_fiyati where barkod_no='"+txtBarkodNo.Text+"'", baglanti);
                komut3.ExecuteNonQuery();

                baglanti.Close();
            }

            
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtUrunMiktari)
                    {
                        item.Text = "";
                    }
                }

            }
        }

        private void txtUrunMiktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtUrunMiktari.Text) * double.Parse(txtSatisFiyati.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtSatisFiyati_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtUrunMiktari.Text) * double.Parse(txtSatisFiyati.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkod_no='"+dataGridView1.CurrentRow.Cells["barkod_no"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
           
            MessageBox.Show("Ürün Sepetten Çıkarıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnSatisİptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
            MessageBox.Show("Ürünler Sepetten Çıkarıldı.");
            daset.Tables["sepet"].Clear();
           
            sepetlistele();
            hesapla();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            satis_listeleme satlist = new satis_listeleme();
            satlist.ShowDialog();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                 baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satis(tc,ad_soyad,telefon,barkod_no,urun_adi,miktari,satis_fiyati,toplam_fiyati,tarih)values(@tc,@ad_soyad,@telefon,@barkod_no,@urun_adi,@miktari,@satis_fiyati,@toplam_fiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("tc", txtTc.Text);
                komut.Parameters.AddWithValue("ad_soyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("barkod_no", dataGridView1.Rows[i].Cells["barkod_no"].Value.ToString());
                komut.Parameters.AddWithValue("urun_adi", dataGridView1.Rows[i].Cells["urun_adi"].Value.ToString());
                komut.Parameters.AddWithValue("miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("satis_fiyati", double.Parse(dataGridView1.Rows[i].Cells["satis_fiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("toplam_fiyati", double.Parse(dataGridView1.Rows[i].Cells["toplam_fiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                
                
                SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' where barkod_no='" + dataGridView1.Rows[i].Cells["barkod_no"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
             

            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
