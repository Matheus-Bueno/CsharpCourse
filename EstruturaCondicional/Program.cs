
using System.Globalization;

namespace EstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o exercício :");
            Console.WriteLine("1 - Negativo ou Positivo");
            Console.WriteLine("2 - Par ou Ímpar");
            Console.WriteLine("3 - Múltiplos");
            Console.WriteLine("4 - Duração do jogo");
            Console.WriteLine("5 - Valor da Conta");
            Console.WriteLine("6 - Verificação de Intervalos");
            Console.WriteLine("7 - Plano Cartesiano");
            Console.WriteLine("8 - Calculo Imposto de Renda");

            while (true)
            {
                Console.Write("\nOpção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Exercicio1();
                        break;
                    case "2":
                        Exercicio2();
                        break;
                    case "3":
                        Exercicio3();
                        break;
                    case "4":
                        Exercicio4();
                        break;
                    case "5":
                        Exercicio5();
                        break;
                    case "6":
                        Exercicio6();
                        break;
                    case "7":
                        Exercicio7();
                        break;
                    case "8":
                        Exercicio8();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        private static void Exercicio1()
        {
            //Verificação se um Numero é positivo ou negativo
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("NEGATIVO");

            }
            else
            {
                Console.WriteLine("POSITIVO");
            }
        }


        private static void Exercicio2()
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }

        private static void Exercicio3()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 % num2 == 0 || num2 % num1 == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }

        private static void Exercicio4()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine($"O Jogo Durou {duracao} Hora(s)");

        }

        private static void Exercicio5()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int codProduto = int.Parse(valores[0]);
            int qtdProduto = int.Parse(valores[1]);

            double valorFinal;

            if (codProduto == 1)
            {
                //valor cachorro quente
                valorFinal = qtdProduto * 4;
            }
            else if (codProduto == 2)
            {
                //valor X-Salada
                valorFinal = qtdProduto * 4.50;
            }
            else if (codProduto == 3)
            {
                //valor X-Bacon
                valorFinal = qtdProduto * 5;
            }
            else if (codProduto == 4)
            {
                //valor X-Bacon
                valorFinal = qtdProduto * 2;
            }
            else
            {
                //valor refrigerante
                valorFinal = qtdProduto * 1.50;
            }

            Console.WriteLine($"TOTAL : R$ {valorFinal.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        private static void Exercicio6()
        {
            double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (entrada < 0 || entrada > 100)
            {
                Console.WriteLine("Fora de intervalo"); ;
            }
            else if (entrada <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (entrada <= 50)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (entrada <= 75)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo [75,100]");
            }
        }

        private static void Exercicio7()
        {

            //Plano Catesiano
            //  Q2  |  Q1
            //-------------
            //  Q3  |  Q4

            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0 || y == 0)
            {
                if (x == 0 && y == 0)
                {
                    Console.WriteLine("Origem");
                }
                else if (x == 0)
                {
                    Console.WriteLine("Eixo X");
                }
                else
                {
                    Console.WriteLine("Eixo Y");
                }
            }
            else
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Q1");
                }
                else if (x > 0 && y <0)
                {
                    Console.WriteLine("Q4");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Q2");
                }
                else
                {
                    Console.WriteLine("Q3");
                }
            }
        }

        private static void Exercicio8()
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
