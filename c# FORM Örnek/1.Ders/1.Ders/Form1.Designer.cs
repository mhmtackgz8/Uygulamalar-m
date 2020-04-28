namespace _1.Ders
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sayi2textBox = new System.Windows.Forms.TextBox();
            this.sayi1textBox = new System.Windows.Forms.TextBox();
            this.Hesaplabutton = new System.Windows.Forms.Button();
            this.SonuctextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Sayı";
            // 
            // sayi2textBox
            // 
            this.sayi2textBox.Location = new System.Drawing.Point(78, 60);
            this.sayi2textBox.Name = "sayi2textBox";
            this.sayi2textBox.Size = new System.Drawing.Size(100, 20);
            this.sayi2textBox.TabIndex = 2;
            // 
            // sayi1textBox
            // 
            this.sayi1textBox.Location = new System.Drawing.Point(78, 18);
            this.sayi1textBox.Name = "sayi1textBox";
            this.sayi1textBox.Size = new System.Drawing.Size(100, 20);
            this.sayi1textBox.TabIndex = 3;
            // 
            // Hesaplabutton
            // 
            this.Hesaplabutton.Location = new System.Drawing.Point(39, 86);
            this.Hesaplabutton.Name = "Hesaplabutton";
            this.Hesaplabutton.Size = new System.Drawing.Size(139, 23);
            this.Hesaplabutton.TabIndex = 4;
            this.Hesaplabutton.Text = "button1";
            this.Hesaplabutton.UseVisualStyleBackColor = true;
            this.Hesaplabutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SonuctextBox
            // 
            this.SonuctextBox.Location = new System.Drawing.Point(78, 125);
            this.SonuctextBox.Name = "SonuctextBox";
            this.SonuctextBox.Size = new System.Drawing.Size(100, 20);
            this.SonuctextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 165);
            this.Controls.Add(this.SonuctextBox);
            this.Controls.Add(this.Hesaplabutton);
            this.Controls.Add(this.sayi1textBox);
            this.Controls.Add(this.sayi2textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sayi2textBox;
        private System.Windows.Forms.TextBox sayi1textBox;
        private System.Windows.Forms.Button Hesaplabutton;
        private System.Windows.Forms.TextBox SonuctextBox;
    }
}

