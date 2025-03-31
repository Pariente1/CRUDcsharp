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
    public partial class frmViewDirectors : Form
    {
        public frmViewDirectors()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void frmViewDirectors_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=ProyectoKamil;Integrated Security=True;TrustServerCertificate=True";

            string query = "SELECT * FROM Empleado WHERE 1=1"; // 1=1 permite agregar filtros dinámicos
            List<SqlParameter> parametros = new List<SqlParameter>();

            // Filtros

            if (!string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                query += " AND Nombre = @Nombre";
                parametros.Add(new SqlParameter("@Nombre", textBoxName.Text));
            }

            if (!string.IsNullOrWhiteSpace(textBoxSelectRFC.Text))
            {
                query += " AND RFC = @RFC";
                parametros.Add(new SqlParameter("@RFC", textBoxSelectRFC.Text));
            }

            if (dateTimePickerBirthDay.Value.Date != new DateTime(1900, 1, 1))
            {
                query += " AND Fecha_Nacimiento = @Fecha";
                parametros.Add(new SqlParameter("@Fecha", dateTimePickerBirthDay.Value.Date));
            }

            if ((int)selectWorkCenter.Value != 0)
            {
                query += " AND Centro_Trabajo = @Centro";
                parametros.Add(new SqlParameter("@Centro", (int)selectWorkCenter.Value));
            }

            // Ejecución
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        foreach (var p in parametros)
                            cmd.Parameters.Add(p);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<string> empleados = new List<string>();

                            if (reader.HasRows)
                            {

                                while (reader.Read())
                                {

                                    string empleadoInfo = $"Nombre: {reader["Nombre"]} " +
                                                          $"{reader["Apellido_Paterno"]} " +
                                                          $"{reader["Apellido_Materno"]}\n" +
                                                          $"RFC: {reader["RFC"]}\n" +
                                                          $"Centro Trabajo: {reader["Centro_Trabajo"]}";
                                    empleados.Add(empleadoInfo);
                                }
                                if (empleados.Count == 0)
                                {
                                    MessageBox.Show("No se encontró ningún empleado con los criterios proporcionados.");
                                }
                                else
                                {
                                    // Muestra todos los resultados en un solo MessageBox
                                    string resultado = string.Join("\n-----------------\n", empleados);
                                    MessageBox.Show(resultado, "Empleados encontrados");
                                }

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
