namespace Bunifi1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ŞifreMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.kadıMetroTextbox2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ŞifreMetroTextbox1
            // 
            this.ŞifreMetroTextbox1.BackColor = System.Drawing.Color.GhostWhite;
            this.ŞifreMetroTextbox1.BorderColorFocused = System.Drawing.Color.DarkGreen;
            this.ŞifreMetroTextbox1.BorderColorIdle = System.Drawing.Color.Black;
            this.ŞifreMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.DarkGreen;
            this.ŞifreMetroTextbox1.BorderThickness = 3;
            this.ŞifreMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ŞifreMetroTextbox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ŞifreMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ŞifreMetroTextbox1.isPassword = true;
            this.ŞifreMetroTextbox1.Location = new System.Drawing.Point(41, 186);
            this.ŞifreMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.ŞifreMetroTextbox1.Name = "ŞifreMetroTextbox1";
            this.ŞifreMetroTextbox1.Size = new System.Drawing.Size(350, 43);
            this.ŞifreMetroTextbox1.TabIndex = 3;
            this.ŞifreMetroTextbox1.Text = "Şifreniz";
            this.ŞifreMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ŞifreMetroTextbox1.Click += new System.EventHandler(this.ŞifreMetroTextbox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(63, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Beni Hatırla";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.Transparent;
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(42, 257);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 5;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 40;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SpringGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.YellowGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Giriş Yap";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Tan;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.DarkGreen;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.Location = new System.Drawing.Point(44, 285);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(349, 47);
            this.bunifuThinButton22.TabIndex = 7;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // kadıMetroTextbox2
            // 
            this.kadıMetroTextbox2.BackColor = System.Drawing.Color.GhostWhite;
            this.kadıMetroTextbox2.BorderColorFocused = System.Drawing.Color.DarkGreen;
            this.kadıMetroTextbox2.BorderColorIdle = System.Drawing.Color.Black;
            this.kadıMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.DarkGreen;
            this.kadıMetroTextbox2.BorderThickness = 3;
            this.kadıMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kadıMetroTextbox2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kadıMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kadıMetroTextbox2.isPassword = false;
            this.kadıMetroTextbox2.Location = new System.Drawing.Point(43, 122);
            this.kadıMetroTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.kadıMetroTextbox2.Name = "kadıMetroTextbox2";
            this.kadıMetroTextbox2.Size = new System.Drawing.Size(348, 43);
            this.kadıMetroTextbox2.TabIndex = 8;
            this.kadıMetroTextbox2.Text = "Kullanıcı Adınız";
            this.kadıMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kadıMetroTextbox2.Click += new System.EventHandler(this.kadıMetroTextbox2_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DarkGreen;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(40, 384);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(124, 20);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Şifremi Unuttum";
            this.bunifuCustomLabel2.MouseHover += new System.EventHandler(this.bunifuCustomLabel2_MouseHover);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(201, 384);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(62, 20);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Kayıt Ol";
            this.bunifuCustomLabel1.MouseHover += new System.EventHandler(this.bunifuCustomLabel1_MouseHover);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.DarkGreen;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(332, 384);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(59, 20);
            this.bunifuCustomLabel3.TabIndex = 12;
            this.bunifuCustomLabel3.Text = "Yardım";
            this.bunifuCustomLabel3.MouseHover += new System.EventHandler(this.bunifuCustomLabel3_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Bunifi1.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(172, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(426, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.kadıMetroTextbox2);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ŞifreMetroTextbox1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMetroTextbox ŞifreMetroTextbox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuMetroTextbox kadıMetroTextbox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

