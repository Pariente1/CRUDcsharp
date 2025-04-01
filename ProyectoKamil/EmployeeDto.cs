using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoKamil
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string RFC { get; set; }
        public int CentroTrabajo { get; set; }
        public int IdPuesto { get; set; }
        public bool Directivo { get; set; }
    }
}
