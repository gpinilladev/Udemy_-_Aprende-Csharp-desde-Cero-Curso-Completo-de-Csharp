using System;
using System.Collections.Generic;

namespace _65_Listas
{
    class Program
    {
        static void Main()
        {
            /* ***** Listas ***** */
            // La lista es el tipo de coleccion mas ampliamente usado en c#
            // por su versatilidad, simplicidad y su potencia

            // List<T>
            // La clase List pertenece a System.Collection.Generic;
            Console.WriteLine("***** Ejemplo 1 - Creacion de listas instanciando la clase List *****");
            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(10);
            // numbers.Add("Mark"); // No se puede agregar otro tipo de dato diferente al definido en la creacion de la coleccion en este caso no se pude agregar un string a una lista de int
            foreach (var item in numbers)
            {
                Console.WriteLine($"Value to item => {item}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("***** Ejemplo 2 - Creacion de listas de tipo implicito *****");
            
        }
    }
}
