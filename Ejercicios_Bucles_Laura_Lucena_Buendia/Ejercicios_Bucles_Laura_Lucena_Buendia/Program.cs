using System;

namespace Ejercicios_Bucles_Laura_Lucena_Buendia
{
    /// <summary>
    /// Primer programa realizado para el repaso de bucles. (Sólo con lo explicado en clase/No Arrays)
    /// Trabajo de clase - Profesor Álvaro López Jurado
    /// 
    /// Deberá realizar lo siguiente:
    /// 1. Factorial
    /// 2. Clave
    /// 3. Números primos
    /// 4. Mayusculas descendentes
    /// 5. Salir
    /// 
    /// @author - Alumno. Laura Lucena Buendia
    /// </summary>
    class Program
    {
        //Main
        static void Main(string[] args)
        {
            Boolean menuPrincipal = true;

            //Menu principal
            do
            {
                Console.WriteLine("\n**************  EJERCICIOS DE BUCLES   ************" +
                "\n1.Factorial" +
                "\n2.Clave" +
                "\n3.Numeros primos" +
                "\n4.Mayúsculas descendentes" +
                "\n5.Salir" +
                "\n****************************************************");

                //Condicion selección menú (Para que sólo pueda insertar números)
                Boolean es_numero = false;
                int numeroTest = 0;
                int numeroOpcionMenu = 0;
                do
                {
                    Console.Write("\nInserte opción: ");
                    String input = Console.ReadLine();

                    if (int.TryParse(input, out numeroTest))
                    {
                        numeroOpcionMenu = numeroTest;
                        es_numero = true;
                    }

                } while (!es_numero);

                //SWITCH (Dependiendo de lo que hayamos introducido hará un ejercicio u otro)
                switch (numeroOpcionMenu)
                {
                    case 1:
                        Console.WriteLine("\nEj1. Factorial");
                        Console.Write("Escribe un número dado para calcular el factorial: ");
                        int numFactorial = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("El factorial del número '" + numFactorial + "' es: " + calculoFactorial(numFactorial));
                        pulsarParaSeguir();
                        break;

                    case 2:
                        Console.WriteLine("\nEj2. Clave");
                        clave_de_Usuario();
                        // comentario personal: Realizarlo la próxima vez con '.remove()'
                        pulsarParaSeguir();
                        break;

                    case 3:
                        Console.WriteLine("\nEj3. Números Primos");
                        Console.Write("Inserte cuantos números primos desea obtener (irán en orden): ");
                        int numPrimos = Convert.ToInt32(Console.ReadLine());
                        encontrarNumerosPrimos(numPrimos);
                        pulsarParaSeguir();
                        break;


                    case 4:
                        Console.WriteLine("\nEj4. Mayúsculas descendentes");
                        mayusculasDescendentes();
                        pulsarParaSeguir();
                        break;


                    case 5:
                        menuPrincipal = false;
                        Console.WriteLine("\nHasta pronto");
                        break;

                    default:
                        Console.WriteLine("\nOpción no contemplada en el menú");
                        pulsarParaSeguir();
                        break;
                }

            } while (menuPrincipal);//Fin Menu principal
        }



        //Métodos
        //Crear factorial
        public static int calculoFactorial(int num)
        {
            int resultado = num;
            for (int i = 1; i < num; i++)
            {
                resultado *= i;
            }
            return resultado;
        }


        //Clave de usuario
        private static void clave_de_Usuario()
        {
            String clave = "";
            String claveGuardada = "";

            do
            {
                Console.Write("¿Qué clave deseas? ");
                clave = Console.ReadLine();

                if (clave != "*")
                    claveGuardada = clave;
                else
                    Console.WriteLine("La clave es '" + claveGuardada + "'");

            } while (clave != "*");
            
        }

        //Mostrar 'x' Numeros primos
        private static void encontrarNumerosPrimos(int numPrimos)
        {
            int contadorNumPrimos = 0;

            for (int num = 2; contadorNumPrimos < numPrimos; num++)
            {
                //Primero contamos el '2'
                if(num == 2)
                {
                    contadorNumPrimos++;
                    Console.WriteLine(contadorNumPrimos + " => " + num);

                }
                //Empezamos a recorrer
                else
                {
                    Boolean esPrimo = true;
                    for (int divisor = 2; divisor <= num/2; divisor++)
                    {
                        if (num % divisor == 0)
                            esPrimo = false;
                        //Console.Write(num + " " + divisor);
                    }

                    if (esPrimo)
                    {
                        contadorNumPrimos++;
                        Console.WriteLine(contadorNumPrimos + " => " + num);
                    }
                }
            }
        }


        //Abecedario inverso
        private static void mayusculasDescendentes()
        {
            for (int letra = 90; letra >= 65; letra--)
            {
                Console.WriteLine((char)(letra));
            }
        }


        // Función para resetear el menu
        private static void pulsarParaSeguir()
        {
            Console.WriteLine("\n\n\n ----- Pulse para seguir -----");
            Console.ReadKey();
        }
    }
}
