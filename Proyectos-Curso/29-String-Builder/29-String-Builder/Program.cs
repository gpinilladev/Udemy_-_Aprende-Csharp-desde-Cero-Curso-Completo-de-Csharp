using System;
using System.Text;

namespace _29_String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            string number = "1";
            string street = "Palo Alto St.";
            string city = "California";

            string location = street + " " + number + " " + city;
            Console.WriteLine(location);

            StringBuilder sb = new StringBuilder();
            sb.Append(street);
            sb.AppendLine(number);
            sb.Append(city);

            sb.Insert(1, "AA");
            Console.WriteLine(sb.ToString());

            sb.Remove(1, 2);
            Console.WriteLine(sb.ToString());

            sb.Replace("Alto", "Bajo");
            Console.WriteLine(sb.ToString());

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hi there!");
            //sb.AppendLine("This is a new line!");

            //sb.Insert(2, " German");

            //Console.WriteLine(sb.ToString());

            //sb.Remove(4, 8);
            //Console.WriteLine(sb.ToString());

            //sb.Replace("This", " This");
            //Console.WriteLine(sb.ToString());

            //sb.Replace("This is a new line", "This is great!");
            //Console.WriteLine(sb.ToString());
        }
    }
}
