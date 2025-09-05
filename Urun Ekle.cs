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
    public partial class Urun_Ekle : Form
    {
        public Urun_Ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-1A66CI4K;Initial Catalog=Stok_Takip;Integrated Security=TrueData Source=DESKTOP-QIG478R;Initial Catalog=Stok_Takip;Integrated Security=True");
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkod_no"].ToString() || txtBarkodNo.Text=="") 
                {
                    durum = false;

                }
            }
            baglanti.Close();
        }
        private void kategori_getir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from kategori_bilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());

            }
            baglanti.Close();
        }
        private void Urun_Ekle_Load(object sender, EventArgs e)
        {
            kategori_getir();
        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from marka_bilgileri where kategori='"+comboKategori.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());

            }
            baglanti.Close();
            
        }

        private void btnYeniUrunEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if(durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into urun(barkod_no,kategori,marka,urun_adi,miktari,alis_fiyati,satis_fiyatı,tarih) values (@barkod_no1,@kategori1,@marka1,@urun_adi1,@miktari1,@alis_fiyati1,@satis_fiyatı1,@tarih1)", baglanti);
                komut.Parameters.AddWithValue("@barkod_no1", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori1", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka1", comboMarka.Text);
                komut.Parameters.AddWithValue("@urun_adi1", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@miktari1", int.Parse(txtMiktari.Text));
                komut.Parameters.AddWithValue("@alis_fiyati1", double.Parse(txtAlisFiyati.Text));
                komut.Parameters.AddWithValue("@satis_fiyatı1", double.Parse(txtSatisFiyati.Text));
                komut.Parameters.AddWithValue("@tarih1", DateTime.Now.ToString());
                komut.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Ürün Eklendi.");
            }
            else
            {
                MessageBox.Show("Böyle bir barkod numarası var.");
            }
            
            comboMarka.Items.Clear();
            foreach(Control item in groupBox1.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
                if(item is ComboBox)
                {
                    item.Text = "";
                }
            }
            
        }

        private void barkodNotxt_TextChanged(object sender, EventArgs e)
        {
            if(barkodNotxt.Text=="")
            {
                lblmiktari.Text = "";
                foreach(Control item in groupBox2.Controls)
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun where barkod_no like '"+barkodNotxt.Text+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                kategoriTxt.Text = read["kategori"].ToString();
                markaTxt.Text = read["marka"].ToString();
                urunAdiTxt.Text = read["urun_adi"].ToString();
                miktariTxt.Text = read["miktari"].ToString();
                AlisFiyatiTxt.Text = read["alis_fiyati"].ToString();
                satisFiyatiTxt.Text = read["satis_fiyatı"].ToString();
               
            }
            baglanti.Close();
        }

        private void btnVarOlanUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktari=miktari+'"+int.Parse(miktariTxt.Text)+"' where barkod_no='"+barkodNotxt.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
                if (item is TextBox)
                {
                    item.Text = "";
                }
            MessageBox.Show("Var olan Ürüne Ekleme Yapıldı");
        }
    }
}
