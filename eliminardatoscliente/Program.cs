using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eliminardatoscliente
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente uwu = new cliente();
            uwu.InsertarCliente();
            uwu.MostararCliente();
            uwu.EliminarCliente();


            Console.ReadKey();


        }
    }
}
