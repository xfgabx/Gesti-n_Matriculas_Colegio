using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_Horarios
{
    public partial class Horarios : Form
    {
        public static List<Horario> listaHorarios = new List<Horario>();
        int fila = -1;
        public Horarios()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            comboBox_Dias.Text = string.Empty;
            comboBox_Hora.Text = string.Empty;
            textBox_Aula.Text = string.Empty;
            fila = -1;
        }
        private bool ValidarCampos()
        {

            if (comboBox_Dias.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese el día", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_Dias.Focus();
                return false;
            }
            if (comboBox_Hora.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese la hora", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_Hora.Focus();
                return false;
            }
            if (textBox_Aula.Text == "")
            {
                MessageBox.Show("Ingrese el aula", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Aula.Focus();
                return false;
            }
            return true;

        }
        private void MostrarHorarios()
        {
            dataGridView_Horarios.Rows.Clear();
            foreach (var item in listaHorarios)
            {
                dataGridView_Horarios.Rows.Add(item.Dia, item.Hora, item.Aula);
            }
        }
        private void Horarios_Load(object sender, EventArgs e)
        {
            dataGridView_Horarios.Columns.Clear();
            dataGridView_Horarios.Columns.Add("Dia", "Día");
            dataGridView_Horarios.Columns.Add("Hora", "Hora");
            dataGridView_Horarios.Columns.Add("Aula", "Aula");
        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (fila == -1)
                {
                    MessageBox.Show("Seleccione un horario de la tabla", "Seleccionar horario",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ValidarCampos() == false)
                {
                    return;
                }
                listaHorarios[fila].Dia=comboBox_Dias.Text;
                listaHorarios[fila].Hora=comboBox_Hora.Text;
                listaHorarios[fila].Aula=textBox_Aula.Text;
                MostrarHorarios();
                LimpiarCampos();
                MessageBox.Show("Horario actualizado correctamente", "Horario actualizado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se detectó el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (fila == -1)
                {
                    MessageBox.Show("Seleccione un horario de la tabla", "Seleccionar",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar al horario del día: "
                    + comboBox_Dias.Text +" en el horario de: "+comboBox_Hora.Text+ " ?"
                    , "Eliminar horario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    listaHorarios.RemoveAt(fila);
                    MostrarHorarios();
                    LimpiarCampos();
                    MessageBox.Show("Horario eliminado correctamente", "Eliminación", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se detectó el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                {
                    return;
                }
                Horario horario = new Horario();
                horario.Dia = comboBox_Dias.Text;
                horario.Hora= comboBox_Hora.Text;
                horario.Aula=textBox_Aula.Text;
                listaHorarios.Add(horario);
                MostrarHorarios();
                LimpiarCampos();
                MessageBox.Show("Horario agregado con éxito", "Éxito",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se detectó el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Horarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                fila=e.RowIndex;
                comboBox_Dias.Text = dataGridView_Horarios.Rows[fila].Cells[0].Value.ToString();
                comboBox_Hora.Text= dataGridView_Horarios.Rows[fila].Cells[1].Value.ToString();
                textBox_Aula.Text= dataGridView_Horarios.Rows[fila].Cells[2].Value.ToString();
            }
        }

    }
}
