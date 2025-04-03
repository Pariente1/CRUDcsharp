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

namespace ProyectoKamil
{
    public partial class frmDeleteDirector : Form
    {
        public frmDeleteDirector()
        {
            InitializeComponent();
            this.Size = new Size(700, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void label_RFC_Click(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click_1(object sender, EventArgs e)
        {
            string textRFC = textBox_RFC.Text;

            if (string.IsNullOrEmpty(textRFC))
            {
                MessageBox.Show("Favor de poner el RFC.");
                return;
            }

            bool exists = EmployeeRepository.EmployeeExists(textRFC);
            if (!exists)
            {
                MessageBox.Show("El RFC no existe.");
                return;
            }

            bool success = EmployeeRepository.DeleteEmpleado(textRFC);
            if (!success)
            {
                MessageBox.Show("No se pudo borrar el empleado.");
                return;
            }
            else
            {
                string resultado = $"Se elimino el empleado con el RFC: {textRFC}";
                MessageBox.Show(resultado, "Cambio exitoso");
            }
        }

        private void textBox_RFC_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDeleteDirector_Load(object sender, EventArgs e)
        {

        }
    }
}
