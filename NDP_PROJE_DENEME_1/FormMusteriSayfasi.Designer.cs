
namespace NDP_PROJE_DENEME_1
{
    partial class FormMusteriSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusteriSayfasi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunKod = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMusteriNo = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSatınAl = new System.Windows.Forms.Button();
            this.magazaVeriTabaniDataSet1 = new NDP_PROJE_DENEME_1.MagazaVeriTabaniDataSet1();
            this.tableUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_UrunTableAdapter = new NDP_PROJE_DENEME_1.MagazaVeriTabaniDataSet1TableAdapters.Table_UrunTableAdapter();
            this.urunKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunStokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblUrunSize = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magazaVeriTabaniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUrunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(317, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünlerimiz";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunKodDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.urunSizeDataGridViewTextBoxColumn,
            this.urunFiyatDataGridViewTextBoxColumn,
            this.urunStokDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableUrunBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(610, 172);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Kodu:";
            // 
            // txtUrunKod
            // 
            this.txtUrunKod.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtUrunKod.Location = new System.Drawing.Point(122, 41);
            this.txtUrunKod.Name = "txtUrunKod";
            this.txtUrunKod.ReadOnly = true;
            this.txtUrunKod.Size = new System.Drawing.Size(100, 27);
            this.txtUrunKod.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMusteriNo);
            this.groupBox2.Controls.Add(this.lblAd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 153);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgisi";
            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.Location = new System.Drawing.Point(118, 75);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(53, 19);
            this.lblMusteriNo.TabIndex = 6;
            this.lblMusteriNo.Text = "...........";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(118, 38);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(53, 19);
            this.lblAd.TabIndex = 5;
            this.lblAd.Text = "...........";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Müşteri No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(317, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(616, 210);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Satın Alma Geçmişi";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(610, 184);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblUrunAdi);
            this.groupBox4.Controls.Add(this.lblUrunSize);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtTutar);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtStok);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtAdet);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnSatınAl);
            this.groupBox4.Controls.Add(this.txtUrunKod);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 233);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Satın Alma Paneli";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(122, 128);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 27);
            this.txtAdet.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Adet:";
            // 
            // btnSatınAl
            // 
            this.btnSatınAl.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSatınAl.Location = new System.Drawing.Point(188, 189);
            this.btnSatınAl.Name = "btnSatınAl";
            this.btnSatınAl.Size = new System.Drawing.Size(75, 23);
            this.btnSatınAl.TabIndex = 3;
            this.btnSatınAl.Text = "Satın Al";
            this.btnSatınAl.UseVisualStyleBackColor = false;
            this.btnSatınAl.Click += new System.EventHandler(this.btnSatınAl_Click);
            // 
            // magazaVeriTabaniDataSet1
            // 
            this.magazaVeriTabaniDataSet1.DataSetName = "MagazaVeriTabaniDataSet1";
            this.magazaVeriTabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableUrunBindingSource
            // 
            this.tableUrunBindingSource.DataMember = "Table_Urun";
            this.tableUrunBindingSource.DataSource = this.magazaVeriTabaniDataSet1;
            // 
            // table_UrunTableAdapter
            // 
            this.table_UrunTableAdapter.ClearBeforeFill = true;
            // 
            // urunKodDataGridViewTextBoxColumn
            // 
            this.urunKodDataGridViewTextBoxColumn.DataPropertyName = "urunKod";
            this.urunKodDataGridViewTextBoxColumn.HeaderText = "urunKod";
            this.urunKodDataGridViewTextBoxColumn.Name = "urunKodDataGridViewTextBoxColumn";
            this.urunKodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "urunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "urunAdi";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            // 
            // urunSizeDataGridViewTextBoxColumn
            // 
            this.urunSizeDataGridViewTextBoxColumn.DataPropertyName = "urunSize";
            this.urunSizeDataGridViewTextBoxColumn.HeaderText = "urunSize";
            this.urunSizeDataGridViewTextBoxColumn.Name = "urunSizeDataGridViewTextBoxColumn";
            // 
            // urunFiyatDataGridViewTextBoxColumn
            // 
            this.urunFiyatDataGridViewTextBoxColumn.DataPropertyName = "urunFiyat";
            this.urunFiyatDataGridViewTextBoxColumn.HeaderText = "urunFiyat";
            this.urunFiyatDataGridViewTextBoxColumn.Name = "urunFiyatDataGridViewTextBoxColumn";
            // 
            // urunStokDataGridViewTextBoxColumn
            // 
            this.urunStokDataGridViewTextBoxColumn.DataPropertyName = "urunStok";
            this.urunStokDataGridViewTextBoxColumn.HeaderText = "urunStok";
            this.urunStokDataGridViewTextBoxColumn.Name = "urunStokDataGridViewTextBoxColumn";
            // 
            // txtStok
            // 
            this.txtStok.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtStok.Location = new System.Drawing.Point(122, 84);
            this.txtStok.Name = "txtStok";
            this.txtStok.ReadOnly = true;
            this.txtStok.Size = new System.Drawing.Size(100, 27);
            this.txtStok.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stok:";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(6, 128);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(50, 19);
            this.lblUrunAdi.TabIndex = 6;
            this.lblUrunAdi.Text = "label5";
            this.lblUrunAdi.Visible = false;
            // 
            // lblUrunSize
            // 
            this.lblUrunSize.AutoSize = true;
            this.lblUrunSize.Location = new System.Drawing.Point(6, 92);
            this.lblUrunSize.Name = "lblUrunSize";
            this.lblUrunSize.Size = new System.Drawing.Size(49, 19);
            this.lblUrunSize.TabIndex = 7;
            this.lblUrunSize.Text = "label7";
            this.lblUrunSize.Visible = false;
            // 
            // txtTutar
            // 
            this.txtTutar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtTutar.Location = new System.Drawing.Point(57, 185);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(78, 27);
            this.txtTutar.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tutar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "tl";
            this.label7.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(19, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 27);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMusteriSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(957, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMusteriSayfasi";
            this.Text = "FormMusteriSayfasi";
            this.Load += new System.EventHandler(this.FormMusteriSayfasi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magazaVeriTabaniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUrunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunKod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMusteriNo;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSatınAl;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label6;
        private MagazaVeriTabaniDataSet1 magazaVeriTabaniDataSet1;
        private System.Windows.Forms.BindingSource tableUrunBindingSource;
        private MagazaVeriTabaniDataSet1TableAdapters.Table_UrunTableAdapter table_UrunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunStokDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblUrunSize;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}