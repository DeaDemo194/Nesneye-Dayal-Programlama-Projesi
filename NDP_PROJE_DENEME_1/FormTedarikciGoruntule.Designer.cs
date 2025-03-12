
namespace NDP_PROJE_DENEME_1
{
    partial class FormTedarikciGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTedarikciGoruntule));
            this.lblTedarikciNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tedarikciNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedarikciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedarikciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedarikciKonumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedarikciSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableTedarikciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazaVeriTabaniDataSet3 = new NDP_PROJE_DENEME_1.MagazaVeriTabaniDataSet3();
            this.table_TedarikciTableAdapter = new NDP_PROJE_DENEME_1.MagazaVeriTabaniDataSet3TableAdapters.Table_TedarikciTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTedarikciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazaVeriTabaniDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTedarikciNo
            // 
            this.lblTedarikciNo.AutoSize = true;
            this.lblTedarikciNo.Location = new System.Drawing.Point(515, 32);
            this.lblTedarikciNo.Name = "lblTedarikciNo";
            this.lblTedarikciNo.Size = new System.Drawing.Size(93, 19);
            this.lblTedarikciNo.TabIndex = 14;
            this.lblTedarikciNo.Text = "TedarikciNO";
            this.lblTedarikciNo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(152, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tedarikçilerin Satışlarını Görmek İçin İlgili Tedarikçiye Çİft Tıklayın";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 27);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(15, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 197);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Siparişler";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 188);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tedarikçi Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tedarikciNoDataGridViewTextBoxColumn,
            this.tedarikciAdDataGridViewTextBoxColumn,
            this.tedarikciSoyadDataGridViewTextBoxColumn,
            this.tedarikciKonumDataGridViewTextBoxColumn,
            this.tedarikciSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableTedarikciBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(727, 162);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tedarikciNoDataGridViewTextBoxColumn
            // 
            this.tedarikciNoDataGridViewTextBoxColumn.DataPropertyName = "tedarikciNo";
            this.tedarikciNoDataGridViewTextBoxColumn.HeaderText = "tedarikciNo";
            this.tedarikciNoDataGridViewTextBoxColumn.Name = "tedarikciNoDataGridViewTextBoxColumn";
            this.tedarikciNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tedarikciAdDataGridViewTextBoxColumn
            // 
            this.tedarikciAdDataGridViewTextBoxColumn.DataPropertyName = "tedarikciAd";
            this.tedarikciAdDataGridViewTextBoxColumn.HeaderText = "tedarikciAd";
            this.tedarikciAdDataGridViewTextBoxColumn.Name = "tedarikciAdDataGridViewTextBoxColumn";
            this.tedarikciAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tedarikciSoyadDataGridViewTextBoxColumn
            // 
            this.tedarikciSoyadDataGridViewTextBoxColumn.DataPropertyName = "tedarikciSoyad";
            this.tedarikciSoyadDataGridViewTextBoxColumn.HeaderText = "tedarikciSoyad";
            this.tedarikciSoyadDataGridViewTextBoxColumn.Name = "tedarikciSoyadDataGridViewTextBoxColumn";
            this.tedarikciSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tedarikciKonumDataGridViewTextBoxColumn
            // 
            this.tedarikciKonumDataGridViewTextBoxColumn.DataPropertyName = "tedarikciKonum";
            this.tedarikciKonumDataGridViewTextBoxColumn.HeaderText = "tedarikciKonum";
            this.tedarikciKonumDataGridViewTextBoxColumn.Name = "tedarikciKonumDataGridViewTextBoxColumn";
            this.tedarikciKonumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tedarikciSifreDataGridViewTextBoxColumn
            // 
            this.tedarikciSifreDataGridViewTextBoxColumn.DataPropertyName = "tedarikciSifre";
            this.tedarikciSifreDataGridViewTextBoxColumn.HeaderText = "tedarikciSifre";
            this.tedarikciSifreDataGridViewTextBoxColumn.Name = "tedarikciSifreDataGridViewTextBoxColumn";
            this.tedarikciSifreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableTedarikciBindingSource
            // 
            this.tableTedarikciBindingSource.DataMember = "Table_Tedarikci";
            this.tableTedarikciBindingSource.DataSource = this.magazaVeriTabaniDataSet3;
            // 
            // magazaVeriTabaniDataSet3
            // 
            this.magazaVeriTabaniDataSet3.DataSetName = "MagazaVeriTabaniDataSet3";
            this.magazaVeriTabaniDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_TedarikciTableAdapter
            // 
            this.table_TedarikciTableAdapter.ClearBeforeFill = true;
            // 
            // FormTedarikciGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 504);
            this.Controls.Add(this.lblTedarikciNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormTedarikciGoruntule";
            this.Text = "FormTedarikci";
            this.Load += new System.EventHandler(this.FormTedarikciGoruntule_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTedarikciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazaVeriTabaniDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTedarikciNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MagazaVeriTabaniDataSet3 magazaVeriTabaniDataSet3;
        private System.Windows.Forms.BindingSource tableTedarikciBindingSource;
        private MagazaVeriTabaniDataSet3TableAdapters.Table_TedarikciTableAdapter table_TedarikciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedarikciNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedarikciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedarikciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedarikciKonumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedarikciSifreDataGridViewTextBoxColumn;
    }
}