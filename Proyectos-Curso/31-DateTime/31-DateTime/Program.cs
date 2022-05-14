using System;

namespace _31_DateTime
{
    class Program
    {
        static void Main()
        {
            /* ********** DateTime ********** */
            // La clase DateTime nos permite generar fechas y se intancia como cualquier otra clase en C#
            DateTime dt = new DateTime(); // Si no pasamos parametros, por defecto nos tomara la fecha de 1/1/0001 12:00:00 AM
            // Para poder impremir el valor pasamos el metodo .ToString() para obtener la fecha como texto y poderla imprimir
            Console.WriteLine($"Fecha por defecto sin parametros: {dt.ToString()}"); // El resultado sera => 1/1/0001 12:00:00 AM

            // Podemos tambien inicializar la clase pasandole parametros año, mes y dia DateTime dt = new DateTime(año, mes, dia);
            DateTime dt1 = new DateTime(2022, 5, 3);
            Console.WriteLine($"Fecha con año, mes, dia: {dt1.ToString()}");

            // Podemos tambien inicializar la clase pasandole no solo los parametros de año, mes y dia, tambien podemos pasarle horas, minutos y segundos a la clase
            DateTime dt2 = new DateTime(2022, 12, 31, 15, 10, 20);
            Console.WriteLine($"Fecha con año, mes, dia, hora, minuto, segundo: {dt2.ToString()}");

            // Otra particularidad de la clase DateTime, es que incluye campos y propiedades estaticas sin la necesidad de crear un objeto
            // Fecha de ahora mismo
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"Fecha ahora mismo: {currentDate.ToString()}");

            // Fecha de hoy
            DateTime todaysDate = DateTime.Today;
            Console.WriteLine($"Fecha de hoy: {todaysDate.ToString()}");

            // Fecha minima de DateTime
            DateTime minDateTime = DateTime.MinValue;
            Console.WriteLine($"Fecha minima DateTime: {minDateTime.ToString()}");

            // Fecha maxima DateTime
            DateTime maxDateTime = DateTime.MaxValue;
            Console.WriteLine($"Fecha maxima DateTime: {maxDateTime.ToString()}");


            // Otra estructura es TIMESPAN que nos represents tiempo en dias, horas, minutos, segundos y milisegundos

            DateTime initialDt = new DateTime(2020, 08, 18);
            Console.WriteLine(initialDt.ToString());

            TimeSpan newTs = new TimeSpan(25, 20, 55);
            Console.WriteLine(newTs.ToString());

            DateTime newDate = initialDt.Add(newTs);
            Console.WriteLine(newDate.ToString());
            Console.WriteLine("\n --------------------------- \n");
            // DateTime Operators
            // Tambien podemos escribir operaciones entre fechas
            DateTime dtOp1 = new DateTime(2020, 08, 18);
            DateTime dtOp2 = new DateTime(2021, 05, 07, 5, 10, 20);
            TimeSpan tsOp1 = new TimeSpan(10, 5, 15, 50);

            Console.WriteLine($"Fecha 1: {dtOp1.ToString()}");
            Console.WriteLine($"Fecha 2: {dtOp2.ToString()}");
            Console.WriteLine($"Fecha 2 + 10 dias, 5 horas, 15 minutos y 50 segundos: {dtOp2 + tsOp1}");
            Console.WriteLine($"Fecha 2 - fecha 1: {dtOp2 - dtOp1}");
            Console.WriteLine($"Fecha 2 == Fecha 1: {dtOp2 == dtOp1}");
            Console.WriteLine($"Fecha 2 != Fecha 1: {dtOp2 != dtOp1}");
            Console.WriteLine($"Fecha 2 > Fecha 1: {dtOp2 > dtOp1}");
            Console.WriteLine($"Fecha 2 < Fecha 1: {dtOp2 < dtOp1}");


            // Metodos de DateTime
            // Ademas de las propiedades que nos ofrece, tambien podemos usar algunos metodos disponibles para el formato de fechas
            // ToString() => Permite convertir el objeto DateTime a texto
            Console.WriteLine($"Fecha DateTime a texto con ToString(): {dtOp2.ToString()}"); // Con ToString() podemos imprimir el texto en el Console
            Console.WriteLine($"Fecha corta sin tiempo (horas, minutos, segundos) con ToShortDateString(): {dtOp2.ToShortDateString()}");
            Console.WriteLine($"Fecha de tiempo corta con ToShortTimeString(): {dtOp2.ToShortTimeString()}");
            Console.WriteLine($"Fecha larga con ToLongDateString(): {dtOp2.ToLongDateString()}");
            Console.WriteLine($"Fecha de tiempo larga ToLongTimeString(): {dtOp2.ToLongTimeString()}");

            Console.WriteLine($"Dias de un mes en especifico (2022, Julio): {DateTime.DaysInMonth(2022, 07)}"); // Dias que tendra julio del 2022 => 31
            Console.WriteLine($"Determina si un año es biciesto (2023): {DateTime.IsLeapYear(2022)}"); // Año biciesto (2022) => False

            DateTime myBirthDate = new DateTime(1988, 05, 03);
            Console.WriteLine($"Mi fecha de nacimiento: {myBirthDate.ToString()}");
            Console.WriteLine($"Mi fecha de nacimiento + 20 horas: {myBirthDate.AddHours(20)}");
            Console.WriteLine($"Mi fecha de nacimiento + 20 horas + 21 minutos: {myBirthDate.AddHours(20).AddMinutes(21)}");
            Console.WriteLine($"Mi fecha de nacimiento + 20 horas + 21 minutos + 48 segundos: {myBirthDate.AddHours(20).AddMinutes(21).AddSeconds(48)}");

            Console.WriteLine($"Mi fecha de nacimiento + 10 dias: {myBirthDate.AddDays(10)}");
            Console.WriteLine($"Mi fecha de nacimiento + 3 meses: {myBirthDate.AddMonths(3)}");
            Console.WriteLine($"Mi fecha de nacimiento + 5 años: {myBirthDate.AddYears(5)}");

        }
    }
}
