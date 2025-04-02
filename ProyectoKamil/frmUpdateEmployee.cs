using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoKamil.EmployeeDto;
using static ProyectoKamil.Data.EmployeeRepository;
using ProyectoKamil.Data;

namespace ProyectoKamil
{
    public partial class frmUpdateEmployee : Form
    {
        public frmUpdateEmployee()
        {
            InitializeComponent();
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

            string? nombre = string.IsNullOrWhiteSpace(textBoxName.Text)
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

            //Workcenter ComboBox
            DataTable dtWorkCenters = WorkCenterRepository.GetWorkCenters();
            int centroTrabajo = Convert.ToInt32(comboBoxWorkCenter.SelectedValue);

            //JonPosition ComboBox
            DataTable dtJobPosition = WorkCenterRepository.GetWorkCenters();
            int puestoTrabajo = Convert.ToInt32(comboBoxJobPosition.SelectedValue);

            string? rfc = string.IsNullOrWhiteSpace(textBoxSelectRFC.Text)
             ? null
             : textBoxSelectRFC.Text.Trim();

            List<EmployeeDto> listaEmpleados = EmployeeRepository.BuscarEmpleados(nombre, apellidoPaterno, apellidoMaterno, rfc, fechaNac, centroTrabajo, puestoTrabajo);

            // 3) Procesar el resultado
            if (listaEmpleados.Count == 0)
            {
                MessageBox.Show("No se encontró ningún empleado con los criterios proporcionados.");
                return;
            }

            // 4) Construir la cadena con los resultados
            List<string> empleadosInfo = new List<string>();
            foreach (var emp in listaEmpleados)
            {
                string info = $"Nombre: {emp.Nombre} {emp.ApellidoPaterno} {emp.ApellidoMaterno}\n" +
                              $"RFC: {emp.RFC}\n" +
                              $"Centro Trabajo: {emp.CentroTrabajo}\n" +
                              $"Puesto: {emp.IdPuesto}\n";
                empleadosInfo.Add(info);
            }

            // 5) Mostrar los datos en un MessageBox (o en un DataGridView si prefieres)

            string resultado = string.Join("\n-----------------\n", empleadosInfo);
            MessageBox.Show(resultado, "Empleados encontrados");



            frmUpdatingEmployee window = new frmUpdatingEmployee();
            window.ShowDialog();
        }

        private void textBoxSelectRFC_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUpdateEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
