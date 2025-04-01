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

            // Validar que ambos campos tengan valor
            if (string.IsNullOrEmpty(nameCenter))
            {
                MessageBox.Show("El nombre del centro es obligatorio.");
                return;
            }
            if (string.IsNullOrEmpty(newNameCenter))
            {
                newNameCenter = nameCenter;
            }


            WorkCenterRepository.UpdateWorkCenter(nameCenter, newNameCenter, nameCity);
            string resultado = string.Join("\n-----------------\n", "Se cambió nombre de centro: " + nameCenter + "\n" + "Por:" + newNameCenter + "\n\n" + "Se cambió la ciudad a: " + nameCity);
            MessageBox.Show(resultado, "Cambio exitoso");


        }
    }
}
