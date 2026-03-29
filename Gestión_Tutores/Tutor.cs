using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_Tutores
{
    public class Tutor
    {
        public Tutor()
        {

        }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Especialidad { get; set; }
        public int CuposMaximos { get; set; }
        public Tutor(string cedula, string nombre, string apellido, string correo, string telefono,
            string especialidad, int cuposMaximos)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Telefono = telefono;
            Especialidad = especialidad;
            CuposMaximos = cuposMaximos;
        }


    }
}
