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
    public partial class musteriListeleme : Form
    {
        public musteriListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-1A66CI4K;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void musteriListeleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stok_TakipDataSet1.Musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.musteriTableAdapter1.Fill(this.stok_TakipDataSet1.Musteri);
            // TODO: Bu kod satırı 'stok_TakipDataSet.Musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.musteriTableAdapter.Fill(this.stok_TakipDataSet.Musteri);
            Kayıt_Göster();
        }

        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from Musteri", baglanti);
            adtr.Fill(daset, "Musteri");
            dataGridView1.DataSource = daset.Tables["Musteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtTc1.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad1.Text = dataGridView1.CurrentRow.Cells["ad_soyad"].Value.ToString();
            txtTelefon1.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres1.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtEmail1.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update  Musteri set ad_soyad=@ad_soyad, telefon=@telefon, adres=@adres, email=@email where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc1.Text);
            komut.Parameters.AddWithValue("@ad_soyad", txtAdSoyad1.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon1.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres1.Text);
            komut.Parameters.AddWithValue("@email", txtEmail1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Musteri"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Müşteri Kaydı Başarı İle Güncellendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Musteri where tc='"+dataGridView1.CurrentRow.Cells["tc"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Musteri"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Kayıt Başarı İle Silinmiştir.");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select* from Musteri where tc like '%"+txtTcAra.Text+"%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
