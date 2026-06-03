namespace KotaTakipSistemi.UI
{
    partial class Form1
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtTckn = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAboneler = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.cmbAboneler = new System.Windows.Forms.ComboBox();
            this.cmbPaketler = new System.Windows.Forms.ComboBox();
            this.txtHarcananMB = new System.Windows.Forms.TextBox();
            this.btnHatTanimla = new System.Windows.Forms.Button();
            this.btnKotaHarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAboneler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(112, 78);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(112, 168);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(112, 262);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtTckn
            // 
            this.txtTckn.Location = new System.Drawing.Point(373, 144);
            this.txtTckn.Name = "txtTckn";
            this.txtTckn.Size = new System.Drawing.Size(100, 22);
            this.txtTckn.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(373, 224);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(1150, 635);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(147, 23);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Abone Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "TCKN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "e-mail";
            // 
            // dgvAboneler
            // 
            this.dgvAboneler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAboneler.Location = new System.Drawing.Point(548, 40);
            this.dgvAboneler.Name = "dgvAboneler";
            this.dgvAboneler.RowHeadersWidth = 51;
            this.dgvAboneler.RowTemplate.Height = 24;
            this.dgvAboneler.Size = new System.Drawing.Size(805, 568);
            this.dgvAboneler.TabIndex = 11;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(927, 635);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(184, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Abone Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmbAboneler
            // 
            this.cmbAboneler.FormattingEnabled = true;
            this.cmbAboneler.Location = new System.Drawing.Point(112, 317);
            this.cmbAboneler.Name = "cmbAboneler";
            this.cmbAboneler.Size = new System.Drawing.Size(121, 24);
            this.cmbAboneler.TabIndex = 13;
            // 
            // cmbPaketler
            // 
            this.cmbPaketler.FormattingEnabled = true;
            this.cmbPaketler.Location = new System.Drawing.Point(112, 401);
            this.cmbPaketler.Name = "cmbPaketler";
            this.cmbPaketler.Size = new System.Drawing.Size(121, 24);
            this.cmbPaketler.TabIndex = 14;
            // 
            // txtHarcananMB
            // 
            this.txtHarcananMB.Location = new System.Drawing.Point(122, 483);
            this.txtHarcananMB.Name = "txtHarcananMB";
            this.txtHarcananMB.Size = new System.Drawing.Size(100, 22);
            this.txtHarcananMB.TabIndex = 16;
            // 
            // btnHatTanimla
            // 
            this.btnHatTanimla.Location = new System.Drawing.Point(93, 441);
            this.btnHatTanimla.Name = "btnHatTanimla";
            this.btnHatTanimla.Size = new System.Drawing.Size(159, 23);
            this.btnHatTanimla.TabIndex = 17;
            this.btnHatTanimla.Text = "Paketi Tanımla";
            this.btnHatTanimla.UseVisualStyleBackColor = true;
            this.btnHatTanimla.Click += new System.EventHandler(this.btnHatTanimla_Click);
            // 
            // btnKotaHarca
            // 
            this.btnKotaHarca.Location = new System.Drawing.Point(112, 511);
            this.btnKotaHarca.Name = "btnKotaHarca";
            this.btnKotaHarca.Size = new System.Drawing.Size(121, 23);
            this.btnKotaHarca.TabIndex = 18;
            this.btnKotaHarca.Text = "Kota Harca";
            this.btnKotaHarca.UseVisualStyleBackColor = true;
            this.btnKotaHarca.Click += new System.EventHandler(this.btnKotaHarca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 698);
            this.Controls.Add(this.btnKotaHarca);
            this.Controls.Add(this.btnHatTanimla);
            this.Controls.Add(this.txtHarcananMB);
            this.Controls.Add(this.cmbPaketler);
            this.Controls.Add(this.cmbAboneler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvAboneler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTckn);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAboneler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtTckn;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAboneler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cmbAboneler;
        private System.Windows.Forms.ComboBox cmbPaketler;
        private System.Windows.Forms.TextBox txtHarcananMB;
        private System.Windows.Forms.Button btnHatTanimla;
        private System.Windows.Forms.Button btnKotaHarca;
    }
}