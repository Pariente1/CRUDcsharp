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

namespace ProyectoKamil
{
    public partial class frmAddDirectors : Form
    {
        public frmAddDirectors()
        {
            InitializeComponent();
            this.Size = new Size(700, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void frmAddDirectors_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar y obtener el centro de trabajo
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

            // Datos del empleado/directivo
            string nombre = textBoxName.Text;
            string apellidoPaterno = textBoxFatherLastname.Text;
            string apellidoMaterno = textBoxMotherLastname.Text;
            DateTime fechaNac = dateTimePicker.Value;
            int idCentro = Catalogos.WorkCenters[selectedWorkCenter];
            int idPuesto = 3; // Directivo
            int isDirective = 1;  // Puedes ajustar este valor si lo necesitas
            string rfcCalculado = RFCGenerator.GenerarRFC(nombre, apellidoPaterno, apellidoMaterno, fechaNac);
            bool FuelAllowance = radioButton1.Checked;

            // Validación de la fecha
            if (fechaNac == new DateTime(1900, 1, 1))
            {
                MessageBox.Show("Por favor selecciona una fecha; no puede ser 01/01/1900.");
                return;
            }
            if (fechaNac > new DateTime(2002, 1, 1))
            {
                MessageBox.Show("Solo se pueden ingresar personas mayores de edad.");
                return;
            }

            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=ProyectoKamil;Integrated Security=True;TrustServerCertificate=True";

            // Query para insertar en Empleado y recuperar el nuevo ID
            string queryEmpleado = @"
                INSERT INTO Empleado 
                    (Nombre, Apellido_Paterno, Apellido_Materno, Fecha_Nacimiento, RFC, Centro_Trabajo, ID_Puesto, Directivo) 
                VALUES 
                    (@Nombre, @apellidoPaterno, @apellidoMaterno, @fechaNac, @rfcCalculado, @idCentro, @idPuesto, @isDirective);
                SELECT SCOPE_IDENTITY();";

            // Query para insertar en Directivo
            string queryDirectivo = @"
                INSERT INTO Directivo 
                    (ID_Empleado, Centro_Supervisado, Prestacion_Combustible) 
                VALUES 
                    (@ID_Empleado, @Centro_Supervisado, @FuelAllowance);";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        int newEmpleadoId = 0;
                        // Insertar en Empleado
                        using (SqlCommand cmd = new SqlCommand(queryEmpleado, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@Nombre", nombre);
                            cmd.Parameters.AddWithValue("@apellidoPaterno", apellidoPaterno);
                            cmd.Parameters.AddWithValue("@apellidoMaterno", apellidoMaterno);
                            cmd.Parameters.AddWithValue("@fechaNac", fechaNac);
                            cmd.Parameters.AddWithValue("@rfcCalculado", rfcCalculado);
                            cmd.Parameters.AddWithValue("@idCentro", idCentro);
                            cmd.Parameters.AddWithValue("@idPuesto", idPuesto);
                            cmd.Parameters.AddWithValue("@isDirective", isDirective);

                            object result = cmd.ExecuteScalar();
                            newEmpleadoId = Convert.ToInt32(result);
                        }

                        // Insertar en Directivo (como es esta interfaz, siempre se insertará)
                        using (SqlCommand cmd2 = new SqlCommand(queryDirectivo, conn, tran))
                        {
                            cmd2.Parameters.AddWithValue("@ID_Empleado", newEmpleadoId);
                            // Aquí se usa el mismo centro para Centro_Supervisado; ajústalo si es necesario
                            cmd2.Parameters.AddWithValue("@Centro_Supervisado", idCentro);
                            cmd2.Parameters.AddWithValue("@FuelAllowance", FuelAllowance ? 1 : 0);
                            cmd2.ExecuteNonQuery();
                        }

                        tran.Commit();
                        MessageBox.Show("Directivo agregado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Error al insertar: " + ex.Message);
                    }
                }
            }
        }

        private void NumeroCentroTrabajo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxWorkCenter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FuelAllowance_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFatherLastname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
