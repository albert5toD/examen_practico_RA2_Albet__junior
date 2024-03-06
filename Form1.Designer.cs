namespace proyectofinal_RA2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cbo_Curso = new System.Windows.Forms.ComboBox();
            this.cbo_Area = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.txt_maestro = new System.Windows.Forms.TextBox();
            this.cbo_seccion = new System.Windows.Forms.ComboBox();
            this.cbo_genero = new System.Windows.Forms.ComboBox();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgvMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_maestro_titular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Maestro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Area_tecnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maestro titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Matricula";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(176, 154);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(100, 26);
            this.txt_direccion.TabIndex = 10;
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(176, 57);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(100, 26);
            this.txt_matricula.TabIndex = 14;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(176, 260);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 26);
            this.txt_email.TabIndex = 15;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(176, 199);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 26);
            this.txt_telefono.TabIndex = 16;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(176, 104);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 26);
            this.txt_nombre.TabIndex = 17;
            // 
            // cbo_Curso
            // 
            this.cbo_Curso.FormattingEnabled = true;
            this.cbo_Curso.Items.AddRange(new object[] {
            "4TO-D1",
            "4TO-D2",
            "5TO-D1",
            "5TO-D2",
            "6TO-D1",
            "6TO-D2"});
            this.cbo_Curso.Location = new System.Drawing.Point(372, 152);
            this.cbo_Curso.Name = "cbo_Curso";
            this.cbo_Curso.Size = new System.Drawing.Size(121, 28);
            this.cbo_Curso.TabIndex = 21;
            this.cbo_Curso.SelectedIndexChanged += new System.EventHandler(this.cbo_Curso_SelectedIndexChanged);
            // 
            // cbo_Area
            // 
            this.cbo_Area.FormattingEnabled = true;
            this.cbo_Area.Items.AddRange(new object[] {
            "Informatica",
            "Gastronomia",
            "Electricidad",
            "Enfermeria",
            "Contabilidad"});
            this.cbo_Area.Location = new System.Drawing.Point(537, 152);
            this.cbo_Area.Name = "cbo_Area";
            this.cbo_Area.Size = new System.Drawing.Size(121, 28);
            this.cbo_Area.TabIndex = 22;
            this.cbo_Area.SelectedIndexChanged += new System.EventHandler(this.cbo_Area_SelectedIndexChanged);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_agregar.Location = new System.Drawing.Point(836, 240);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(145, 46);
            this.btn_agregar.TabIndex = 23;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_nuevo.Location = new System.Drawing.Point(685, 240);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(145, 46);
            this.btn_nuevo.TabIndex = 24;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_borrar.Location = new System.Drawing.Point(523, 240);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(145, 46);
            this.btn_borrar.TabIndex = 25;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Red;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Salir.Location = new System.Drawing.Point(348, 238);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(145, 46);
            this.btn_Salir.TabIndex = 26;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // txt_maestro
            // 
            this.txt_maestro.Location = new System.Drawing.Point(176, 320);
            this.txt_maestro.Name = "txt_maestro";
            this.txt_maestro.Size = new System.Drawing.Size(100, 26);
            this.txt_maestro.TabIndex = 27;
            // 
            // cbo_seccion
            // 
            this.cbo_seccion.FormattingEnabled = true;
            this.cbo_seccion.Items.AddRange(new object[] {
            "D1",
            "D2",
            "A1",
            "A2",
            "A3",
            "C",
            "E"});
            this.cbo_seccion.Location = new System.Drawing.Point(685, 152);
            this.cbo_seccion.Name = "cbo_seccion";
            this.cbo_seccion.Size = new System.Drawing.Size(121, 28);
            this.cbo_seccion.TabIndex = 28;
            this.cbo_seccion.SelectedIndexChanged += new System.EventHandler(this.cbo_seccion_SelectedIndexChanged);
            // 
            // cbo_genero
            // 
            this.cbo_genero.FormattingEnabled = true;
            this.cbo_genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbo_genero.Location = new System.Drawing.Point(836, 152);
            this.cbo_genero.Name = "cbo_genero";
            this.cbo_genero.Size = new System.Drawing.Size(121, 28);
            this.cbo_genero.TabIndex = 29;
            this.cbo_genero.SelectedIndexChanged += new System.EventHandler(this.cbo_genero_SelectedIndexChanged);
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToOrderColumns = true;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMatricula,
            this.dgv_Nombre,
            this.dgv_direccion,
            this.dgv_telefono,
            this.dgv_maestro_titular,
            this.dgv_Genero,
            this.dgv_Maestro,
            this.dgv_Area_tecnica,
            this.dgvCurso,
            this.dgv_seccion});
            this.dgv_datos.Location = new System.Drawing.Point(-12, 403);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.RowHeadersWidth = 62;
            this.dgv_datos.RowTemplate.Height = 28;
            this.dgv_datos.Size = new System.Drawing.Size(1560, 271);
            this.dgv_datos.TabIndex = 30;
            this.dgv_datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_datos_CellContentClick);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_guardar.Location = new System.Drawing.Point(592, 299);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(145, 46);
            this.btn_guardar.TabIndex = 31;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dgvMatricula
            // 
            this.dgvMatricula.HeaderText = "Matricula";
            this.dgvMatricula.MinimumWidth = 8;
            this.dgvMatricula.Name = "dgvMatricula";
            this.dgvMatricula.Width = 150;
            // 
            // dgv_Nombre
            // 
            this.dgv_Nombre.HeaderText = "Nombre";
            this.dgv_Nombre.MinimumWidth = 8;
            this.dgv_Nombre.Name = "dgv_Nombre";
            this.dgv_Nombre.Width = 150;
            // 
            // dgv_direccion
            // 
            this.dgv_direccion.HeaderText = "Direccion";
            this.dgv_direccion.MinimumWidth = 8;
            this.dgv_direccion.Name = "dgv_direccion";
            this.dgv_direccion.Width = 150;
            // 
            // dgv_telefono
            // 
            this.dgv_telefono.HeaderText = "Telefono";
            this.dgv_telefono.MinimumWidth = 8;
            this.dgv_telefono.Name = "dgv_telefono";
            this.dgv_telefono.Width = 150;
            // 
            // dgv_maestro_titular
            // 
            this.dgv_maestro_titular.HeaderText = "Email";
            this.dgv_maestro_titular.MinimumWidth = 8;
            this.dgv_maestro_titular.Name = "dgv_maestro_titular";
            this.dgv_maestro_titular.Width = 150;
            // 
            // dgv_Genero
            // 
            this.dgv_Genero.HeaderText = "Genero";
            this.dgv_Genero.MinimumWidth = 8;
            this.dgv_Genero.Name = "dgv_Genero";
            this.dgv_Genero.Width = 150;
            // 
            // dgv_Maestro
            // 
            this.dgv_Maestro.HeaderText = "Maestro";
            this.dgv_Maestro.MinimumWidth = 8;
            this.dgv_Maestro.Name = "dgv_Maestro";
            this.dgv_Maestro.Width = 150;
            // 
            // dgv_Area_tecnica
            // 
            this.dgv_Area_tecnica.HeaderText = "Area tecnica";
            this.dgv_Area_tecnica.MinimumWidth = 8;
            this.dgv_Area_tecnica.Name = "dgv_Area_tecnica";
            this.dgv_Area_tecnica.Width = 150;
            // 
            // dgvCurso
            // 
            this.dgvCurso.HeaderText = "Curso";
            this.dgvCurso.MinimumWidth = 8;
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.Width = 150;
            // 
            // dgv_seccion
            // 
            this.dgv_seccion.HeaderText = "Seccion";
            this.dgv_seccion.MinimumWidth = 8;
            this.dgv_seccion.Name = "dgv_seccion";
            this.dgv_seccion.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1395, 675);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.cbo_genero);
            this.Controls.Add(this.cbo_seccion);
            this.Controls.Add(this.txt_maestro);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.cbo_Area);
            this.Controls.Add(this.cbo_Curso);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cbo_Curso;
        private System.Windows.Forms.ComboBox cbo_Area;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox txt_maestro;
        private System.Windows.Forms.ComboBox cbo_seccion;
        private System.Windows.Forms.ComboBox cbo_genero;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_maestro_titular;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Maestro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Area_tecnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_seccion;
    }
}

