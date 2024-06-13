namespace Actividad2
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTitulo = new TextBox();
            cboGenero = new ComboBox();
            txtDirector = new TextBox();
            txtDuraccion = new TextBox();
            txtProductora = new TextBox();
            dgvPelicula = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnGuardar = new Button();
            btnSalir = new Button();
            btnGenerar = new Button();
            txtContenidoArchivo = new TextBox();
            btnVerArchivo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPelicula).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 79);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 1;
            label2.Text = "Genero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 185);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 2;
            label3.Text = "Director";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 251);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 3;
            label4.Text = "Productora";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 136);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 4;
            label5.Text = "Duracion";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(127, 24);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(150, 31);
            txtTitulo.TabIndex = 5;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Items.AddRange(new object[] { "Acción", "Comedia  ", "Drama", "Ciencia ficción", "Terror  ", "Romance" });
            cboGenero.Location = new Point(127, 76);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(182, 33);
            cboGenero.TabIndex = 6;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(144, 185);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(150, 31);
            txtDirector.TabIndex = 7;
            // 
            // txtDuraccion
            // 
            txtDuraccion.Location = new Point(144, 133);
            txtDuraccion.Name = "txtDuraccion";
            txtDuraccion.Size = new Size(150, 31);
            txtDuraccion.TabIndex = 8;
            // 
            // txtProductora
            // 
            txtProductora.Location = new Point(144, 245);
            txtProductora.Name = "txtProductora";
            txtProductora.Size = new Size(150, 31);
            txtProductora.TabIndex = 9;
            // 
            // dgvPelicula
            // 
            dgvPelicula.BackgroundColor = Color.MistyRose;
            dgvPelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPelicula.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvPelicula.Location = new Point(327, 12);
            dgvPelicula.Name = "dgvPelicula";
            dgvPelicula.RowHeadersWidth = 62;
            dgvPelicula.RowTemplate.Height = 33;
            dgvPelicula.Size = new Size(1014, 339);
            dgvPelicula.TabIndex = 10;
            dgvPelicula.CellContentClick += dgvPelicula_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Titulo";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Genero";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Duracion";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Director";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Productora";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(63, 409);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(141, 46);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(417, 409);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(141, 46);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(241, 409);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(141, 46);
            btnGenerar.TabIndex = 13;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtContenidoArchivo
            // 
            txtContenidoArchivo.Location = new Point(756, 409);
            txtContenidoArchivo.Name = "txtContenidoArchivo";
            txtContenidoArchivo.Size = new Size(585, 31);
            txtContenidoArchivo.TabIndex = 14;
            // 
            // btnVerArchivo
            // 
            btnVerArchivo.Location = new Point(585, 409);
            btnVerArchivo.Name = "btnVerArchivo";
            btnVerArchivo.Size = new Size(141, 46);
            btnVerArchivo.TabIndex = 15;
            btnVerArchivo.Text = "Ver Archivo";
            btnVerArchivo.UseVisualStyleBackColor = true;
            btnVerArchivo.Click += btnVerArchivo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1367, 686);
            Controls.Add(btnVerArchivo);
            Controls.Add(txtContenidoArchivo);
            Controls.Add(btnGenerar);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(dgvPelicula);
            Controls.Add(txtProductora);
            Controls.Add(txtDuraccion);
            Controls.Add(txtDirector);
            Controls.Add(cboGenero);
            Controls.Add(txtTitulo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPelicula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTitulo;
        private ComboBox cboGenero;
        private TextBox txtDirector;
        private TextBox txtDuraccion;
        private TextBox txtProductora;
        private DataGridView dgvPelicula;
        private Button btnGuardar;
        private Button btnSalir;
        private Button btnGenerar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txtContenidoArchivo;
        private Button btnVerArchivo;
    }
}
