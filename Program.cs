// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Laboratorio1_Elvis_Wosbaldo_Rubio_Medrano.Entidades;
using Laboratorio1_Elvis_Wosbaldo_Rubio_Medrano.Negocio;

namespace Laboratorio1_Elvis_Wosbaldo_Rubio_Medrano
{
    internal class Program
    {
        static void Main(string[] agrs)
        {
            Persona per = new Persona();
            ClsPersona Clsper = new ClsPersona();
            {
                Console.WriteLine("Ingrese su nombre: ");
                per.Nombre = (Console.ReadLine());

                Console.WriteLine("Escriba su genero: ");
                per.Sexo = (Console.ReadLine());

                Console.WriteLine("Escriba su Edad Señor(a) " + per.Nombre + "por favor");
                per.Edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Escriba su Altura Señor(a) " + per.Nombre + "por favor");
                per.Altura = double.Parse(Console.ReadLine());

                Console.WriteLine("Escriba su Peso Señor(a) " + per.Nombre + "por favor");
                per.Peso = double.Parse(Console.ReadLine());

                ClsPersona.calcularIMC(per);
                ClsPersona.esMayorDEEdad(per);






            }

            
        }


    }
}
