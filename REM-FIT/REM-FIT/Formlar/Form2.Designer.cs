
namespace REM_FIT.Formlar
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.chkKadin = new System.Windows.Forms.CheckBox();
            this.chkErkek = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKilo = new ns1.BunifuMetroTextbox();
            this.txtBoy = new ns1.BunifuMetroTextbox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnHesapla = new ns1.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVki = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnZatenUyeyim = new ns1.BunifuFlatButton();
            this.btnUyeOl = new ns1.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // chkKadin
            // 
            this.chkKadin.AutoSize = true;
            this.chkKadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.chkKadin.Location = new System.Drawing.Point(153, 26);
            this.chkKadin.Name = "chkKadin";
            this.chkKadin.Size = new System.Drawing.Size(70, 24);
            this.chkKadin.TabIndex = 6;
            this.chkKadin.Text = "Kadın";
            this.chkKadin.UseVisualStyleBackColor = true;
            this.chkKadin.CheckedChanged += new System.EventHandler(this.chkKadin_CheckedChanged);
            // 
            // chkErkek
            // 
            this.chkErkek.AutoSize = true;
            this.chkErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.chkErkek.Location = new System.Drawing.Point(299, 26);
            this.chkErkek.Name = "chkErkek";
            this.chkErkek.Size = new System.Drawing.Size(70, 24);
            this.chkErkek.TabIndex = 7;
            this.chkErkek.Text = "Erkek";
            this.chkErkek.UseVisualStyleBackColor = true;
            this.chkErkek.CheckedChanged += new System.EventHandler(this.chkErkek_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Doğum Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kilo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Boy:";
            // 
            // txtKilo
            // 
            this.txtKilo.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtKilo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKilo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtKilo.BorderThickness = 3;
            this.txtKilo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKilo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKilo.isPassword = false;
            this.txtKilo.Location = new System.Drawing.Point(143, 123);
            this.txtKilo.Margin = new System.Windows.Forms.Padding(4);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(233, 30);
            this.txtKilo.TabIndex = 14;
            this.txtKilo.Text = "Kilonuzu Giriniz";
            this.txtKilo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBoy
            // 
            this.txtBoy.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtBoy.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoy.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtBoy.BorderThickness = 3;
            this.txtBoy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoy.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoy.isPassword = false;
            this.txtBoy.Location = new System.Drawing.Point(143, 179);
            this.txtBoy.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(233, 28);
            this.txtBoy.TabIndex = 15;
            this.txtBoy.Text = "Boyunuzu Giriniz";
            this.txtBoy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(143, 82);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(239, 20);
            this.dtpDogumTarihi.TabIndex = 16;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHesapla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapla.BorderRadius = 0;
            this.btnHesapla.ButtonText = "Hesapla";
            this.btnHesapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapla.DisabledColor = System.Drawing.Color.Gray;
            this.btnHesapla.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHesapla.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHesapla.Iconimage")));
            this.btnHesapla.Iconimage_right = null;
            this.btnHesapla.Iconimage_right_Selected = null;
            this.btnHesapla.Iconimage_Selected = null;
            this.btnHesapla.IconMarginLeft = 0;
            this.btnHesapla.IconMarginRight = 0;
            this.btnHesapla.IconRightVisible = true;
            this.btnHesapla.IconRightZoom = 0D;
            this.btnHesapla.IconVisible = true;
            this.btnHesapla.IconZoom = 90D;
            this.btnHesapla.IsTab = false;
            this.btnHesapla.Location = new System.Drawing.Point(196, 229);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHesapla.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHesapla.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHesapla.selected = false;
            this.btnHesapla.Size = new System.Drawing.Size(107, 33);
            this.btnHesapla.TabIndex = 20;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapla.Textcolor = System.Drawing.Color.White;
            this.btnHesapla.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Vücut-Kitle Endeksi:";
            // 
            // lblVki
            // 
            this.lblVki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVki.Location = new System.Drawing.Point(143, 272);
            this.lblVki.Name = "lblVki";
            this.lblVki.Size = new System.Drawing.Size(233, 27);
            this.lblVki.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "İdeal Kiloya bizimle ulaşmak için ÜYE OL";
            // 
            // btnZatenUyeyim
            // 
            this.btnZatenUyeyim.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnZatenUyeyim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnZatenUyeyim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZatenUyeyim.BorderRadius = 0;
            this.btnZatenUyeyim.ButtonText = "Zaten Üyeyim";
            this.btnZatenUyeyim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZatenUyeyim.DisabledColor = System.Drawing.Color.Gray;
            this.btnZatenUyeyim.Iconcolor = System.Drawing.Color.Transparent;
            this.btnZatenUyeyim.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnZatenUyeyim.Iconimage")));
            this.btnZatenUyeyim.Iconimage_right = null;
            this.btnZatenUyeyim.Iconimage_right_Selected = null;
            this.btnZatenUyeyim.Iconimage_Selected = null;
            this.btnZatenUyeyim.IconMarginLeft = 0;
            this.btnZatenUyeyim.IconMarginRight = 0;
            this.btnZatenUyeyim.IconRightVisible = true;
            this.btnZatenUyeyim.IconRightZoom = 0D;
            this.btnZatenUyeyim.IconVisible = true;
            this.btnZatenUyeyim.IconZoom = 90D;
            this.btnZatenUyeyim.IsTab = false;
            this.btnZatenUyeyim.Location = new System.Drawing.Point(72, 352);
            this.btnZatenUyeyim.Name = "btnZatenUyeyim";
            this.btnZatenUyeyim.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnZatenUyeyim.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnZatenUyeyim.OnHoverTextColor = System.Drawing.Color.White;
            this.btnZatenUyeyim.selected = false;
            this.btnZatenUyeyim.Size = new System.Drawing.Size(140, 30);
            this.btnZatenUyeyim.TabIndex = 24;
            this.btnZatenUyeyim.Text = "Zaten Üyeyim";
            this.btnZatenUyeyim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZatenUyeyim.Textcolor = System.Drawing.Color.White;
            this.btnZatenUyeyim.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatenUyeyim.Click += new System.EventHandler(this.btnZatenUyeyim_Click);
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUyeOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUyeOl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUyeOl.BorderRadius = 0;
            this.btnUyeOl.ButtonText = "Üye Ol";
            this.btnUyeOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeOl.DisabledColor = System.Drawing.Color.Gray;
            this.btnUyeOl.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUyeOl.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUyeOl.Iconimage")));
            this.btnUyeOl.Iconimage_right = null;
            this.btnUyeOl.Iconimage_right_Selected = null;
            this.btnUyeOl.Iconimage_Selected = null;
            this.btnUyeOl.IconMarginLeft = 0;
            this.btnUyeOl.IconMarginRight = 0;
            this.btnUyeOl.IconRightVisible = true;
            this.btnUyeOl.IconRightZoom = 0D;
            this.btnUyeOl.IconVisible = true;
            this.btnUyeOl.IconZoom = 90D;
            this.btnUyeOl.IsTab = false;
            this.btnUyeOl.Location = new System.Drawing.Point(267, 352);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUyeOl.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUyeOl.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUyeOl.selected = false;
            this.btnUyeOl.Size = new System.Drawing.Size(148, 30);
            this.btnUyeOl.TabIndex = 25;
            this.btnUyeOl.Text = "Üye Ol";
            this.btnUyeOl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeOl.Textcolor = System.Drawing.Color.White;
            this.btnUyeOl.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(507, 422);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.btnZatenUyeyim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblVki);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.txtBoy);
            this.Controls.Add(this.txtKilo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkErkek);
            this.Controls.Add(this.chkKadin);
            this.Name = "Form2";
            this.Text = "Kayıt Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkKadin;
        private System.Windows.Forms.CheckBox chkErkek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuMetroTextbox txtKilo;
        private ns1.BunifuMetroTextbox txtBoy;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private ns1.BunifuFlatButton btnHesapla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVki;
        private System.Windows.Forms.Label label5;
        private ns1.BunifuFlatButton btnZatenUyeyim;
        private ns1.BunifuFlatButton btnUyeOl;
    }
}