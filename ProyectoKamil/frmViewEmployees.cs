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
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string empleadoInfo = $"Nombre: {reader["Nombre"]}\n" +
                                                          $"RFC: {reader["RFC"]}\n" +
                                                          $"Centro Trabajo: {reader["Centro_Trabajo"]}";
                                    MessageBox.Show(empleadoInfo, "Empleado encontrado");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún empleado con los criterios proporcionados.");
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
