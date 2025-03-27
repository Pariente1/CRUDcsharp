using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoKamil
{

    public partial class frmAddWorker : Form
    {
        public frmAddWorker()
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
            string nombre = textBoxName.Text;
            string apellidoPaterno = textBoxFatherLastname.Text;
            string apellidoMaterno = textBoxFatherLastname.Text;
            DateTime fechaNac = dateTimePicker.Value;
            int centroTrabajo = (int)NumeroCentroTrabajo.Value;
            int idPuesto = (int)numericUpDown_jobPosition.Value;


            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=ProyectoKamil;Integrated Security=True;TrustServerCertificate=True";
            string query = "INSERT INTO Empleado (Nombre, Apellido_Paterno, Apellido_Materno, Fecha_Nacimiento, Centro_Trabajo, ID_Puesto) VALUES (@Nombre, @apellidoPaterno, @apellidoMaterno, @fechaNac, @centroTrabajo, @idPuesto)";

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
                        cmd.Parameters.AddWithValue("@centroTrabajo", centroTrabajo);
                        cmd.Parameters.AddWithValue("@idPuesto", idPuesto);
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
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
    }


}
