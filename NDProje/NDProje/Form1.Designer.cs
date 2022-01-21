namespace NDProje
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
            this.components = new System.ComponentModel.Container();
            this.listorganik = new System.Windows.Forms.ListBox();
            this.listkagit = new System.Windows.Forms.ListBox();
            this.listcam = new System.Windows.Forms.ListBox();
            this.listmetal = new System.Windows.Forms.ListBox();
            this.butorganik = new System.Windows.Forms.Button();
            this.butkagit = new System.Windows.Forms.Button();
            this.butcam = new System.Windows.Forms.Button();
            this.butmetal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labsayac = new System.Windows.Forms.Label();
            this.butyenioyun = new System.Windows.Forms.Button();
            this.butcikis = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labpuan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.barorganik = new System.Windows.Forms.ProgressBar();
            this.barkagit = new System.Windows.Forms.ProgressBar();
            this.barcam = new System.Windows.Forms.ProgressBar();
            this.barmetal = new System.Windows.Forms.ProgressBar();
            this.butorganikbos = new System.Windows.Forms.Button();
            this.butkagitbos = new System.Windows.Forms.Button();
            this.butcambos = new System.Windows.Forms.Button();
            this.butmetalbos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listorganik
            // 
            this.listorganik.BackColor = System.Drawing.SystemColors.MenuText;
            this.listorganik.ForeColor = System.Drawing.SystemColors.Window;
            this.listorganik.FormattingEnabled = true;
            this.listorganik.Location = new System.Drawing.Point(323, 49);
            this.listorganik.Name = "listorganik";
            this.listorganik.Size = new System.Drawing.Size(134, 121);
            this.listorganik.TabIndex = 0;
            this.listorganik.Tag = "organikd";
            // 
            // listkagit
            // 
            this.listkagit.BackColor = System.Drawing.SystemColors.MenuText;
            this.listkagit.ForeColor = System.Drawing.SystemColors.Window;
            this.listkagit.FormattingEnabled = true;
            this.listkagit.Location = new System.Drawing.Point(503, 49);
            this.listkagit.Name = "listkagit";
            this.listkagit.Size = new System.Drawing.Size(132, 121);
            this.listkagit.TabIndex = 1;
            this.listkagit.Tag = "kagitd";
            // 
            // listcam
            // 
            this.listcam.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listcam.ForeColor = System.Drawing.SystemColors.Window;
            this.listcam.FormattingEnabled = true;
            this.listcam.Location = new System.Drawing.Point(323, 278);
            this.listcam.Name = "listcam";
            this.listcam.Size = new System.Drawing.Size(134, 121);
            this.listcam.TabIndex = 2;
            this.listcam.Tag = "cams";
            // 
            // listmetal
            // 
            this.listmetal.BackColor = System.Drawing.SystemColors.MenuText;
            this.listmetal.ForeColor = System.Drawing.SystemColors.Window;
            this.listmetal.FormattingEnabled = true;
            this.listmetal.Location = new System.Drawing.Point(503, 278);
            this.listmetal.Name = "listmetal";
            this.listmetal.Size = new System.Drawing.Size(132, 121);
            this.listmetal.TabIndex = 3;
            this.listmetal.Tag = "metalk";
            // 
            // butorganik
            // 
            this.butorganik.BackColor = System.Drawing.Color.Aquamarine;
            this.butorganik.Enabled = false;
            this.butorganik.ForeColor = System.Drawing.Color.SaddleBrown;
            this.butorganik.Location = new System.Drawing.Point(348, 21);
            this.butorganik.Name = "butorganik";
            this.butorganik.Size = new System.Drawing.Size(75, 23);
            this.butorganik.TabIndex = 8;
            this.butorganik.Tag = "organiks";
            this.butorganik.Text = "ORGANİK";
            this.butorganik.UseVisualStyleBackColor = false;
            this.butorganik.Click += new System.EventHandler(this.butorganik_Click);
            // 
            // butkagit
            // 
            this.butkagit.BackColor = System.Drawing.Color.Aquamarine;
            this.butkagit.Enabled = false;
            this.butkagit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.butkagit.Location = new System.Drawing.Point(539, 21);
            this.butkagit.Name = "butkagit";
            this.butkagit.Size = new System.Drawing.Size(75, 23);
            this.butkagit.TabIndex = 9;
            this.butkagit.Tag = "kagitg";
            this.butkagit.Text = "KAĞIT";
            this.butkagit.UseVisualStyleBackColor = false;
            this.butkagit.Click += new System.EventHandler(this.butkagit_Click);
            // 
            // butcam
            // 
            this.butcam.BackColor = System.Drawing.Color.Aquamarine;
            this.butcam.Enabled = false;
            this.butcam.ForeColor = System.Drawing.Color.SaddleBrown;
            this.butcam.Location = new System.Drawing.Point(348, 247);
            this.butcam.Name = "butcam";
            this.butcam.Size = new System.Drawing.Size(75, 26);
            this.butcam.TabIndex = 10;
            this.butcam.Tag = "camb";
            this.butcam.Text = "CAM";
            this.butcam.UseVisualStyleBackColor = false;
            this.butcam.Click += new System.EventHandler(this.butcam_Click);
            // 
            // butmetal
            // 
            this.butmetal.BackColor = System.Drawing.Color.Aquamarine;
            this.butmetal.Enabled = false;
            this.butmetal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.butmetal.Location = new System.Drawing.Point(539, 250);
            this.butmetal.Name = "butmetal";
            this.butmetal.Size = new System.Drawing.Size(75, 23);
            this.butmetal.TabIndex = 11;
            this.butmetal.Tag = "metals";
            this.butmetal.Text = "METAL";
            this.butmetal.UseVisualStyleBackColor = false;
            this.butmetal.Click += new System.EventHandler(this.butmetal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 260);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labsayac
            // 
            this.labsayac.AutoSize = true;
            this.labsayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labsayac.Location = new System.Drawing.Point(93, 332);
            this.labsayac.Name = "labsayac";
            this.labsayac.Size = new System.Drawing.Size(44, 31);
            this.labsayac.TabIndex = 13;
            this.labsayac.Text = "60";
            // 
            // butyenioyun
            // 
            this.butyenioyun.Location = new System.Drawing.Point(82, 278);
            this.butyenioyun.Name = "butyenioyun";
            this.butyenioyun.Size = new System.Drawing.Size(75, 23);
            this.butyenioyun.TabIndex = 14;
            this.butyenioyun.Text = "YENİ OYUN ";
            this.butyenioyun.UseVisualStyleBackColor = true;
            this.butyenioyun.Click += new System.EventHandler(this.butyenioyun_Click);
            // 
            // butcikis
            // 
            this.butcikis.Location = new System.Drawing.Point(82, 431);
            this.butcikis.Name = "butcikis";
            this.butcikis.Size = new System.Drawing.Size(75, 23);
            this.butcikis.TabIndex = 15;
            this.butcikis.Text = "ÇIKIŞ";
            this.butcikis.UseVisualStyleBackColor = true;
            this.butcikis.Click += new System.EventHandler(this.butcikis_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(91, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "SÜRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(91, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "PUAN";
            // 
            // labpuan
            // 
            this.labpuan.AutoSize = true;
            this.labpuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labpuan.Location = new System.Drawing.Point(93, 397);
            this.labpuan.Name = "labpuan";
            this.labpuan.Size = new System.Drawing.Size(29, 31);
            this.labpuan.TabIndex = 18;
            this.labpuan.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(422, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "ATIK KUTULARI";
            // 
            // barorganik
            // 
            this.barorganik.Location = new System.Drawing.Point(338, 176);
            this.barorganik.Maximum = 700;
            this.barorganik.Name = "barorganik";
            this.barorganik.Size = new System.Drawing.Size(100, 23);
            this.barorganik.TabIndex = 20;
            // 
            // barkagit
            // 
            this.barkagit.Location = new System.Drawing.Point(525, 176);
            this.barkagit.Maximum = 1200;
            this.barkagit.Name = "barkagit";
            this.barkagit.Size = new System.Drawing.Size(100, 23);
            this.barkagit.TabIndex = 21;
            // 
            // barcam
            // 
            this.barcam.Location = new System.Drawing.Point(338, 405);
            this.barcam.Maximum = 2200;
            this.barcam.Name = "barcam";
            this.barcam.Size = new System.Drawing.Size(100, 23);
            this.barcam.TabIndex = 22;
            this.barcam.Click += new System.EventHandler(this.progressBar3_Click);
            // 
            // barmetal
            // 
            this.barmetal.Location = new System.Drawing.Point(525, 405);
            this.barmetal.Maximum = 2300;
            this.barmetal.Name = "barmetal";
            this.barmetal.Size = new System.Drawing.Size(100, 23);
            this.barmetal.TabIndex = 23;
            // 
            // butorganikbos
            // 
            this.butorganikbos.BackColor = System.Drawing.Color.Plum;
            this.butorganikbos.Enabled = false;
            this.butorganikbos.Location = new System.Drawing.Point(348, 205);
            this.butorganikbos.Name = "butorganikbos";
            this.butorganikbos.Size = new System.Drawing.Size(75, 23);
            this.butorganikbos.TabIndex = 24;
            this.butorganikbos.Text = "BOŞALT";
            this.butorganikbos.UseVisualStyleBackColor = false;
            this.butorganikbos.Click += new System.EventHandler(this.butorganikbos_Click);
            // 
            // butkagitbos
            // 
            this.butkagitbos.BackColor = System.Drawing.Color.Plum;
            this.butkagitbos.Enabled = false;
            this.butkagitbos.Location = new System.Drawing.Point(539, 205);
            this.butkagitbos.Name = "butkagitbos";
            this.butkagitbos.Size = new System.Drawing.Size(75, 23);
            this.butkagitbos.TabIndex = 25;
            this.butkagitbos.Text = "BOŞALT";
            this.butkagitbos.UseVisualStyleBackColor = false;
            this.butkagitbos.Click += new System.EventHandler(this.butkagitbos_Click);
            // 
            // butcambos
            // 
            this.butcambos.BackColor = System.Drawing.Color.Plum;
            this.butcambos.Enabled = false;
            this.butcambos.Location = new System.Drawing.Point(348, 434);
            this.butcambos.Name = "butcambos";
            this.butcambos.Size = new System.Drawing.Size(75, 23);
            this.butcambos.TabIndex = 26;
            this.butcambos.Text = "BOŞALT";
            this.butcambos.UseVisualStyleBackColor = false;
            this.butcambos.Click += new System.EventHandler(this.butcambos_Click);
            // 
            // butmetalbos
            // 
            this.butmetalbos.BackColor = System.Drawing.Color.Plum;
            this.butmetalbos.Enabled = false;
            this.butmetalbos.Location = new System.Drawing.Point(539, 434);
            this.butmetalbos.Name = "butmetalbos";
            this.butmetalbos.Size = new System.Drawing.Size(75, 23);
            this.butmetalbos.TabIndex = 27;
            this.butmetalbos.Text = "BOŞALT";
            this.butmetalbos.UseVisualStyleBackColor = false;
            this.butmetalbos.Click += new System.EventHandler(this.butmetalbos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(320, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "----------------------------------------------------------------\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butmetalbos);
            this.Controls.Add(this.butcambos);
            this.Controls.Add(this.butkagitbos);
            this.Controls.Add(this.butorganikbos);
            this.Controls.Add(this.barmetal);
            this.Controls.Add(this.barcam);
            this.Controls.Add(this.barkagit);
            this.Controls.Add(this.barorganik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labpuan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butcikis);
            this.Controls.Add(this.butyenioyun);
            this.Controls.Add(this.labsayac);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butmetal);
            this.Controls.Add(this.butcam);
            this.Controls.Add(this.butkagit);
            this.Controls.Add(this.butorganik);
            this.Controls.Add(this.listmetal);
            this.Controls.Add(this.listcam);
            this.Controls.Add(this.listkagit);
            this.Controls.Add(this.listorganik);
            this.Name = "Form1";
            this.Text = "ATIK TOPLAMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listorganik;
        private System.Windows.Forms.ListBox listkagit;
        private System.Windows.Forms.ListBox listcam;
        private System.Windows.Forms.ListBox listmetal;
        private System.Windows.Forms.Button butorganik;
        private System.Windows.Forms.Button butkagit;
        private System.Windows.Forms.Button butcam;
        private System.Windows.Forms.Button butmetal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labsayac;
        private System.Windows.Forms.Button butyenioyun;
        private System.Windows.Forms.Button butcikis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labpuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar barorganik;
        private System.Windows.Forms.ProgressBar barkagit;
        private System.Windows.Forms.ProgressBar barcam;
        private System.Windows.Forms.ProgressBar barmetal;
        private System.Windows.Forms.Button butorganikbos;
        private System.Windows.Forms.Button butkagitbos;
        private System.Windows.Forms.Button butcambos;
        private System.Windows.Forms.Button butmetalbos;
        private System.Windows.Forms.Label label1;
    }
}

