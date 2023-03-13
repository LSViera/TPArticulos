namespace TPFinalNivel2_Viera
{
    partial class frmArticulos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvArticulos = new DataGridView();
            pbxArticulos = new PictureBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnElimanar = new Button();
            lblCampo = new Label();
            lblCriterio = new Label();
            lblFiltro = new Label();
            cboCriterio = new ComboBox();
            txbFiltro = new TextBox();
            btnBuscar = new Button();
            cboCampo = new ComboBox();
            lblFiltroRapido = new Label();
            txbFiltroRapido = new TextBox();
            btnDetalle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxArticulos).BeginInit();
            SuspendLayout();
            // 
            // dgvArticulos
            // 
            dgvArticulos.AllowDrop = true;
            dgvArticulos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArticulos.BackgroundColor = SystemColors.ButtonShadow;
            dgvArticulos.BorderStyle = BorderStyle.None;
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvArticulos.Location = new Point(26, 50);
            dgvArticulos.MultiSelect = false;
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.RowHeadersWidth = 51;
            dgvArticulos.RowTemplate.Height = 29;
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulos.Size = new Size(838, 195);
            dgvArticulos.TabIndex = 0;
            dgvArticulos.SelectionChanged += dgvArticulos_SelectionChanged;
            // 
            // pbxArticulos
            // 
            pbxArticulos.Location = new Point(998, 50);
            pbxArticulos.Name = "pbxArticulos";
            pbxArticulos.Size = new Size(329, 290);
            pbxArticulos.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxArticulos.TabIndex = 1;
            pbxArticulos.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(24, 311);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(124, 311);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnElimanar
            // 
            btnElimanar.Location = new Point(224, 311);
            btnElimanar.Name = "btnElimanar";
            btnElimanar.Size = new Size(123, 29);
            btnElimanar.TabIndex = 4;
            btnElimanar.Text = "Eliminar Fisico";
            btnElimanar.UseVisualStyleBackColor = true;
            btnElimanar.Click += btnElimanar_Click;
            // 
            // lblCampo
            // 
            lblCampo.AutoSize = true;
            lblCampo.Location = new Point(26, 264);
            lblCampo.Name = "lblCampo";
            lblCampo.Size = new Size(57, 20);
            lblCampo.TabIndex = 5;
            lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            lblCriterio.AutoSize = true;
            lblCriterio.Location = new Point(239, 264);
            lblCriterio.Name = "lblCriterio";
            lblCriterio.Size = new Size(58, 20);
            lblCriterio.TabIndex = 6;
            lblCriterio.Text = "Criterio";
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(452, 264);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(43, 20);
            lblFiltro.TabIndex = 7;
            lblFiltro.Text = "Filtro";
            // 
            // cboCriterio
            // 
            cboCriterio.FormattingEnabled = true;
            cboCriterio.Location = new Point(295, 261);
            cboCriterio.Name = "cboCriterio";
            cboCriterio.Size = new Size(151, 28);
            cboCriterio.TabIndex = 9;
            // 
            // txbFiltro
            // 
            txbFiltro.Location = new Point(501, 261);
            txbFiltro.Name = "txbFiltro";
            txbFiltro.Size = new Size(125, 27);
            txbFiltro.TabIndex = 10;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(652, 260);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cboCampo
            // 
            cboCampo.FormattingEnabled = true;
            cboCampo.Location = new Point(82, 261);
            cboCampo.Name = "cboCampo";
            cboCampo.Size = new Size(151, 28);
            cboCampo.TabIndex = 12;
            cboCampo.SelectedIndexChanged += cboCampo_SelectedIndexChanged;
            // 
            // lblFiltroRapido
            // 
            lblFiltroRapido.AutoSize = true;
            lblFiltroRapido.Location = new Point(26, 15);
            lblFiltroRapido.Name = "lblFiltroRapido";
            lblFiltroRapido.Size = new Size(95, 20);
            lblFiltroRapido.TabIndex = 13;
            lblFiltroRapido.Text = "Filtro Rapido";
            // 
            // txbFiltroRapido
            // 
            txbFiltroRapido.Location = new Point(127, 12);
            txbFiltroRapido.Name = "txbFiltroRapido";
            txbFiltroRapido.Size = new Size(170, 27);
            txbFiltroRapido.TabIndex = 14;
            txbFiltroRapido.TextChanged += txbFiltroRapido_TextChanged;
            // 
            // btnDetalle
            // 
            btnDetalle.Location = new Point(352, 311);
            btnDetalle.Name = "btnDetalle";
            btnDetalle.Size = new Size(122, 29);
            btnDetalle.TabIndex = 15;
            btnDetalle.Text = "Detalle";
            btnDetalle.UseVisualStyleBackColor = true;
            btnDetalle.Click += btnDetalle_Click;
            // 
            // frmArticulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 361);
            Controls.Add(btnDetalle);
            Controls.Add(txbFiltroRapido);
            Controls.Add(lblFiltroRapido);
            Controls.Add(cboCampo);
            Controls.Add(btnBuscar);
            Controls.Add(txbFiltro);
            Controls.Add(cboCriterio);
            Controls.Add(lblFiltro);
            Controls.Add(lblCriterio);
            Controls.Add(lblCampo);
            Controls.Add(btnElimanar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(pbxArticulos);
            Controls.Add(dgvArticulos);
            Name = "frmArticulos";
            Text = "Articulos";
            Load += frmArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvArticulos;
        private PictureBox pbxArticulos;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnElimanar;
        private Label lblCampo;
        private Label lblCriterio;
        private Label lblFiltro;
        private ComboBox cboCriterio;
        private TextBox txbFiltro;
        private Button btnBuscar;
        private ComboBox cboCampo;
        private Label lblFiltroRapido;
        private TextBox txbFiltroRapido;
        private Button btnDetalle;
    }
}