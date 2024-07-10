using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Clases
{
    class Usuario : IABMC<Usuario>, IUsuario
    {

        static List<Usuario>Usuarios = new List<Usuario>();
        private static int LasID = 1;

        #region IID
        public int ID { get; set; }
        #endregion

        #region IABMC
        public void Add(Usuario usuarios)
        {
            if (DNIExist(usuarios.DNI))
            {
                throw new Exception("El DNI ya existe.");
            }
            if (MailExist(usuarios.Mail))
            {
                throw new Exception("El Mail ya existe.");
            }
            usuarios.ID=LasID;
            LasID++;
            Usuarios.Add(usuarios);
        }
        public void Erase(Usuario usuarios)
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.ID==usuarios.ID)
                {
                    Usuarios.Remove(u);
                    return;
                }
            }
            throw new Exception("No se encontro el Usuario.");
        }
        public Usuario Find(Usuario usuarios)
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.ID==usuarios.ID)
                {
                    return u;
                }
            }
            throw new Exception("No se encontro el Usuario.");
        }
        public void Modify(Usuario usuarios)
        {
            Usuario u = Find(usuarios);
            if (u == null)
            {
                throw new Exception("El Usuario no existe.");
            }
            u.Nombre = usuarios.Nombre;
        }
        #endregion

        #region IUsuario
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public string Mail { get; set; }

        public bool DNIExist(int dni)
        {
            foreach (Usuario usuario in Usuarios)
            {
                if (usuario.DNI == dni)
                    return true;
            }
            return false;
        }
        public bool MailExist(string Mail)
        {
            foreach (Usuario usuario in Usuarios)
            {
                if (usuario.Mail == Mail)
                    return true;
            }
            return false;
        }

        public Usuario FindDNI(int dni)
        {
            foreach (Usuario usuario in Usuarios)
            {
                if (usuario.DNI == dni)
                    return usuario;
            }
            throw new Exception("No se encontro el DNI");
        }
        public Usuario FindMail(string mail)
        {
            foreach (Usuario usuario in Usuarios)
            {
                if (usuario.Mail == mail)
                    return usuario;
            }
            throw new Exception("No se encontro el Mail.");
        }

        public List<Usuario> List()
        {
            return Usuarios;
        }
        #endregion

    }
}
