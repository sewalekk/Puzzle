namespace YapBoz
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
            this.pictureBox_Resim = new System.Windows.Forms.PictureBox();
            this.pb0 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_karistir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Resim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Resim
            // 
            this.pictureBox_Resim.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Resim.Image")));
            this.pictureBox_Resim.Location = new System.Drawing.Point(25, 21);
            this.pictureBox_Resim.Name = "pictureBox_Resim";
            this.pictureBox_Resim.Size = new System.Drawing.Size(208, 249);
            this.pictureBox_Resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Resim.TabIndex = 0;
            this.pictureBox_Resim.TabStop = false;
            this.pictureBox_Resim.Click += new System.EventHandler(this.pictureBox_Resim_Click);
            // 
            // pb0
            // 
            this.pb0.Location = new System.Drawing.Point(256, 21);
            this.pb0.Margin = new System.Windows.Forms.Padding(1);
            this.pb0.Name = "pb0";
            this.pb0.Size = new System.Drawing.Size(150, 150);
            this.pb0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb0.TabIndex = 1;
            this.pb0.TabStop = false;
            this.pb0.Click += new System.EventHandler(this.pb0_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(408, 21);
            this.pb1.Margin = new System.Windows.Forms.Padding(1);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(150, 150);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb0_Click);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(560, 21);
            this.pb2.Margin = new System.Windows.Forms.Padding(1);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(150, 150);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 3;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb0_Click);
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(256, 173);
            this.pb3.Margin = new System.Windows.Forms.Padding(1);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(150, 150);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 4;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb0_Click);
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(408, 173);
            this.pb4.Margin = new System.Windows.Forms.Padding(1);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(150, 150);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 5;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb0_Click);
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(560, 173);
            this.pb5.Margin = new System.Windows.Forms.Padding(1);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(150, 150);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 6;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.pb0_Click);
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(256, 325);
            this.pb6.Margin = new System.Windows.Forms.Padding(1);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(150, 150);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 7;
            this.pb6.TabStop = false;
            this.pb6.Click += new System.EventHandler(this.pb0_Click);
            // 
            // pb7
            // 
            this.pb7.Location = new System.Drawing.Point(408, 325);
            this.pb7.Margin = new System.Windows.Forms.Padding(1);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(150, 150);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb7.TabIndex = 8;
            this.pb7.TabStop = false;
            this.pb7.Click += new System.EventHandler(this.pb0_Click);
            // 
            // pb8
            // 
            this.pb8.Location = new System.Drawing.Point(560, 325);
            this.pb8.Margin = new System.Windows.Forms.Padding(1);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(150, 150);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb8.TabIndex = 9;
            this.pb8.TabStop = false;
            this.pb8.Click += new System.EventHandler(this.pb0_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_karistir
            // 
            this.button_karistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_karistir.Location = new System.Drawing.Point(51, 283);
            this.button_karistir.Name = "button_karistir";
            this.button_karistir.Size = new System.Drawing.Size(153, 44);
            this.button_karistir.TabIndex = 10;
            this.button_karistir.Text = "Karıştır";
            this.button_karistir.UseVisualStyleBackColor = true;
            this.button_karistir.Click += new System.EventHandler(this.button_karistir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(744, 514);
            this.Controls.Add(this.button_karistir);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb0);
            this.Controls.Add(this.pictureBox_Resim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "YapBoz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.pb0_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Resim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Resim;
        private System.Windows.Forms.PictureBox pb0;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_karistir;
    }
}

