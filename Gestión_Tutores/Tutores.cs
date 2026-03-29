using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Gestión_Tutores
{

    public partial class Tutores : Form
    {
        public static List<Tutor> listaTutores = new List<Tutor>();
        int fila = -1;
        public Tutores()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            textBox_Cedula.Text = string.Empty;
            textBox_Nombre.Text = string.Empty;
            textBox_Apellido.Text = string.Empty;
            textBox_Correo.Text = string.Empty;
            textBox_Especialidad.Text = string.Empty;
            textBox_Telefono.Text = string.Empty;
            numericUpDown_CuposMax.Value = 1;
            fila = -1;
        }
        private void MostrarTutores()
        {
            dataGridView_Tutores.Rows.Clear();
            foreach (var item in listaTutores)
            {
                dataGridView_Tutores.Rows.Add(item.Cedula,
                    item.Nombre, item.Apellido, item.Correo, item.Telefono,
                    item.Especialidad, item.CuposMaximos);
            }
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
            if (textBox_Especialidad.Text == "")
            {
                MessageBox.Show("Ingrese la especialidad", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Especialidad.Focus();
                return false;
            }
            for (int i = 0; i < textBox_Especialidad.Text.Length; i++)
            {
                if (char.IsLetter(textBox_Especialidad.Text[i]) == false && textBox_Especialidad.Text[i] != ' ')
                {
                    MessageBox.Show("La especialidad debe contener únicamente letras",
                        "Especialidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_Especialidad.Focus();
                    return false;
                }
            }
            if (textBox_Especialidad.Text.Length < 6)
            {
                MessageBox.Show("La especialidad debe tener por lo menos 6 letras",
                      "Especialidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Especialidad.Focus();
                return false;
            }
            int cupos = Convert.ToInt32(numericUpDown_CuposMax.Value);
            if (cupos == 0)
            {
                MessageBox.Show("La cantidad de cupos máximos debe ser por lo menos 1 ",
                     "Cantidad de cupos inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown_CuposMax.Focus();
                return false;
            }
            if (cupos > 40)
            {
                MessageBox.Show("La cantidad de cupos máximos no debe ser mayor a 40",
                   "Cantidad de cupos inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown_CuposMax.Focus();
                return false;
            }
            return true;
        }
        private bool CedulaExiste()
        {
            foreach (var item in listaTutores)
            {
                if (textBox_Cedula.Text == item.Cedula)
                {
                    return true;
                }
            }
            return false;
        }


        private void Tutores_Load(object sender, EventArgs e)
        {
            dataGridView_Tutores.Columns.Clear();
            dataGridView_Tutores.Rows.Clear();
            dataGridView_Tutores.Columns.Add("Cedula", "Cédula");
            dataGridView_Tutores.Columns.Add("Nombre", "Nombre");
            dataGridView_Tutores.Columns.Add("Apellido", "Apellido");
            dataGridView_Tutores.Columns.Add("Correo", "Correo");
            dataGridView_Tutores.Columns.Add("Telefono", "Teléfono");
            dataGridView_Tutores.Columns.Add("Especialidad", "Especialidad");
            dataGridView_Tutores.Columns.Add("Cupos Máximos", "Cupos Máximos");
            textBox_Buscar.Enabled = false;
        }

        private void pictureBox_Buscar_Tutor_Click(object sender, EventArgs e)
        {
            try
            {
                bool encontrado = false;
                if (textBox_Buscar.Text == "")
                {
                    MessageBox.Show("Ingrese la cédula o nombre para buscar al tutor",
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
                dataGridView_Tutores.Rows.Clear();
                string campo = comboBox_BuscarPor.Text;
                foreach (var item in listaTutores)
                {
                    if (campo == "Cédula")
                    {
                        if (item.Cedula.Contains(textBox_Buscar.Text))
                        {
                            dataGridView_Tutores.Rows.Add(item.Cedula, item.Nombre, item.Apellido,
                        item.Correo, item.Telefono, item.Especialidad, item.CuposMaximos);
                            encontrado = true;
                        }

                    }
                    else if (campo == "Nombre")
                    {
                        if (item.Nombre.ToLower().Contains(textBox_Buscar.Text.ToLower()))
                        {
                            dataGridView_Tutores.Rows.Add(item.Cedula, item.Nombre, item.Apellido,
                        item.Correo, item.Telefono, item.Especialidad, item.CuposMaximos);
                            encontrado = true;
                        }
                    }

                }

                if (!encontrado)
                {
                    MessageBox.Show("No existe ningún tutor con el/la: " + campo, "Sin coincidencias",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Tutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                fila = e.RowIndex;
                textBox_Cedula.Text = dataGridView_Tutores.Rows[fila].Cells[0].Value.ToString();
                textBox_Nombre.Text = dataGridView_Tutores.Rows[fila].Cells[1].Value.ToString();
                textBox_Apellido.Text = dataGridView_Tutores.Rows[fila].Cells[2].Value.ToString();
                textBox_Correo.Text = dataGridView_Tutores.Rows[fila].Cells[3].Value.ToString();
                textBox_Telefono.Text = dataGridView_Tutores.Rows[fila].Cells[4].Value.ToString();
                textBox_Especialidad.Text = dataGridView_Tutores.Rows[fila].Cells[5].Value.ToString();
                numericUpDown_CuposMax.Value = Convert.ToInt32(dataGridView_Tutores.Rows[fila].Cells[6].Value.ToString());
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
                MostrarTutores();
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
                Tutor tutor = new Tutor();
                tutor.Cedula = textBox_Cedula.Text;
                tutor.Nombre = textBox_Nombre.Text;
                tutor.Apellido = textBox_Apellido.Text;
                tutor.Correo = textBox_Correo.Text;
                tutor.Telefono = textBox_Telefono.Text;
                tutor.Especialidad = textBox_Especialidad.Text;
                tutor.CuposMaximos = Convert.ToInt32(numericUpDown_CuposMax.Value);
                listaTutores.Add(tutor);
                MostrarTutores();
                LimpiarCampos();
                MessageBox.Show("Tutor agregado con éxito", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se detectó el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (fila == -1)
                {
                    MessageBox.Show("Seleccione un tutor de la tabla", "Seleccionar tutor",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ValidarCampos() == false)
                {
                    return;
                }
                listaTutores[fila].Cedula = textBox_Cedula.Text;
                listaTutores[fila].Nombre = textBox_Nombre.Text;
                listaTutores[fila].Apellido = textBox_Apellido.Text;
                listaTutores[fila].Correo = textBox_Correo.Text;
                listaTutores[fila].Telefono = textBox_Telefono.Text;
                listaTutores[fila].Especialidad = textBox_Especialidad.Text;
                listaTutores[fila].CuposMaximos = Convert.ToInt32(numericUpDown_CuposMax.Value);
                MostrarTutores();
                LimpiarCampos();
                MessageBox.Show("Tutor actualizado correctamente", "Información actualizada", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (fila == -1)
                {
                    MessageBox.Show("Seleccione un tutor de la tabla", "Seleccionar",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar al tutor con la cedula: "
                    + textBox_Cedula.Text + " ?", "Eliminar tutor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    listaTutores.RemoveAt(fila);
                    MostrarTutores();
                    LimpiarCampos();
                    MessageBox.Show("Tutor eliminado correctamente", "Eliminar", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente error: " + ex.Message, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
