namespace winform
{
    partial class frmAltaArticulos
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
            txbCodigo = new TextBox();
            txbNombre = new TextBox();
            txbDescripcion = new TextBox();
            lblCodigo = new Label();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblIdMarca = new Label();
            lblIdCategoria = new Label();
            lblImagenUrl = new Label();
            lblPrecio = new Label();
            txbImagenUrl = new TextBox();
            txbPrecio = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            cboIdMarca = new ComboBox();
            cboIdCategoria = new ComboBox();
            pbxAltaArticulos = new PictureBox();
            btnAgregarImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxAltaArticulos).BeginInit();
            SuspendLayout();
            // 
            // txbCodigo
            // 
            txbCodigo.Location = new Point(114, 16);
            txbCodigo.Name = "txbCodigo";
            txbCodigo.Size = new Size(125, 27);
            txbCodigo.TabIndex = 0;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(114, 65);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(125, 27);
            txbNombre.TabIndex = 1;
            // 
            // txbDescripcion
            // 
            txbDescripcion.Location = new Point(114, 114);
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.Size = new Size(125, 27);
            txbDescripcion.TabIndex = 2;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 19);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 68);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(12, 117);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripción";
            // 
            // lblIdMarca
            // 
            lblIdMarca.AutoSize = true;
            lblIdMarca.Location = new Point(12, 166);
            lblIdMarca.Name = "lblIdMarca";
            lblIdMarca.Size = new Size(67, 20);
            lblIdMarca.TabIndex = 6;
            lblIdMarca.Text = "Id Marca";
            // 
            // lblIdCategoria
            // 
            lblIdCategoria.AutoSize = true;
            lblIdCategoria.Location = new Point(12, 215);
            lblIdCategoria.Name = "lblIdCategoria";
            lblIdCategoria.Size = new Size(91, 20);
            lblIdCategoria.TabIndex = 7;
            lblIdCategoria.Text = "Id Categoria";
            // 
            // lblImagenUrl
            // 
            lblImagenUrl.AutoSize = true;
            lblImagenUrl.Location = new Point(12, 264);
            lblImagenUrl.Name = "lblImagenUrl";
            lblImagenUrl.Size = new Size(82, 20);
            lblImagenUrl.TabIndex = 8;
            lblImagenUrl.Text = "Imagen Url";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(12, 313);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio";
            // 
            // txbImagenUrl
            // 
            txbImagenUrl.Location = new Point(114, 261);
            txbImagenUrl.Name = "txbImagenUrl";
            txbImagenUrl.Size = new Size(125, 27);
            txbImagenUrl.TabIndex = 12;
            txbImagenUrl.Leave += txbImagenUrl_Leave;
            // 
            // txbPrecio
            // 
            txbPrecio.Location = new Point(114, 310);
            txbPrecio.Name = "txbPrecio";
            txbPrecio.Size = new Size(125, 27);
            txbPrecio.TabIndex = 13;
            txbPrecio.KeyUp += txbPrecio_KeyUp;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 360);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(145, 360);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboIdMarca
            // 
            cboIdMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdMarca.FormattingEnabled = true;
            cboIdMarca.Location = new Point(114, 163);
            cboIdMarca.Name = "cboIdMarca";
            cboIdMarca.Size = new Size(125, 28);
            cboIdMarca.TabIndex = 16;
            // 
            // cboIdCategoria
            // 
            cboIdCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdCategoria.FormattingEnabled = true;
            cboIdCategoria.Location = new Point(114, 212);
            cboIdCategoria.Name = "cboIdCategoria";
            cboIdCategoria.Size = new Size(125, 28);
            cboIdCategoria.TabIndex = 17;
            // 
            // pbxAltaArticulos
            // 
            pbxAltaArticulos.Location = new Point(285, 16);
            pbxAltaArticulos.Name = "pbxAltaArticulos";
            pbxAltaArticulos.Size = new Size(313, 373);
            pbxAltaArticulos.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxAltaArticulos.TabIndex = 18;
            pbxAltaArticulos.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            btnAgregarImagen.Location = new Point(245, 261);
            btnAgregarImagen.Name = "btnAgregarImagen";
            btnAgregarImagen.Size = new Size(34, 29);
            btnAgregarImagen.TabIndex = 19;
            btnAgregarImagen.Text = "+";
            btnAgregarImagen.UseVisualStyleBackColor = true;
            btnAgregarImagen.Click += btnAgregarImagen_Click;
            // 
            // frmAltaArticulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 409);
            Controls.Add(btnAgregarImagen);
            Controls.Add(pbxAltaArticulos);
            Controls.Add(cboIdCategoria);
            Controls.Add(cboIdMarca);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txbPrecio);
            Controls.Add(txbImagenUrl);
            Controls.Add(lblPrecio);
            Controls.Add(lblImagenUrl);
            Controls.Add(lblIdCategoria);
            Controls.Add(lblIdMarca);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Controls.Add(txbDescripcion);
            Controls.Add(txbNombre);
            Controls.Add(txbCodigo);
            Name = "frmAltaArticulos";
            Text = "Alta de Articulos";
            Load += frmAltaArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)pbxAltaArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbCodigo;
        private TextBox txbNombre;
        private TextBox txbDescripcion;
        private Label lblCodigo;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblIdMarca;
        private Label lblIdCategoria;
        private Label lblImagenUrl;
        private Label lblPrecio;
        private TextBox txbImagenUrl;
        private TextBox txbPrecio;
        private Button btnAceptar;
        private Button btnCancelar;
        private ComboBox cboIdMarca;
        private ComboBox cboIdCategoria;
        private PictureBox pbxAltaArticulos;
        private Button btnAgregarImagen;
    }
}