
namespace NDP_PROJE_DENEME_1
{
    partial class FormYonetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYonetici));
            this.btnStokGrntl = new System.Windows.Forms.Button();
            this.btnMusterileriGrntl = new System.Windows.Forms.Button();
            this.btnTedarikcileriGrntl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStokGrntl
            // 
            this.btnStokGrntl.Location = new System.Drawing.Point(51, 77);
            this.btnStokGrntl.Name = "btnStokGrntl";
            this.btnStokGrntl.Size = new System.Drawing.Size(108, 53);
            this.btnStokGrntl.TabIndex = 5;
            this.btnStokGrntl.Text = "Stoğu Görüntüle";
            this.btnStokGrntl.UseVisualStyleBackColor = true;
            this.btnStokGrntl.Click += new System.EventHandler(this.btnStokGrntl_Click);
            // 
            // btnMusterileriGrntl
            // 
            this.btnMusterileriGrntl.Location = new System.Drawing.Point(51, 156);
            this.btnMusterileriGrntl.Name = "btnMusterileriGrntl";
            this.btnMusterileriGrntl.Size = new System.Drawing.Size(108, 53);
            this.btnMusterileriGrntl.TabIndex = 6;
            this.btnMusterileriGrntl.Text = "Müşterileri Görüntüle";
            this.btnMusterileriGrntl.UseVisualStyleBackColor = true;
            this.btnMusterileriGrntl.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnTedarikcileriGrntl
            // 
            this.btnTedarikcileriGrntl.Location = new System.Drawing.Point(51, 230);
            this.btnTedarikcileriGrntl.Name = "btnTedarikcileriGrntl";
            this.btnTedarikcileriGrntl.Size = new System.Drawing.Size(108, 53);
            this.btnTedarikcileriGrntl.TabIndex = 7;
            this.btnTedarikcileriGrntl.Text = "Tedarikçileri Görüntüle";
            this.btnTedarikcileriGrntl.UseVisualStyleBackColor = true;
            this.btnTedarikcileriGrntl.Click += new System.EventHandler(this.btnTedarikcileriGrntl_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 27);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(214, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTedarikcileriGrntl);
            this.Controls.Add(this.btnMusterileriGrntl);
            this.Controls.Add(this.btnStokGrntl);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormYonetici";
            this.Text = "FormAnaSayfa";
            this.Load += new System.EventHandler(this.FormAnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStokGrntl;
        private System.Windows.Forms.Button btnMusterileriGrntl;
        private System.Windows.Forms.Button btnTedarikcileriGrntl;
        private System.Windows.Forms.Button button1;
    }
}