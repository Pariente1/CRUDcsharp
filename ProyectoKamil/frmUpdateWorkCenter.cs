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
    public partial class frmUpdateWorkCenter : Form
    {
        public frmUpdateWorkCenter()
        {
            InitializeComponent();
        }

        private void textBox_CenterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_NewCenterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CityName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_NewCityName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void CityName_Click(object sender, EventArgs e)
        {

        }

        private void button_SaveUpdate_Click(object sender, EventArgs e)
        {
            string nameCenter = textBox_CenterName.Text;
            string newNameCenter = textBox_NewCenterName.Text;
            string nameCity = textBox_NewCityName.Text;

            if (string.IsNullOrEmpty(nameCenter))
            {
                MessageBox.Show("El nombre del centro es obligatorio.");
                return;
            }

            bool exists = WorkCenterRepository.WorkCenterExists(nameCenter);
            if (!exists) {
                MessageBox.Show("El centro no existe.");
                return;
            }

            if (string.IsNullOrEmpty(newNameCenter))
            {
                newNameCenter = nameCenter;
            }

            if (string.IsNullOrEmpty(nameCenter))
            {
                MessageBox.Show("El nombre del centro es obligatorio.");
                return;
            }

                       

            bool updated= WorkCenterRepository.UpdateWorkCenter(nameCenter, newNameCenter, nameCity);
            if (updated)
            {
                string resultado = $"Se cambió el nombre del centro: {nameCenter}\nPor: {newNameCenter}\n" +
                                     $"Se cambió la ciudad a: {nameCity}";
                MessageBox.Show(resultado, "Cambio exitoso");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el centro.");
            }


        }
    }
}
