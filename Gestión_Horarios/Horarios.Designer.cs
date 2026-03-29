namespace Gestión_Horarios
{
    partial class Horarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Horarios));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ExportarCSV = new System.Windows.Forms.Button();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.button_Editar = new System.Windows.Forms.Button();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.comboBox_Hora = new System.Windows.Forms.ComboBox();
            this.comboBox_Dias = new System.Windows.Forms.ComboBox();
            this.textBox_Aula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Horarios = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Horarios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ExportarCSV);
            this.groupBox1.Controls.Add(this.button_Eliminar);
            this.groupBox1.Controls.Add(this.button_Editar);
            this.groupBox1.Controls.Add(this.button_Agregar);
            this.groupBox1.Controls.Add(this.comboBox_Hora);
            this.groupBox1.Controls.Add(this.comboBox_Dias);
            this.groupBox1.Controls.Add(this.textBox_Aula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL HORARIO";

            // 
            // button_ExportarCSV
            // 
            this.button_ExportarCSV.Location = new System.Drawing.Point(617, 63);
            this.button_ExportarCSV.Name = "button_ExportarCSV";
            this.button_ExportarCSV.Size = new System.Drawing.Size(110, 23);
            this.button_ExportarCSV.TabIndex = 9;
            this.button_ExportarCSV.Text = "Exportar CSV";
            this.button_ExportarCSV.UseVisualStyleBackColor = true;
        
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(242, 63);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(99, 23);
            this.button_Eliminar.TabIndex = 8;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // button_Editar
            // 
            this.button_Editar.Location = new System.Drawing.Point(68, 63);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(99, 23);
            this.button_Editar.TabIndex = 7;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = true;
            this.button_Editar.Click += new System.EventHandler(this.button_Editar_Click);
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(422, 62);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(99, 24);
            this.button_Agregar.TabIndex = 6;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // comboBox_Hora
            // 
            this.comboBox_Hora.FormattingEnabled = true;
            this.comboBox_Hora.Items.AddRange(new object[] {
            "09:00-10:00",
            "15:00-16:00",
            "16:00-17:00",
            "08:00-09:00",
            "13:00-14:00",
            "19:00-20:00",
            "11:00-12:00"});
            this.comboBox_Hora.Location = new System.Drawing.Point(300, 18);
            this.comboBox_Hora.Name = "comboBox_Hora";
            this.comboBox_Hora.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Hora.TabIndex = 5;
            // 
            // comboBox_Dias
            // 
            this.comboBox_Dias.FormattingEnabled = true;
            this.comboBox_Dias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes"});
            this.comboBox_Dias.Location = new System.Drawing.Point(83, 18);
            this.comboBox_Dias.Name = "comboBox_Dias";
            this.comboBox_Dias.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Dias.TabIndex = 4;
            // 
            // textBox_Aula
            // 
            this.textBox_Aula.Location = new System.Drawing.Point(533, 20);
            this.textBox_Aula.Name = "textBox_Aula";
            this.textBox_Aula.Size = new System.Drawing.Size(126, 22);
            this.textBox_Aula.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Aula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Día:";
            // 
            // dataGridView_Horarios
            // 
            this.dataGridView_Horarios.AllowUserToAddRows = false;
            this.dataGridView_Horarios.AllowUserToDeleteRows = false;
            this.dataGridView_Horarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Horarios.Location = new System.Drawing.Point(12, 156);
            this.dataGridView_Horarios.MultiSelect = false;
            this.dataGridView_Horarios.Name = "dataGridView_Horarios";
            this.dataGridView_Horarios.ReadOnly = true;
            this.dataGridView_Horarios.RowHeadersWidth = 51;
            this.dataGridView_Horarios.RowTemplate.Height = 24;
            this.dataGridView_Horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Horarios.Size = new System.Drawing.Size(793, 485);
            this.dataGridView_Horarios.TabIndex = 2;
            this.dataGridView_Horarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Horarios_CellClick);
            // 
            // Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 653);
            this.Controls.Add(this.dataGridView_Horarios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Horarios";
            this.Text = "Horarios";
            this.Load += new System.EventHandler(this.Horarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Horarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.ComboBox comboBox_Hora;
        private System.Windows.Forms.ComboBox comboBox_Dias;
        private System.Windows.Forms.TextBox textBox_Aula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Horarios;
        private System.Windows.Forms.Button button_ExportarCSV;
    }
}

