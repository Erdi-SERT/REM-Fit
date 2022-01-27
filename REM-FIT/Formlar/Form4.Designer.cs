
namespace REM_FIT.Formlar
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btnGiris = new ns1.BunifuFlatButton();
            this.txtSifreGiris = new ns1.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailGiris = new ns1.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.BorderRadius = 0;
            this.btnGiris.ButtonText = "GİRİŞ YAP";
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.DisabledColor = System.Drawing.Color.Gray;
            this.btnGiris.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGiris.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGiris.Iconimage")));
            this.btnGiris.Iconimage_right = null;
            this.btnGiris.Iconimage_right_Selected = null;
            this.btnGiris.Iconimage_Selected = null;
            this.btnGiris.IconMarginLeft = 0;
            this.btnGiris.IconMarginRight = 0;
            this.btnGiris.IconRightVisible = true;
            this.btnGiris.IconRightZoom = 0D;
            this.btnGiris.IconVisible = true;
            this.btnGiris.IconZoom = 90D;
            this.btnGiris.IsTab = false;
            this.btnGiris.Location = new System.Drawing.Point(165, 256);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGiris.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGiris.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGiris.selected = false;
            this.btnGiris.Size = new System.Drawing.Size(359, 66);
            this.btnGiris.TabIndex = 26;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiris.Textcolor = System.Drawing.Color.White;
            this.btnGiris.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifreGiris
            // 
            this.txtSifreGiris.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSifreGiris.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSifreGiris.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSifreGiris.BorderThickness = 3;
            this.txtSifreGiris.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifreGiris.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSifreGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSifreGiris.isPassword = false;
            this.txtSifreGiris.Location = new System.Drawing.Point(165, 193);
            this.txtSifreGiris.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifreGiris.Name = "txtSifreGiris";
            this.txtSifreGiris.Size = new System.Drawing.Size(359, 44);
            this.txtSifreGiris.TabIndex = 25;
            this.txtSifreGiris.Text = "bunifuMetroTextbox5";
            this.txtSifreGiris.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(69, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "ŞİFRE :";
            // 
            // txtEmailGiris
            // 
            this.txtEmailGiris.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtEmailGiris.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmailGiris.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtEmailGiris.BorderThickness = 3;
            this.txtEmailGiris.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailGiris.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmailGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmailGiris.isPassword = false;
            this.txtEmailGiris.Location = new System.Drawing.Point(165, 141);
            this.txtEmailGiris.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailGiris.Name = "txtEmailGiris";
            this.txtEmailGiris.Size = new System.Drawing.Size(359, 44);
            this.txtEmailGiris.TabIndex = 23;
            this.txtEmailGiris.Text = "bunifuMetroTextbox3";
            this.txtEmailGiris.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(63, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "E-Mail :";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifreGiris);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmailGiris);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuFlatButton btnGiris;
        private ns1.BunifuMetroTextbox txtSifreGiris;
        private System.Windows.Forms.Label label5;
        private ns1.BunifuMetroTextbox txtEmailGiris;
        private System.Windows.Forms.Label label3;
    }
}