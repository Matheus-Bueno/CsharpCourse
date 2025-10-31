
using System.Globalization;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o exercício :");
            Console.WriteLine("1 - Media Alturas");
            Console.WriteLine("2 - Salario Funcionario");
            Console.WriteLine("3 - Média Aluno");
            Console.WriteLine("4 - Banco");


            while (true)
            {
                Console.Write("\nOpção: ");
                string opcao = Console.ReadLine() ?? "0";

                switch (opcao)
                {
                    case "1":
                        Exercicio1();
                        break;
                    case "2":
                        //Exercicio2();
                        break;
                    case "3":
                        //Exercicio3();
                        break;
                    case "4":
                        //Exercicio4();
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
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++) { 
            
                    sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
