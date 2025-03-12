
namespace NDP_PROJE_DENEME_1
{
    partial class FormStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStok));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.magazaVeriTabaniDataSet4 = new NDP_PROJE_DENEME_1.MagazaVeriTabaniDataSet4();
            this.tableUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_UrunTableAdapter = new NDP_PROJE_DENEME_1.MagazaVeriTabaniDataSet4TableAdapters.Table_UrunTableAdapter();
            this.urunKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunStokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazaVeriTabaniDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUrunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            this.dataGridView1.Size = new System.Drawing.Size(570, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(15, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 27);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // magazaVeriTabaniDataSet4
            // 
            this.magazaVeriTabaniDataSet4.DataSetName = "MagazaVeriTabaniDataSet4";
            this.magazaVeriTabaniDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableUrunBindingSource
            // 
            this.tableUrunBindingSource.DataMember = "Table_Urun";
            this.tableUrunBindingSource.DataSource = this.magazaVeriTabaniDataSet4;
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
            // FormStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(601, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormStok";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FormStok";
            this.Load += new System.EventHandler(this.FormStok_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazaVeriTabaniDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUrunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private MagazaVeriTabaniDataSet4 magazaVeriTabaniDataSet4;
        private System.Windows.Forms.BindingSource tableUrunBindingSource;
        private MagazaVeriTabaniDataSet4TableAdapters.Table_UrunTableAdapter table_UrunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunStokDataGridViewTextBoxColumn;
    }
}