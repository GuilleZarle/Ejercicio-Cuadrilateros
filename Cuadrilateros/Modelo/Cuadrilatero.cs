using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Modelo
{
    public abstract class Cuadrilatero
    {
        // Datos Privados
        private int _x1 { get; set; }
        private int _x2 { get; set; }
        private int _x3 { get; set; }
        private int _x4 { get; set; }
        private int _y1 { get; set; }
        private int _y2 { get; set; }
        private int _y3 { get; set; }
        private int _y4 { get; set; }

        // Metodo abstracto
        public abstract double CalcularSuperficie(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);


        // Constructor
        public Cuadrilatero(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            _x1 = x1;
            _x2 = x2;
            _x3 = x3;
            _x4 = x4;
            _y1 = y1;
            _y2 = y2;
            _y3 = y3;
            _y4 = y4;

            Console.WriteLine("  Coordenadas:");
            Console.WriteLine($"        X1,Y1: {_x1},{_y1}");
            Console.WriteLine($"        X2,Y2: {_x2},{_y2}");
            Console.WriteLine($"        X3,Y3: {_x3},{_y3}");
            Console.WriteLine($"        X4,Y4: {_x4},{_y4}");
        }
        
    }
}



