using System;

namespace crear_un_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un banco tiene 3 clientes que pueden hacer depósitos y extracciones. 
            También el banco requiere que al final del día calcule la cantidad 
            de dinero que hay depositada.*/
            int menu;
            int deposito=0, extraer=0, monto =30000;
            do
            {
                
                
                Console.WriteLine("\n" + "----Menu----");
                Console.WriteLine("1.- depositar");
                Console.WriteLine("2.- extraer");
                Console.WriteLine("3.- saber saldo");
                Console.WriteLine("4.- Salir del programa.");
                Console.WriteLine("ingrese una contrasena");

               

                Console.Write("\n" + "Ingrese una opcion del menu: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {

                    case 1:
                        Console.WriteLine("Cuanto desea depositar");
                        deposito = int.Parse(Console.ReadLine());
                        Console.WriteLine("usted ha depositado: " + deposito);

                        break;

                    case 2:
                        Console.WriteLine("cuanto desea extraer:");
                        extraer = int.Parse(Console.ReadLine());

                        Console.WriteLine("usted ha extrajo: " + extraer);
                        
                        break;

                    case 3:
                        monto = monto - extraer + deposito;
                        Console.WriteLine("tienes un monto de: "+ monto);

                        break;
                   
                    case 4:
                         Console.WriteLine("\n" + "Fin del programa");
                         break;

                    default:
                        Console.WriteLine("\n" + "Esta opcion no esta en el menu.");
                        break;

                }
                Console.ReadKey();

            }
            while (menu != 0);
        }   
    }
}

        