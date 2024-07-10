using System;
using ConsoleApp3.Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Interfaces
{
    internal interface ICarrera
    {
        string Nombre { get; set; }
        string Sigla { get; set; }
        string Titulo { get; set; }
        int Duracion { get; set; }

        bool NombreExist(string nombre);
        bool SiglaExist(string sigla);

        Carrera FindBySigla(string sigla);

        List<Carrera> List();
        }
}
