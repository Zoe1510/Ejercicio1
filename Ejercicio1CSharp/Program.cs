using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_DFDaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "", apellido = "", codigo = "", materia = "";
            double nota1 = 0, nota2 = 0, nota3 = 0;
            double cortes = 35, corte = 30;
            try
            {
                Console.WriteLine("A Continuación introduzca los siguientes datos:");
                Console.WriteLine("Nombre:");
                nombre=Console.ReadLine();
                Console.WriteLine("Apellido:");
                apellido = Console.ReadLine();
                Console.WriteLine("Código:");
                codigo = Console.ReadLine();
                Console.WriteLine("Materia o Asignatura:");
                materia = Console.ReadLine();
                Console.WriteLine("Nota del corte 1:");
                nota1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota del corte 2:");
                nota2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota del corte 3:");
                nota3 = double.Parse(Console.ReadLine());

                nota1 = (nota1 * cortes) / 100;
                nota2 = (nota2*cortes) / 100;
                nota3 = (nota3*corte) / 100;

                double definitiva = nota1 + nota2 + nota3;

                Console.WriteLine("La nota definitiva de la materia "+ materia + " es: "+definitiva.ToString()+"");
                Console.ReadKey();


            }
            catch(Exception error)
            {
                Console.WriteLine("Ha ocurrido el siguiente error: ", error);
            }
            
        }
    }
}
