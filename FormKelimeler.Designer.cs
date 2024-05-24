namespace İngilizceKelimeEzberleme
{
    partial class FormKelimeler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GoruntuleBtn = new System.Windows.Forms.Button();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.panelEkle = new System.Windows.Forms.Panel();
            this.btnEkleIptal = new System.Windows.Forms.Button();
            this.btnEkleOnay = new System.Windows.Forms.Button();
            this.txtEkleAnlam = new System.Windows.Forms.TextBox();
            this.txtEkleAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButon = new System.Windows.Forms.Panel();
            this.silPanel = new System.Windows.Forms.Panel();
            this.silIptalbtn = new System.Windows.Forms.Button();
            this.silOnaybtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelEkle.SuspendLayout();
            this.panelButon.SuspendLayout();
            this.silPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(933, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // GoruntuleBtn
            // 
            this.GoruntuleBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.GoruntuleBtn.Location = new System.Drawing.Point(47, 21);
            this.GoruntuleBtn.Name = "GoruntuleBtn";
            this.GoruntuleBtn.Size = new System.Drawing.Size(162, 66);
            this.GoruntuleBtn.TabIndex = 1;
            this.GoruntuleBtn.Text = "görüntüle";
            this.GoruntuleBtn.UseVisualStyleBackColor = false;
            this.GoruntuleBtn.Click += new System.EventHandler(this.GoruntuleBtn_Click);
            // 
            // EkleBtn
            // 
            this.EkleBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.EkleBtn.Location = new System.Drawing.Point(272, 21);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(177, 66);
            this.EkleBtn.TabIndex = 2;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = false;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.silBtn.Location = new System.Drawing.Point(501, 21);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(183, 66);
            this.silBtn.TabIndex = 4;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // panelEkle
            // 
            this.panelEkle.BackColor = System.Drawing.Color.Khaki;
            this.panelEkle.Controls.Add(this.btnEkleIptal);
            this.panelEkle.Controls.Add(this.btnEkleOnay);
            this.panelEkle.Controls.Add(this.txtEkleAnlam);
            this.panelEkle.Controls.Add(this.txtEkleAd);
            this.panelEkle.Controls.Add(this.label4);
            this.panelEkle.Controls.Add(this.label2);
            this.panelEkle.Controls.Add(this.label1);
            this.panelEkle.Location = new System.Drawing.Point(276, 44);
            this.panelEkle.Name = "panelEkle";
            this.panelEkle.Size = new System.Drawing.Size(446, 351);
            this.panelEkle.TabIndex = 6;
            this.panelEkle.Visible = false;
            // 
            // btnEkleIptal
            // 
            this.btnEkleIptal.Location = new System.Drawing.Point(68, 289);
            this.btnEkleIptal.Name = "btnEkleIptal";
            this.btnEkleIptal.Size = new System.Drawing.Size(94, 29);
            this.btnEkleIptal.TabIndex = 7;
            this.btnEkleIptal.Text = "İptal";
            this.btnEkleIptal.UseVisualStyleBackColor = true;
            this.btnEkleIptal.Click += new System.EventHandler(this.btnEkleIptal_Click_1);
            // 
            // btnEkleOnay
            // 
            this.btnEkleOnay.Location = new System.Drawing.Point(297, 289);
            this.btnEkleOnay.Name = "btnEkleOnay";
            this.btnEkleOnay.Size = new System.Drawing.Size(94, 29);
            this.btnEkleOnay.TabIndex = 6;
            this.btnEkleOnay.Text = "Ekle";
            this.btnEkleOnay.UseVisualStyleBackColor = true;
            this.btnEkleOnay.Click += new System.EventHandler(this.btnEkleOnay_Click_1);
            // 
            // txtEkleAnlam
            // 
            this.txtEkleAnlam.Location = new System.Drawing.Point(115, 176);
            this.txtEkleAnlam.Name = "txtEkleAnlam";
            this.txtEkleAnlam.Size = new System.Drawing.Size(250, 27);
            this.txtEkleAnlam.TabIndex = 5;
            // 
            // txtEkleAd
            // 
            this.txtEkleAd.Location = new System.Drawing.Point(115, 105);
            this.txtEkleAd.Name = "txtEkleAd";
            this.txtEkleAd.Size = new System.Drawing.Size(250, 27);
            this.txtEkleAd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Anlamı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(172, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelime Ekle";
            // 
            // panelButon
            // 
            this.panelButon.BackColor = System.Drawing.SystemColors.Menu;
            this.panelButon.Controls.Add(this.GoruntuleBtn);
            this.panelButon.Controls.Add(this.EkleBtn);
            this.panelButon.Controls.Add(this.silBtn);
            this.panelButon.Location = new System.Drawing.Point(115, 437);
            this.panelButon.Name = "panelButon";
            this.panelButon.Size = new System.Drawing.Size(729, 125);
            this.panelButon.TabIndex = 7;
            // 
            // silPanel
            // 
            this.silPanel.BackColor = System.Drawing.Color.Khaki;
            this.silPanel.Controls.Add(this.silIptalbtn);
            this.silPanel.Controls.Add(this.silOnaybtn);
            this.silPanel.Controls.Add(this.label3);
            this.silPanel.Location = new System.Drawing.Point(242, 327);
            this.silPanel.Name = "silPanel";
            this.silPanel.Size = new System.Drawing.Size(504, 125);
            this.silPanel.TabIndex = 8;
            this.silPanel.Visible = false;
            // 
            // silIptalbtn
            // 
            this.silIptalbtn.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.silIptalbtn.Location = new System.Drawing.Point(102, 65);
            this.silIptalbtn.Name = "silIptalbtn";
            this.silIptalbtn.Size = new System.Drawing.Size(94, 29);
            this.silIptalbtn.TabIndex = 2;
            this.silIptalbtn.Text = "x";
            this.silIptalbtn.UseVisualStyleBackColor = true;
            this.silIptalbtn.Click += new System.EventHandler(this.silIptalbtn_Click);
            // 
            // silOnaybtn
            // 
            this.silOnaybtn.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.silOnaybtn.Location = new System.Drawing.Point(310, 65);
            this.silOnaybtn.Name = "silOnaybtn";
            this.silOnaybtn.Size = new System.Drawing.Size(94, 29);
            this.silOnaybtn.TabIndex = 1;
            this.silOnaybtn.Text = "✓";
            this.silOnaybtn.UseVisualStyleBackColor = true;
            this.silOnaybtn.Click += new System.EventHandler(this.silOnaybtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(115, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Silmek İstediğiniz Kelimeyi Seçiniz";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormKelimeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(957, 589);
            this.Controls.Add(this.silPanel);
            this.Controls.Add(this.panelButon);
            this.Controls.Add(this.panelEkle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormKelimeler";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormKelimeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelEkle.ResumeLayout(false);
            this.panelEkle.PerformLayout();
            this.panelButon.ResumeLayout(false);
            this.silPanel.ResumeLayout(false);
            this.silPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button GoruntuleBtn;
        private Button EkleBtn;
        private Button silBtn;
        private Panel panelEkle;
        private Button btnEkleIptal;
        private Button btnEkleOnay;
        private TextBox txtEkleAnlam;
        private TextBox txtEkleAd;
        private Label label4;
        private Label label2;
        private Label label1;
        private Panel panelButon;
        private Panel silPanel;
        private Button silIptalbtn;
        private Button silOnaybtn;
        private Label label3;
    }
}