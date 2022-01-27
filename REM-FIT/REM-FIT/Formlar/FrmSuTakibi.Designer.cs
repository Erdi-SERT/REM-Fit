
namespace REM_FIT.Formlar
{
    partial class FrmSuTakibi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuTakibi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaloriTakip = new ns1.BunifuThinButton2();
            this.btnKaçKalori = new ns1.BunifuThinButton2();
            this.btnUzmanaSor = new ns1.BunifuThinButton2();
            this.btnTarifler = new ns1.BunifuThinButton2();
            this.btnRaporlar = new ns1.BunifuThinButton2();
            this.btnSuTakibi = new ns1.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(568, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(568, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hedef : 2.00 Lt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(441, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "0.25Lt";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::REM_FIT.Properties.Resources.water;
            this.pictureBox1.Location = new System.Drawing.Point(416, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaloriTakip);
            this.groupBox1.Controls.Add(this.btnKaçKalori);
            this.groupBox1.Controls.Add(this.btnUzmanaSor);
            this.groupBox1.Controls.Add(this.btnTarifler);
            this.groupBox1.Controls.Add(this.btnRaporlar);
            this.groupBox1.Controls.Add(this.btnSuTakibi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 122);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // btnKaloriTakip
            // 
            this.btnKaloriTakip.ActiveBorderThickness = 1;
            this.btnKaloriTakip.ActiveCornerRadius = 20;
            this.btnKaloriTakip.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnKaloriTakip.ActiveForecolor = System.Drawing.Color.White;
            this.btnKaloriTakip.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnKaloriTakip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnKaloriTakip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaloriTakip.BackgroundImage")));
            this.btnKaloriTakip.ButtonText = "Kalori Takip";
            this.btnKaloriTakip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaloriTakip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaloriTakip.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnKaloriTakip.IdleBorderThickness = 1;
            this.btnKaloriTakip.IdleCornerRadius = 20;
            this.btnKaloriTakip.IdleFillColor = System.Drawing.Color.White;
            this.btnKaloriTakip.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnKaloriTakip.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnKaloriTakip.Location = new System.Drawing.Point(26, 25);
            this.btnKaloriTakip.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaloriTakip.Name = "btnKaloriTakip";
            this.btnKaloriTakip.Size = new System.Drawing.Size(145, 78);
            this.btnKaloriTakip.TabIndex = 8;
            this.btnKaloriTakip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaloriTakip.Click += new System.EventHandler(this.btnKaloriTakip_Click_1);
            // 
            // btnKaçKalori
            // 
            this.btnKaçKalori.ActiveBorderThickness = 1;
            this.btnKaçKalori.ActiveCornerRadius = 20;
            this.btnKaçKalori.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnKaçKalori.ActiveForecolor = System.Drawing.Color.White;
            this.btnKaçKalori.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnKaçKalori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnKaçKalori.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaçKalori.BackgroundImage")));
            this.btnKaçKalori.ButtonText = "Kaç Kalori";
            this.btnKaçKalori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaçKalori.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaçKalori.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnKaçKalori.IdleBorderThickness = 1;
            this.btnKaçKalori.IdleCornerRadius = 20;
            this.btnKaçKalori.IdleFillColor = System.Drawing.Color.White;
            this.btnKaçKalori.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnKaçKalori.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnKaçKalori.Location = new System.Drawing.Point(191, 25);
            this.btnKaçKalori.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaçKalori.Name = "btnKaçKalori";
            this.btnKaçKalori.Size = new System.Drawing.Size(145, 78);
            this.btnKaçKalori.TabIndex = 3;
            this.btnKaçKalori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaçKalori.Click += new System.EventHandler(this.btnKaçKalori_Click);
            // 
            // btnUzmanaSor
            // 
            this.btnUzmanaSor.ActiveBorderThickness = 1;
            this.btnUzmanaSor.ActiveCornerRadius = 20;
            this.btnUzmanaSor.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnUzmanaSor.ActiveForecolor = System.Drawing.Color.White;
            this.btnUzmanaSor.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnUzmanaSor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnUzmanaSor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUzmanaSor.BackgroundImage")));
            this.btnUzmanaSor.ButtonText = "Uzmana Sor";
            this.btnUzmanaSor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUzmanaSor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUzmanaSor.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUzmanaSor.IdleBorderThickness = 1;
            this.btnUzmanaSor.IdleCornerRadius = 20;
            this.btnUzmanaSor.IdleFillColor = System.Drawing.Color.White;
            this.btnUzmanaSor.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnUzmanaSor.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnUzmanaSor.Location = new System.Drawing.Point(851, 25);
            this.btnUzmanaSor.Margin = new System.Windows.Forms.Padding(5);
            this.btnUzmanaSor.Name = "btnUzmanaSor";
            this.btnUzmanaSor.Size = new System.Drawing.Size(145, 78);
            this.btnUzmanaSor.TabIndex = 7;
            this.btnUzmanaSor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUzmanaSor.Click += new System.EventHandler(this.btnUzmanaSor_Click);
            // 
            // btnTarifler
            // 
            this.btnTarifler.ActiveBorderThickness = 1;
            this.btnTarifler.ActiveCornerRadius = 20;
            this.btnTarifler.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnTarifler.ActiveForecolor = System.Drawing.Color.White;
            this.btnTarifler.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTarifler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnTarifler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTarifler.BackgroundImage")));
            this.btnTarifler.ButtonText = "Tarifler";
            this.btnTarifler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTarifler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarifler.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTarifler.IdleBorderThickness = 1;
            this.btnTarifler.IdleCornerRadius = 20;
            this.btnTarifler.IdleFillColor = System.Drawing.Color.White;
            this.btnTarifler.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnTarifler.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnTarifler.Location = new System.Drawing.Point(521, 25);
            this.btnTarifler.Margin = new System.Windows.Forms.Padding(5);
            this.btnTarifler.Name = "btnTarifler";
            this.btnTarifler.Size = new System.Drawing.Size(145, 78);
            this.btnTarifler.TabIndex = 4;
            this.btnTarifler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTarifler.Click += new System.EventHandler(this.btnTarifler_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.ActiveBorderThickness = 1;
            this.btnRaporlar.ActiveCornerRadius = 20;
            this.btnRaporlar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnRaporlar.ActiveForecolor = System.Drawing.Color.White;
            this.btnRaporlar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRaporlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnRaporlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRaporlar.BackgroundImage")));
            this.btnRaporlar.ButtonText = "Raporlar";
            this.btnRaporlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaporlar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaporlar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRaporlar.IdleBorderThickness = 1;
            this.btnRaporlar.IdleCornerRadius = 20;
            this.btnRaporlar.IdleFillColor = System.Drawing.Color.White;
            this.btnRaporlar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnRaporlar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnRaporlar.Location = new System.Drawing.Point(686, 25);
            this.btnRaporlar.Margin = new System.Windows.Forms.Padding(5);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(145, 78);
            this.btnRaporlar.TabIndex = 6;
            this.btnRaporlar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnSuTakibi
            // 
            this.btnSuTakibi.ActiveBorderThickness = 1;
            this.btnSuTakibi.ActiveCornerRadius = 20;
            this.btnSuTakibi.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSuTakibi.ActiveForecolor = System.Drawing.Color.White;
            this.btnSuTakibi.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSuTakibi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnSuTakibi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuTakibi.BackgroundImage")));
            this.btnSuTakibi.ButtonText = "Su Takip";
            this.btnSuTakibi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuTakibi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuTakibi.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSuTakibi.IdleBorderThickness = 1;
            this.btnSuTakibi.IdleCornerRadius = 20;
            this.btnSuTakibi.IdleFillColor = System.Drawing.Color.SandyBrown;
            this.btnSuTakibi.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSuTakibi.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSuTakibi.Location = new System.Drawing.Point(356, 25);
            this.btnSuTakibi.Margin = new System.Windows.Forms.Padding(5);
            this.btnSuTakibi.Name = "btnSuTakibi";
            this.btnSuTakibi.Size = new System.Drawing.Size(145, 78);
            this.btnSuTakibi.TabIndex = 5;
            this.btnSuTakibi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuTakibi.Click += new System.EventHandler(this.btnSuTakibi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(568, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "label4";
            // 
            // FrmSuTakibi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1056, 533);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSuTakibi";
            this.Text = "Su Takibi";
            this.Load += new System.EventHandler(this.FrmSuTakibi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private ns1.BunifuThinButton2 btnKaloriTakip;
        private ns1.BunifuThinButton2 btnKaçKalori;
        private ns1.BunifuThinButton2 btnUzmanaSor;
        private ns1.BunifuThinButton2 btnTarifler;
        private ns1.BunifuThinButton2 btnRaporlar;
        private ns1.BunifuThinButton2 btnSuTakibi;
        private System.Windows.Forms.Label label4;
    }
}