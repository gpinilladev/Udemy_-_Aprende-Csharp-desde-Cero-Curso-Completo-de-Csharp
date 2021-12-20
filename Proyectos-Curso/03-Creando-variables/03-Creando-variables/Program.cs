using System;

namespace _03_Creando_variables
{
    class Program
    {
        protected static void Main(string[] args)
        {
            // 🤓 Para crear variables o propiedades de la clase debemos tener en cuenta la siguiete sintaxis
            // 1 - Debemos definir el tipo de variable que vamos a crear, en este caso los tipos mas usados son:
            //     - int
            //     - string
            //     - bool
            //     - float
            //     - double
            //     - decimal
            //     - object
            // 2 - Una vez identificamos el tipo de variable, definimos su nombre en formato camel case
            //     string firstName
            // 3 - Una vez damos un nombre acorde al tipo e variable y logicmante su valor. Asignamos un valor logico a dicha variable:
            //     string firstName = "German";
            // 4 - Finalizamos la sentencia con punto y coma (;). Muy importante!

            string firstNameUser = "German"; // Variable de tipo string que almacena el nombre del usuario
            string lastNameUser = "Pinilla"; // Variable de tipo string que almacena el apellido del usuario
            string emailUser = "gpinilladev@gmail.com"; // Variable de tipo string que almacena el email del usuario
            int ageUser = 33; // Variable de tipo integer que almacena la edad del usuario
            double heightUser = 1.68; // Variable de tipo string que almacena la estatura del usuario
            bool isStudent = true; // Variable de tipo boolean que almacena el valor bit de si es estudiante o no lo es (true o false)

            string dataUserMessage = dataUser(firstNameUser, lastNameUser, emailUser, ageUser, heightUser, isStudent);
            Console.WriteLine(dataUserMessage);

            int number1 = 10;
            int number2 = 20;
            Console.WriteLine(number1 + number2);

            double dataPI = PI();
            Console.WriteLine("Data value PI: " + dataPI);

        }

        public static string dataUser(
            string firstNameUser,
            string lastNameUser,
            string emailUser,
            int ageUser,
            double heightUser,
            bool isStudent)
        {
            string isStudentFlag = (isStudent) ? "Si" : "No";
            return "Data User\n\nName User: " + firstNameUser + " " + lastNameUser + "\nEmail User: " + emailUser + "\nAge User: " + ageUser + "\nHeight User: " + heightUser + "\n¿Es estudiante?: " + isStudentFlag;
        }

        public static double PI()
        {
            const double dataPI = Math.PI;
            return dataPI;
        }

    }
}
