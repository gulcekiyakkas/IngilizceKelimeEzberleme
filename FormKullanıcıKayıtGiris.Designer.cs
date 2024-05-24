namespace İngilizceKelimeEzberleme
{
    partial class FormKullanıcıKayıtGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KullaniciAdi = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.GirisBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.kaydolBtn = new System.Windows.Forms.Button();
            this.KytOlpanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.KytSifreTkr = new System.Windows.Forms.TextBox();
            this.KytKayıt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KytSifre = new System.Windows.Forms.TextBox();
            this.kytKullaniciAdi = new System.Windows.Forms.TextBox();
            this.KytOlpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(256, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoş Geldiniz Lütfen Giriş Yapınız";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(158, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(158, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.Location = new System.Drawing.Point(320, 194);
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Size = new System.Drawing.Size(272, 27);
            this.KullaniciAdi.TabIndex = 3;
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(320, 274);
            this.Sifre.Name = "Sifre";
            this.Sifre.PasswordChar = '*';
            this.Sifre.Size = new System.Drawing.Size(272, 27);
            this.Sifre.TabIndex = 4;
            this.Sifre.UseSystemPasswordChar = true;
            // 
            // GirisBtn
            // 
            this.GirisBtn.Location = new System.Drawing.Point(388, 335);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(133, 44);
            this.GirisBtn.TabIndex = 5;
            this.GirisBtn.Text = "Giriş ";
            this.GirisBtn.UseVisualStyleBackColor = true;
            this.GirisBtn.Click += new System.EventHandler(this.GirisBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(320, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Henüz hesabınız yoksa kaydolunuz";
            // 
            // kaydolBtn
            // 
            this.kaydolBtn.Location = new System.Drawing.Point(388, 502);
            this.kaydolBtn.Name = "kaydolBtn";
            this.kaydolBtn.Size = new System.Drawing.Size(133, 47);
            this.kaydolBtn.TabIndex = 7;
            this.kaydolBtn.Text = "Kaydol";
            this.kaydolBtn.UseVisualStyleBackColor = true;
            this.kaydolBtn.Click += new System.EventHandler(this.kaydolBtn_Click);
            // 
            // KytOlpanel
            // 
            this.KytOlpanel.BackColor = System.Drawing.Color.MistyRose;
            this.KytOlpanel.Controls.Add(this.label8);
            this.KytOlpanel.Controls.Add(this.label7);
            this.KytOlpanel.Controls.Add(this.KytSifreTkr);
            this.KytOlpanel.Controls.Add(this.KytKayıt);
            this.KytOlpanel.Controls.Add(this.label6);
            this.KytOlpanel.Controls.Add(this.label5);
            this.KytOlpanel.Controls.Add(this.KytSifre);
            this.KytOlpanel.Controls.Add(this.kytKullaniciAdi);
            this.KytOlpanel.Location = new System.Drawing.Point(95, 87);
            this.KytOlpanel.Name = "KytOlpanel";
            this.KytOlpanel.Size = new System.Drawing.Size(667, 462);
            this.KytOlpanel.TabIndex = 8;
            this.KytOlpanel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(239, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "Lütfen Bilgileri Giriniz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(74, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Şifre tekrarı";
            // 
            // KytSifreTkr
            // 
            this.KytSifreTkr.Location = new System.Drawing.Point(233, 260);
            this.KytSifreTkr.Name = "KytSifreTkr";
            this.KytSifreTkr.PasswordChar = '*';
            this.KytSifreTkr.Size = new System.Drawing.Size(253, 27);
            this.KytSifreTkr.TabIndex = 12;
            this.KytSifreTkr.UseSystemPasswordChar = true;
            this.KytSifreTkr.TextChanged += new System.EventHandler(this.KytSifreTkr_TextChanged);
            // 
            // KytKayıt
            // 
            this.KytKayıt.Location = new System.Drawing.Point(291, 310);
            this.KytKayıt.Name = "KytKayıt";
            this.KytKayıt.Size = new System.Drawing.Size(133, 47);
            this.KytKayıt.TabIndex = 9;
            this.KytKayıt.Text = "Kaydol";
            this.KytKayıt.UseVisualStyleBackColor = true;
            this.KytKayıt.Click += new System.EventHandler(this.KytKayıt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(85, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(73, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // KytSifre
            // 
            this.KytSifre.Location = new System.Drawing.Point(233, 215);
            this.KytSifre.Name = "KytSifre";
            this.KytSifre.PasswordChar = '*';
            this.KytSifre.Size = new System.Drawing.Size(253, 27);
            this.KytSifre.TabIndex = 10;
            this.KytSifre.UseSystemPasswordChar = true;
            this.KytSifre.TextChanged += new System.EventHandler(this.KytSifre_TextChanged);
            // 
            // kytKullaniciAdi
            // 
            this.kytKullaniciAdi.Location = new System.Drawing.Point(233, 171);
            this.kytKullaniciAdi.Name = "kytKullaniciAdi";
            this.kytKullaniciAdi.Size = new System.Drawing.Size(253, 27);
            this.kytKullaniciAdi.TabIndex = 9;
            // 
            // FormKullanıcıKayıtGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(871, 674);
            this.Controls.Add(this.KytOlpanel);
            this.Controls.Add(this.kaydolBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GirisBtn);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.KullaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKullanıcıKayıtGiris";
            this.Text = "FormKullanıcıKayıtGiris";
            this.KytOlpanel.ResumeLayout(false);
            this.KytOlpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox KullaniciAdi;
        private TextBox Sifre;
        private Button GirisBtn;
        private Label label4;
        private Button kaydolBtn;
        private Panel KytOlpanel;
        private Label label8;
        private Label label7;
        private TextBox KytSifreTkr;
        private Button KytKayıt;
        private Label label6;
        private Label label5;
        private TextBox KytSifre;
        private TextBox kytKullaniciAdi;
    }
}