using Laboratorio1_Elvis_Wosbaldo_Rubio_Medrano.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_Elvis_Wosbaldo_Rubio_Medrano.Negocio
{
    public class ClsPersona 
    {
        internal static void calcularIMC(Persona per)
        {
            throw new NotImplementedException();
        }

        internal static void esMayorDEEdad(Persona per)
        {
            throw new NotImplementedException();
        }

        public String calcularIMC(double Peso, double Altura)
        {
            double calculoIMC=Peso/Math.Pow(Altura,2);
            if (calculoIMC < 24)
            {
                return "Peso Ideal";
            }

            else
            {
                return "Sobre peso";
            }
           

            
          
        }
        public String esMayorDeEdad( double Edad, double edad)
        {
            if (edad <18)
            {
                return "Usted es mayor de edad";
            }
            else
            {
                return "Es menor de edad";
            }



        }


    }

}
