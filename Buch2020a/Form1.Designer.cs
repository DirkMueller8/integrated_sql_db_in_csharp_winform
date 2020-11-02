namespace Buch2020a
{
    partial class frmBuch2020
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbKunden = new System.Windows.Forms.GroupBox();
            this.btnListenansicht = new System.Windows.Forms.Button();
            this.grbMedien = new System.Windows.Forms.GroupBox();
            this.Einzelansicht = new System.Windows.Forms.Button();
            this.frmMedienliste = new System.Windows.Forms.Button();
            this.frmMedieneinzel = new System.Windows.Forms.Button();
            this.grbKunden.SuspendLayout();
            this.grbMedien.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKunden
            // 
            this.grbKunden.Controls.Add(this.Einzelansicht);
            this.grbKunden.Controls.Add(this.btnListenansicht);
            this.grbKunden.Location = new System.Drawing.Point(68, 41);
            this.grbKunden.Name = "grbKunden";
            this.grbKunden.Size = new System.Drawing.Size(200, 100);
            this.grbKunden.TabIndex = 0;
            this.grbKunden.TabStop = false;
            this.grbKunden.Text = "Kunden";
            // 
            // btnListenansicht
            // 
            this.btnListenansicht.Location = new System.Drawing.Point(19, 29);
            this.btnListenansicht.Name = "btnListenansicht";
            this.btnListenansicht.Size = new System.Drawing.Size(127, 23);
            this.btnListenansicht.TabIndex = 0;
            this.btnListenansicht.Text = "Listenansicht";
            this.btnListenansicht.UseVisualStyleBackColor = true;
            this.btnListenansicht.Click += new System.EventHandler(this.btnListenansicht_Click);
            // 
            // grbMedien
            // 
            this.grbMedien.Controls.Add(this.frmMedieneinzel);
            this.grbMedien.Controls.Add(this.frmMedienliste);
            this.grbMedien.Location = new System.Drawing.Point(330, 41);
            this.grbMedien.Name = "grbMedien";
            this.grbMedien.Size = new System.Drawing.Size(200, 100);
            this.grbMedien.TabIndex = 0;
            this.grbMedien.TabStop = false;
            this.grbMedien.Text = "Medien";
            // 
            // Einzelansicht
            // 
            this.Einzelansicht.Location = new System.Drawing.Point(19, 59);
            this.Einzelansicht.Name = "Einzelansicht";
            this.Einzelansicht.Size = new System.Drawing.Size(127, 23);
            this.Einzelansicht.TabIndex = 1;
            this.Einzelansicht.Text = "Einzelansicht";
            this.Einzelansicht.UseVisualStyleBackColor = true;
            this.Einzelansicht.Click += new System.EventHandler(this.Einzelansicht_Click);
            // 
            // frmMedienliste
            // 
            this.frmMedienliste.Location = new System.Drawing.Point(19, 28);
            this.frmMedienliste.Name = "frmMedienliste";
            this.frmMedienliste.Size = new System.Drawing.Size(112, 23);
            this.frmMedienliste.TabIndex = 0;
            this.frmMedienliste.Text = "Listenansicht";
            this.frmMedienliste.UseVisualStyleBackColor = true;
            this.frmMedienliste.Click += new System.EventHandler(this.frmMedienliste_Click);
            // 
            // frmMedieneinzel
            // 
            this.frmMedieneinzel.Location = new System.Drawing.Point(19, 58);
            this.frmMedieneinzel.Name = "frmMedieneinzel";
            this.frmMedieneinzel.Size = new System.Drawing.Size(112, 23);
            this.frmMedieneinzel.TabIndex = 1;
            this.frmMedieneinzel.Text = "Einzelansicht";
            this.frmMedieneinzel.UseVisualStyleBackColor = true;
            this.frmMedieneinzel.Click += new System.EventHandler(this.frmMedieneinzel_Click);
            // 
            // frmBuch2020
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.grbMedien);
            this.Controls.Add(this.grbKunden);
            this.Name = "frmBuch2020";
            this.Text = "Buch2020";
            this.grbKunden.ResumeLayout(false);
            this.grbMedien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKunden;
        private System.Windows.Forms.GroupBox grbMedien;
        private System.Windows.Forms.Button btnListenansicht;
        private System.Windows.Forms.Button Einzelansicht;
        private System.Windows.Forms.Button frmMedieneinzel;
        private System.Windows.Forms.Button frmMedienliste;
    }
}

