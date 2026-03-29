namespace Gestión_Tutores
{
    partial class Tutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutores));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ExportarCSV = new System.Windows.Forms.Button();
            this.button_Editar = new System.Windows.Forms.Button();
            this.numericUpDown_CuposMax = new System.Windows.Forms.NumericUpDown();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.textBox_Especialidad = new System.Windows.Forms.TextBox();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.textBox_Correo = new System.Windows.Forms.TextBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Cedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_BuscarPor = new System.Windows.Forms.ComboBox();
            this.textBox_Buscar = new System.Windows.Forms.TextBox();
            this.pictureBox_Buscar_Tutor = new System.Windows.Forms.PictureBox();
            this.dataGridView_Tutores = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CuposMax)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Buscar_Tutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tutores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ExportarCSV);
            this.groupBox1.Controls.Add(this.button_Editar);
            this.groupBox1.Controls.Add(this.numericUpDown_CuposMax);
            this.groupBox1.Controls.Add(this.button_Eliminar);
            this.groupBox1.Controls.Add(this.textBox_Especialidad);
            this.groupBox1.Controls.Add(this.button_Agregar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_Telefono);
            this.groupBox1.Controls.Add(this.textBox_Correo);
            this.groupBox1.Controls.Add(this.textBox_Apellido);
            this.groupBox1.Controls.Add(this.textBox_Nombre);
            this.groupBox1.Controls.Add(this.textBox_Cedula);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL TUTOR";
            // 
            // button_ExportarCSV
            // 
            this.button_ExportarCSV.Location = new System.Drawing.Point(664, 169);
            this.button_ExportarCSV.Name = "button_ExportarCSV";
            this.button_ExportarCSV.Size = new System.Drawing.Size(102, 23);
            this.button_ExportarCSV.TabIndex = 14;
            this.button_ExportarCSV.Text = "Exportar CSV";
            this.button_ExportarCSV.UseVisualStyleBackColor = true;

            // 
            // button_Editar
            // 
            this.button_Editar.Location = new System.Drawing.Point(672, 74);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(94, 22);
            this.button_Editar.TabIndex = 4;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = true;
            this.button_Editar.Click += new System.EventHandler(this.button_Editar_Click);
            // 
            // numericUpDown_CuposMax
            // 
            this.numericUpDown_CuposMax.Location = new System.Drawing.Point(480, 56);
            this.numericUpDown_CuposMax.Name = "numericUpDown_CuposMax";
            this.numericUpDown_CuposMax.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_CuposMax.TabIndex = 13;
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(672, 122);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(94, 24);
            this.button_Eliminar.TabIndex = 3;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // textBox_Especialidad
            // 
            this.textBox_Especialidad.Location = new System.Drawing.Point(480, 18);
            this.textBox_Especialidad.Name = "textBox_Especialidad";
            this.textBox_Especialidad.Size = new System.Drawing.Size(157, 22);
            this.textBox_Especialidad.TabIndex = 12;
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(672, 20);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(94, 24);
            this.button_Agregar.TabIndex = 2;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cupo Máximo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Especialidad:";
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(98, 161);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(146, 22);
            this.textBox_Telefono.TabIndex = 9;
            // 
            // textBox_Correo
            // 
            this.textBox_Correo.Location = new System.Drawing.Point(98, 122);
            this.textBox_Correo.Name = "textBox_Correo";
            this.textBox_Correo.Size = new System.Drawing.Size(244, 22);
            this.textBox_Correo.TabIndex = 8;
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(98, 89);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(146, 22);
            this.textBox_Apellido.TabIndex = 7;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(98, 51);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(146, 22);
            this.textBox_Nombre.TabIndex = 6;
            // 
            // textBox_Cedula
            // 
            this.textBox_Cedula.Location = new System.Drawing.Point(98, 22);
            this.textBox_Cedula.Name = "textBox_Cedula";
            this.textBox_Cedula.Size = new System.Drawing.Size(146, 22);
            this.textBox_Cedula.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cédula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestión de tutores";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBox_BuscarPor);
            this.groupBox2.Controls.Add(this.textBox_Buscar);
            this.groupBox2.Controls.Add(this.pictureBox_Buscar_Tutor);
            this.groupBox2.Location = new System.Drawing.Point(815, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 198);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nombre/Cédula:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Buscar por:";
            // 
            // comboBox_BuscarPor
            // 
            this.comboBox_BuscarPor.FormattingEnabled = true;
            this.comboBox_BuscarPor.Items.AddRange(new object[] {
            "Cédula",
            "Nombre"});
            this.comboBox_BuscarPor.Location = new System.Drawing.Point(6, 44);
            this.comboBox_BuscarPor.Name = "comboBox_BuscarPor";
            this.comboBox_BuscarPor.Size = new System.Drawing.Size(154, 24);
            this.comboBox_BuscarPor.TabIndex = 16;
            this.comboBox_BuscarPor.SelectedIndexChanged += new System.EventHandler(this.comboBox_BuscarPor_SelectedIndexChanged);
            // 
            // textBox_Buscar
            // 
            this.textBox_Buscar.Location = new System.Drawing.Point(6, 123);
            this.textBox_Buscar.Name = "textBox_Buscar";
            this.textBox_Buscar.Size = new System.Drawing.Size(154, 22);
            this.textBox_Buscar.TabIndex = 15;
            this.textBox_Buscar.TextChanged += new System.EventHandler(this.textBox_Buscar_TextChanged);
            // 
            // pictureBox_Buscar_Tutor
            // 
            this.pictureBox_Buscar_Tutor.Image = global::Gestión_Tutores.Properties.Resources.Buscar;
            this.pictureBox_Buscar_Tutor.Location = new System.Drawing.Point(205, 72);
            this.pictureBox_Buscar_Tutor.Name = "pictureBox_Buscar_Tutor";
            this.pictureBox_Buscar_Tutor.Size = new System.Drawing.Size(117, 109);
            this.pictureBox_Buscar_Tutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Buscar_Tutor.TabIndex = 14;
            this.pictureBox_Buscar_Tutor.TabStop = false;
            this.pictureBox_Buscar_Tutor.Click += new System.EventHandler(this.pictureBox_Buscar_Tutor_Click);
            // 
            // dataGridView_Tutores
            // 
            this.dataGridView_Tutores.AllowUserToAddRows = false;
            this.dataGridView_Tutores.AllowUserToDeleteRows = false;
            this.dataGridView_Tutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Tutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tutores.Location = new System.Drawing.Point(12, 286);
            this.dataGridView_Tutores.MultiSelect = false;
            this.dataGridView_Tutores.Name = "dataGridView_Tutores";
            this.dataGridView_Tutores.ReadOnly = true;
            this.dataGridView_Tutores.RowHeadersVisible = false;
            this.dataGridView_Tutores.RowHeadersWidth = 51;
            this.dataGridView_Tutores.RowTemplate.Height = 24;
            this.dataGridView_Tutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Tutores.Size = new System.Drawing.Size(1125, 480);
            this.dataGridView_Tutores.TabIndex = 17;
            this.dataGridView_Tutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Tutores_CellClick);
            // 
            // Tutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 778);
            this.Controls.Add(this.dataGridView_Tutores);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tutores";
            this.Text = "Tutores";
            this.Load += new System.EventHandler(this.Tutores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CuposMax)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Buscar_Tutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.NumericUpDown numericUpDown_CuposMax;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.TextBox textBox_Especialidad;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.TextBox textBox_Correo;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Cedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_BuscarPor;
        private System.Windows.Forms.TextBox textBox_Buscar;
        private System.Windows.Forms.PictureBox pictureBox_Buscar_Tutor;
        private System.Windows.Forms.DataGridView dataGridView_Tutores;
        private System.Windows.Forms.Button button_ExportarCSV;
    }
}

