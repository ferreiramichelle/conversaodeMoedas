using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace conversordeMoedas
    {
        public class Program
        {

            static void Main(string[] args)
            {

                while (true)
                {

                    Console.WriteLine("Escolha uma opção para converter:");
                    Console.WriteLine("1 - Real para Dola $");
                    Console.WriteLine("2 - Real para Euro €");
                    Console.WriteLine("3 - Real para Iene ¥ ");
                    Console.WriteLine("4 - Real para Libra Esterlina £");



                    int op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            RealParaDolar();
                            break;
                        case 2:
                            RealParaEuro();
                            break;
                        case 3:
                            RealParaIene();
                            break;
                        case 4:
                            RealParaLibra();
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
            }



            public static void RealParaDolar()
            {
                Console.WriteLine("Digite o valor em Real: ");
                decimal valorReal = Convert.ToDecimal(Console.ReadLine());

                decimal taxaCambio = 5.23m;

                decimal valorDolar = valorReal / taxaCambio;

                Console.WriteLine("Valor em Dólar: " + valorDolar);
            }

            public static void RealParaEuro()
            {
                Console.WriteLine("Digite o valor em Real: ");
                decimal valorReal = Convert.ToDecimal(Console.ReadLine());

                decimal taxaCambio = 6.19m;

                decimal valorEuro = valorReal / taxaCambio;

                Console.WriteLine("Valor em Euro: " + valorEuro);
            }

            public static void RealParaIene()
            {
                Console.WriteLine("Digite o valor em Real: ");
                decimal valorReal = Convert.ToDecimal(Console.ReadLine());

                decimal taxaCambio = 5.23m;

                decimal valorIene = valorReal * taxaCambio;

                Console.WriteLine("Valor em Iene: " + valorIene);
            }

            public static void RealParaLibra()
            {
                Console.WriteLine("Digite o valor em Real: ");
                decimal valorReal = Convert.ToDecimal(Console.ReadLine());

                decimal taxaCambio = 6.19m;

                decimal valorLibra = valorReal * taxaCambio;

                Console.WriteLine("Valor em Libra Esterlina: " + valorLibra);
            }
        }
    }


