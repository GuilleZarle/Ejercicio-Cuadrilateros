// Diseñe la siguiente jerarquía para las clases:

// Cuadrilátero.
// Trapecio.
// Rectángulo.
// Cuadrado.

// Use la clase Cuadrilátero como la clase base de la jerarquía, que debe ser abstracta.

// Los datos privados de la clase base deben ser las coordenadas x-y de los cuatro vértices de la figura
// y debe contener un método abstracto para calcular el área.

// Agregue un constructor a cada clase para inicializar sus datos
// e invoque el constructor de la clase base desde el constructor de cada clase derivada.

// Escriba un programa que instancie objetos de cada una de las clases
// y calcule el área correspondiente.
// Investigue las fórmulas para calcular el área de cada figura.

using Cuadrilateros.Modelo;

int opcion = 0;
while (opcion != 4)
{
    Console.WriteLine("");
    Console.WriteLine("Elija el Cuadrilátero para Calcular la Superficie:");
    Console.WriteLine("  1 - Cuadrado");
    Console.WriteLine("  2 - Rectángulo");
    Console.WriteLine("  3 - Trapecio");
    Console.WriteLine("  4 - Salir");
    Console.WriteLine("");
    opcion = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    switch (opcion)
    {
        case 1:
            Console.WriteLine("  Seleccionó Cuadrado.");
            Cuadrado cuadrado = new Cuadrado(5, 1, 9, 1, 9, 5, 5, 5);

            Console.WriteLine($"  La superficie del cuadrado es: {cuadrado.CalcularSuperficie(5, 1, 9, 1, 9, 5, 5, 5)}");
            break;

        case 2:
            Console.WriteLine("  Seleccionó Rectángulo.");
            Rectangulo rectangulo = new Rectangulo(5, 1, 9, 1, 9, 3, 5, 3);

            Console.WriteLine($"  La superficie del rectangulo es: {rectangulo.CalcularSuperficie(5, 1, 9, 1, 9, 3, 5, 3)}");
            break;

        case 3:
            Console.WriteLine("  Seleccionó Trapecio.");
            Trapecio trapecio = new Trapecio(1, 1, 1, 6, 5, 9, 3, 9);

            Console.WriteLine($"  La superficie del trapecio es: {trapecio.CalcularSuperficie(1, 1, 1, 10, 8, 9, 3, 9)}");
            break;

        case 4:
            Console.WriteLine("  Saliendo.");
            break;

        default:
            Console.WriteLine("Opción no válida");
            break;

    }
}



