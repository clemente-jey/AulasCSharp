using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    internal class Retangulo
    {
        double Largura;
        double Altura;

        public Retangulo ()
        {
            
        }

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2*Largura +2* Altura;
        }
    }
           
}
