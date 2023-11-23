namespace PruebaApkComida
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblPalmerasTitulo = new System.Windows.Forms.Label();
            this.btnDesayuno = new System.Windows.Forms.Button();
            this.btnAlmuerzo = new System.Windows.Forms.Button();
            this.btnCena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalmerasTitulo
            // 
            this.lblPalmerasTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPalmerasTitulo.AutoSize = true;
            this.lblPalmerasTitulo.Font = new System.Drawing.Font("Yu Gothic", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalmerasTitulo.Location = new System.Drawing.Point(230, 90);
            this.lblPalmerasTitulo.Name = "lblPalmerasTitulo";
            this.lblPalmerasTitulo.Size = new System.Drawing.Size(1247, 72);
            this.lblPalmerasTitulo.TabIndex = 0;
            this.lblPalmerasTitulo.Text = "BIENBENIDO AL RESTAURANTE PALMERAS";
            this.lblPalmerasTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDesayuno
            // 
            this.btnDesayuno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDesayuno.BackColor = System.Drawing.SystemColors.Control;
            this.btnDesayuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesayuno.Image = ((System.Drawing.Image)(resources.GetObject("btnDesayuno.Image")));
            this.btnDesayuno.Location = new System.Drawing.Point(12, 327);
            this.btnDesayuno.Name = "btnDesayuno";
            this.btnDesayuno.Size = new System.Drawing.Size(453, 376);
            this.btnDesayuno.TabIndex = 1;
            this.btnDesayuno.Text = "Desayuno";
            this.btnDesayuno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDesayuno.UseVisualStyleBackColor = false;
            this.btnDesayuno.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlmuerzo
            // 
            this.btnAlmuerzo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlmuerzo.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlmuerzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmuerzo.Image = ((System.Drawing.Image)(resources.GetObject("btnAlmuerzo.Image")));
            this.btnAlmuerzo.Location = new System.Drawing.Point(653, 327);
            this.btnAlmuerzo.Name = "btnAlmuerzo";
            this.btnAlmuerzo.Size = new System.Drawing.Size(453, 376);
            this.btnAlmuerzo.TabIndex = 2;
            this.btnAlmuerzo.Text = "Almuerzo";
            this.btnAlmuerzo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlmuerzo.UseVisualStyleBackColor = false;
            this.btnAlmuerzo.Click += new System.EventHandler(this.btnAlmuerzo_Click);
            // 
            // btnCena
            // 
            this.btnCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCena.BackColor = System.Drawing.SystemColors.Control;
            this.btnCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCena.Image = ((System.Drawing.Image)(resources.GetObject("btnCena.Image")));
            this.btnCena.Location = new System.Drawing.Point(1267, 327);
            this.btnCena.Name = "btnCena";
            this.btnCena.Size = new System.Drawing.Size(453, 376);
            this.btnCena.TabIndex = 3;
            this.btnCena.Text = "Cena";
            this.btnCena.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCena.UseVisualStyleBackColor = false;
            this.btnCena.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 840);
            this.Controls.Add(this.btnCena);
            this.Controls.Add(this.btnAlmuerzo);
            this.Controls.Add(this.btnDesayuno);
            this.Controls.Add(this.lblPalmerasTitulo);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalmerasTitulo;
        private System.Windows.Forms.Button btnDesayuno;
        private System.Windows.Forms.Button btnAlmuerzo;
        private System.Windows.Forms.Button btnCena;
    }
}

