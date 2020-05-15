using System;

namespace _21bProyectoCalculador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========  CALCULADOR  ==========\n");

            Opciones();

            int operacion;

            do
            {
                Console.WriteLine("Escribe el numero de la opcion que desea seleccionar:");

                try
                {
                    operacion = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Una respuesta en forma de texto no es valida. Intenta por ejemplo: 1");

                    operacion = 0;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Introdujo un caracter demasiado grande. Intente por ejemplo: 1");

                    operacion = 0;
                }

                if (operacion == 1)
                {
                    Console.WriteLine("\n---------   DISTANCIA ENTRE PUNTOS  ----------\n");

                    Console.WriteLine("1- Distancia dos puntos (en plano).\n2- Distancia dos puntos (en espacio)." +
                        "\n\nEscribe el numero de la opcion que desea seleccionar:");

                    int subOpperacion = 0;

                    bool bucle = true;

                    while (bucle)
                    {
                        try
                        {
                            subOpperacion = Int32.Parse(Console.ReadLine());

                            bucle = false;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Una respuesta en forma de texto no es valida. Intenta por ejemplo: 1");
                        }
                        catch (OverflowException e)
                        {
                            Console.WriteLine("Introdujo un caracter demasiado grande. Intente por ejemplo: 1");
                        }
                    }                   

                    if (subOpperacion == 1) DistanciaDosPuntosEnPlano();

                    else if (subOpperacion == 2) DistanciaDosPuntosEnEspacio();

                    break;
                }

                else if (operacion == 2) Console.WriteLine("Opcion 2");  //TODO: Hacer la distancia entre rectas

                else if (operacion == 3) Console.WriteLine("Opcion 3");  //TODO: Hacer la distancia entre planos

                else if (operacion == 4) Console.WriteLine("Ha salido del programa");

                else if (operacion == 0) Console.WriteLine("");

                else Console.WriteLine("Introdujo un numero de opcion invalido. Vuelve a intentarlo.");

            } while (operacion != 4);

        }

        public static void Opciones()
        {
            Console.WriteLine("1- Distancia entre puntos.\n2- Distancia entre rectas.\n3- Distancia entre planos.");

            Console.WriteLine("\n4- Salir.\n");
        }

        public static void DistanciaDosPuntosEnPlano()  //TODO: Hacer excepciones de string
        {
            Console.WriteLine("\n----- Primer punto -----\n");

            Console.WriteLine("Coordenada en X:");

            bool bucle = true;

            double coorX = 0;

            while (bucle)
            {
                try
                {
                    coorX = double.Parse(Console.ReadLine());

                    bucle = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Una respuesta en forma de texto no es valida. Intenta por ejemplo: 1");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Introdujo un caracter demasiado grande. Intente por ejemplo: 1");
                }
            }

            Console.WriteLine("\nCoordenada en Y:");

            double coorY = double.Parse(Console.ReadLine());

            Console.WriteLine("\n----- Segundo punto -----\n");

            Console.WriteLine("Coordenada en X:");

            double coorDosX = double.Parse(Console.ReadLine());

            Console.WriteLine("\nCoordenada en Y:");

            double coorDosY = double.Parse(Console.ReadLine());

            distanciaPuntos primPunto = new distanciaPuntos(coorX, coorY);

            distanciaPuntos segPunto = new distanciaPuntos(coorDosX, coorDosY);

            double distanciaFinal = primPunto.DistanciaDosPuntosPlano(segPunto);

            Console.WriteLine($"\nRESULTADO:\nLa distancia entre los puntos es: {distanciaFinal}");
        }

        public static void DistanciaDosPuntosEnEspacio()
        {
            Console.WriteLine("\n----- Primer punto -----\n");

            Console.WriteLine("Coordenada en X:");

            double coorX = double.Parse(Console.ReadLine());

            Console.WriteLine("\nCoordenada en Y:");

            double coorY = double.Parse(Console.ReadLine());

            Console.WriteLine("\nCoordenada en Z:");

            double coorZ = double.Parse(Console.ReadLine());

            Console.WriteLine("\n----- Segundo punto -----\n");

            Console.WriteLine("Coordenada en X:");

            double coorDosX = double.Parse(Console.ReadLine());

            Console.WriteLine("\nCoordenada en Y:");

            double coorDosY = double.Parse(Console.ReadLine());

            Console.WriteLine("\nCoordenada en Z:");

            double coorDosZ = double.Parse(Console.ReadLine());

            distanciaPuntos primPunto = new distanciaPuntos(coorX, coorY, coorZ);

            distanciaPuntos segPunto = new distanciaPuntos(coorDosX, coorDosY, coorDosZ);

            double distanciaFinal = primPunto.DistanciaDosPuntosEspacio(segPunto);

            Console.WriteLine($"\nRESULTADO:\nLa distancia entre los puntos es: {distanciaFinal}");
        }
    }
}
