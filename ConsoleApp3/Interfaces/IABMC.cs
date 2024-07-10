using System;
using ConsoleApp3.Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Interfaces
{
    internal interface IABMC<T>:IID
    {
        void Modify(T data);
        void Add(T data);
        void Erase(T data);

        T Find(T data);
    }
}
