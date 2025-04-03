using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ProyectoKamil
{
    public static class RFCGenerator
    {
        public static string GenerarRFC(string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento)
        {
            if (string.IsNullOrWhiteSpace(apellidoMaterno))
                apellidoMaterno = "X";

            bool tieneApellidoMaterno = apellidoMaterno != "X";

            // Convertir todo a mayúsculas
            nombre = nombre.ToUpper();
            apellidoPaterno = apellidoPaterno.ToUpper();
            apellidoMaterno = apellidoMaterno.ToUpper();

            // Asegurar que no haya errores de longitud
            string rfc = "";
            rfc += apellidoPaterno.Length >= 2 ? apellidoPaterno.Substring(0, 2) : apellidoPaterno.PadRight(2, 'X');
            rfc += tieneApellidoMaterno ? apellidoMaterno.Substring(0, 1) : "X";
            rfc += nombre.Substring(0, 1);
            rfc += fechaNacimiento.ToString("yyMMdd");

            // Validar palabras prohibidas
            List<string> palabrasProhibidas = new List<string> { "CACA", "CULO", "TETA" };
            foreach (var palabra in palabrasProhibidas)
            {
                if (rfc.StartsWith(palabra))
                {
                    rfc = rfc.Substring(0, palabra.Length - 1) + "X";
                    break;
                }
            }

            return rfc + "XXX"; 
        }
    }
}
