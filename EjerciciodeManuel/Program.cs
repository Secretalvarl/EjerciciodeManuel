using System.Runtime.Serialization.Formatters;

namespace EjerciciodeManuel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numeroRandom = new Random();

            int longitudArray = numeroRandom.Next(10, 20);

            int[] arrayNumeros = new int[longitudArray];

            for (int i = 0; i < arrayNumeros.Length - 1; i++)
            {
                arrayNumeros[i] = numeroRandom.Next(1, 200);
            }

            Console.WriteLine("Escriba el último dígito para completar el array: ");
            string ultimoNumero = Console.ReadLine();

            if (int.TryParse(ultimoNumero, out int numero))
            {
                arrayNumeros[arrayNumeros.Length - 1] = numero;

                
                Console.WriteLine("Array completo:");
                foreach (var num in arrayNumeros)
                {
                    Console.Write(num + " ");
                }
            }
            else
            {
                Console.WriteLine("Error-El dato introducido no es un numero");
            }

            Array.Sort(arrayNumeros);
            Array.Reverse(arrayNumeros);

            Console.WriteLine("\n" + "Array completo (ordenado de forma descendente):");
            foreach (var num in arrayNumeros)
            {
                Console.Write(num + " ");
            }
        }
    }
}