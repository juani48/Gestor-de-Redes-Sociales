using CshaprSocialNetWorkManager.Models;
using System;
using CshaprSocialNetWorkManager.Utilities;
using System.Linq;
using CshaprSocialNetWorkManager.Utilities.Log;

namespace CshaprSocialNetWorkManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var App = new AppManager(new LogJson());

            Console.WriteLine($"Bienvenido a: {App.getAppTitle()}");
            bool ok = true;
            while (ok)
            {
                Console.WriteLine("--Ingrese-- " +
                    "\n-1: Para ver las redes sociales disponibles." +
                    "\n-2: Para salir.");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Redes sociales disponibles...");
                            var SNW = App.getSNW().Concat(App.getSNWwG());

                            foreach (var item in SNW)
                            {
                                Console.WriteLine(item.getName());
                            }

                            Console.WriteLine("--Ingrese-- " +
                                "\n-1: Para ver una red social." +
                                "\n-2: Para ingresar un usuario." +
                                "\n-3: Para ver estadisticas de una red social." +
                                "\n-4: Para regresar." +
                                "\n-5: Para salir.");
                            int option2 = int.Parse(Console.ReadLine());
                            switch (option2)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Ingrese un nombre de red social");
                                        string nameSocialNetWork = Console.ReadLine();

                                        var SNWselected = SNW.FirstOrDefault(p => p.Name.ToLower() == nameSocialNetWork);
                                        if (SNWselected != null)
                                            Console.WriteLine(App.getInfomratioSNW(SNWselected));
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Ingrese un nombre de red social para agregar un usuario");
                                        string nameSocialNetWork = Console.ReadLine();
                                        var SNWselected = SNW.FirstOrDefault(p => p.Name.ToLower() == nameSocialNetWork);

                                        Console.WriteLine("Ingrese su asuario");
                                        string name = Console.ReadLine();
                                        Console.WriteLine("Ingrese su email");
                                        string email = Console.ReadLine();
                                        Console.WriteLine("Ingrese su edad");
                                        var age = short.Parse(Console.ReadLine());
                                        var User = new User(name, email, age);

                                        if (SNWselected is SocialNetWorkWhitGroups)
                                        {
                                            var SNWselected2 = SNWselected as SocialNetWorkWhitGroups;
                                            int index = App.getSNWwG().IndexOf(SNWselected2);
                                            App.getSNWwG()[index].getUsers().Add(User);
                                        }
                                        else
                                        {
                                            int index = App.getSNW().IndexOf(SNWselected);
                                            App.getSNW()[index].getUsers().Add(User);
                                        }

                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Ingrese un nombre de red social para ver sus estadisticas");
                                        string nameSocialNetWork = Console.ReadLine();
                                        var SNWselected = SNW.FirstOrDefault(p => p.Name.ToLower() == nameSocialNetWork);
                                        if (SNWselected != null)
                                            Console.WriteLine(App.getStackSNW(SNWselected));
                                        break;
                                    }
                                case 4:
                                    {
                                        break;
                                    }
                                default:
                                    {
                                        ok = false;
                                        break;
                                    }

                            }
                            break;
                        }
                    default:
                        {
                            ok = false;
                            break;
                        }

                }
            }
        }
    }
}
