namespace PruebaApkComida
{
    partial class frmFactura
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.lbxProductos = new System.Windows.Forms.ListBox();
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            this.lblMostrarHora = new System.Windows.Forms.Label();
            this.lblMostraNombre = new System.Windows.Forms.Label();
            this.lblMostraNit = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.lblCantidadProductos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(96, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(149, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PALMERAS";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 64);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 20);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCliente.Location = new System.Drawing.Point(2, 389);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(179, 25);
            this.lblDatosCliente.TabIndex = 3;
            this.lblDatosCliente.Text = "Datos del cliente:";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(197, 64);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(53, 20);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(17, 435);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(154, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre completo:";
            // 
            // lblNit
            // 
            this.lblNit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.Location = new System.Drawing.Point(17, 477);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(80, 20);
            this.lblNit.TabIndex = 5;
            this.lblNit.Text = "NIT o CI:";
            // 
            // lbxProductos
            // 
            this.lbxProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbxProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxProductos.FormattingEnabled = true;
            this.lbxProductos.ItemHeight = 20;
            this.lbxProductos.Location = new System.Drawing.Point(83, 106);
            this.lbxProductos.Name = "lbxProductos";
            this.lbxProductos.Size = new System.Drawing.Size(178, 204);
            this.lbxProductos.TabIndex = 11;
            this.lbxProductos.SelectedIndexChanged += new System.EventHandler(this.lbxProductos_SelectedIndexChanged);
            // 
            // lblMostrarFecha
            // 
            this.lblMostrarFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMostrarFecha.AutoSize = true;
            this.lblMostrarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarFecha.Location = new System.Drawing.Point(79, 64);
            this.lblMostrarFecha.Name = "lblMostrarFecha";
            this.lblMostrarFecha.Size = new System.Drawing.Size(14, 20);
            this.lblMostrarFecha.TabIndex = 12;
            this.lblMostrarFecha.Text = "-";
            this.lblMostrarFecha.Click += new System.EventHandler(this.lblMostrarFecha_Click);
            // 
            // lblMostrarHora
            // 
            this.lblMostrarHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMostrarHora.AutoSize = true;
            this.lblMostrarHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarHora.Location = new System.Drawing.Point(247, 64);
            this.lblMostrarHora.Name = "lblMostrarHora";
            this.lblMostrarHora.Size = new System.Drawing.Size(14, 20);
            this.lblMostrarHora.TabIndex = 13;
            this.lblMostrarHora.Text = "-";
            // 
            // lblMostraNombre
            // 
            this.lblMostraNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMostraNombre.AutoSize = true;
            this.lblMostraNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraNombre.Location = new System.Drawing.Point(177, 435);
            this.lblMostraNombre.Name = "lblMostraNombre";
            this.lblMostraNombre.Size = new System.Drawing.Size(14, 20);
            this.lblMostraNombre.TabIndex = 14;
            this.lblMostraNombre.Text = "-";
            // 
            // lblMostraNit
            // 
            this.lblMostraNit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMostraNit.AutoSize = true;
            this.lblMostraNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraNit.Location = new System.Drawing.Point(103, 477);
            this.lblMostraNit.Name = "lblMostraNit";
            this.lblMostraNit.Size = new System.Drawing.Size(14, 20);
            this.lblMostraNit.TabIndex = 15;
            this.lblMostraNit.Text = "-";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(202, 328);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(12, 15);
            this.lblPrecioTotal.TabIndex = 16;
            this.lblPrecioTotal.Text = "-";
            // 
            // lblCantidadProductos
            // 
            this.lblCantidadProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidadProductos.AutoSize = true;
            this.lblCantidadProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProductos.Location = new System.Drawing.Point(12, 328);
            this.lblCantidadProductos.Name = "lblCantidadProductos";
            this.lblCantidadProductos.Size = new System.Drawing.Size(12, 15);
            this.lblCantidadProductos.TabIndex = 17;
            this.lblCantidadProductos.Text = "-";
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 532);
            this.Controls.Add(this.lblCantidadProductos);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.lblMostraNit);
            this.Controls.Add(this.lblMostraNombre);
            this.Controls.Add(this.lblMostrarHora);
            this.Controls.Add(this.lblMostrarFecha);
            this.Controls.Add(this.lbxProductos);
            this.Controls.Add(this.lblNit);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmFactura";
            this.Text = "Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.ListBox lbxProductos;
        private System.Windows.Forms.Label lblMostrarFecha;
        private System.Windows.Forms.Label lblMostrarHora;
        private System.Windows.Forms.Label lblMostraNombre;
        private System.Windows.Forms.Label lblMostraNit;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label lblCantidadProductos;
    }
}