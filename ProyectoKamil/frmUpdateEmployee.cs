using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoKamil.Dto.EmployeeDto;
using static ProyectoKamil.Data.EmployeeRepository;
using ProyectoKamil.Data;
using ProyectoKamil.Dto;

namespace ProyectoKamil
{
    public partial class frmUpdateEmployee : Form
    {
        private EmployeeDto _empleado = new EmployeeDto();
        public frmUpdateEmployee()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            textBoxName.Text = _empleado.Nombre ?? "";
            textBoxFatherLastname.Text = _empleado.ApellidoPaterno ?? ""; ;
            textBoxMotherLastname.Text = _empleado.ApellidoMaterno ?? ""; ;
            dateTimePicker.Value = new DateTime(2000, 1, 1);
            textBoxSelectRFC.Text = _empleado.RFC;
            //  ComboBoxes:
            comboBoxWorkCenter.SelectedValue = _empleado.CentroTrabajo;
            comboBoxJobPosition.SelectedValue = _empleado.IdPuesto;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFatherLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMotherLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxWorkCenter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxJobPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGetAndUpdate_Click(object sender, EventArgs e)
        {
            // Recopilar los criterios de busqueda desde la interfaz
            string? nombre = string.IsNullOrEmpty(textBoxName.Text.Trim())
                ? null
                : textBoxName.Text.Trim();

            string? apellidoPaterno = string.IsNullOrWhiteSpace(textBoxFatherLastname.Text)
                ? null
                : textBoxFatherLastname.Text.Trim();

            string? apellidoMaterno = string.IsNullOrWhiteSpace(textBoxMotherLastname.Text)
                ? null
                : textBoxMotherLastname.Text.Trim();

            DateTime? fechaNac = null;
            if (dateTimePicker.Value.Date != new DateTime(1900, 1, 1))
            {
                fechaNac = dateTimePicker.Value.Date;
            }

            // Cargar los ComboBoxes (asumiendo que ya se han asignado en el Load del formulario)
            DataTable dtWorkCenters = WorkCenterRepository.GetWorkCenters();
            DataTable dtJobPositions = JobPositionRepository.GetJobPositions();

            string? rfc = string.IsNullOrWhiteSpace(textBoxSelectRFC.Text)
             ? null
             : textBoxSelectRFC.Text.Trim();

            // Declarar variables como int? para permitir null
            int? centroTrabajo = null;
            if (comboBoxWorkCenter.SelectedValue != null && Convert.ToInt32(comboBoxWorkCenter.SelectedValue) != 0)
            {
                centroTrabajo = Convert.ToInt32(comboBoxWorkCenter.SelectedValue);
            }

            int? puestoTrabajo = null;
            if (comboBoxJobPosition.SelectedValue != null && Convert.ToInt32(comboBoxJobPosition.SelectedValue) != 0)
            {
                puestoTrabajo = Convert.ToInt32(comboBoxJobPosition.SelectedValue);
            }

            //LLamar al repositorio
            List<EmployeeDto> listaEmpleados = EmployeeRepository.BuscarEmpleados(nombre, apellidoPaterno, apellidoMaterno, rfc, fechaNac, centroTrabajo, puestoTrabajo);

            // 3) Procesar el resultado
            if (listaEmpleados.Count == 0)
            {
                MessageBox.Show("No se encontró ningún empleado con los criterios proporcionados.");
                return;
            }


            // 4) (Opcional) Construir la cadena para mostrar resultados en MessageBox
            List<string> empleadosInfo = new List<string>();
            foreach (var emp in listaEmpleados)
            {
                string info = $"Nombre: {emp.Nombre} {emp.ApellidoPaterno} {emp.ApellidoMaterno}\n" +
                              $"RFC: {emp.RFC}\n" +
                              $"Centro Trabajo: {emp.CentroTrabajo}\n" +
                              $"Puesto: {emp.IdPuesto}\n";
                empleadosInfo.Add(info);
            }


            string resultado = string.Join("\n-----------------\n", empleadosInfo);
            MessageBox.Show(resultado, "Empleados encontrados");

            // 5) Abrir el formulario de actualización con el primer empleado encontrado
            EmployeeDto empleadoSeleccionado = listaEmpleados[0];

            frmUpdatingEmployee window = new frmUpdatingEmployee(empleadoSeleccionado);
            window.ShowDialog();
        }

        private void textBoxSelectRFC_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUpdateEmployee_Load(object sender, EventArgs e)
        {
            // Cargar el ComboBox de WorkCenters
            DataTable dtWorkCenters = WorkCenterRepository.GetWorkCenters();
            comboBoxWorkCenter.DataSource = dtWorkCenters;
            comboBoxWorkCenter.DisplayMember = "Nombre_Centro";
            comboBoxWorkCenter.ValueMember = "ID_Centro";
            comboBoxWorkCenter.SelectedIndex = -1;  // Ningún elemento seleccionado

            // Cargar el ComboBox de JobPositions
            DataTable dtJobPositions = JobPositionRepository.GetJobPositions();
            comboBoxJobPosition.DataSource = dtJobPositions;
            comboBoxJobPosition.DisplayMember = "Nombre_Puesto";
            comboBoxJobPosition.ValueMember = "ID_Puesto";
            comboBoxJobPosition.SelectedIndex = -1;
        }
    }
}
