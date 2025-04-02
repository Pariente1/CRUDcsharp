using System.Collections.Generic;
using System.Windows.Forms;
using static ProyectoKamil.JobPositionRepository;
using ProyectoKamil.Data;  

namespace ProyectoKamil.Helpers
{
    public static class ComboBoxLoader
    {
        // Método para cargar el ComboBox de Centro de Trabajo
        public static void CargarCentroTrabajo(ComboBox combo)
        {
            // Suponiendo que tienes un repositorio que te retorna la lista de centros
            List<CentroTrabajo> centros = WorkCenterRepository.GetWorkCenters();

            combo.DataSource = centros;
            combo.DisplayMember = "Nombre"; // La propiedad que se muestra
            combo.ValueMember = "ID";         // La propiedad que identifica el centro
        }

        // Método para cargar el ComboBox de Puesto de Trabajo
        public static void CargarPuestoTrabajo(ComboBox combo)
        {
            // Suponiendo que tienes un repositorio para puestos
            List<PuestoTrabajo> puestos = JobPositionRepository.GetJobPositions();

            combo.DataSource = puestos;
            combo.DisplayMember = "Nombre"; // La propiedad que se muestra
            combo.ValueMember = "ID";         // La propiedad que identifica el puesto
        }
    }
}
