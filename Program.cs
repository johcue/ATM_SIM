using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Realizar una aplicación en consola que simule un cajero Electronico, en el cual se disponga inicialmente de un
//saldo definido por un administrador, y se permita hacer retiros por un valor máximo de $600.000.

namespace Taller1Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int monto, opc=0;
            double admin = 3300000, i = 0, j = 0, k = 0, valor = 0;

            Console.WriteLine("\t\t-----------------(0 0)-----------------");
            Console.WriteLine("\t\t---------------------------------------");
            Console.WriteLine("\t\t    BIENVENIDO AL CAJERO ELECTRONICO   ");
            Console.WriteLine("\t\t---------------------------------------");
            Console.WriteLine("\t\t-----------------(0 0)-----------------");
            Console.Write("\n\n");
            Console.WriteLine("\t\t           1. SACAR DINERO");
            Console.WriteLine("\t\t           2. SALIR ");
            Console.Write("\n ");
            Console.Write("\t Por favor, elija su operacion ");
            opc = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch(opc)
            {
                case 1: Console.WriteLine("\n \t SACAR DINERO \n");
                    Console.WriteLine("Recuerde que se permite unicamente hacer retiros de maximo $"+ admin);
                    Console.Write("\n \t Por favor, digite el monto de dinero que desea retirar:");
                    monto = Convert.ToInt32(Console.ReadLine());
                    if (monto > admin)
                    {
                        Console.WriteLine("\t Lo sentimos, no tenemos el monto de dinero requerido\n");
                    }
                    else if (monto != 0)
                    {
                        if (monto > 600000)
                            { 
                                Console.WriteLine(" El monto ingresado NO puede ser retirado\n"); 
                            }
                            else if (monto <= 600000 && monto >= 50000)
                            {
                                while (monto > 50000)
                                {
                                   monto = monto - 50000;
                                   i = i + 1;
                                 }
                                while (monto > 20000)
                                {
                                    monto = monto - 20000;
                                    j = j + 1;
                                 }
                                while (monto >= 10000)
                                {
                                    monto = monto - 10000;
                                    k = k + 1;
                                     }
                                valor = i * 50000 + j * 20000 + k * 10000;
                                Console.WriteLine(" Hacemos Entrega de:                  " + i + " billetes de $ 50.000\n");
                                Console.WriteLine("                                      " + j + " billetes de $ 20.000\n");
                                Console.WriteLine("                                      " + k + " billetes de $ 10.000\n");
                            }
                            else if (monto < 50000)
                            {
                                while (monto > 20000)
                                {
                                    monto = monto - 20000;
                                    j = j + 1;
                                    }
                                while (monto >= 10000)
                                {
                                    monto = monto - 10000;
                                    k = k + 1;
                                }
                                valor = j * 20000 + k * 10000;
                                Console.WriteLine(" Hacemos Entrega de:   " + j + " billetes de $ 20.000\n");
                                Console.WriteLine("                                      " + k + " billete de $ 10.000\n");
                            }
                            Console.WriteLine("\t Se entrego $ " + valor + " exitosamente\n");
                            Console.Write("\t Gracias en nuestros servicios, Hasta Pronto");
                        
                    }
                    Console.ReadKey();                    
            break;
                default:
            Console.Write("\n \n \n");
                    Console.WriteLine("\t\t---------------------------------------------");
                    Console.WriteLine("\t\t--------------------(0 0)--------------------");
                    Console.WriteLine("\t\t Gracias en nuestros servicios, Hasta Pronto");
                    Console.WriteLine("\t\t--------------------(0 0)--------------------");
                    Console.WriteLine("\t\t---------------------------------------------");
                     Console.ReadKey();  
            break;

            }
            Console.ReadKey();  
           
        }
    }
}
