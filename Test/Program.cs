using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //AgregarAtaud();
            //BuscarYModificar();
            //Listar();
            BuscarYEliminar();
            //TipoDeMov();
            Console.Write("PRESIONE PARA FINALIZAR");
            Console.ReadLine();
        }
        static void AgregarAtaud()
        {
            ATAUD ataud = new ATAUD();
            {
                ataud.Codigo = "Barnizado";
                ataud.Precio = 17000;
                using (var repos = new Repository<ATAUD>())
                {
                    repos.Create(ataud);
                }
                Console.WriteLine("ATAUD: {0}", ataud.Codigo);
                Console.WriteLine("PRECIO: ${0}", ataud.Precio);
            }
        }

        static void BuscarYModificar()
        {
            using (var repos = new Repository<ATAUD>())
            {
                var A = repos.Retrieve(a => a.ID == 2);
                if (A != null)
                {
                    Console.WriteLine(A.Codigo);
                    A.Codigo = A.Codigo + "***";
                    repos.Update(A);
                    Console.WriteLine("NOMBRRE MODIFICADO");
                }
                else
                {
                    Console.WriteLine("ATAUD NO ENCONTRADO");
                }
            }
        }

        static void Listar()
        {
            using(var repos = new Repository<ATAUD>())
            {
                var ATAUD = repos.Filter(a => a.ID == 1);
                foreach(var a in ATAUD)
                {
                    Console.WriteLine("{0}", a.Codigo);
                }
            }
        }

        static void BuscarYEliminar()
        {
            using (var repos = new Repository<ATAUD>())
            {
                var A = repos.Retrieve(a => a.ID != 1);
                if (A != null)
                {
                    Console.WriteLine(A.Codigo);
                    repos.Delete(A);
                    Console.WriteLine("ATAUD ELIMINADO");
                }
                else
                {
                    Console.WriteLine("ATAUD NO ENCONTRADO");
                }
            }
        }

        static void TipoDeMov()
        {
            MOV mov = new MOV();
            {
                mov.Fecha = DateTime.Now;
                mov.Proveedor = "ETERNITY";
                //mov.TMov = bool;
                using (var repos = new Repository<MOV>())
                {
                    repos.Create(mov);
                }
                Console.WriteLine("FECHA: {0}", mov.Fecha);
                Console.WriteLine("PROVEEDOR: {0}", mov.Proveedor);
            }
        }
    }
}