namespace WindowsForms_10MFirstApp
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
            this.buttonBaslat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.listBoxArsiv = new System.Windows.Forms.ListBox();
            this.comboBoxMeslek = new System.Windows.Forms.ComboBox();
            this.labelMeslek = new System.Windows.Forms.Label();
            this.labelYas = new System.Windows.Forms.Label();
            this.textBoxYas = new System.Windows.Forms.TextBox();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBaslat
            // 
            this.buttonBaslat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBaslat.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonBaslat.Location = new System.Drawing.Point(122, 416);
            this.buttonBaslat.Name = "buttonBaslat";
            this.buttonBaslat.Size = new System.Drawing.Size(100, 32);
            this.buttonBaslat.TabIndex = 0;
            this.buttonBaslat.Text = "TIKLA";
            this.buttonBaslat.UseVisualStyleBackColor = false;
            this.buttonBaslat.Click += new System.EventHandler(this.buttonBaslat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(292, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 55);
            this.label1.TabIndex = 1;
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(122, 28);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdSoyad.TabIndex = 2;
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(31, 28);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(85, 13);
            this.labelAdSoyad.TabIndex = 3;
            this.labelAdSoyad.Text = "Ad-Soyad giriniz:";
            // 
            // listBoxArsiv
            // 
            this.listBoxArsiv.FormattingEnabled = true;
            this.listBoxArsiv.Location = new System.Drawing.Point(367, 28);
            this.listBoxArsiv.Name = "listBoxArsiv";
            this.listBoxArsiv.Size = new System.Drawing.Size(218, 420);
            this.listBoxArsiv.TabIndex = 4;
            // 
            // comboBoxMeslek
            // 
            this.comboBoxMeslek.FormattingEnabled = true;
            this.comboBoxMeslek.Items.AddRange(new object[] {
            "Öğretmen",
            "Futbolcu",
            "Fenomen",
            "Şarkıcı"});
            this.comboBoxMeslek.Location = new System.Drawing.Point(122, 70);
            this.comboBoxMeslek.Name = "comboBoxMeslek";
            this.comboBoxMeslek.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMeslek.TabIndex = 5;
            // 
            // labelMeslek
            // 
            this.labelMeslek.AutoSize = true;
            this.labelMeslek.Location = new System.Drawing.Point(34, 77);
            this.labelMeslek.Name = "labelMeslek";
            this.labelMeslek.Size = new System.Drawing.Size(59, 13);
            this.labelMeslek.TabIndex = 6;
            this.labelMeslek.Text = "Mesleğiniz:";
            // 
            // labelYas
            // 
            this.labelYas.AutoSize = true;
            this.labelYas.Location = new System.Drawing.Point(34, 118);
            this.labelYas.Name = "labelYas";
            this.labelYas.Size = new System.Drawing.Size(43, 13);
            this.labelYas.TabIndex = 7;
            this.labelYas.Text = "Yaşınız:";
            // 
            // textBoxYas
            // 
            this.textBoxYas.Location = new System.Drawing.Point(122, 110);
            this.textBoxYas.Name = "textBoxYas";
            this.textBoxYas.Size = new System.Drawing.Size(41, 20);
            this.textBoxYas.TabIndex = 8;
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Location = new System.Drawing.Point(128, 386);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(41, 13);
            this.labelSonuc.TabIndex = 9;
            this.labelSonuc.Text = "Sonuç:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 493);
            this.Controls.Add(this.labelSonuc);
            this.Controls.Add(this.textBoxYas);
            this.Controls.Add(this.labelYas);
            this.Controls.Add(this.labelMeslek);
            this.Controls.Add(this.comboBoxMeslek);
            this.Controls.Add(this.listBoxArsiv);
            this.Controls.Add(this.labelAdSoyad);
            this.Controls.Add(this.textBoxAdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBaslat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBaslat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.ListBox listBoxArsiv;
        private System.Windows.Forms.ComboBox comboBoxMeslek;
        private System.Windows.Forms.Label labelMeslek;
        private System.Windows.Forms.Label labelYas;
        private System.Windows.Forms.TextBox textBoxYas;
        private System.Windows.Forms.Label labelSonuc;
    }
}

