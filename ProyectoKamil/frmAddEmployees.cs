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


namespace ProyectoKamil
{

    public partial class frmAddEmployees : Form
    { 

        public frmAddEmployees()
        {
            InitializeComponent();
            this.Size = new Size(1200, 800);
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

            string nombre = textBoxName.Text;
            string apellidoPaterno = textBoxFatherLastname.Text;
            string apellidoMaterno = textBoxMotherLastname.Text;
            DateTime fechaNac = dateTimePicker.Value;
            int idCentro = Catalogos.WorkCenters[selectedWorkCenter];
            int idPuesto = Catalogos.JobPositions[selectedJobPosition];
            int isDirective = 0;
            string rfcCalculado = RFCGenerator.GenerarRFC(nombre, apellidoPaterno, apellidoMaterno, fechaNac);

            // Validación de la fecha para que no sea Default ni menor de edad
            if (fechaNac == new DateTime(1900, 1, 1))
            {
                MessageBox.Show("Por favor selecciona una fecha; no puede ser 01/01/1900.");
                return;
            }

            if (fechaNac > new DateTime(2002, 1, 1))
            {
                MessageBox.Show("Solo puede ingregar personas mayores de edad.");
                return;
            }

            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=ProyectoKamil;Integrated Security=True;TrustServerCertificate=True";
            string query = "INSERT INTO Empleado (Nombre, Apellido_Paterno, Apellido_Materno, Fecha_Nacimiento, RFC, Centro_Trabajo, ID_Puesto, Directivo) VALUES (@Nombre, @apellidoPaterno, @apellidoMaterno, @fechaNac, @rfcCalculado, @idCentro, @idPuesto, @isDirective)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellidoPaterno", apellidoPaterno);
                        cmd.Parameters.AddWithValue("@apellidoMaterno", apellidoMaterno);
                        cmd.Parameters.AddWithValue("@fechaNac", fechaNac);
                        cmd.Parameters.AddWithValue("@rfcCalculado", rfcCalculado);
                        cmd.Parameters.AddWithValue("@idCentro", idCentro);
                        cmd.Parameters.AddWithValue("@idPuesto", idPuesto);
                        cmd.Parameters.AddWithValue("@isDirective", isDirective);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            MessageBox.Show("Empleado agregado correctamente.");
                        else
                            MessageBox.Show("No se pudo agregar el empleado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar: " + ex.Message);
                }
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
