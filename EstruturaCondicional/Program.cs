
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
            throw new NotImplementedException();
        }

        private static void Exercicio3()
        {
            throw new NotImplementedException();
        }

        private static void Exercicio4()
        {
            throw new NotImplementedException();
        }

        private static void Exercicio5()
        {
            throw new NotImplementedException();
        }

        private static void Exercicio6()
        {
            throw new NotImplementedException();
        }

        private static void Exercicio7()
        {
            throw new NotImplementedException();
        }

        private static void Exercicio8()
        {
            throw new NotImplementedException();
        }
    }
}
