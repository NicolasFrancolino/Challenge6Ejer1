using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6Ejer1
{
    partial class Rectangulo
    {
        public int RetornarSuperficie()
        {
            return lado1 * lado2;
        }

        public int RetornarPerimetro()
        {
            return lado1 * 2 + lado2 * 2;
        }
    }
}
