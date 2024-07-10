using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Clases;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido!");
            Console.WriteLine();
            Console.Write("> Pulse una tecla para continuar. ");
            Console.ReadKey();
            Console.WriteLine();

            #region CreacionDeUsuario
            Usuario usuario = new Usuario();
            usuario.Nombre = "Nahuel";
            usuario.DNI = 36637742;
            usuario.Mail = "nahuel.i.alonzo@gmail.com";
            #endregion

            #region CreacionDeCarrera
            Carrera carrera = new Carrera();
            carrera.Nombre = "Tecnicatura en Analisis de Sistemas";
            carrera.Sigla = "TECAS";
            carrera.Titulo = "Analista de Sistemas";
            carrera.Duracion = 3;
            #endregion

            #region AddUsuarios
            usuario.Add(usuario);
            #endregion

            #region AddCarrera
            carrera.Add(carrera);
            #endregion

            #region ListaDeUsuarios
            List<Usuario>listausuarios = usuario.List();
            foreach (Usuario u in listausuarios )
            {
                Console.WriteLine("\nNombre del usuario: " + u.Nombre);
                Console.WriteLine("Dni del usuario: " + u.DNI);
                Console.WriteLine("Mail del usuario: " + u.Mail);
            }
            #endregion

            #region ListaDeCarrera
            List<Carrera>listacarrera = carrera.List();
            foreach (Carrera c in listacarrera)
            {
                Console.WriteLine("\nNombre de la carrera: " + c.Nombre);
                Console.WriteLine("Sigla de la carrera: " + c.Sigla);
                Console.WriteLine("Titulo de la carrera: " + c.Titulo);
                Console.WriteLine("Duracion de la carrera: " + c.Duracion + " años");
            }
            #endregion

            Console.WriteLine();
            Console.Write("> Pulse una tecla para salir. ");
            Console.ReadKey();
        }
    }
}
