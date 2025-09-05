
namespace Stok_Takip_Otomasyonu
{
    partial class urun_listele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.satisFiyatiTxt = new System.Windows.Forms.TextBox();
            this.AlisFiyatiTxt = new System.Windows.Forms.TextBox();
            this.miktariTxt = new System.Windows.Forms.TextBox();
            this.urunAdiTxt = new System.Windows.Forms.TextBox();
            this.markaTxt = new System.Windows.Forms.TextBox();
            this.kategoriTxt = new System.Windows.Forms.TextBox();
            this.barkodNotxt = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtBarkodnoAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combokategori = new System.Windows.Forms.ComboBox();
            this.combomarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMarkaGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(660, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(163, 321);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(161, 41);
            this.btnGuncelle.TabIndex = 24;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 293);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Satış Fiyatı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 261);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Alış Fiyatı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 229);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Miktarı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 197);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Ürün Adı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(101, 165);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Marka:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(89, 133);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Kategori:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 101);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Barkod Numarası:";
            // 
            // satisFiyatiTxt
            // 
            this.satisFiyatiTxt.Location = new System.Drawing.Point(163, 289);
            this.satisFiyatiTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.satisFiyatiTxt.Name = "satisFiyatiTxt";
            this.satisFiyatiTxt.Size = new System.Drawing.Size(160, 22);
            this.satisFiyatiTxt.TabIndex = 17;
            // 
            // AlisFiyatiTxt
            // 
            this.AlisFiyatiTxt.Location = new System.Drawing.Point(163, 257);
            this.AlisFiyatiTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AlisFiyatiTxt.Name = "AlisFiyatiTxt";
            this.AlisFiyatiTxt.Size = new System.Drawing.Size(160, 22);
            this.AlisFiyatiTxt.TabIndex = 18;
            // 
            // miktariTxt
            // 
            this.miktariTxt.Location = new System.Drawing.Point(163, 225);
            this.miktariTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.miktariTxt.Name = "miktariTxt";
            this.miktariTxt.Size = new System.Drawing.Size(160, 22);
            this.miktariTxt.TabIndex = 19;
            // 
            // urunAdiTxt
            // 
            this.urunAdiTxt.Location = new System.Drawing.Point(163, 193);
            this.urunAdiTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.urunAdiTxt.Name = "urunAdiTxt";
            this.urunAdiTxt.Size = new System.Drawing.Size(160, 22);
            this.urunAdiTxt.TabIndex = 20;
            // 
            // markaTxt
            // 
            this.markaTxt.Location = new System.Drawing.Point(163, 161);
            this.markaTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.markaTxt.Name = "markaTxt";
            this.markaTxt.ReadOnly = true;
            this.markaTxt.Size = new System.Drawing.Size(160, 22);
            this.markaTxt.TabIndex = 21;
            // 
            // kategoriTxt
            // 
            this.kategoriTxt.Location = new System.Drawing.Point(163, 129);
            this.kategoriTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kategoriTxt.Name = "kategoriTxt";
            this.kategoriTxt.ReadOnly = true;
            this.kategoriTxt.Size = new System.Drawing.Size(160, 22);
            this.kategoriTxt.TabIndex = 22;
            // 
            // barkodNotxt
            // 
            this.barkodNotxt.Location = new System.Drawing.Point(163, 97);
            this.barkodNotxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barkodNotxt.Name = "barkodNotxt";
            this.barkodNotxt.Size = new System.Drawing.Size(160, 22);
            this.barkodNotxt.TabIndex = 23;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(800, 27);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(161, 41);
            this.btnSil.TabIndex = 32;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtBarkodnoAra
            // 
            this.txtBarkodnoAra.Location = new System.Drawing.Point(231, 38);
            this.txtBarkodnoAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBarkodnoAra.Name = "txtBarkodnoAra";
            this.txtBarkodnoAra.Size = new System.Drawing.Size(197, 22);
            this.txtBarkodnoAra.TabIndex = 33;
            this.txtBarkodnoAra.TextChanged += new System.EventHandler(this.txtBarkodnoAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Barkod Numarsına Göre Ara:";
            // 
            // combokategori
            // 
            this.combokategori.FormattingEnabled = true;
            this.combokategori.Location = new System.Drawing.Point(455, 454);
            this.combokategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combokategori.Name = "combokategori";
            this.combokategori.Size = new System.Drawing.Size(160, 24);
            this.combokategori.TabIndex = 35;
            this.combokategori.SelectedIndexChanged += new System.EventHandler(this.combokategori_SelectedIndexChanged);
            // 
            // combomarka
            // 
            this.combomarka.FormattingEnabled = true;
            this.combomarka.Location = new System.Drawing.Point(455, 482);
            this.combomarka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combomarka.Name = "combomarka";
            this.combomarka.Size = new System.Drawing.Size(160, 24);
            this.combomarka.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 490);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 458);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Kategori:";
            // 
            // btnMarkaGuncelle
            // 
            this.btnMarkaGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMarkaGuncelle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkaGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnMarkaGuncelle.Location = new System.Drawing.Point(631, 446);
            this.btnMarkaGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            this.btnMarkaGuncelle.Size = new System.Drawing.Size(161, 65);
            this.btnMarkaGuncelle.TabIndex = 39;
            this.btnMarkaGuncelle.Text = "MARKA GÜNCELLE";
            this.btnMarkaGuncelle.UseVisualStyleBackColor = false;
            this.btnMarkaGuncelle.Click += new System.EventHandler(this.btnMarkaGuncelle_Click);
            // 
            // urun_listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnMarkaGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combomarka);
            this.Controls.Add(this.combokategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkodnoAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.satisFiyatiTxt);
            this.Controls.Add(this.AlisFiyatiTxt);
            this.Controls.Add(this.miktariTxt);
            this.Controls.Add(this.urunAdiTxt);
            this.Controls.Add(this.markaTxt);
            this.Controls.Add(this.kategoriTxt);
            this.Controls.Add(this.barkodNotxt);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "urun_listele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.urun_listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox satisFiyatiTxt;
        private System.Windows.Forms.TextBox AlisFiyatiTxt;
        private System.Windows.Forms.TextBox miktariTxt;
        private System.Windows.Forms.TextBox urunAdiTxt;
        private System.Windows.Forms.TextBox markaTxt;
        private System.Windows.Forms.TextBox kategoriTxt;
        private System.Windows.Forms.TextBox barkodNotxt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtBarkodnoAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combokategori;
        private System.Windows.Forms.ComboBox combomarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMarkaGuncelle;
    }
}