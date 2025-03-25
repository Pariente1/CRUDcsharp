using System;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoKamil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddWorker(object sender, EventArgs e)
        {
            frmAddWorker window = new frmAddWorker();
            window.ShowDialog(); // Muestra como ventana modal
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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
    }
}
