using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_Horarios
{
    public class Horario
    {
        public Horario()
        {
            
        }
        public string Dia { get; set; }
        public string Hora { get; set; }
        public string Aula { get; set; }
        public Horario(string dia, string hora, string aula)
        {
            Dia = dia;
            Hora = hora;
            Aula = aula;
        }


    }
}
