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
        public frmUpdatingEmployee(EmployeeDto empleado)
        {
            InitializeComponent();
            _empleado = empleado;
            CargarDatos();
        }

        private void CargarDatos()
        {
            textBoxName.Text = _empleado.Nombre;
            textBoxFatherLastname.Text = _empleado.ApellidoPaterno;
            textBoxMotherLastname.Text = _empleado.ApellidoMaterno;
            dateTimePicker.Value = _empleado.FechaNacimiento;

            // Si tienes los ComboBoxes llenos, asigna el valor seleccionado:
            comboBoxWorkCenter.SelectedValue = _empleado.CentroTrabajo;
            comboBoxJobPosition.SelectedValue = _empleado.IdPuesto;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
