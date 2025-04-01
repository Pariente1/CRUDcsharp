using Microsoft.Data.SqlClient;
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
    public partial class frmAddWorkCenter : Form
    {
        public frmAddWorkCenter()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void frmAddWorkCenter_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_Name_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNameCenter_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nameCenter = textBoxName.Text;
            string nameCity = textBoxCity.Text;
            try
            {
                int newId = WorkCenterRepository.InsertWorkCenter(nameCenter, nameCity);
                if (newId > 0) {
                    WorkCenterRepository.InsertWorkCenter(nameCenter, nameCity);
                    MessageBox.Show("Se agregó el centro de trabajo con éxito. " + newId);
                }
                else
                    MessageBox.Show("El nombre del centro es obligatorio.");

                // Limpiamos el box para que el usuario pueda agregar otro WorkCenter
                textBoxName.Clear();
                textBoxCity.Clear();
            }
            catch (Exception ex) {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }            
        }
    }
}
