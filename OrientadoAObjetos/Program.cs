
using OrientadoAObjetos.ExercicioUm;
using System.Globalization;

namespace OrientadoAObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o exercício :");
            Console.WriteLine("1 - Dimensoes do Retangulo");
            Console.WriteLine("2 - Verificação Plano Cartesiano");
            Console.WriteLine("3 - Posto de Gasolina");


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
                        //Exercicio2();
                        break;
                    case "3":
                        //Exercicio3();
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
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");

            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
