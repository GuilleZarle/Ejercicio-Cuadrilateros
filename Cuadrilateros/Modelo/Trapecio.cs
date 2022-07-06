using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Modelo
{
    public sealed class Trapecio : Cuadrilatero
    {
        
        
        public override double CalcularSuperficie(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            // Calculo por metodo de Determinantes
            double supTrapecio = Math.Abs(((x1 * y2) + (x2 * y3) + (x3 * y4) + (x4 * y1)) 
                                        - ((y1 * x2) + (y2 * x3) + (y3 * x4) + (y4 * x1))) / 2;
           
            return supTrapecio;
        }

        // Constructor
        public Trapecio(int X1, int Y1, int X2, int Y2, int X3, int Y3, int X4, int Y4) : base(X1, Y1, X2, Y2, X3, Y3, X4, Y4)
        {
           
        }


    }
}
