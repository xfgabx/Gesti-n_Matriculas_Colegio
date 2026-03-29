using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_Matriculas_Colegio
{
    public class Estudiante
    {
        public Estudiante()
        {

        }
        //d
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Genero { get; set; }
        public Estudiante(string cedula, string nombre, string apellido, string correo, string telefono, string genero)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Telefono = telefono;
            Genero = genero;
        }
    }
}
