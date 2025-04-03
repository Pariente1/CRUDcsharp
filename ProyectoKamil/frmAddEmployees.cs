using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoKamil.RFCGenerator;
using static ProyectoKamil.Catalogos;
using ProyectoKamil.Data;
using static ProyectoKamil.Data.EmployeeRepository;
using static ProyectoKamil.Dto.EmployeeDto;
using ProyectoKamil.Dto;


namespace ProyectoKamil
{

    public partial class frmAddEmployees : Form
    { 

        public frmAddEmployees()
        {
            InitializeComponent();
            this.Size = new Size(700, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void frmAddWorker_Load(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveAddWorker_Click(object sender, EventArgs e)
        {
            // 1) Validar y obtener valor del comboBoxWorkCenter
            if (comboBoxWorkCenter.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un centro de trabajo.");
                return;
            }
            string selectedWorkCenter = comboBoxWorkCenter.SelectedItem.ToString().Trim();

            if (!Catalogos.WorkCenters.ContainsKey(selectedWorkCenter))
            {
                MessageBox.Show("Selecciona un centro de trabajo válido.");
                return;
            }

            // 2) Validar y obtener valor del comboBoxJobPosition
            if (comboBoxJobPosition.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecciona un puesto.");
                return;
            }
            string selectedJobPosition = comboBoxJobPosition.SelectedItem.ToString().Trim();

            if (!Catalogos.JobPositions.ContainsKey(selectedJobPosition))
            {
                MessageBox.Show("Falta seleccionar un puesto de trabajo válido.");
                return;
            }

            // 3) Recolectar datos del formulario
            string nombre = textBoxName.Text.Trim();
            string apellidoPaterno = textBoxFatherLastname.Text.Trim();
            string apellidoMaterno = textBoxMotherLastname.Text.Trim();
            DateTime fechaNac = dateTimePicker.Value;
            int idCentro = Catalogos.WorkCenters[selectedWorkCenter];
            int idPuesto = Catalogos.JobPositions[selectedJobPosition];
            bool isDirectivo = false; //Aqui nunca es director, para eso tiene su propio formulario

            // 4) Validar la fecha
            if (fechaNac == new DateTime(1900, 1, 1))
            {
                MessageBox.Show("Por favor selecciona una fecha; no puede ser 01/01/1900.");
                return;
            }
            if (fechaNac > new DateTime(2002, 1, 1))
            {
                MessageBox.Show("Solo puede ingresar personas mayores de edad.");
                return;
            }

            // 5) Generar RFC
            string rfcCalculado = RFCGenerator.GenerarRFC(nombre, apellidoPaterno, apellidoMaterno, fechaNac);

            // 6) Construir el DTO
            var nuevoEmpleado = new EmployeeDto
            {
                Nombre = nombre,
                ApellidoPaterno = apellidoPaterno,
                ApellidoMaterno = apellidoMaterno,
                FechaNacimiento = fechaNac,
                RFC = rfcCalculado,
                CentroTrabajo = idCentro,
                IdPuesto = idPuesto,
                Directivo = isDirectivo
            };

            // 7) Insertar en la BD vía EmployeeRepository
            try
            {
                int newId = EmployeeRepository.InsertEmpleado(nuevoEmpleado);

                if (newId > 0)
                {
                    MessageBox.Show($"Empleado agregado correctamente. ID generado: {newId}");                    
                    textBoxName.Clear();
                    textBoxFatherLastname.Clear();
                    textBoxMotherLastname.Clear();
                    comboBoxWorkCenter.SelectedIndex = -1;
                    comboBoxJobPosition.SelectedIndex = -1;
                    dateTimePicker.Value = new DateTime(1900, 1, 1);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el empleado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }

        }

        private void textBoxFatherLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxIsDirective_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMotherLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumeroCentroTrabajo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_jobPosition_ValueChanged(object sender, EventArgs e)
        {

        }

        private void isNotDirective_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxJobPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxWorkCenter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
