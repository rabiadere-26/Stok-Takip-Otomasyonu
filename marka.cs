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
    public partial class marka : Form
    {
        public marka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-1A66CI4K;Initial Catalog=Stok_Takip;Integrated Security=True");
        bool durum;
        private void markakontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from marka_bilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboBox1.Text==read["kategori"].ToString() && textBox1.Text == read["marka"].ToString() || comboBox1.Text=="" || textBox1.Text == "")
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
                comboBox1.Items.Add(read["kategori"].ToString());

            }
            baglanti.Close();
        }
        private void marka_Load(object sender, EventArgs e)
        {
            kategori_getir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            markakontrol();
            if(durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into marka_bilgileri(kategori,marka) values ('" + comboBox1.Text + "', '" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Marka Eklendi.");
            }
            else
            {
                MessageBox.Show("Böyle bir Kategori ve Marka Var.", "Uyarı");
            }
           
           
            textBox1.Text = "";
            comboBox1.Text = "";
           
        }
    }
}
