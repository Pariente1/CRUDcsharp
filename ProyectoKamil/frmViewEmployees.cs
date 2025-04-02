using Microsoft.Data.SqlClient;
using ProyectoKamil.Data;
using ProyectoKamil.Dto;
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
            // 1) Recopilar los criterios de búsqueda desde la interfaz
            string? nombre = string.IsNullOrWhiteSpace(textBoxName.Text)
                            ? null
                            : textBoxName.Text.Trim();

            string? rfc = string.IsNullOrWhiteSpace(textBoxSelectRFC.Text)
                         ? null
                         : textBoxSelectRFC.Text.Trim();

            DateTime? fechaNac = null;
            // Usamos el dateTimePickerBirthDay. 
            // Si no queremos filtrar cuando sea 1900,1,1
            if (dateTimePickerBirthDay.Value.Date != new DateTime(1900, 1, 1))
            {
                fechaNac = dateTimePickerBirthDay.Value.Date;
            }

            int? centroTrabajo = null;
            // Suponiendo que selectWorkCenter es un NumericUpDown 
            // y si es 0, no lo usamos.
            if ((int)selectWorkCenter.Value != 0)
            {
                centroTrabajo = (int)selectWorkCenter.Value;
            }

            // 2) Llamar al repositorio para buscar
            List<EmployeeDto> listaEmpleados = EmployeeRepository.BuscarEmpleados(nombre, "", "", rfc, fechaNac, centroTrabajo, null);

            // 3) Procesar el resultado
            if (listaEmpleados.Count == 0)
            {
                MessageBox.Show("No se encontró ningún empleado con los criterios proporcionados.");
                return;
            }

            // 4) Construir la cadena con los resultados
            List<string> empleadosInfo = new List<string>();
            foreach (var emp in listaEmpleados)
            {
                string info = $"Nombre: {emp.Nombre} {emp.ApellidoPaterno} {emp.ApellidoMaterno}\n" +
                              $"RFC: {emp.RFC}\n" +
                              $"Centro Trabajo: {emp.CentroTrabajo}\n" +
                              $"Puesto: {emp.IdPuesto}\n";
                empleadosInfo.Add(info);
            }

            // 5) Mostrar los datos en un MessageBox (o en un DataGridView si prefieres)
            string resultado = string.Join("\n-----------------\n", empleadosInfo);
            MessageBox.Show(resultado, "Empleados encontrados");
        }
    }
}
