namespace İngilizceKelimeEzberleme
{
    partial class PratikMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PratikMenu));
            this.KontrolBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.IngTxt = new System.Windows.Forms.TextBox();
            this.trTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KontrolBtn
            // 
            this.KontrolBtn.BackColor = System.Drawing.Color.Transparent;
            this.KontrolBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KontrolBtn.ForeColor = System.Drawing.Color.Transparent;
            this.KontrolBtn.Location = new System.Drawing.Point(74, 459);
            this.KontrolBtn.Name = "KontrolBtn";
            this.KontrolBtn.Size = new System.Drawing.Size(227, 50);
            this.KontrolBtn.TabIndex = 1;
            this.KontrolBtn.UseVisualStyleBackColor = false;
            this.KontrolBtn.Click += new System.EventHandler(this.KontrolBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(428, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 50);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(74, 604);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 50);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(428, 604);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 50);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // IngTxt
            // 
            this.IngTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.IngTxt.Cursor = System.Windows.Forms.Cursors.No;
            this.IngTxt.Location = new System.Drawing.Point(229, 164);
            this.IngTxt.Name = "IngTxt";
            this.IngTxt.Size = new System.Drawing.Size(250, 27);
            this.IngTxt.TabIndex = 5;
            this.IngTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trTxt
            // 
            this.trTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.trTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trTxt.Location = new System.Drawing.Point(229, 267);
            this.trTxt.Name = "trTxt";
            this.trTxt.Size = new System.Drawing.Size(250, 27);
            this.trTxt.TabIndex = 6;
            this.trTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(494, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(178, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "-->";
            // 
            // PratikMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(705, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trTxt);
            this.Controls.Add(this.IngTxt);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.KontrolBtn);
            this.Name = "PratikMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button KontrolBtn;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox IngTxt;
        private TextBox trTxt;
        private Label label2;
        private Label label1;
    }
}