using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoKamil
{
    internal class Catalogos
    {
        public static readonly Dictionary<string, int> JobPositions = new Dictionary<string, int>()
        {
            { "Vendedor", 1 },
            { "Cajero", 2 },
            { "Directivo", 3 }
        };
        public static readonly Dictionary<string, int> WorkCenters = new Dictionary<string, int>()
        {
            { "Centro Culiacan", 1 },
            { "Centro Guasave", 2 },
            { "Centro Navolato", 3 }
        };



    }
}
