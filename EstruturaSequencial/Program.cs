

using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace EstruturaSequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o exercício :");
            Console.WriteLine("1 - Soma de Dois números");
            Console.WriteLine("2 - Área de um circulo");
            Console.WriteLine("3 - Diferença entre duas Multiplicações");
            Console.WriteLine("4 - Calculo de Salário");
            Console.WriteLine("5 - Registradora");
            Console.WriteLine("6 - Calculo de Áreas");

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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;

            Console.WriteLine($"SOMA = {soma}");
        }

        private static void Exercicio2()
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * (raio * raio);

            Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }

        private static void Exercicio3()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b) - (c * d);
            Console.WriteLine($"Diferença = {diferenca}");
        }

        private static void Exercicio4()
        {
            int numFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calculo = valorHora * horasTrabalhadas;

            Console.WriteLine($"NUMBER = {numFuncionario}");
            Console.WriteLine($"SALARY = U$ {calculo.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        private static void Exercicio5()
        {
            //ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.

            string[] valores = Console.ReadLine().Split(' ');
            int codPecaUm = int.Parse(valores[0]);
            int qtdPecaUm = int.Parse(valores[1]);
            double valorUnPecaUm = double.Parse(valores[2], CultureInfo.InvariantCulture);


            valores = Console.ReadLine().Split(' ');
            int codPecaDois = int.Parse(valores[0]);
            int qtdPecaDois = int.Parse(valores[1]);
            double valorUnPecaDois = double.Parse(valores[2], CultureInfo.InvariantCulture);


            double somaPecaUm = qtdPecaUm * valorUnPecaUm;

            double somaPecaDois = qtdPecaDois * valorUnPecaDois;

            double valorFinal = somaPecaUm + somaPecaDois;

            Console.WriteLine($"VALOR A PAGAR: R$ {valorFinal.ToString("F2", CultureInfo.InvariantCulture)}");

        }


        private static void Exercicio6()
        {
            // exemplo de entrada 3.0 4.0 5.2

            string[] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double triangulo = A * C / 2.0;
            double circulo = 3.14159 * C * C;
            double trapezio = (A + B) / 2.0 * C;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
