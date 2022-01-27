
namespace REM_FIT.Formlar
{
    partial class FrmRaporlar
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
            this.btnKiyasRaporu = new System.Windows.Forms.Button();
            this.btnYemekCesidiRaporu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKiyasRaporu
            // 
            this.btnKiyasRaporu.Location = new System.Drawing.Point(122, 134);
            this.btnKiyasRaporu.Name = "btnKiyasRaporu";
            this.btnKiyasRaporu.Size = new System.Drawing.Size(157, 110);
            this.btnKiyasRaporu.TabIndex = 0;
            this.btnKiyasRaporu.Text = "Kıyas Raporu";
            this.btnKiyasRaporu.UseVisualStyleBackColor = true;
            // 
            // btnYemekCesidiRaporu
            // 
            this.btnYemekCesidiRaporu.Location = new System.Drawing.Point(362, 134);
            this.btnYemekCesidiRaporu.Name = "btnYemekCesidiRaporu";
            this.btnYemekCesidiRaporu.Size = new System.Drawing.Size(161, 109);
            this.btnYemekCesidiRaporu.TabIndex = 1;
            this.btnYemekCesidiRaporu.Text = "Yemek Çeşidi Raporu";
            this.btnYemekCesidiRaporu.UseVisualStyleBackColor = true;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYemekCesidiRaporu);
            this.Controls.Add(this.btnKiyasRaporu);
            this.Name = "FrmRaporlar";
            this.Text = "FrmRaporlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKiyasRaporu;
        private System.Windows.Forms.Button btnYemekCesidiRaporu;
    }
}