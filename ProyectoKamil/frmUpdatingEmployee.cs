using ProyectoKamil.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoKamil
{
    public partial class frmUpdatingEmployee : Form
    {
        private EmployeeDto _empleado;
        private int _empleadoId;

        public frmUpdatingEmployee(EmployeeDto empleado)
        {
            InitializeComponent();
            _empleado = empleado;
            _empleadoId = empleado.Id;
            CargarDatos();
        }

        private void CargarDatos()
        {
            textBoxName.Text = _empleado.Nombre ?? "";
            textBoxFatherLastname.Text = _empleado.ApellidoPaterno ?? ""; ;
            textBoxMotherLastname.Text = _empleado.ApellidoMaterno ?? ""; ;
            dateTimePicker.Value = new DateTime(2000, 1, 1);

            // Si tienes los ComboBoxes llenos, asigna el valor seleccionado:
            comboBoxWorkCenter.SelectedValue = _empleado.CentroTrabajo;
            comboBoxJobPosition.SelectedValue = _empleado.IdPuesto;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                EmployeeDto nuevoEmpleado = new EmployeeDto
                {
                    Id = _empleadoId,  // Usas el ID que ya tenías almacenado
                    Nombre = textBoxName.Text.Trim(),
                    ApellidoPaterno = textBoxFatherLastname.Text.Trim(),
                    ApellidoMaterno = textBoxMotherLastname.Text.Trim(),
                    FechaNacimiento = dateTimePicker.Value.Date,
                    IdPuesto = comboBoxJobPosition.SelectedValue != null && Convert.ToInt32(comboBoxJobPosition.SelectedValue) != 0
                         ? Convert.ToInt32(comboBoxJobPosition.SelectedValue)
                         : 0,
                    Directivo = false  // O el valor que corresponda
                };

                bool actualizado = EmployeeRepository.UpdateEmpleado(_empleado, nuevoEmpleado);

                if (actualizado)
                    MessageBox.Show("Empleado actualizado correctamente.");
                else
                    MessageBox.Show("No se pudo actualizar el empleado.");

            }
        }
            
    }
}
