namespace Gestión_Inscripciones
{
    partial class Inscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscripciones));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ExportarCSV = new System.Windows.Forms.Button();
            this.textBox_CuposDisponibles = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_CuposOcupados = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_AgregarInscripcion = new System.Windows.Forms.Button();
            this.comboBox_Horario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Tutor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Estudiante = new System.Windows.Forms.ComboBox();
            this.dataGridView_Inscripciones = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Inscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Inscripciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ExportarCSV);
            this.groupBox1.Controls.Add(this.textBox_CuposDisponibles);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_CuposOcupados);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button_AgregarInscripcion);
            this.groupBox1.Controls.Add(this.comboBox_Horario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_Tutor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_Estudiante);
            this.groupBox1.Location = new System.Drawing.Point(13, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE LA INSCRIPCIÓN";
            // 
            // button_ExportarCSV
            // 
            this.button_ExportarCSV.Location = new System.Drawing.Point(940, 27);
            this.button_ExportarCSV.Name = "button_ExportarCSV";
            this.button_ExportarCSV.Size = new System.Drawing.Size(118, 23);
            this.button_ExportarCSV.TabIndex = 12;
            this.button_ExportarCSV.Text = "Exportar CSV";
            this.button_ExportarCSV.UseVisualStyleBackColor = true;
          
            // 
            // textBox_CuposDisponibles
            // 
            this.textBox_CuposDisponibles.Location = new System.Drawing.Point(626, 69);
            this.textBox_CuposDisponibles.Name = "textBox_CuposDisponibles";
            this.textBox_CuposDisponibles.ReadOnly = true;
            this.textBox_CuposDisponibles.Size = new System.Drawing.Size(224, 22);
            this.textBox_CuposDisponibles.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cupos disponibles:";
            // 
            // textBox_CuposOcupados
            // 
            this.textBox_CuposOcupados.Location = new System.Drawing.Point(626, 29);
            this.textBox_CuposOcupados.Name = "textBox_CuposOcupados";
            this.textBox_CuposOcupados.ReadOnly = true;
            this.textBox_CuposOcupados.Size = new System.Drawing.Size(224, 22);
            this.textBox_CuposOcupados.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cupos ocupados:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 7;
            // 
            // button_AgregarInscripcion
            // 
            this.button_AgregarInscripcion.Location = new System.Drawing.Point(323, 29);
            this.button_AgregarInscripcion.Name = "button_AgregarInscripcion";
            this.button_AgregarInscripcion.Size = new System.Drawing.Size(75, 23);
            this.button_AgregarInscripcion.TabIndex = 6;
            this.button_AgregarInscripcion.Text = "Inscribir";
            this.button_AgregarInscripcion.UseVisualStyleBackColor = true;
            this.button_AgregarInscripcion.Click += new System.EventHandler(this.button_AgregarInscripcion_Click);
            // 
            // comboBox_Horario
            // 
            this.comboBox_Horario.FormattingEnabled = true;
            this.comboBox_Horario.Location = new System.Drawing.Point(98, 123);
            this.comboBox_Horario.Name = "comboBox_Horario";
            this.comboBox_Horario.Size = new System.Drawing.Size(147, 24);
            this.comboBox_Horario.TabIndex = 5;
            this.comboBox_Horario.SelectedIndexChanged += new System.EventHandler(this.comboBox_Horario_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Horario:";
            // 
            // comboBox_Tutor
            // 
            this.comboBox_Tutor.FormattingEnabled = true;
            this.comboBox_Tutor.Location = new System.Drawing.Point(98, 75);
            this.comboBox_Tutor.Name = "comboBox_Tutor";
            this.comboBox_Tutor.Size = new System.Drawing.Size(147, 24);
            this.comboBox_Tutor.TabIndex = 3;
            this.comboBox_Tutor.SelectedIndexChanged += new System.EventHandler(this.comboBox_Tutor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tutor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estudiante:";
            // 
            // comboBox_Estudiante
            // 
            this.comboBox_Estudiante.FormattingEnabled = true;
            this.comboBox_Estudiante.Location = new System.Drawing.Point(98, 29);
            this.comboBox_Estudiante.Name = "comboBox_Estudiante";
            this.comboBox_Estudiante.Size = new System.Drawing.Size(147, 24);
            this.comboBox_Estudiante.TabIndex = 0;
            this.comboBox_Estudiante.SelectedIndexChanged += new System.EventHandler(this.comboBox_Estudiante_SelectedIndexChanged);
            // 
            // dataGridView_Inscripciones
            // 
            this.dataGridView_Inscripciones.AllowUserToAddRows = false;
            this.dataGridView_Inscripciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Inscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Inscripciones.Location = new System.Drawing.Point(13, 288);
            this.dataGridView_Inscripciones.MultiSelect = false;
            this.dataGridView_Inscripciones.Name = "dataGridView_Inscripciones";
            this.dataGridView_Inscripciones.ReadOnly = true;
            this.dataGridView_Inscripciones.RowHeadersWidth = 51;
            this.dataGridView_Inscripciones.RowTemplate.Height = 24;
            this.dataGridView_Inscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Inscripciones.Size = new System.Drawing.Size(1131, 488);
            this.dataGridView_Inscripciones.TabIndex = 2;
            // 
            // Inscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 778);
            this.Controls.Add(this.dataGridView_Inscripciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inscripciones";
            this.Text = "Inscripciones";
            this.Load += new System.EventHandler(this.Inscripciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Inscripciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_AgregarInscripcion;
        private System.Windows.Forms.ComboBox comboBox_Horario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Tutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Estudiante;
        private System.Windows.Forms.DataGridView dataGridView_Inscripciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_CuposOcupados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_CuposDisponibles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_ExportarCSV;
    }
}

