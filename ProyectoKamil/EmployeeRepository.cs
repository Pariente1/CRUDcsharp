using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ProyectoKamil.Data
{
    public static class EmployeeRepository
    {
        private static string connectionString = "Data Source=(localdb)\\local;Initial Catalog=ProyectoKamil;Integrated Security=True;TrustServerCertificate=True";

        // CREATE
        public static int InsertEmpleado(EmployeeDto emp)
        {
            int newId = 0;
            string query = @"
                INSERT INTO Empleado 
                    (Nombre, Apellido_Paterno, Apellido_Materno, Fecha_Nacimiento, RFC, Centro_Trabajo, ID_Puesto, Directivo)
                VALUES 
                    (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @FechaNacimiento, @RFC, @CentroTrabajo, @IdPuesto, @Directivo);
                SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Nombre", emp.Nombre);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", emp.ApellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", emp.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@FechaNacimiento", emp.FechaNacimiento);
                cmd.Parameters.AddWithValue("@RFC", emp.RFC);
                cmd.Parameters.AddWithValue("@CentroTrabajo", emp.CentroTrabajo);
                cmd.Parameters.AddWithValue("@IdPuesto", emp.IdPuesto);
                cmd.Parameters.AddWithValue("@Directivo", emp.Directivo);
                conn.Open();
                newId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return newId;
        }

        // READ con filtros flexibles
        public static List<EmployeeDto> BuscarEmpleados(string? nombre = null, string? apellidoPaterno = null, string? apellidoMaterno = null, string? rfc = null, DateTime? fechaNac = null, int? centroTrabajo = null, int? puestoTrabajo = null)
        {
            List<EmployeeDto> empleados = new List<EmployeeDto>();
            string query = "SELECT * FROM Empleado WHERE 1=1";

            List<SqlParameter> parametros = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(nombre))
            {
                query += " AND Nombre = @Nombre";
                parametros.Add(new SqlParameter("@Nombre", nombre));
            }

            if (!string.IsNullOrEmpty(apellidoPaterno))
            {
                query += " AND Apellido_Paterno = @apellidoPaterno";
                parametros.Add(new SqlParameter("@apellidoPaterno", apellidoPaterno));
            }

            if (!string.IsNullOrEmpty(apellidoMaterno))
            {
                query += " AND Apellido_Materno = @apellidoMaterno";
                parametros.Add(new SqlParameter("@apellidoMaterno", apellidoMaterno));
            }

            if (!string.IsNullOrEmpty(rfc))
            {
                query += " AND RFC = @RFC";
                parametros.Add(new SqlParameter("@RFC", rfc));
            }

            if (fechaNac.HasValue)
            {
                query += " AND Fecha_Nacimiento = @FechaNacimiento";
                parametros.Add(new SqlParameter("@FechaNacimiento", fechaNac.Value));
            }

            if (centroTrabajo.HasValue)
            {
                query += " AND Centro_Trabajo = @CentroTrabajo";
                parametros.Add(new SqlParameter("@CentroTrabajo", centroTrabajo.Value));
            }

            if (puestoTrabajo.HasValue)
            {
                query += " AND ID_Puesto = @puestoTrabajo";
                parametros.Add(new SqlParameter("@puestoTrabajo", puestoTrabajo.Value));
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                foreach (var param in parametros)
                    cmd.Parameters.Add(param);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string materno = reader["Apellido_Paterno"].ToString();
                        MessageBox.Show("Apellido Paterno leído: " + materno);

                        empleados.Add(new EmployeeDto
                        {
                            Id = Convert.ToInt32(reader["ID_Empleado"]),
                            Nombre = reader["Nombre"].ToString(),
                            ApellidoPaterno = reader["Apellido_Paterno"].ToString(),
                            ApellidoMaterno = reader["Apellido_Materno"].ToString(),
                            FechaNacimiento = Convert.ToDateTime(reader["Fecha_Nacimiento"]),
                            RFC = reader["RFC"].ToString(),
                            CentroTrabajo = Convert.ToInt32(reader["Centro_Trabajo"]),
                            IdPuesto = Convert.ToInt32(reader["ID_Puesto"]),
                            Directivo = Convert.ToBoolean(reader["Directivo"])
                        });
                    }
                }
            }

            return empleados;
        }

        // UPDATE
        public static bool UpdateEmpleado(EmployeeDto emp)
        {
            string query = @"
                UPDATE Empleado SET
                    Nombre = @Nombre,
                    Apellido_Paterno = @ApellidoPaterno,
                    Apellido_Materno = @ApellidoMaterno,
                    Fecha_Nacimiento = @FechaNacimiento,
                    RFC = @RFC,
                    Centro_Trabajo = @CentroTrabajo,
                    ID_Puesto = @IdPuesto,
                    Directivo = @Directivo
                WHERE ID_Empleado = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Nombre", emp.Nombre);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", emp.ApellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", emp.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@FechaNacimiento", emp.FechaNacimiento);
                cmd.Parameters.AddWithValue("@RFC", emp.RFC);
                cmd.Parameters.AddWithValue("@CentroTrabajo", emp.CentroTrabajo);
                cmd.Parameters.AddWithValue("@IdPuesto", emp.IdPuesto);
                cmd.Parameters.AddWithValue("@Directivo", emp.Directivo);
                cmd.Parameters.AddWithValue("@Id", emp.Id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // DELETE
        public static bool DeleteEmpleado(int idEmpleado)
        {
            string query = "DELETE FROM Empleado WHERE ID_Empleado = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", idEmpleado);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
