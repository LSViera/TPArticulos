namespace winform
{
    partial class frmDetalle
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
            pbxfrmDetalle = new PictureBox();
            txbCodigo = new TextBox();
            txbNombre = new TextBox();
            txbDescripcion = new TextBox();
            txbPrecio = new TextBox();
            cbxMarca = new ComboBox();
            cbxIdCategoria = new ComboBox();
            txbImagenUrl = new TextBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxfrmDetalle).BeginInit();
            SuspendLayout();
            // 
            // pbxfrmDetalle
            // 
            pbxfrmDetalle.Location = new Point(12, 20);
            pbxfrmDetalle.Name = "pbxfrmDetalle";
            pbxfrmDetalle.Size = new Size(434, 317);
            pbxfrmDetalle.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxfrmDetalle.TabIndex = 6;
            pbxfrmDetalle.TabStop = false;
            // 
            // txbCodigo
            // 
            txbCodigo.Enabled = false;
            txbCodigo.Location = new Point(478, 55);
            txbCodigo.Name = "txbCodigo";
            txbCodigo.Size = new Size(125, 27);
            txbCodigo.TabIndex = 7;
            // 
            // txbNombre
            // 
            txbNombre.Enabled = false;
            txbNombre.Location = new Point(478, 95);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(125, 27);
            txbNombre.TabIndex = 8;
            // 
            // txbDescripcion
            // 
            txbDescripcion.Enabled = false;
            txbDescripcion.Location = new Point(478, 135);
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.Size = new Size(125, 27);
            txbDescripcion.TabIndex = 9;
            // 
            // txbPrecio
            // 
            txbPrecio.Enabled = false;
            txbPrecio.Location = new Point(478, 310);
            txbPrecio.Name = "txbPrecio";
            txbPrecio.Size = new Size(125, 27);
            txbPrecio.TabIndex = 12;
            // 
            // cbxMarca
            // 
            cbxMarca.Enabled = false;
            cbxMarca.FormattingEnabled = true;
            cbxMarca.Location = new Point(478, 178);
            cbxMarca.Name = "cbxMarca";
            cbxMarca.Size = new Size(125, 28);
            cbxMarca.TabIndex = 13;
            // 
            // cbxIdCategoria
            // 
            cbxIdCategoria.Enabled = false;
            cbxIdCategoria.FormattingEnabled = true;
            cbxIdCategoria.Location = new Point(478, 221);
            cbxIdCategoria.Name = "cbxIdCategoria";
            cbxIdCategoria.Size = new Size(125, 28);
            cbxIdCategoria.TabIndex = 14;
            // 
            // txbImagenUrl
            // 
            txbImagenUrl.Enabled = false;
            txbImagenUrl.Location = new Point(478, 265);
            txbImagenUrl.Name = "txbImagenUrl";
            txbImagenUrl.Size = new Size(125, 27);
            txbImagenUrl.TabIndex = 15;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(478, 20);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(125, 29);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 360);
            Controls.Add(btnSalir);
            Controls.Add(txbImagenUrl);
            Controls.Add(cbxIdCategoria);
            Controls.Add(cbxMarca);
            Controls.Add(txbPrecio);
            Controls.Add(txbDescripcion);
            Controls.Add(txbNombre);
            Controls.Add(txbCodigo);
            Controls.Add(pbxfrmDetalle);
            Name = "frmDetalle";
            Text = "frmDetalle";
            Load += frmDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)pbxfrmDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbxfrmDetalle;
        private TextBox txbCodigo;
        private TextBox txbNombre;
        private TextBox txbDescripcion;
        private TextBox txbPrecio;
        private ComboBox cbxMarca;
        private ComboBox cbxIdCategoria;
        private TextBox txbImagenUrl;
        private Button btnSalir;
    }
}