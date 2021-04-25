namespace WindowsFormsApp1
{
    partial class FrmEmpleado
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
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.LblEdad = new System.Windows.Forms.Label();
            this.TxtLugarDeResidencia = new System.Windows.Forms.TextBox();
            this.LblLugarDeResidencia = new System.Windows.Forms.Label();
            this.LblSalario = new System.Windows.Forms.Label();
            this.LblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.TxtNivelDeColaridad = new System.Windows.Forms.TextBox();
            this.LblNivelDeColaridad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblCarreaQueEstudia = new System.Windows.Forms.Label();
            this.DtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.GrdEmpleado = new System.Windows.Forms.DataGridView();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblSeguro = new System.Windows.Forms.Label();
            this.LblImpuesto = new System.Windows.Forms.Label();
            this.LblGastoGeneral = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtGastoG = new System.Windows.Forms.TextBox();
            this.TxtImpuesto = new System.Windows.Forms.TextBox();
            this.TxtSeguro = new System.Windows.Forms.TextBox();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(78, 5);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre:";
            this.LblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Location = new System.Drawing.Point(168, 2);
            this.TxtNombre.MaxLength = 200;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(150, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(78, 37);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(47, 13);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "Apellido:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtApellido.Location = new System.Drawing.Point(168, 37);
            this.TxtApellido.MaxLength = 200;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(150, 20);
            this.TxtApellido.TabIndex = 3;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(168, 79);
            this.TxtEdad.MaxLength = 50;
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(50, 20);
            this.TxtEdad.TabIndex = 5;
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Location = new System.Drawing.Point(90, 79);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(35, 13);
            this.LblEdad.TabIndex = 4;
            this.LblEdad.Text = "Edad:";
            // 
            // TxtLugarDeResidencia
            // 
            this.TxtLugarDeResidencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtLugarDeResidencia.Location = new System.Drawing.Point(168, 247);
            this.TxtLugarDeResidencia.MaxLength = 200;
            this.TxtLugarDeResidencia.Multiline = true;
            this.TxtLugarDeResidencia.Name = "TxtLugarDeResidencia";
            this.TxtLugarDeResidencia.Size = new System.Drawing.Size(200, 35);
            this.TxtLugarDeResidencia.TabIndex = 7;
            this.TxtLugarDeResidencia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblLugarDeResidencia
            // 
            this.LblLugarDeResidencia.AutoSize = true;
            this.LblLugarDeResidencia.Location = new System.Drawing.Point(15, 247);
            this.LblLugarDeResidencia.Name = "LblLugarDeResidencia";
            this.LblLugarDeResidencia.Size = new System.Drawing.Size(110, 13);
            this.LblLugarDeResidencia.TabIndex = 6;
            this.LblLugarDeResidencia.Text = "Lugar De Residencia:";
            // 
            // LblSalario
            // 
            this.LblSalario.AutoSize = true;
            this.LblSalario.Location = new System.Drawing.Point(83, 116);
            this.LblSalario.Name = "LblSalario";
            this.LblSalario.Size = new System.Drawing.Size(42, 13);
            this.LblSalario.TabIndex = 8;
            this.LblSalario.Text = "Salario:";
            // 
            // LblFechaDeNacimiento
            // 
            this.LblFechaDeNacimiento.AutoSize = true;
            this.LblFechaDeNacimiento.Location = new System.Drawing.Point(12, 199);
            this.LblFechaDeNacimiento.Name = "LblFechaDeNacimiento";
            this.LblFechaDeNacimiento.Size = new System.Drawing.Size(113, 13);
            this.LblFechaDeNacimiento.TabIndex = 10;
            this.LblFechaDeNacimiento.Text = "Fecha De Nacimiento:";
            this.LblFechaDeNacimiento.Click += new System.EventHandler(this.LblFechaDeNacimiento_Click);
            // 
            // TxtNivelDeColaridad
            // 
            this.TxtNivelDeColaridad.Location = new System.Drawing.Point(168, 309);
            this.TxtNivelDeColaridad.MaxLength = 200;
            this.TxtNivelDeColaridad.Name = "TxtNivelDeColaridad";
            this.TxtNivelDeColaridad.Size = new System.Drawing.Size(100, 20);
            this.TxtNivelDeColaridad.TabIndex = 13;
            // 
            // LblNivelDeColaridad
            // 
            this.LblNivelDeColaridad.AutoSize = true;
            this.LblNivelDeColaridad.Location = new System.Drawing.Point(27, 309);
            this.LblNivelDeColaridad.Name = "LblNivelDeColaridad";
            this.LblNivelDeColaridad.Size = new System.Drawing.Size(98, 13);
            this.LblNivelDeColaridad.TabIndex = 12;
            this.LblNivelDeColaridad.Text = "Nivel De Colaridad:";
            this.LblNivelDeColaridad.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(168, 348);
            this.textBox1.MaxLength = 200;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 15;
            // 
            // LblCarreaQueEstudia
            // 
            this.LblCarreaQueEstudia.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.LblCarreaQueEstudia.AutoSize = true;
            this.LblCarreaQueEstudia.Location = new System.Drawing.Point(20, 348);
            this.LblCarreaQueEstudia.Name = "LblCarreaQueEstudia";
            this.LblCarreaQueEstudia.Size = new System.Drawing.Size(105, 13);
            this.LblCarreaQueEstudia.TabIndex = 14;
            this.LblCarreaQueEstudia.Text = "Carrera Que Estudia:";
            // 
            // DtpNacimiento
            // 
            this.DtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpNacimiento.Location = new System.Drawing.Point(168, 199);
            this.DtpNacimiento.Name = "DtpNacimiento";
            this.DtpNacimiento.Size = new System.Drawing.Size(130, 20);
            this.DtpNacimiento.TabIndex = 16;
            this.DtpNacimiento.ValueChanged += new System.EventHandler(this.DtpNacimiento_ValueChanged);
            // 
            // GrdEmpleado
            // 
            this.GrdEmpleado.AllowUserToAddRows = false;
            this.GrdEmpleado.AllowUserToDeleteRows = false;
            this.GrdEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdEmpleado.Location = new System.Drawing.Point(525, 12);
            this.GrdEmpleado.MultiSelect = false;
            this.GrdEmpleado.Name = "GrdEmpleado";
            this.GrdEmpleado.ReadOnly = true;
            this.GrdEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdEmpleado.Size = new System.Drawing.Size(263, 178);
            this.GrdEmpleado.TabIndex = 18;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(702, 196);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(60, 23);
            this.BtnSalir.TabIndex = 19;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(525, 196);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(60, 23);
            this.BtnNuevo.TabIndex = 21;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(614, 196);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(60, 23);
            this.BtnEliminar.TabIndex = 22;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // LblSeguro
            // 
            this.LblSeguro.AutoSize = true;
            this.LblSeguro.Location = new System.Drawing.Point(373, 79);
            this.LblSeguro.Name = "LblSeguro";
            this.LblSeguro.Size = new System.Drawing.Size(67, 13);
            this.LblSeguro.TabIndex = 23;
            this.LblSeguro.Text = "Seguro (3%):";
            // 
            // LblImpuesto
            // 
            this.LblImpuesto.AutoSize = true;
            this.LblImpuesto.Location = new System.Drawing.Point(364, 116);
            this.LblImpuesto.Name = "LblImpuesto";
            this.LblImpuesto.Size = new System.Drawing.Size(76, 13);
            this.LblImpuesto.TabIndex = 25;
            this.LblImpuesto.Text = "Impuesto (5%):";
            this.LblImpuesto.Click += new System.EventHandler(this.LblImpuesto_Click);
            // 
            // LblGastoGeneral
            // 
            this.LblGastoGeneral.AutoSize = true;
            this.LblGastoGeneral.Location = new System.Drawing.Point(355, 155);
            this.LblGastoGeneral.Name = "LblGastoGeneral";
            this.LblGastoGeneral.Size = new System.Drawing.Size(78, 13);
            this.LblGastoGeneral.TabIndex = 27;
            this.LblGastoGeneral.Text = "Gasto General:";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(91, 155);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(34, 13);
            this.LblTotal.TabIndex = 29;
            this.LblTotal.Text = "Total:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(367, 199);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(60, 23);
            this.BtnCalcular.TabIndex = 31;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtGastoG
            // 
            this.TxtGastoG.Enabled = false;
            this.TxtGastoG.Location = new System.Drawing.Point(345, 173);
            this.TxtGastoG.Name = "TxtGastoG";
            this.TxtGastoG.ReadOnly = true;
            this.TxtGastoG.Size = new System.Drawing.Size(100, 20);
            this.TxtGastoG.TabIndex = 32;
            // 
            // TxtImpuesto
            // 
            this.TxtImpuesto.Enabled = false;
            this.TxtImpuesto.Location = new System.Drawing.Point(345, 132);
            this.TxtImpuesto.Name = "TxtImpuesto";
            this.TxtImpuesto.ReadOnly = true;
            this.TxtImpuesto.Size = new System.Drawing.Size(100, 20);
            this.TxtImpuesto.TabIndex = 33;
            // 
            // TxtSeguro
            // 
            this.TxtSeguro.Enabled = false;
            this.TxtSeguro.Location = new System.Drawing.Point(345, 95);
            this.TxtSeguro.Name = "TxtSeguro";
            this.TxtSeguro.ReadOnly = true;
            this.TxtSeguro.Size = new System.Drawing.Size(100, 20);
            this.TxtSeguro.TabIndex = 34;
            // 
            // TxtSalario
            // 
            this.TxtSalario.Enabled = false;
            this.TxtSalario.Location = new System.Drawing.Point(168, 116);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.ReadOnly = true;
            this.TxtSalario.Size = new System.Drawing.Size(100, 20);
            this.TxtSalario.TabIndex = 35;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(168, 155);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 36;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(this.TxtSeguro);
            this.Controls.Add(this.TxtImpuesto);
            this.Controls.Add(this.TxtGastoG);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblGastoGeneral);
            this.Controls.Add(this.LblImpuesto);
            this.Controls.Add(this.LblSeguro);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.GrdEmpleado);
            this.Controls.Add(this.DtpNacimiento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblCarreaQueEstudia);
            this.Controls.Add(this.TxtNivelDeColaridad);
            this.Controls.Add(this.LblNivelDeColaridad);
            this.Controls.Add(this.LblFechaDeNacimiento);
            this.Controls.Add(this.LblSalario);
            this.Controls.Add(this.TxtLugarDeResidencia);
            this.Controls.Add(this.LblLugarDeResidencia);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.LblEdad);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Name = "FrmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.TextBox TxtLugarDeResidencia;
        private System.Windows.Forms.Label LblLugarDeResidencia;
        private System.Windows.Forms.Label LblSalario;
        private System.Windows.Forms.Label LblFechaDeNacimiento;
        private System.Windows.Forms.TextBox TxtNivelDeColaridad;
        private System.Windows.Forms.Label LblNivelDeColaridad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblCarreaQueEstudia;
        private System.Windows.Forms.DateTimePicker DtpNacimiento;
        private System.Windows.Forms.DataGridView GrdEmpleado;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label LblSeguro;
        private System.Windows.Forms.Label LblImpuesto;
        private System.Windows.Forms.Label LblGastoGeneral;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtGastoG;
        private System.Windows.Forms.TextBox TxtImpuesto;
        private System.Windows.Forms.TextBox TxtSeguro;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.TextBox TxtTotal;
    }
}

