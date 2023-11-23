namespace PruebaApkComida
{
    partial class frmCliente
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
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.txbApellidoP = new System.Windows.Forms.TextBox();
            this.txbApellidoM = new System.Windows.Forms.TextBox();
            this.lblNitCl = new System.Windows.Forms.Label();
            this.txbNit = new System.Windows.Forms.TextBox();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(2, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(392, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de datos para la factura";
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(236, 117);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(138, 26);
            this.txbNombre.TabIndex = 1;
            this.txbNombre.TextChanged += new System.EventHandler(this.txbNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(22, 123);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(146, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Ingrese su nombre:";
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoP.Location = new System.Drawing.Point(22, 156);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(209, 20);
            this.lblApellidoP.TabIndex = 3;
            this.lblApellidoP.Text = "Ingrese su apellido paterno: ";
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoM.Location = new System.Drawing.Point(22, 197);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(209, 20);
            this.lblApellidoM.TabIndex = 4;
            this.lblApellidoM.Text = "Ingrese su apellido materno:";
            // 
            // txbApellidoP
            // 
            this.txbApellidoP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellidoP.Location = new System.Drawing.Point(236, 153);
            this.txbApellidoP.Name = "txbApellidoP";
            this.txbApellidoP.Size = new System.Drawing.Size(138, 26);
            this.txbApellidoP.TabIndex = 5;
            this.txbApellidoP.TextChanged += new System.EventHandler(this.txbApellidoP_TextChanged);
            // 
            // txbApellidoM
            // 
            this.txbApellidoM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbApellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellidoM.Location = new System.Drawing.Point(236, 191);
            this.txbApellidoM.Name = "txbApellidoM";
            this.txbApellidoM.Size = new System.Drawing.Size(138, 26);
            this.txbApellidoM.TabIndex = 6;
            this.txbApellidoM.TextChanged += new System.EventHandler(this.txbApellidoM_TextChanged);
            // 
            // lblNitCl
            // 
            this.lblNitCl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNitCl.AutoSize = true;
            this.lblNitCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNitCl.Location = new System.Drawing.Point(22, 231);
            this.lblNitCl.Name = "lblNitCl";
            this.lblNitCl.Size = new System.Drawing.Size(150, 20);
            this.lblNitCl.TabIndex = 7;
            this.lblNitCl.Text = "Ingrese su NIT o CI:";
            // 
            // txbNit
            // 
            this.txbNit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNit.Location = new System.Drawing.Point(236, 231);
            this.txbNit.Name = "txbNit";
            this.txbNit.Size = new System.Drawing.Size(139, 26);
            this.txbNit.TabIndex = 8;
            this.txbNit.TextChanged += new System.EventHandler(this.txbNit_TextChanged);
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactura.Location = new System.Drawing.Point(96, 338);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(171, 60);
            this.btnGenerarFactura.TabIndex = 9;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 446);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.txbNit);
            this.Controls.Add(this.lblNitCl);
            this.Controls.Add(this.txbApellidoM);
            this.Controls.Add(this.txbApellidoP);
            this.Controls.Add(this.lblApellidoM);
            this.Controls.Add(this.lblApellidoP);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidoP;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.TextBox txbApellidoP;
        private System.Windows.Forms.TextBox txbApellidoM;
        private System.Windows.Forms.Label lblNitCl;
        private System.Windows.Forms.TextBox txbNit;
        private System.Windows.Forms.Button btnGenerarFactura;
    }
}