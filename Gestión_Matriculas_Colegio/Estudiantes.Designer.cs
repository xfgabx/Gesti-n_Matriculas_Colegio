namespace Gestión_Estudiante
{
    partial class Estudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estudiantes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_Generos = new System.Windows.Forms.GroupBox();
            this.radioButton_Masculino = new System.Windows.Forms.RadioButton();
            this.radioButton_Femenino = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.textBox_Correo = new System.Windows.Forms.TextBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Cedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.button_Editar = new System.Windows.Forms.Button();
            this.dataGridView_Estudiantes = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox_Buscar_Estudiante = new System.Windows.Forms.PictureBox();
            this.comboBox_BuscarPor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Buscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_ExportarCSV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox_Generos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Estudiantes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Buscar_Estudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox_Generos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_Telefono);
            this.groupBox1.Controls.Add(this.textBox_Correo);
            this.groupBox1.Controls.Add(this.textBox_Apellido);
            this.groupBox1.Controls.Add(this.textBox_Nombre);
            this.groupBox1.Controls.Add(this.textBox_Cedula);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL ESTUDIANTE";
            // 
            // groupBox_Generos
            // 
            this.groupBox_Generos.Controls.Add(this.radioButton_Masculino);
            this.groupBox_Generos.Controls.Add(this.radioButton_Femenino);
            this.groupBox_Generos.Location = new System.Drawing.Point(365, 11);
            this.groupBox_Generos.Name = "groupBox_Generos";
            this.groupBox_Generos.Size = new System.Drawing.Size(200, 77);
            this.groupBox_Generos.TabIndex = 13;
            this.groupBox_Generos.TabStop = false;
            // 
            // radioButton_Masculino
            // 
            this.radioButton_Masculino.AutoSize = true;
            this.radioButton_Masculino.Location = new System.Drawing.Point(6, 21);
            this.radioButton_Masculino.Name = "radioButton_Masculino";
            this.radioButton_Masculino.Size = new System.Drawing.Size(82, 20);
            this.radioButton_Masculino.TabIndex = 11;
            this.radioButton_Masculino.TabStop = true;
            this.radioButton_Masculino.Text = "Maculino";
            this.radioButton_Masculino.UseVisualStyleBackColor = true;
            // 
            // radioButton_Femenino
            // 
            this.radioButton_Femenino.AutoSize = true;
            this.radioButton_Femenino.Location = new System.Drawing.Point(6, 50);
            this.radioButton_Femenino.Name = "radioButton_Femenino";
            this.radioButton_Femenino.Size = new System.Drawing.Size(88, 20);
            this.radioButton_Femenino.TabIndex = 12;
            this.radioButton_Femenino.TabStop = true;
            this.radioButton_Femenino.Text = "Femenino";
            this.radioButton_Femenino.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Género:";
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(108, 174);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(145, 22);
            this.textBox_Telefono.TabIndex = 9;
            // 
            // textBox_Correo
            // 
            this.textBox_Correo.Location = new System.Drawing.Point(108, 138);
            this.textBox_Correo.Name = "textBox_Correo";
            this.textBox_Correo.Size = new System.Drawing.Size(285, 22);
            this.textBox_Correo.TabIndex = 8;
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(108, 101);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(145, 22);
            this.textBox_Apellido.TabIndex = 7;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(108, 66);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(145, 22);
            this.textBox_Nombre.TabIndex = 6;
            // 
            // textBox_Cedula
            // 
            this.textBox_Cedula.Location = new System.Drawing.Point(108, 33);
            this.textBox_Cedula.Name = "textBox_Cedula";
            this.textBox_Cedula.Size = new System.Drawing.Size(145, 22);
            this.textBox_Cedula.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula:";
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(641, 60);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(86, 27);
            this.button_Agregar.TabIndex = 14;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(641, 112);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(86, 23);
            this.button_Eliminar.TabIndex = 15;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // button_Editar
            // 
            this.button_Editar.Location = new System.Drawing.Point(641, 166);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(86, 24);
            this.button_Editar.TabIndex = 16;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = true;
            this.button_Editar.Click += new System.EventHandler(this.button_Editar_Click);
            // 
            // dataGridView_Estudiantes
            // 
            this.dataGridView_Estudiantes.AllowUserToAddRows = false;
            this.dataGridView_Estudiantes.AllowUserToDeleteRows = false;
            this.dataGridView_Estudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Estudiantes.Location = new System.Drawing.Point(13, 294);
            this.dataGridView_Estudiantes.MultiSelect = false;
            this.dataGridView_Estudiantes.Name = "dataGridView_Estudiantes";
            this.dataGridView_Estudiantes.ReadOnly = true;
            this.dataGridView_Estudiantes.RowHeadersWidth = 51;
            this.dataGridView_Estudiantes.RowTemplate.Height = 24;
            this.dataGridView_Estudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Estudiantes.Size = new System.Drawing.Size(1119, 473);
            this.dataGridView_Estudiantes.TabIndex = 1;
            this.dataGridView_Estudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Estudiantes_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(389, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "GESTIÓN DE ESTUDIANTES";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox_Buscar_Estudiante);
            this.groupBox2.Controls.Add(this.comboBox_BuscarPor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_Buscar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(783, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 210);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR ESTUDIANTE";
            // 
            // pictureBox_Buscar_Estudiante
            // 
            this.pictureBox_Buscar_Estudiante.Image = global::Gestión_Matriculas_Colegio.Properties.Resources.Buscar;
            this.pictureBox_Buscar_Estudiante.Location = new System.Drawing.Point(81, 99);
            this.pictureBox_Buscar_Estudiante.Name = "pictureBox_Buscar_Estudiante";
            this.pictureBox_Buscar_Estudiante.Size = new System.Drawing.Size(196, 105);
            this.pictureBox_Buscar_Estudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Buscar_Estudiante.TabIndex = 4;
            this.pictureBox_Buscar_Estudiante.TabStop = false;
            this.pictureBox_Buscar_Estudiante.Click += new System.EventHandler(this.pictureBox_Buscar_Estudiante_Click);
            // 
            // comboBox_BuscarPor
            // 
            this.comboBox_BuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BuscarPor.FormattingEnabled = true;
            this.comboBox_BuscarPor.Items.AddRange(new object[] {
            "Cédula",
            "Nombre"});
            this.comboBox_BuscarPor.Location = new System.Drawing.Point(118, 25);
            this.comboBox_BuscarPor.Name = "comboBox_BuscarPor";
            this.comboBox_BuscarPor.Size = new System.Drawing.Size(201, 24);
            this.comboBox_BuscarPor.TabIndex = 3;
            this.comboBox_BuscarPor.SelectedIndexChanged += new System.EventHandler(this.comboBox_BuscarPor_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Buscar por:";
            // 
            // textBox_Buscar
            // 
            this.textBox_Buscar.Location = new System.Drawing.Point(118, 71);
            this.textBox_Buscar.Name = "textBox_Buscar";
            this.textBox_Buscar.Size = new System.Drawing.Size(201, 22);
            this.textBox_Buscar.TabIndex = 1;
            this.textBox_Buscar.TextChanged += new System.EventHandler(this.textBox_Buscar_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre/Cédula:";
            // 
            // button_ExportarCSV
            // 
            this.button_ExportarCSV.Location = new System.Drawing.Point(641, 223);
            this.button_ExportarCSV.Name = "button_ExportarCSV";
            this.button_ExportarCSV.Size = new System.Drawing.Size(103, 23);
            this.button_ExportarCSV.TabIndex = 19;
            this.button_ExportarCSV.Text = "Exportar CSV";
            this.button_ExportarCSV.UseVisualStyleBackColor = true;
        
            // 
            // Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 779);
            this.Controls.Add(this.button_ExportarCSV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Editar);
            this.Controls.Add(this.dataGridView_Estudiantes);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Agregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estudiantes";
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.Estudiantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Generos.ResumeLayout(false);
            this.groupBox_Generos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Estudiantes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Buscar_Estudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Masculino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.TextBox textBox_Correo;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Cedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.GroupBox groupBox_Generos;
        private System.Windows.Forms.RadioButton radioButton_Femenino;
        private System.Windows.Forms.DataGridView dataGridView_Estudiantes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_BuscarPor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Buscar;
        private System.Windows.Forms.PictureBox pictureBox_Buscar_Estudiante;
        private System.Windows.Forms.Button button_ExportarCSV;
    }
}

