using System;

namespace NumOpciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Proporcione el valor máximo: ");
            int tope = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1) Mostrar secuencia par");
            Console.WriteLine("2) Mostrar secuencia impar");
            Console.WriteLine("3) Calcular producto factorial");
            Console.Write("Elección: ");
            int eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    for (int i = 1; i <= tope; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    break;

                case 2:
                    for (int i = 1; i <= tope; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    break;

                case 3:
                    ulong product = 1;
                    for (int i = 1; i <= tope; i++)
                    {
                        product *= (ulong)i;
                    }
                    Console.Write($"El producto factorial de {tope} es {product}");
                    break;

                default:
                    Console.WriteLine("Selección no válida.");
                    break;
            }
        }
    }
}
