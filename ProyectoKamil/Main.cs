using System;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using ProyectoKamil.Data;
using System.Data;
using System.Text;

namespace ProyectoKamil
{
    public partial class Main : Form
    {
        public Main()
        {
            Debug.WriteLine("Se creó Main");
            InitializeComponent();
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void Main_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddWorker(object sender, EventArgs e)
        {
            frmAddEmployees window = new frmAddEmployees();
            window.ShowDialog();
        }

        private void frmAddDirectors_Click(object sender, EventArgs e)
        {
            frmAddDirectors window = new frmAddDirectors();
            window.ShowDialog();
        }

        private void frmAddWorkCenter_Click(object sender, EventArgs e)
        {
            frmAddWorkCenter window = new frmAddWorkCenter();
            window.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmViewEmployees_Click(object sender, EventArgs e)
        {
            frmViewEmployees window = new frmViewEmployees();
            window.ShowDialog();
        }

        private void conectarABaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=ProyectoKamil;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Conexión exitosa a ProyectoKamil");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmViewDirectors_Click(object sender, EventArgs e)
        {
            frmViewDirectors window = new frmViewDirectors();
            window.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmViewWorkCenter_Click(object sender, EventArgs e)
        {
            DataTable dt = WorkCenterRepository.GetWorkCenters();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron centros de trabajo.", "Centros de Trabajo");
                return;
            }

            StringBuilder sb = new StringBuilder();

            foreach (DataRow row in dt.Rows)
            {
                sb.AppendLine($"Código: {row["ID_Centro"]}, Nombre: {row["Nombre_Centro"]}, Ciudad: {row["Ciudad"]}");
            }

            MessageBox.Show(sb.ToString(), "Centros de Trabajo");


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
