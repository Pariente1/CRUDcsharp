using ProyectoKamil.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoKamil.Data.WorkCenterRepository;

namespace ProyectoKamil
{
    public partial class frmDeleteWorkCenter : Form
    {
        public frmDeleteWorkCenter()
        {
            InitializeComponent();
        }

        private void frmDeleteWorkCenter_Load(object sender, EventArgs e)
        {

        }

        private void textBox_DeleteCenterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string nameCenter = textBox_DeleteCenterName.Text;

            if (string.IsNullOrEmpty(nameCenter))
            {
                MessageBox.Show("El nombre del centro es obligatorio.");
                return;
            }

            bool exists = WorkCenterRepository.WorkCenterExists(nameCenter);
            if (!exists)
            {
                MessageBox.Show("El centro no existe.");
                return;
            }

            bool success = WorkCenterRepository.DeleteWorkCenter(nameCenter);
            if (!success)
            {
                MessageBox.Show("No se pudo borrar el centro de la base de datos.");
                return;
            }
            else
            {
                string resultado = $"Se elimino el centro: {nameCenter}";
                MessageBox.Show(resultado, "Cambio exitoso");
            }

            }
    }
}
