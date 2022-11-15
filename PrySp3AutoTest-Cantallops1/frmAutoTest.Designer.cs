namespace PrySp3AutoTest_Cantallops
{
    partial class frmAutoTest
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
            this.MrcRegistro = new System.Windows.Forms.GroupBox();
            this.MrcEstadisiticas = new System.Windows.Forms.GroupBox();
            this.numAnioFabricacion = new System.Windows.Forms.NumericUpDown();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblAñoFabricacion = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblAñoAntiguedad = new System.Windows.Forms.Label();
            this.lblCantidadDominio = new System.Windows.Forms.Label();
            this.txtCantidadTurnos = new System.Windows.Forms.TextBox();
            this.txtAnioMasAntiguo = new System.Windows.Forms.TextBox();
            this.txtDominio6Caracteres = new System.Windows.Forms.TextBox();
            this.txtNroTurno = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.MrcRegistro.SuspendLayout();
            this.MrcEstadisiticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioFabricacion)).BeginInit();
            this.SuspendLayout();
            // 
            // MrcRegistro
            // 
            this.MrcRegistro.Controls.Add(this.txtTitular);
            this.MrcRegistro.Controls.Add(this.txtDominio);
            this.MrcRegistro.Controls.Add(this.txtNroTurno);
            this.MrcRegistro.Controls.Add(this.lblTitular);
            this.MrcRegistro.Controls.Add(this.lblAñoFabricacion);
            this.MrcRegistro.Controls.Add(this.lblDominio);
            this.MrcRegistro.Controls.Add(this.lblNumero);
            this.MrcRegistro.Controls.Add(this.numAnioFabricacion);
            this.MrcRegistro.Location = new System.Drawing.Point(12, 31);
            this.MrcRegistro.Name = "MrcRegistro";
            this.MrcRegistro.Size = new System.Drawing.Size(480, 200);
            this.MrcRegistro.TabIndex = 0;
            this.MrcRegistro.TabStop = false;
            this.MrcRegistro.Text = "Registro de Turnos";
            // 
            // MrcEstadisiticas
            // 
            this.MrcEstadisiticas.Controls.Add(this.txtDominio6Caracteres);
            this.MrcEstadisiticas.Controls.Add(this.txtAnioMasAntiguo);
            this.MrcEstadisiticas.Controls.Add(this.txtCantidadTurnos);
            this.MrcEstadisiticas.Controls.Add(this.lblCantidadDominio);
            this.MrcEstadisiticas.Controls.Add(this.lblAñoAntiguedad);
            this.MrcEstadisiticas.Controls.Add(this.lblCantidad);
            this.MrcEstadisiticas.Location = new System.Drawing.Point(12, 252);
            this.MrcEstadisiticas.Name = "MrcEstadisiticas";
            this.MrcEstadisiticas.Size = new System.Drawing.Size(480, 186);
            this.MrcEstadisiticas.TabIndex = 1;
            this.MrcEstadisiticas.TabStop = false;
            this.MrcEstadisiticas.Text = "Estadísticas";
            // 
            // numAnioFabricacion
            // 
            this.numAnioFabricacion.Location = new System.Drawing.Point(172, 113);
            this.numAnioFabricacion.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numAnioFabricacion.Minimum = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            this.numAnioFabricacion.Name = "numAnioFabricacion";
            this.numAnioFabricacion.Size = new System.Drawing.Size(70, 20);
            this.numAnioFabricacion.TabIndex = 0;
            this.numAnioFabricacion.Value = new decimal(new int[] {
            1998,
            0,
            0,
            0});
            this.numAnioFabricacion.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(54, 35);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(90, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Número de Turno";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(54, 73);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(45, 13);
            this.lblDominio.TabIndex = 2;
            this.lblDominio.Text = "Dominio";
            // 
            // lblAñoFabricacion
            // 
            this.lblAñoFabricacion.AutoSize = true;
            this.lblAñoFabricacion.Location = new System.Drawing.Point(54, 115);
            this.lblAñoFabricacion.Name = "lblAñoFabricacion";
            this.lblAñoFabricacion.Size = new System.Drawing.Size(84, 13);
            this.lblAñoFabricacion.TabIndex = 3;
            this.lblAñoFabricacion.Text = "Año Fabricacion";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(54, 156);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 4;
            this.lblTitular.Text = "Titular";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(15, 41);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(100, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad de Turnos";
            // 
            // lblAñoAntiguedad
            // 
            this.lblAñoAntiguedad.AutoSize = true;
            this.lblAñoAntiguedad.Location = new System.Drawing.Point(15, 91);
            this.lblAñoAntiguedad.Name = "lblAñoAntiguedad";
            this.lblAñoAntiguedad.Size = new System.Drawing.Size(103, 13);
            this.lblAñoAntiguedad.TabIndex = 3;
            this.lblAñoAntiguedad.Text = "Año del más antiguo";
            // 
            // lblCantidadDominio
            // 
            this.lblCantidadDominio.AutoSize = true;
            this.lblCantidadDominio.Location = new System.Drawing.Point(15, 139);
            this.lblCantidadDominio.Name = "lblCantidadDominio";
            this.lblCantidadDominio.Size = new System.Drawing.Size(186, 13);
            this.lblCantidadDominio.TabIndex = 4;
            this.lblCantidadDominio.Text = "Cantidad con dominio de 6 caracteres";
            // 
            // txtCantidadTurnos
            // 
            this.txtCantidadTurnos.Location = new System.Drawing.Point(230, 38);
            this.txtCantidadTurnos.Name = "txtCantidadTurnos";
            this.txtCantidadTurnos.ReadOnly = true;
            this.txtCantidadTurnos.Size = new System.Drawing.Size(75, 20);
            this.txtCantidadTurnos.TabIndex = 5;
            // 
            // txtAnioMasAntiguo
            // 
            this.txtAnioMasAntiguo.Location = new System.Drawing.Point(230, 91);
            this.txtAnioMasAntiguo.Name = "txtAnioMasAntiguo";
            this.txtAnioMasAntiguo.ReadOnly = true;
            this.txtAnioMasAntiguo.Size = new System.Drawing.Size(75, 20);
            this.txtAnioMasAntiguo.TabIndex = 6;
            // 
            // txtDominio6Caracteres
            // 
            this.txtDominio6Caracteres.Location = new System.Drawing.Point(230, 136);
            this.txtDominio6Caracteres.Name = "txtDominio6Caracteres";
            this.txtDominio6Caracteres.ReadOnly = true;
            this.txtDominio6Caracteres.Size = new System.Drawing.Size(75, 20);
            this.txtDominio6Caracteres.TabIndex = 7;
            // 
            // txtNroTurno
            // 
            this.txtNroTurno.Location = new System.Drawing.Point(172, 32);
            this.txtNroTurno.MaxLength = 5;
            this.txtNroTurno.Name = "txtNroTurno";
            this.txtNroTurno.Size = new System.Drawing.Size(70, 20);
            this.txtNroTurno.TabIndex = 6;
            this.txtNroTurno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTurno_KeyPress);
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(172, 66);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(100, 20);
            this.txtDominio.TabIndex = 7;
            this.txtDominio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDominio_KeyPress);
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(172, 153);
            this.txtTitular.MaxLength = 30;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(243, 20);
            this.txtTitular.TabIndex = 8;
            this.txtTitular.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(511, 35);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(122, 45);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(511, 110);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 45);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(511, 261);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(122, 45);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmAutoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 453);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.MrcEstadisiticas);
            this.Controls.Add(this.MrcRegistro);
            this.Name = "frmAutoTest";
            this.Text = "Auto Test";
            this.Load += new System.EventHandler(this.frmAutoTest_Load);
            this.MrcRegistro.ResumeLayout(false);
            this.MrcRegistro.PerformLayout();
            this.MrcEstadisiticas.ResumeLayout(false);
            this.MrcEstadisiticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioFabricacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MrcRegistro;
        private System.Windows.Forms.NumericUpDown numAnioFabricacion;
        private System.Windows.Forms.GroupBox MrcEstadisiticas;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.TextBox txtNroTurno;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblAñoFabricacion;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtDominio6Caracteres;
        private System.Windows.Forms.TextBox txtAnioMasAntiguo;
        private System.Windows.Forms.TextBox txtCantidadTurnos;
        private System.Windows.Forms.Label lblCantidadDominio;
        private System.Windows.Forms.Label lblAñoAntiguedad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
    }
}

