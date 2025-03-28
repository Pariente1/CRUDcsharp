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
    public partial class frmViewEmployees : Form
    {
        public frmViewEmployees()
        {
            InitializeComponent();
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void frmViewEmployees_Load(object sender, EventArgs e)
        {

        }

        private void label_Name_Click(object sender, EventArgs e)
        {

        }

        private void label_RFC_Click(object sender, EventArgs e)
        {

        }

        private void label_birthDate_Click(object sender, EventArgs e)
        {

        }

        private void label_workCenter_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_birthDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown_selectWorkCenter_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_selectRFC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_selectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxName.Text;

            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=ProyectoKamil;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM Empleado WHERE Nombre = @Nombre";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Por ejemplo, mostrar algunos datos en un MessageBox
                                    string empleadoInfo = $"Nombre: {reader["Nombre"]}\n" +
                                                          $"Apellido Paterno: {reader["Apellido_Paterno"]}\n" +
                                                          $"Centro Trabajo: {reader["Centro_Trabajo"]}";

                                    MessageBox.Show(empleadoInfo, "Empleado encontrado");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el empleado.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar: " + ex.Message);
                }
            }

        }
    }
}
