
namespace REM_FIT.Formlar
{
    partial class FrmTarifler
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
            this.cmbTarifler = new System.Windows.Forms.ComboBox();
            this.lstTarifler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbTarifler
            // 
            this.cmbTarifler.FormattingEnabled = true;
            this.cmbTarifler.Location = new System.Drawing.Point(137, 85);
            this.cmbTarifler.Name = "cmbTarifler";
            this.cmbTarifler.Size = new System.Drawing.Size(277, 21);
            this.cmbTarifler.TabIndex = 0;
            // 
            // lstTarifler
            // 
            this.lstTarifler.FormattingEnabled = true;
            this.lstTarifler.Location = new System.Drawing.Point(142, 158);
            this.lstTarifler.Name = "lstTarifler";
            this.lstTarifler.Size = new System.Drawing.Size(487, 186);
            this.lstTarifler.TabIndex = 1;
            // 
            // FrmTarifler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstTarifler);
            this.Controls.Add(this.cmbTarifler);
            this.Name = "FrmTarifler";
            this.Text = "Tarifler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTarifler;
        private System.Windows.Forms.ListBox lstTarifler;
    }
}