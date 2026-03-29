
using Gestión_Matriculas_Colegio;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gestión_Estudiante
{
    public partial class Estudiantes : Form
    {
        public static List<Estudiante> listaEstudiantes = new List<Estudiante>();
        int fila = -1;
        public Estudiantes()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            textBox_Cedula.Text = string.Empty;
            textBox_Apellido.Text = string.Empty;
            textBox_Correo.Text = string.Empty;
            textBox_Nombre.Text = string.Empty;
            textBox_Telefono.Text = string.Empty;
            radioButton_Femenino.Checked = false;
            radioButton_Masculino.Checked = false;
            textBox_Cedula.Focus();
            fila = -1;
        }
        private string ObtenerGenero()
        {
            string genero = "";

            if (radioButton_Masculino.Checked == true)
            {
                genero = "Masculino";

            }
            else if (radioButton_Femenino.Checked == true)
            {
                genero = "Femenino";
            }
            return genero;
        }
        private bool ValidarCampos()
        {
            if (textBox_Cedula.Text == "")
            {
                MessageBox.Show("Ingrese la cédula", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Cedula.Focus();
                return false;
            }
            for (int i = 0; i < textBox_Cedula.Text.Length; i++)
            {
                if (char.IsDigit(textBox_Cedula.Text[i]) == false)
                {
                    MessageBox.Show("La cédula debe contener únicamente números",
                        "Cédula inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_Cedula.Focus();
                    return false;
                }
            }
            if (textBox_Cedula.Text.Length != 10)
            {
                MessageBox.Show("La cédula no puede tener más o menos de 10 dígitos",
                    "Cédula inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Cedula.Focus();
                return false;
            }
            if (textBox_Nombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Nombre.Focus();
                return false;
            }
            for (int i = 0; i < textBox_Nombre.Text.Length; i++)
            {
                if (char.IsLetter(textBox_Nombre.Text[i]) == false)
                {
                    MessageBox.Show("El nombre debe contener únicamente letras",
                        "Nombre inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_Nombre.Focus();
                    return false;
                }
            }
            if (textBox_Nombre.Text.Length < 3)
            {
                MessageBox.Show("El nombre debe tener por lo menos 3 letras",
                      "Nombre inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Nombre.Focus();
                return false;
            }
            if (textBox_Apellido.Text == "")
            {
                MessageBox.Show("Ingrese el apellido", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Apellido.Focus();
                return false;
            }
            for (int i = 0; i < textBox_Apellido.Text.Length; i++)
            {
                if (char.IsLetter(textBox_Apellido.Text[i]) == false)
                {
                    MessageBox.Show("El apellido debe contener únicamente letras",
                        "Apellido inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_Apellido.Focus();
                    return false;
                }
            }
            if (textBox_Apellido.Text.Length < 5)
            {
                MessageBox.Show("El apellido debe tener por lo menos 5 letras",
                      "Apellido inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Apellido.Focus();
                return false;
            }
            if (textBox_Correo.Text == "")
            {
                MessageBox.Show("Ingrese el correo", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Correo.Focus();
                return false;
            }
            if (textBox_Correo.Text.Length > 50)
            {
                MessageBox.Show("El correo no puede ser mayor a 50 caracteres ",
                      "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Correo.Focus();
                return false;
            }
            if (textBox_Correo.Text.Contains("@") == false)
            {
                MessageBox.Show("El correo debe contener un @",
                    "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Correo.Focus();
                return false;
            }
            if (textBox_Correo.Text.Contains(".") == false)
            {
                MessageBox.Show("El correo debe contener un . y la extensión de dominio",
                    "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Correo.Focus();
                return false;
            }
            if (textBox_Telefono.Text == "")
            {
                MessageBox.Show("Ingrese el teléfono", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Telefono.Focus();
                return false;
            }
            for (int i = 0; i < textBox_Telefono.Text.Length; i++)
            {
                if (char.IsDigit(textBox_Telefono.Text[i]) == false)
                {
                    MessageBox.Show("El número de teléfono debe contener únicamente números",
                        "Teléfono inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_Telefono.Focus();
                    return false;
                }
            }
            if (textBox_Telefono.Text.Length != 10)
            {
                MessageBox.Show("El número de teléfono no puede tener más o menos de 10 dígitos",
                      "Teléfono inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Telefono.Focus();
                return false;
            }
            string genero = ObtenerGenero();
            if (genero == string.Empty)
            {
                MessageBox.Show("Seleccione un género",
                     "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupBox_Generos.Focus();
                return false;
            }
            return true;
        }
        private bool CedulaExiste()
        {
            foreach (var item in listaEstudiantes)
            {
                if (textBox_Cedula.Text == item.Cedula)
                {
                    return true;
                }
            }
            return false;
        }
        private void Estudiantes_Load(object sender, EventArgs e)
        {
            dataGridView_Estudiantes.Columns.Clear();
            dataGridView_Estudiantes.Columns.Add("Cedula", "Cédula");
            dataGridView_Estudiantes.Columns.Add("Nombre", "Nombre");
            dataGridView_Estudiantes.Columns.Add("Apellido", "Apellido");
            dataGridView_Estudiantes.Columns.Add("Correo", "Correo");
            dataGridView_Estudiantes.Columns.Add("Telefono", "Teléfono");
            dataGridView_Estudiantes.Columns.Add("Género", "Género");
            textBox_Buscar.Enabled = false;
        }
        private void MostrarEstudiantes()
        {
            dataGridView_Estudiantes.Rows.Clear();
            foreach (var item in listaEstudiantes)
            {
                dataGridView_Estudiantes.Rows.Add(item.Cedula,
                    item.Nombre, item.Apellido, item.Correo,
                    item.Telefono, item.Genero);
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
                if (CedulaExiste())
                {
                    MessageBox.Show("La cédula ya existe", "Cédula duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_Cedula.Focus();
                    return;
                }
                Estudiante estudiante = new Estudiante();
                estudiante.Cedula = textBox_Cedula.Text;
                estudiante.Nombre = textBox_Nombre.Text;
                estudiante.Apellido = textBox_Apellido.Text;
                estudiante.Correo = textBox_Correo.Text;
                estudiante.Telefono = textBox_Telefono.Text;
                estudiante.Genero = ObtenerGenero();
                listaEstudiantes.Add(estudiante);
                MostrarEstudiantes();
                LimpiarCampos();
                MessageBox.Show("Estudiante agregado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Seleccione un estudiante de la tabla", "Seleccionar",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string cedulaSeleccionada = textBox_Cedula.Text;
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar al estudiante con la cedula: "
                    + cedulaSeleccionada + " ?", "Eliminar estudiante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    Estudiante eliminarEstudiante = null;
                    foreach (var item in listaEstudiantes)
                    {
                        if (item.Cedula == cedulaSeleccionada)
                        {
                            eliminarEstudiante = item;
                            break;
                        }
                    }
                    if (eliminarEstudiante != null)
                    {
                        listaEstudiantes.Remove(eliminarEstudiante);
                        MostrarEstudiantes();
                        LimpiarCampos();
                        MessageBox.Show("Estudiante eliminado correctamente", "Eliminar", MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente error: " + ex.Message, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (fila == -1)
                {
                    MessageBox.Show("Seleccione un estudiante de la tabla", "Seleccionar estudiante",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ValidarCampos() == false)
                {
                    return;
                }
                string cedulaSeleccionada = dataGridView_Estudiantes.Rows[fila].Cells[0].Value.ToString();
                foreach (var item in listaEstudiantes)
                {
                    if (item.Cedula == cedulaSeleccionada)
                    {
                        item.Cedula = textBox_Cedula.Text;
                        item.Nombre = textBox_Nombre.Text;
                        item.Apellido = textBox_Apellido.Text;
                        item.Correo = textBox_Correo.Text;
                        item.Telefono = textBox_Telefono.Text;
                        item.Genero = ObtenerGenero();
                        break;
                    }
                }
                MostrarEstudiantes();
                LimpiarCampos();
                MessageBox.Show("Estudiante actualizado correctamente", "Información actualizada", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Estudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                fila = e.RowIndex;
                textBox_Cedula.Text = dataGridView_Estudiantes.Rows[fila].Cells[0].Value.ToString();
                textBox_Nombre.Text = dataGridView_Estudiantes.Rows[fila].Cells[1].Value.ToString();
                textBox_Apellido.Text = dataGridView_Estudiantes.Rows[fila].Cells[2].Value.ToString();
                textBox_Correo.Text = dataGridView_Estudiantes.Rows[fila].Cells[3].Value.ToString();
                textBox_Telefono.Text = dataGridView_Estudiantes.Rows[fila].Cells[4].Value.ToString();
                string genero = dataGridView_Estudiantes.Rows[fila].Cells[5].Value.ToString();
                if (genero == "Masculino")
                {
                    radioButton_Masculino.Checked = true;
                    radioButton_Femenino.Checked = false;
                }
                else if (genero == "Femenino")
                {
                    radioButton_Femenino.Checked = true;
                    radioButton_Masculino.Checked = false;
                }
            }

        }
        private void pictureBox_Buscar_Estudiante_Click(object sender, EventArgs e)
        {
            try
            {
                bool encontrado = false;
                if (textBox_Buscar.Text == "")
                {
                    MessageBox.Show("Ingrese la cédula o nombre para buscar al estudiante",
                        "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_Buscar.Focus();
                    return;
                }
                if (comboBox_BuscarPor.Text == "")
                {
                    MessageBox.Show("Seleccione la opción de búsqueda que desea",
                       "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox_BuscarPor.Focus();
                    return;
                }
                dataGridView_Estudiantes.Rows.Clear();
                string campo = comboBox_BuscarPor.Text;
                foreach (var item in listaEstudiantes)
                {
                    if (campo == "Cédula")
                    {

                        if (item.Cedula.Contains(textBox_Buscar.Text))
                        {
                            dataGridView_Estudiantes.Rows.Add(item.Cedula, item.Nombre, item.Apellido,
                        item.Correo, item.Telefono, item.Genero);
                            encontrado = true;

                        }
                    }
                    else if (campo == "Nombre")
                    {
                        if (item.Nombre.ToLower().Contains(textBox_Buscar.Text.ToLower()))
                        {
                            dataGridView_Estudiantes.Rows.Add(item.Cedula, item.Nombre, item.Apellido,
                        item.Correo, item.Telefono, item.Genero);
                            encontrado = true;
                        }
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("No existe ningún estudiante con el/la: " + campo, "Sin coincidencias",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_BuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_BuscarPor.SelectedIndex != -1)
            {
                textBox_Buscar.Enabled = true;
                textBox_Buscar.Focus();
            }
            else
            {
                textBox_Buscar.Enabled = false;
                textBox_Buscar.Text = string.Empty;
            }
        }

        private void textBox_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Buscar.Text == "")
            {
                MostrarEstudiantes();
            }
        }

       
    }
}
