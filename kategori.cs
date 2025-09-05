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
    public partial class kategori : Form
    {
        public kategori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-1A66CI4K;Initial Catalog=Stok_Takip;Integrated Security=True");
        bool durum;
        private void kategorikontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from kategori_bilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                if (textBox1.Text == read["kategori"].ToString() || textBox1.Text == "") 
                {
                    durum = false;

                }
            }
            baglanti.Close();
        }
        private void kategori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategorikontrol();
            if(durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kategori_bilgileri(kategori) values ('" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                
                MessageBox.Show("Kategori Eklendi.");
            }
            else
            {
                MessageBox.Show("Böyle Bir Kategori  Var.", "Utarı");
            }
            textBox1.Text = "";
        }
    }
}
