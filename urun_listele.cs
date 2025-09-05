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
    public partial class urun_listele : Form
    {
        public urun_listele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-1A66CI4K;Initial Catalog=Stok_Takip;Integrated Security=TrueData Source=DESKTOP-QIG478R;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void kategori_getir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from kategori_bilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combokategori.Items.Add(read["kategori"].ToString());

            }
            baglanti.Close();
        }
        private void urun_listele_Load(object sender, EventArgs e)
        {
            UrunListele();
            kategori_getir();
        }

        private void UrunListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from urun ", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            barkodNotxt.Text = dataGridView1.CurrentRow.Cells["barkod_no"].Value.ToString();
            kategoriTxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            markaTxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            urunAdiTxt.Text = dataGridView1.CurrentRow.Cells["urun_adi"].Value.ToString();
            miktariTxt.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            AlisFiyatiTxt.Text = dataGridView1.CurrentRow.Cells["alis_fiyati"].Value.ToString();
            satisFiyatiTxt.Text = dataGridView1.CurrentRow.Cells["satis_fiyatı"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set urun_adi=@urun_adi, miktari=@miktari, alis_fiyati=@alis_fiyati, satis_fiyatı=@satis_fiyatı where barkod_no=@barkod_no",baglanti);
            komut.Parameters.AddWithValue("@barkod_no", barkodNotxt.Text);
            komut.Parameters.AddWithValue("@urun_adi", urunAdiTxt.Text);
            komut.Parameters.AddWithValue("@miktari",int.Parse (miktariTxt.Text));
            komut.Parameters.AddWithValue("@alis_fiyati",double.Parse (AlisFiyatiTxt.Text));
            komut.Parameters.AddWithValue("@satis_fiyatı",double.Parse (satisFiyatiTxt.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            UrunListele();
            MessageBox.Show("Güncelleme Yapıldı.");
            foreach(Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
           if(barkodNotxt.Text!="")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori, marka=@marka where barkod_no=@barkod_no", baglanti);
                komut.Parameters.AddWithValue("@barkod_no", barkodNotxt.Text);
                komut.Parameters.AddWithValue("@kategori", combokategori.Text);
                komut.Parameters.AddWithValue("@marka", combomarka.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme Yapıldı.");
                daset.Tables["urun"].Clear();
                UrunListele();
            }
           else
            {
                MessageBox.Show("Barkod Numarası Yazılı Değil.");
            }
            
      
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void combokategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            combomarka.Items.Clear();
            combomarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from marka_bilgileri where kategori='" + combokategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combomarka.Items.Add(read["marka"].ToString());

            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where barkod_no='" + dataGridView1.CurrentRow.Cells["barkod_no"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            UrunListele();
            MessageBox.Show("Kayıt Başarı İle Silinmiştir.");
        }

        private void txtBarkodnoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select* from urun where barkod_no like '%" + txtBarkodnoAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
    }
 
