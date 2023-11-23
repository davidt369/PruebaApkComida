namespace PruebaApkComida
{
    partial class frmCena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCena));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lstCarrito = new System.Windows.Forms.ListBox();
            this.lblMenuCena = new System.Windows.Forms.Label();
            this.lblCarritoC = new System.Windows.Forms.Label();
            this.btnAgregarHumintas = new System.Windows.Forms.Button();
            this.btnAgregarMajadito = new System.Windows.Forms.Button();
            this.btnAgregarRellenoPapa = new System.Windows.Forms.Button();
            this.btnCompraLlevar = new System.Windows.Forms.Button();
            this.btnCompraAqui = new System.Windows.Forms.Button();
            this.btnAgregarTucumanas = new System.Windows.Forms.Button();
            this.btnAgregarSalchipapa = new System.Windows.Forms.Button();
            this.btnAgregarAnticucho = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.Location = new System.Drawing.Point(928, 525);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lstCarrito
            // 
            this.lstCarrito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCarrito.FormattingEnabled = true;
            this.lstCarrito.ItemHeight = 20;
            this.lstCarrito.Location = new System.Drawing.Point(894, 136);
            this.lstCarrito.Name = "lstCarrito";
            this.lstCarrito.Size = new System.Drawing.Size(152, 364);
            this.lstCarrito.TabIndex = 34;
            this.lstCarrito.SelectedIndexChanged += new System.EventHandler(this.lstCarrito_SelectedIndexChanged);
            // 
            // lblMenuCena
            // 
            this.lblMenuCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMenuCena.AutoSize = true;
            this.lblMenuCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuCena.Location = new System.Drawing.Point(319, 133);
            this.lblMenuCena.Name = "lblMenuCena";
            this.lblMenuCena.Size = new System.Drawing.Size(337, 46);
            this.lblMenuCena.TabIndex = 33;
            this.lblMenuCena.Text = "Menú de la Cena";
            // 
            // lblCarritoC
            // 
            this.lblCarritoC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCarritoC.AutoSize = true;
            this.lblCarritoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarritoC.Location = new System.Drawing.Point(889, 54);
            this.lblCarritoC.Name = "lblCarritoC";
            this.lblCarritoC.Size = new System.Drawing.Size(26, 29);
            this.lblCarritoC.TabIndex = 32;
            this.lblCarritoC.Text = "0";
            this.lblCarritoC.Click += new System.EventHandler(this.lblCarritoC_Click);
            // 
            // btnAgregarHumintas
            // 
            this.btnAgregarHumintas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarHumintas.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarHumintas.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarHumintas.Image")));
            this.btnAgregarHumintas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarHumintas.Location = new System.Drawing.Point(592, 408);
            this.btnAgregarHumintas.Name = "btnAgregarHumintas";
            this.btnAgregarHumintas.Size = new System.Drawing.Size(220, 69);
            this.btnAgregarHumintas.TabIndex = 31;
            this.btnAgregarHumintas.Text = "Agregar al carrito\r\n  HUMINTAS\r\nPrecio 5 Bs.";
            this.btnAgregarHumintas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarHumintas.UseVisualStyleBackColor = false;
            this.btnAgregarHumintas.Click += new System.EventHandler(this.btnAgregarHumintas_Click);
            // 
            // btnAgregarMajadito
            // 
            this.btnAgregarMajadito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarMajadito.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarMajadito.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarMajadito.Image")));
            this.btnAgregarMajadito.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarMajadito.Location = new System.Drawing.Point(592, 309);
            this.btnAgregarMajadito.Name = "btnAgregarMajadito";
            this.btnAgregarMajadito.Size = new System.Drawing.Size(220, 69);
            this.btnAgregarMajadito.TabIndex = 30;
            this.btnAgregarMajadito.Text = "Agregar al carrito\r\nMAJADITO\r\nPrecio 10 Bs.";
            this.btnAgregarMajadito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMajadito.UseVisualStyleBackColor = false;
            this.btnAgregarMajadito.Click += new System.EventHandler(this.btnAgregarMajadito_Click);
            // 
            // btnAgregarRellenoPapa
            // 
            this.btnAgregarRellenoPapa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarRellenoPapa.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarRellenoPapa.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarRellenoPapa.Image")));
            this.btnAgregarRellenoPapa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarRellenoPapa.Location = new System.Drawing.Point(592, 212);
            this.btnAgregarRellenoPapa.Name = "btnAgregarRellenoPapa";
            this.btnAgregarRellenoPapa.Size = new System.Drawing.Size(220, 69);
            this.btnAgregarRellenoPapa.TabIndex = 29;
            this.btnAgregarRellenoPapa.Text = "Agregar al carrito\r\nRELLENO DE PAPA\r\nPrecio 6 Bs.";
            this.btnAgregarRellenoPapa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRellenoPapa.UseVisualStyleBackColor = false;
            this.btnAgregarRellenoPapa.Click += new System.EventHandler(this.btnAgregarRellenoPapa_Click);
            // 
            // btnCompraLlevar
            // 
            this.btnCompraLlevar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompraLlevar.Location = new System.Drawing.Point(546, 517);
            this.btnCompraLlevar.Name = "btnCompraLlevar";
            this.btnCompraLlevar.Size = new System.Drawing.Size(165, 39);
            this.btnCompraLlevar.TabIndex = 28;
            this.btnCompraLlevar.Text = "Comprar para llevar";
            this.btnCompraLlevar.UseVisualStyleBackColor = true;
            this.btnCompraLlevar.Click += new System.EventHandler(this.btnCompraLlevar_Click);
            // 
            // btnCompraAqui
            // 
            this.btnCompraAqui.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompraAqui.Location = new System.Drawing.Point(347, 517);
            this.btnCompraAqui.Name = "btnCompraAqui";
            this.btnCompraAqui.Size = new System.Drawing.Size(165, 39);
            this.btnCompraAqui.TabIndex = 27;
            this.btnCompraAqui.Text = "Comprar para aqui";
            this.btnCompraAqui.UseVisualStyleBackColor = true;
            this.btnCompraAqui.Click += new System.EventHandler(this.btnCompraAqui_Click);
            // 
            // btnAgregarTucumanas
            // 
            this.btnAgregarTucumanas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarTucumanas.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarTucumanas.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTucumanas.Image")));
            this.btnAgregarTucumanas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarTucumanas.Location = new System.Drawing.Point(327, 408);
            this.btnAgregarTucumanas.Name = "btnAgregarTucumanas";
            this.btnAgregarTucumanas.Size = new System.Drawing.Size(225, 69);
            this.btnAgregarTucumanas.TabIndex = 26;
            this.btnAgregarTucumanas.Text = "Agregar al carrito\r\nTUCUMANAS\r\nPrecio 6 Bs.";
            this.btnAgregarTucumanas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTucumanas.UseVisualStyleBackColor = false;
            this.btnAgregarTucumanas.Click += new System.EventHandler(this.btnAgregarTucumanas_Click);
            // 
            // btnAgregarSalchipapa
            // 
            this.btnAgregarSalchipapa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarSalchipapa.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarSalchipapa.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarSalchipapa.Image")));
            this.btnAgregarSalchipapa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarSalchipapa.Location = new System.Drawing.Point(327, 309);
            this.btnAgregarSalchipapa.Name = "btnAgregarSalchipapa";
            this.btnAgregarSalchipapa.Size = new System.Drawing.Size(225, 69);
            this.btnAgregarSalchipapa.TabIndex = 25;
            this.btnAgregarSalchipapa.Text = "Agregar al carrito\r\nSALCHIPAPA\r\nPrecio 12 Bs.";
            this.btnAgregarSalchipapa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarSalchipapa.UseVisualStyleBackColor = false;
            this.btnAgregarSalchipapa.Click += new System.EventHandler(this.btnAgregarSalchipapa_Click);
            // 
            // btnAgregarAnticucho
            // 
            this.btnAgregarAnticucho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarAnticucho.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarAnticucho.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarAnticucho.Image")));
            this.btnAgregarAnticucho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarAnticucho.Location = new System.Drawing.Point(327, 212);
            this.btnAgregarAnticucho.Name = "btnAgregarAnticucho";
            this.btnAgregarAnticucho.Size = new System.Drawing.Size(225, 69);
            this.btnAgregarAnticucho.TabIndex = 24;
            this.btnAgregarAnticucho.Text = "Agregar al carrito\r\nANTICUCHOS\r\nPrecio 6 Bs.";
            this.btnAgregarAnticucho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAnticucho.UseVisualStyleBackColor = false;
            this.btnAgregarAnticucho.Click += new System.EventHandler(this.btnAgregarAnticucho_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(773, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 106);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // frmCena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1364, 614);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lstCarrito);
            this.Controls.Add(this.lblMenuCena);
            this.Controls.Add(this.lblCarritoC);
            this.Controls.Add(this.btnAgregarHumintas);
            this.Controls.Add(this.btnAgregarMajadito);
            this.Controls.Add(this.btnAgregarRellenoPapa);
            this.Controls.Add(this.btnCompraLlevar);
            this.Controls.Add(this.btnCompraAqui);
            this.Controls.Add(this.btnAgregarTucumanas);
            this.Controls.Add(this.btnAgregarSalchipapa);
            this.Controls.Add(this.btnAgregarAnticucho);
            this.Name = "frmCena";
            this.Text = "frmCena";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox lstCarrito;
        private System.Windows.Forms.Label lblMenuCena;
        private System.Windows.Forms.Label lblCarritoC;
        private System.Windows.Forms.Button btnAgregarHumintas;
        private System.Windows.Forms.Button btnAgregarMajadito;
        private System.Windows.Forms.Button btnAgregarRellenoPapa;
        private System.Windows.Forms.Button btnCompraLlevar;
        private System.Windows.Forms.Button btnCompraAqui;
        private System.Windows.Forms.Button btnAgregarTucumanas;
        private System.Windows.Forms.Button btnAgregarSalchipapa;
        private System.Windows.Forms.Button btnAgregarAnticucho;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}