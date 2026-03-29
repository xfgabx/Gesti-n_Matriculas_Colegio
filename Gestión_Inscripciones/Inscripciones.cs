using Gestión_Estudiante;
using Gestión_Horarios;
using Gestión_Matriculas_Colegio;
using Gestión_Tutores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_Inscripciones
{
    public partial class Inscripciones : Form
    {
        public static List<Inscripcion> listaInscripciones= new List<Inscripcion>();
        Estudiante estudianteSeleccionado;
        Tutor tutorSeleccionado;
        Horario horarioSeleccionado;
        int fila = -1;
        public Inscripciones()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            comboBox_Estudiante.Text=string.Empty;
            comboBox_Horario.Text=string.Empty;
            comboBox_Tutor.Text=string.Empty;
            fila = -1;
        }
        private bool ValidarInscripcion()
        {
            if (comboBox_Estudiante.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un estudiante", "Seleccionar",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(comboBox_Tutor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tutor", "Seleccionar",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comboBox_Horario.SelectedIndex==-1)
            {
                MessageBox.Show("Seleccione un horario", "Seleccionar",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            int cuposOcupados = 0;
            for (int i = 0; i < listaInscripciones.Count; i++)
            {
                if (listaInscripciones[i].CedulaTutor == tutorSeleccionado.Cedula)
                {
                    cuposOcupados++;
                }
            }
            if (cuposOcupados >= tutorSeleccionado.CuposMaximos)
            {
                MessageBox.Show("El tutor seleccionado ya no tiene más cupos disponibles", "Agotados",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            for (int i = 0; i < listaInscripciones.Count; i++)
            {
                if (listaInscripciones[i].CedulaEstudiante==estudianteSeleccionado.Cedula &&
                    listaInscripciones[i].Dia==horarioSeleccionado.Dia && 
                    listaInscripciones[i].Hora == horarioSeleccionado.Hora)
                {
                    MessageBox.Show("El estudiante ya se encuentra registrado en una tutoria en dicho horario",
                        "Cambiar de opción",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        private void MostrarInscripciones()
        {
            dataGridView_Inscripciones.Rows.Clear();
            foreach (var item in listaInscripciones)
            {
                dataGridView_Inscripciones.Rows.Add(item.CedulaEstudiante,item.NombreEstudiante,
                    item.CedulaTutor,item.NombreTutor,item.Dia,item.Hora,item.Aula);
            }
        }
        private void ActualizarResumen()
        {
            int cuposOcupados = 0;
            int cuposTotales = 0;
            for (int i = 0; i < Tutores.listaTutores.Count; i++)
            {
                cuposTotales += Tutores.listaTutores[i].CuposMaximos;
                for (int j = 0; j < listaInscripciones.Count; j++)
                {
                    if (listaInscripciones[j].CedulaTutor == Tutores.listaTutores[i].Cedula)
                    {
                        cuposOcupados++;
                    }
                }
            }
            int cuposDisponibles = cuposTotales - cuposOcupados;
            textBox_CuposDisponibles.Text=cuposDisponibles.ToString();
            textBox_CuposOcupados.Text=cuposOcupados.ToString();
        }
        private void Inscripciones_Load(object sender, EventArgs e)
        {
            dataGridView_Inscripciones.Columns.Clear();
            dataGridView_Inscripciones.Columns.Add("C.I Estudiante", "Cédula del estudiante");
            dataGridView_Inscripciones.Columns.Add("Nombre Estudiante", "Nombre del estudiante");
            dataGridView_Inscripciones.Columns.Add("C.I Tutor", "Cédula del tutor");
            dataGridView_Inscripciones.Columns.Add("Nombre Tutor", "Nombre del tutor");
            dataGridView_Inscripciones.Columns.Add("Dia", "Día");
            dataGridView_Inscripciones.Columns.Add("Hora", "Hora");
            dataGridView_Inscripciones.Columns.Add("Aula", "Aula");
            comboBox_Estudiante.Items.Clear();
            foreach (var est in Estudiantes.listaEstudiantes)
            {
                comboBox_Estudiante.Items.Add(est.Nombre);
            }
            comboBox_Tutor.Items.Clear();
            foreach (var tut in Tutores.listaTutores)
            {
                comboBox_Tutor.Items.Add(tut.Nombre);
            }
            comboBox_Horario.Items.Clear();
            foreach (var hor in Horarios.listaHorarios) { 
            comboBox_Horario.Items.Add(hor.Dia + " " + hor.Hora + " - " + hor.Aula);
            }
        }

        private void button_AgregarInscripcion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarInscripcion())
                {
                    return;
                }
                Inscripcion inscripcion= new Inscripcion();
                inscripcion.CedulaEstudiante = estudianteSeleccionado.Cedula;
                inscripcion.NombreEstudiante = estudianteSeleccionado.Nombre;
                inscripcion.CedulaTutor = tutorSeleccionado.Cedula;
                inscripcion.NombreTutor = tutorSeleccionado.Nombre;
                inscripcion.Dia=horarioSeleccionado.Dia;
                inscripcion.Hora=horarioSeleccionado.Hora;
                inscripcion.Aula=horarioSeleccionado.Aula;
                listaInscripciones.Add(inscripcion);
                MostrarInscripciones();
                ActualizarResumen();
                LimpiarCampos();
                MessageBox.Show("Inscripción realizada con éxito", "Éxito",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente error: " + ex.Message, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_Estudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            estudianteSeleccionado = Estudiantes.listaEstudiantes[comboBox_Estudiante.SelectedIndex];
        }

        private void comboBox_Tutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            tutorSeleccionado = Tutores.listaTutores[comboBox_Tutor.SelectedIndex];
        }

        private void comboBox_Horario_SelectedIndexChanged(object sender, EventArgs e)
        {
            horarioSeleccionado= Horarios.listaHorarios[comboBox_Horario.SelectedIndex];
        }

    }
}
