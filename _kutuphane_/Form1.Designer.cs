namespace _kutuphane_
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskSayfa = new System.Windows.Forms.MaskedTextBox();
            this.mskBaskiYil = new System.Windows.Forms.MaskedTextBox();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.cmbDil = new System.Windows.Forms.ComboBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtKitapİd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapSayfaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapDilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYayinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKutuphaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Kutuphane_DataSet1 = new _kutuphane_.Tbl_Kutuphane_DataSet1();
            this.tbl_Kutuphane_TableAdapter = new _kutuphane_.Tbl_Kutuphane_DataSet1TableAdapters.Tbl_Kutuphane_TableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKutuphaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Kutuphane_DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Controls.Add(this.mskSayfa);
            this.groupBox1.Controls.Add(this.mskBaskiYil);
            this.groupBox1.Controls.Add(this.txtYayinEvi);
            this.groupBox1.Controls.Add(this.cmbDil);
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.txtKitapİd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 366);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri :";
            // 
            // mskSayfa
            // 
            this.mskSayfa.Location = new System.Drawing.Point(140, 219);
            this.mskSayfa.Mask = "00000";
            this.mskSayfa.Name = "mskSayfa";
            this.mskSayfa.Size = new System.Drawing.Size(135, 32);
            this.mskSayfa.TabIndex = 15;
            this.mskSayfa.ValidatingType = typeof(int);
            // 
            // mskBaskiYil
            // 
            this.mskBaskiYil.Location = new System.Drawing.Point(140, 170);
            this.mskBaskiYil.Mask = "00000";
            this.mskBaskiYil.Name = "mskBaskiYil";
            this.mskBaskiYil.Size = new System.Drawing.Size(136, 32);
            this.mskBaskiYil.TabIndex = 14;
            this.mskBaskiYil.ValidatingType = typeof(int);
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.Location = new System.Drawing.Point(140, 309);
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(135, 32);
            this.txtYayinEvi.TabIndex = 13;
            // 
            // cmbDil
            // 
            this.cmbDil.FormattingEnabled = true;
            this.cmbDil.Items.AddRange(new object[] {
            "Türkçe ",
            "İngilizce ",
            "Fransızca ",
            "Rusça",
            "Arapça"});
            this.cmbDil.Location = new System.Drawing.Point(140, 265);
            this.cmbDil.Name = "cmbDil";
            this.cmbDil.Size = new System.Drawing.Size(135, 32);
            this.cmbDil.TabIndex = 12;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(140, 129);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(136, 32);
            this.txtYazar.TabIndex = 9;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(140, 87);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(136, 32);
            this.txtAdi.TabIndex = 8;
            // 
            // txtKitapİd
            // 
            this.txtKitapİd.Location = new System.Drawing.Point(140, 42);
            this.txtKitapİd.Name = "txtKitapİd";
            this.txtKitapİd.Size = new System.Drawing.Size(136, 32);
            this.txtKitapİd.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Yayın Evi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dil :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sayfa Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Baskı Yılı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazarı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap No :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Location = new System.Drawing.Point(560, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 368);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler ";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(108, 240);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(151, 33);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = " Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(108, 304);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(151, 36);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(108, 105);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(151, 36);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(108, 39);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(151, 36);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = " Listele ";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(11, 441);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(934, 217);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitaplar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapidDataGridViewTextBoxColumn,
            this.kitapAdDataGridViewTextBoxColumn,
            this.kitapYazarDataGridViewTextBoxColumn,
            this.kitapYilDataGridViewTextBoxColumn,
            this.kitapSayfaDataGridViewTextBoxColumn,
            this.kitapDilDataGridViewTextBoxColumn,
            this.kitapYayinDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblKutuphaneBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(928, 186);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // kitapidDataGridViewTextBoxColumn
            // 
            this.kitapidDataGridViewTextBoxColumn.DataPropertyName = "Kitapid";
            this.kitapidDataGridViewTextBoxColumn.HeaderText = "Kitapid";
            this.kitapidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapidDataGridViewTextBoxColumn.Name = "kitapidDataGridViewTextBoxColumn";
            this.kitapidDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapidDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapAdDataGridViewTextBoxColumn
            // 
            this.kitapAdDataGridViewTextBoxColumn.DataPropertyName = "KitapAd";
            this.kitapAdDataGridViewTextBoxColumn.HeaderText = "KitapAd";
            this.kitapAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapAdDataGridViewTextBoxColumn.Name = "kitapAdDataGridViewTextBoxColumn";
            this.kitapAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapYazarDataGridViewTextBoxColumn
            // 
            this.kitapYazarDataGridViewTextBoxColumn.DataPropertyName = "KitapYazar";
            this.kitapYazarDataGridViewTextBoxColumn.HeaderText = "KitapYazar";
            this.kitapYazarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapYazarDataGridViewTextBoxColumn.Name = "kitapYazarDataGridViewTextBoxColumn";
            this.kitapYazarDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapYilDataGridViewTextBoxColumn
            // 
            this.kitapYilDataGridViewTextBoxColumn.DataPropertyName = "KitapYil";
            this.kitapYilDataGridViewTextBoxColumn.HeaderText = "KitapYil";
            this.kitapYilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapYilDataGridViewTextBoxColumn.Name = "kitapYilDataGridViewTextBoxColumn";
            this.kitapYilDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapSayfaDataGridViewTextBoxColumn
            // 
            this.kitapSayfaDataGridViewTextBoxColumn.DataPropertyName = "KitapSayfa";
            this.kitapSayfaDataGridViewTextBoxColumn.HeaderText = "KitapSayfa";
            this.kitapSayfaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapSayfaDataGridViewTextBoxColumn.Name = "kitapSayfaDataGridViewTextBoxColumn";
            this.kitapSayfaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapDilDataGridViewTextBoxColumn
            // 
            this.kitapDilDataGridViewTextBoxColumn.DataPropertyName = "KitapDil";
            this.kitapDilDataGridViewTextBoxColumn.HeaderText = "KitapDil";
            this.kitapDilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapDilDataGridViewTextBoxColumn.Name = "kitapDilDataGridViewTextBoxColumn";
            this.kitapDilDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapYayinDataGridViewTextBoxColumn
            // 
            this.kitapYayinDataGridViewTextBoxColumn.DataPropertyName = "KitapYayin";
            this.kitapYayinDataGridViewTextBoxColumn.HeaderText = "KitapYayin";
            this.kitapYayinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapYayinDataGridViewTextBoxColumn.Name = "kitapYayinDataGridViewTextBoxColumn";
            this.kitapYayinDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblKutuphaneBindingSource
            // 
            this.tblKutuphaneBindingSource.DataMember = "Tbl_Kutuphane_";
            this.tblKutuphaneBindingSource.DataSource = this.tbl_Kutuphane_DataSet1;
            // 
            // tbl_Kutuphane_DataSet1
            // 
            this.tbl_Kutuphane_DataSet1.DataSetName = "Tbl_Kutuphane_DataSet1";
            this.tbl_Kutuphane_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Kutuphane_TableAdapter
            // 
            this.tbl_Kutuphane_TableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(295, -4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(430, 61);
            this.label8.TabIndex = 5;
            this.label8.Text = "İSTE KÜTÜPHANESİ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(689, 661);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Belemir Eda Çolak 222503049";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(947, 688);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKutuphaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Kutuphane_DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskSayfa;
        private System.Windows.Forms.MaskedTextBox mskBaskiYil;
        private System.Windows.Forms.TextBox txtYayinEvi;
        private System.Windows.Forms.ComboBox cmbDil;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtKitapİd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Tbl_Kutuphane_DataSet1 tbl_Kutuphane_DataSet1;
        private System.Windows.Forms.BindingSource tblKutuphaneBindingSource;
        private Tbl_Kutuphane_DataSet1TableAdapters.Tbl_Kutuphane_TableAdapter tbl_Kutuphane_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapSayfaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapDilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYayinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

