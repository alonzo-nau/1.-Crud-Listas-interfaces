using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Clases
{
    class Carrera : IABMC<Carrera>, ICarrera
    {
        static List<Carrera> objetodelistacarrera = new List<Carrera>();
        private static int LasID = 1;

        #region IDD
        public int ID { get; set; }
        #endregion

        #region IABMC
        public void Add(Carrera carrera)
        {
            if (NombreExist(carrera.Nombre))
            {
                throw new Exception("La carrera ya existe.");
            }
            if (SiglaExist(carrera.Sigla))
            {
                throw new Exception("La sigla de esa carrera ya existe.");
            }
            carrera.ID = LasID;
            LasID++;
            objetodelistacarrera.Add(carrera);
        }
        public void Erase(Carrera carrera)
        {
            foreach (Carrera c in objetodelistacarrera)
            {
                if (c.ID == carrera.ID)
                {
                    objetodelistacarrera.Remove(c);
                    return;
                }
            }
            throw new Exception("No se encontro la Carrera.");
        }
        public Carrera Find(Carrera carrera)
        {
            foreach (Carrera c in objetodelistacarrera)
            {
                if (c.ID == carrera.ID)
                {
                    return c;
                }
            }
            throw new Exception("No se encontro la Carrera.");
        }
        public void Modify(Carrera carrera)
        {
            Carrera c = Find(carrera);
            if (c == null)
            {
                throw new Exception("La Carrera no existe.");
            }
            c.Nombre = carrera.Nombre;
        }
        #endregion

        #region ICarrera
        public string Nombre { get; set; }
        public string Sigla { get; set; }
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        
        public bool NombreExist(string nombre)
        {
            foreach (Carrera carrera in objetodelistacarrera)
            {
                if (carrera.Nombre == nombre)
                {
                    return true;
                }
                    
            }
            return false;
        }
        public bool SiglaExist(string sigla)
        {
            foreach (Carrera carrera in objetodelistacarrera)
            {
                if (carrera.Sigla == sigla)
                {
                    return true;
                }
            }
            return false;
        }

        public Carrera FindBySigla(string sigla)
        {
            foreach (Carrera carrera in objetodelistacarrera)
            {
                if (carrera.Sigla == sigla)
                    return carrera;
            }
            throw new Exception("No se encontro las Siglas");
        }

        public List<Carrera> List()
        {
            return objetodelistacarrera;
        }
        #endregion
    }
}
