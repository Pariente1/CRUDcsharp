using System.Collections.Generic;
using System.Windows.Forms;
using static ProyectoKamil.JobPositionRepository;
using ProyectoKamil.Data;
using static ProyectoKamil.Dto.JobPositionDto;
using static ProyectoKamil.Dto.WorkCenterDto;
using ProyectoKamil.Dto;

namespace ProyectoKamil.Helpers
{
    public static class ComboBoxLoader
    {
        
        public static void CargarCentroTrabajo(ComboBox combo)
        {
            
            List<WorkCenterDto> centros = WorkCenterRepository.GetWorkCenters();

            combo.DataSource = centros;
            combo.DisplayMember = "Nombre"; 
            combo.ValueMember = "ID";         
        }

        
        public static void CargarPuestoTrabajo(ComboBox combo)
        {
            
            List<JobPositionDto> puestos = JobPositionRepository.GetJobPositions();

            combo.DataSource = puestos;
            combo.DisplayMember = "Nombre"; 
            combo.ValueMember = "ID";         
        }
    }
}
