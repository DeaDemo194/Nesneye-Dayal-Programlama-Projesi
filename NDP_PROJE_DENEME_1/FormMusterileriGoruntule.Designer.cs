
namespace NDP_PROJE_DENEME_1
{
    partial class FormMusterileriGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusterileriGoruntule));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriCinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriYasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableMusteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazaVeriTabaniDataSet2 = new NDP_PROJE_DENEME_1.MagazaVeriTabaniDataSet2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.table_MusteriTableAdapter = new NDP_PROJE_DENEME_1.MagazaVeriTabaniDataSet2TableAdapters.Table_MusteriTableAdapter();
            this.lblMusteriNo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMusteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazaVeriTabaniDataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriNoDataGridViewTextBoxColumn,
            this.musteriAdDataGridViewTextBoxColumn,
            this.musteriSoyadDataGridViewTextBoxColumn,
            this.musteriCinsiyetDataGridViewTextBoxColumn,
            this.musteriYasDataGridViewTextBoxColumn,
            this.musteriSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableMusteriBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(727, 162);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // musteriNoDataGridViewTextBoxColumn
            // 
            this.musteriNoDataGridViewTextBoxColumn.DataPropertyName = "musteriNo";
            this.musteriNoDataGridViewTextBoxColumn.HeaderText = "musteriNo";
            this.musteriNoDataGridViewTextBoxColumn.Name = "musteriNoDataGridViewTextBoxColumn";
            this.musteriNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriAdDataGridViewTextBoxColumn
            // 
            this.musteriAdDataGridViewTextBoxColumn.DataPropertyName = "musteriAd";
            this.musteriAdDataGridViewTextBoxColumn.HeaderText = "musteriAd";
            this.musteriAdDataGridViewTextBoxColumn.Name = "musteriAdDataGridViewTextBoxColumn";
            this.musteriAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriSoyadDataGridViewTextBoxColumn
            // 
            this.musteriSoyadDataGridViewTextBoxColumn.DataPropertyName = "musteriSoyad";
            this.musteriSoyadDataGridViewTextBoxColumn.HeaderText = "musteriSoyad";
            this.musteriSoyadDataGridViewTextBoxColumn.Name = "musteriSoyadDataGridViewTextBoxColumn";
            this.musteriSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriCinsiyetDataGridViewTextBoxColumn
            // 
            this.musteriCinsiyetDataGridViewTextBoxColumn.DataPropertyName = "musteriCinsiyet";
            this.musteriCinsiyetDataGridViewTextBoxColumn.HeaderText = "musteriCinsiyet";
            this.musteriCinsiyetDataGridViewTextBoxColumn.Name = "musteriCinsiyetDataGridViewTextBoxColumn";
            this.musteriCinsiyetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriYasDataGridViewTextBoxColumn
            // 
            this.musteriYasDataGridViewTextBoxColumn.DataPropertyName = "musteriYas";
            this.musteriYasDataGridViewTextBoxColumn.HeaderText = "musteriYas";
            this.musteriYasDataGridViewTextBoxColumn.Name = "musteriYasDataGridViewTextBoxColumn";
            this.musteriYasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriSifreDataGridViewTextBoxColumn
            // 
            this.musteriSifreDataGridViewTextBoxColumn.DataPropertyName = "musteriSifre";
            this.musteriSifreDataGridViewTextBoxColumn.HeaderText = "musteriSifre";
            this.musteriSifreDataGridViewTextBoxColumn.Name = "musteriSifreDataGridViewTextBoxColumn";
            this.musteriSifreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableMusteriBindingSource
            // 
            this.tableMusteriBindingSource.DataMember = "Table_Musteri";
            this.tableMusteriBindingSource.DataSource = this.magazaVeriTabaniDataSet2;
            // 
            // magazaVeriTabaniDataSet2
            // 
            this.magazaVeriTabaniDataSet2.DataSetName = "MagazaVeriTabaniDataSet2";
            this.magazaVeriTabaniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(15, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satışlar";
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
            this.dataGridView2.Size = new System.Drawing.Size(724, 171);
            this.dataGridView2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 27);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(144, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Müşterilerin Satın Alımlarını Görmek İçin İlgili Müşteriye Çİft Tıklayın";
            // 
            // table_MusteriTableAdapter
            // 
            this.table_MusteriTableAdapter.ClearBeforeFill = true;
            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.Location = new System.Drawing.Point(581, 20);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(50, 19);
            this.lblMusteriNo.TabIndex = 9;
            this.lblMusteriNo.Text = "label2";
            // 
            // FormMusterileriGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(759, 505);
            this.Controls.Add(this.lblMusteriNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMusterileriGoruntule";
            this.Text = "FormMusterileriGoruntule";
            this.Load += new System.EventHandler(this.FormMusterileriGoruntule_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMusteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazaVeriTabaniDataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private MagazaVeriTabaniDataSet2 magazaVeriTabaniDataSet2;
        private System.Windows.Forms.BindingSource tableMusteriBindingSource;
        private MagazaVeriTabaniDataSet2TableAdapters.Table_MusteriTableAdapter table_MusteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriCinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriYasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblMusteriNo;
    }
}