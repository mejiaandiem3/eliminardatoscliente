using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eliminardatoscliente
{
    public class cliente
    {
        public int n;
        tipopersona [] personas;

        public void InsertarCliente()
        {
            Console.WriteLine("¿cuantos clientes son? ");
            n = int.Parse(Console.ReadLine());

            personas = new tipopersona[n];

            for(int i= 0;i<n;i++)
            {
                Console.WriteLine("ID cliente: ");
                personas[i].IDCliente = Console.ReadLine();
                Console.WriteLine(" ");

                Console.WriteLine("Nombre: ");
                personas[i].Nombre = Console.ReadLine();
                Console.WriteLine(" ");

                Console.WriteLine("Apellido Paterno: ");
                personas[i].ApellidoPaterno = Console.ReadLine();
                Console.WriteLine(" ");

                Console.WriteLine("Apellido Materno: ");
                personas[i].ApellidoMaterno = Console.ReadLine();
                Console.WriteLine(" ");

                Console.WriteLine("Direccion: ");
                personas[i].Direccion = Console.ReadLine();
                Console.WriteLine(" ");

                Console.WriteLine("CP: ");
                personas[i].CP = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("Telefono: ");
                personas[i].Telefono = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("Telefono casa: ");
                personas[i].TelefonoCasa = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine(" ");

            }
        }
        public void MostararCliente()
        {
            for(int i = 0 ; i < n ; i++)
            {
                if (personas[i].Nombre!=null)
                {
                    Console.WriteLine("Cliente no. {0}:", i + 1);
                    Console.WriteLine("");
                    Console.WriteLine(personas[i].IDCliente);
                    Console.WriteLine(personas[i].Nombre);
                    Console.WriteLine(personas[i].ApellidoPaterno);
                    Console.WriteLine(personas[i].ApellidoMaterno);
                    Console.WriteLine(personas[i].Direccion);
                    Console.WriteLine(personas[i].CP);
                    Console.WriteLine(personas[i].Telefono);
                    Console.WriteLine(personas[i].TelefonoCasa);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }
        }

        public void EliminarCliente()
        {
            string buscar;
            string confirmar;
            Console.Write("Ingrese nombre de la persona a buscar");
            buscar = Console.ReadLine();
            
            for (int i = 0; i < n; i++)
            {
                if (personas[i].Nombre==buscar)
                {
                    Console.WriteLine("Elemento encontrado");
                    Console.WriteLine("Desea eliminarlo?");
                    confirmar = Console.ReadLine();

                    if (confirmar == "s" | confirmar == "Si" | confirmar == "si" | confirmar == "S"){
                        personas[i].Nombre = null;
                        personas[i].ApellidoMaterno = null;
                        personas[i].ApellidoPaterno = null;
                        personas[i].Direccion = null;
                        personas[i].IDCliente = null;
                        personas[i].Telefono = 0;
                        personas[i].TelefonoCasa = 0;
                        personas[i].CP = 0;
                    }
                }
            }
            Console.WriteLine("Elemento eliminado correctamente");
        }

    }
}
