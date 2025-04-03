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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoKamil
{
    public partial class frmViewWorkCenter : Form
    {
        public frmViewWorkCenter()
        {
            InitializeComponent();
        }

        private void button_Consultar_Click(object sender, EventArgs e)
        {
            // 1) Recopilar los criterios de búsqueda desde la interfaz
            string? nombreCiudad = string.IsNullOrWhiteSpace(textBox_CityName.Text)
                            ? null
                            : textBox_CityName.Text.Trim();

            // 2) Llamar al repositorio para buscar
            List<WorkCenterDto> listaCentros = WorkCenterRepository.GetWorkCenters("", "", nombreCiudad);

            // 3) Procesar el resultado
            if (listaCentros.Count == 0)
            {
                MessageBox.Show("No se encontró ningún centro con los criterios proporcionados.");
                return;
            }

            // 4) Construir la cadena con los resultados
            List<string> centrosInfo = new List<string>();
            foreach (var emp in listaCentros)
            {
                string info = $"ID: {emp.ID}\n" +
                              $"Nombre_Centro: {emp.Nombre}\n" +
                              $"Ciudad: {emp.Ciudad}\n";

                centrosInfo.Add(info);
            }

            // 5) Mostrar los datos en un MessageBox (o en un DataGridView si prefieres)
            string resultado = string.Join("\n-----------------\n", centrosInfo);
            MessageBox.Show(resultado, "Centros Encontrados");


        }



        private void textBox_CityName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmViewWorkCenter_Load(object sender, EventArgs e)
        {

        }
    }
}
