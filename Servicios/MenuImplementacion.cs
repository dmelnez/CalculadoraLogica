using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Servicios
{
    internal class MenuImplementacion : MenuInterfaz 
    {
        public void BienvenidaUsuario()
        {
            string mensajeBienvenidaU = "Bienvenido a la Calculadora Logica";
            Console.WriteLine(mensajeBienvenidaU);
        }

        public int MostrarMenu()
        {
            int valorIntroducidoU;

            Console.WriteLine("---------- Calculadora ---------");
            Console.WriteLine("1. Cerrar Calculadora          -");
            Console.WriteLine("2. Igualdad                    -");
            Console.WriteLine("3. Desigualdad                 -");
            Console.WriteLine("------- Elija una Opcion -------");

            valorIntroducidoU = Console.ReadKey(true).KeyChar - ('0');
            return valorIntroducidoU;
        }   
    }}
