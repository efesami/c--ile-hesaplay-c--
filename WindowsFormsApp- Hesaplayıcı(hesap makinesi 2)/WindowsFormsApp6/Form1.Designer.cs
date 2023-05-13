namespace WindowsFormsApp6AALIŞTIRMA
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
            this.label1sayi1 = new System.Windows.Forms.Label();
            this.label2sayi2 = new System.Windows.Forms.Label();
            this.label3sonuc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1artı = new System.Windows.Forms.Button();
            this.button2eksi = new System.Windows.Forms.Button();
            this.button3çarpı = new System.Windows.Forms.Button();
            this.button4bölü = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1cıkıs = new System.Windows.Forms.Button();
            this.button2temizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1sayi1
            // 
            this.label1sayi1.AutoSize = true;
            this.label1sayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1sayi1.Location = new System.Drawing.Point(21, 38);
            this.label1sayi1.Name = "label1sayi1";
            this.label1sayi1.Size = new System.Drawing.Size(94, 16);
            this.label1sayi1.TabIndex = 0;
            this.label1sayi1.Text = "1.Sayıyı Gir :";
            // 
            // label2sayi2
            // 
            this.label2sayi2.AutoSize = true;
            this.label2sayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2sayi2.Location = new System.Drawing.Point(21, 65);
            this.label2sayi2.Name = "label2sayi2";
            this.label2sayi2.Size = new System.Drawing.Size(94, 16);
            this.label2sayi2.TabIndex = 1;
            this.label2sayi2.Text = "2.Sayıyı Gir :";
            // 
            // label3sonuc
            // 
            this.label3sonuc.AutoSize = true;
            this.label3sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3sonuc.Location = new System.Drawing.Point(21, 98);
            this.label3sonuc.Name = "label3sonuc";
            this.label3sonuc.Size = new System.Drawing.Size(58, 16);
            this.label3sonuc.TabIndex = 2;
            this.label3sonuc.Text = "Sonuç :";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(123, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(123, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(123, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 22);
            this.textBox3.TabIndex = 8;
            // 
            // button1artı
            // 
            this.button1artı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1artı.Location = new System.Drawing.Point(123, 139);
            this.button1artı.Name = "button1artı";
            this.button1artı.Size = new System.Drawing.Size(47, 38);
            this.button1artı.TabIndex = 9;
            this.button1artı.Text = "+";
            this.button1artı.UseVisualStyleBackColor = false;
            this.button1artı.Click += new System.EventHandler(this.button1artı_Click);
            // 
            // button2eksi
            // 
            this.button2eksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2eksi.Location = new System.Drawing.Point(176, 139);
            this.button2eksi.Name = "button2eksi";
            this.button2eksi.Size = new System.Drawing.Size(47, 38);
            this.button2eksi.TabIndex = 10;
            this.button2eksi.Text = "-";
            this.button2eksi.UseVisualStyleBackColor = false;
            this.button2eksi.Click += new System.EventHandler(this.button2eksi_Click);
            // 
            // button3çarpı
            // 
            this.button3çarpı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3çarpı.Location = new System.Drawing.Point(123, 183);
            this.button3çarpı.Name = "button3çarpı";
            this.button3çarpı.Size = new System.Drawing.Size(47, 38);
            this.button3çarpı.TabIndex = 11;
            this.button3çarpı.Text = "x";
            this.button3çarpı.UseVisualStyleBackColor = false;
            this.button3çarpı.Click += new System.EventHandler(this.button3çarpı_Click);
            // 
            // button4bölü
            // 
            this.button4bölü.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4bölü.Location = new System.Drawing.Point(176, 183);
            this.button4bölü.Name = "button4bölü";
            this.button4bölü.Size = new System.Drawing.Size(47, 38);
            this.button4bölü.TabIndex = 12;
            this.button4bölü.Text = "/";
            this.button4bölü.UseVisualStyleBackColor = false;
            this.button4bölü.Click += new System.EventHandler(this.button4bölü_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Controls.Add(this.button1cıkıs);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.button2temizle);
            this.groupBox1.Controls.Add(this.label1sayi1);
            this.groupBox1.Controls.Add(this.button4bölü);
            this.groupBox1.Controls.Add(this.label2sayi2);
            this.groupBox1.Controls.Add(this.button3çarpı);
            this.groupBox1.Controls.Add(this.label3sonuc);
            this.groupBox1.Controls.Add(this.button2eksi);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1artı);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(299, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 245);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap Makinesi";
            // 
            // button1cıkıs
            // 
            this.button1cıkıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1cıkıs.Location = new System.Drawing.Point(24, 183);
            this.button1cıkıs.Name = "button1cıkıs";
            this.button1cıkıs.Size = new System.Drawing.Size(75, 39);
            this.button1cıkıs.TabIndex = 14;
            this.button1cıkıs.Text = "Çıkış";
            this.button1cıkıs.UseVisualStyleBackColor = false;
            this.button1cıkıs.Click += new System.EventHandler(this.button1cıkıs_Click);
            // 
            // button2temizle
            // 
            this.button2temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2temizle.Location = new System.Drawing.Point(24, 142);
            this.button2temizle.Name = "button2temizle";
            this.button2temizle.Size = new System.Drawing.Size(75, 35);
            this.button2temizle.TabIndex = 15;
            this.button2temizle.Text = "Temizle";
            this.button2temizle.UseVisualStyleBackColor = false;
            this.button2temizle.Click += new System.EventHandler(this.button2temizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1sayi1;
        private System.Windows.Forms.Label label2sayi2;
        private System.Windows.Forms.Label label3sonuc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1artı;
        private System.Windows.Forms.Button button2eksi;
        private System.Windows.Forms.Button button3çarpı;
        private System.Windows.Forms.Button button4bölü;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1cıkıs;
        private System.Windows.Forms.Button button2temizle;
    }
}

