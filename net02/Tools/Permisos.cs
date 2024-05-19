using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net02.Tools
{
    internal class Permisos
    {
        private static readonly bool[,] permisos = new bool[4,12]
        {
            {true, true, true, true, true, false, false, false, false, true, false, false },
            {true, false, false, true, true, true, false, true, true, true, true, false },
            {true, false, false, true, true, true, true, false, false, true, true, false },
            {true, false, false, true, true, false, false, false, false, true, true, false }
        };

        public static bool tienePermiso (int Tipo, int ID)
        {
            return permisos[Tipo, ID];
        }

    }
}
