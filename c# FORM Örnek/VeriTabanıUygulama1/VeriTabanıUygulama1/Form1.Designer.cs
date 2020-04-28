namespace VeriTabanıUygulama1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader ColumHeader1;
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            ColumHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ColumHeader1
            // 
            ColumHeader1.Text = "Personelin Adı";
            ColumHeader1.Width = 79;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            ColumHeader1,
            this.ColumHeader2,
            this.ColumHeader3,
            this.ColumHeader4,
            this.ColumHeader5,
            this.ColumHeader6,
            this.ColumHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(786, 300);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumHeader2
            // 
            this.ColumHeader2.Text = "Personelin Soyadı";
            this.ColumHeader2.Width = 107;
            // 
            // ColumHeader3
            // 
            this.ColumHeader3.Text = "Personelin Görevi";
            this.ColumHeader3.Width = 123;
            // 
            // ColumHeader4
            // 
            this.ColumHeader4.Text = "Telefon No";
            this.ColumHeader4.Width = 119;
            // 
            // ColumHeader5
            // 
            this.ColumHeader5.Text = "Mail Adresi";
            this.ColumHeader5.Width = 115;
            // 
            // ColumHeader6
            // 
            this.ColumHeader6.Text = "Eğitim Durumu";
            this.ColumHeader6.Width = 119;
            // 
            // ColumHeader7
            // 
            this.ColumHeader7.Text = "İşe Başlama Tarihi";
            this.ColumHeader7.Width = 191;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColumHeader2;
        private System.Windows.Forms.ColumnHeader ColumHeader3;
        private System.Windows.Forms.ColumnHeader ColumHeader4;
        private System.Windows.Forms.ColumnHeader ColumHeader5;
        private System.Windows.Forms.ColumnHeader ColumHeader6;
        private System.Windows.Forms.ColumnHeader ColumHeader7;
        private System.Windows.Forms.Button button1;
    }
}

