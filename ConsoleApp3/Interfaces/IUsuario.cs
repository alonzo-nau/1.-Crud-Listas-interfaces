using System;
using ConsoleApp3.Clases; //Agregé esta librería
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Interfaces
{
    internal interface IUsuario
    {
        string Nombre { get; set; }
        int DNI { get; set; }
        string Mail { get; set; }

        bool DNIExist(int dni);
        bool MailExist(string mail);

        Usuario FindMail(string mail);
        Usuario FindDNI(int dni);

        List<Usuario> List();
    }
}
