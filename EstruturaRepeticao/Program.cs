

using System.Globalization;

namespace EstruturaRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o exercício :");
            Console.WriteLine("While:");
            Console.WriteLine("1 - Validação de senha");
            Console.WriteLine("2 - Verificação Plano Cartesiano");
            Console.WriteLine("3 - Posto de Gasolina");
            Console.WriteLine("\n");
            Console.WriteLine("For:");
            Console.WriteLine("4 - Valores Impares");
            Console.WriteLine("5 - Verificação de Intervalo");
            Console.WriteLine("6 - Média Ponderada");
            Console.WriteLine("7 - Divisão");
            Console.WriteLine("8 - Fatorial");

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
            Console.WriteLine("Informe a Senha de Login");


            while (true)
            {

                int senha = int.Parse(Console.ReadLine());

                if (senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");

                }
            }


        }

        private static void Exercicio2()
        {
            while (true)
            {
                Console.WriteLine("Infome as Coordenadas X,Y : (se alguma delas for 0 encerrará o sistema)");

                string[] valores = Console.ReadLine().Split(' ');
                double x = double.Parse(valores[0]);
                double y = double.Parse(valores[1]);

                if (x == 0 || y == 0)
                {
                    break;
                }
                else if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else { Console.WriteLine("quarto"); }
            }
        }

        private static void Exercicio3()
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;


            while (true)
            {

                int tipo = int.Parse(Console.ReadLine());

                if (tipo != 4)
                {
                    if (tipo == 1)
                    {
                        alcool += 1;
                    }
                    else if (tipo == 2)
                    {
                        gasolina += 1;
                    }
                    else if (tipo == 3)
                    {
                        diesel += 1;
                    }

                }
                else { break; }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }

        private static void Exercicio4()
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void Exercicio5()
        {
            int x = int.Parse(Console.ReadLine());

            int contadorDentroIntervalo = 0;
            int contadorForaIntervalo = 0;

            for (int i = 1; i <= x; i++)
            {
                int y = int.Parse(Console.ReadLine());

                if (y >= 10 && y <= 20)
                {
                    contadorDentroIntervalo++;
                }
                else { contadorForaIntervalo++; }
            }

            Console.WriteLine($"{contadorDentroIntervalo} in");
            Console.WriteLine($"{contadorForaIntervalo} out");
        }

        private static void Exercicio6()
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double num1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double num2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double num3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = ((num1 * 2) + (num2 * 3) + (num3 * 5)) / 10;

                Console.WriteLine(media);

            }


        }

        private static void Exercicio7()
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double num1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double num2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

                if (num2 == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = num1 / num2 ;

                    Console.WriteLine (divisao.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }

        private static void Exercicio8()
        {

        }

    }
}
