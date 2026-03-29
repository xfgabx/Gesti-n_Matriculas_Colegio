using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_Inscripciones
{
    public class Inscripcion
    {
        public Inscripcion()
        {

        }

        public string CedulaEstudiante { get; set; }
        public string NombreEstudiante { get; set; }
        public string CedulaTutor { get; set; }
        public string NombreTutor { get; set; }
        public string Dia { get; set; }
        public string Hora { get; set; }
        public string Aula { get; set; }
        public Inscripcion(string cedulaEstudiante, string nombreEstudiante, string cedulaTutor,
          string nombreTutor, string dia, string hora, string aula)
        {
            CedulaEstudiante = cedulaEstudiante;
            NombreEstudiante = nombreEstudiante;
            CedulaTutor = cedulaTutor;
            NombreTutor = nombreTutor;
            Dia = dia;
            Hora = hora;
            Aula = aula;
        }   

    }
}
