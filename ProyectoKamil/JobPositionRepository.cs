using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoKamil
{
    internal class JobPositionRepository
    {
         {
        private static string connectionString = "Data Source=(localdb)\\local;Initial Catalog=ProyectoKamil;Integrated Security=True;TrustServerCertificate=True";
        public static bool JobPositionExists(string nombrePuesto)
        {
            bool exists = false;
            string query = "SELECT COUNT(*) FROM Catalogo_Puestos WHERE Nombre_Centro = @NombrePuesto";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NombrePuesto", nombrePuesto);
                conn.Open();
                exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
            return exists;
        }

        public static DataTable GetJobPositions()
        {
            DataTable dt = new DataTable();
            string query = "SELECT ID_Puesto, Nombre_Puesto, Descripcion_Puesto FROM Catalogo_Puestos";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static int InsertJobPosition(string nombrePuesto, string descripcion)
        {
            int newId = 0;
            string query = "INSERT INTO Catalogo_Puestos (Nombre_Puesto, Descripcion) VALUES (@NombrePuesto, @Descripcion); SELECT SCOPE_IDENTITY();";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NombrePuesto", nombrePuesto);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                conn.Open();
                newId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return newId;
        }

        public static bool UpdateWorkCenter(string nombrePuestoNuevo, string nombrePuesto,  string descripcion)
        {
            bool success = false;
            string query = "UPDATE Catalogo_Puestos SET Nombre_Puesto = @NombrePuestoNuevo, descripcion = @Descripcion WHERE Nombre_Puesto = @NombrePuesto";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NombrePuestoNuevo", nombrePuestoNuevo);
                cmd.Parameters.AddWithValue("@NombrePuesto", nombrePuesto);
                cmd.Parameters.AddWithValue("@Ciudad", descripcion);
                conn.Open();
                success = cmd.ExecuteNonQuery() > 0;
            }
            return success;
        }

        public static bool DeleteWorkCenter(string nombrePuesto)
        {
            bool success = false;
            string query = "DELETE FROM Catalogo_Puestos WHERE Nombre_Puesto = @nombrePuesto";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NombrePuesto", nombrePuesto);
                conn.Open();
                success = cmd.ExecuteNonQuery() > 0;
            }
            return success;
        }
    }
}

