using ClassesAtributosEtc.ExercicioDois;
using ClassesAtributosEtc.ExercicioQuatro;
using ClassesAtributosEtc.ExercicioTres;
using ClassesAtributosEtc.ExercicoUm;
using System.Globalization;

namespace ClassesAtributosEtc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o exercício :");
            Console.WriteLine("1 - Dimensoes do Retangulo");
            Console.WriteLine("2 - Salario Funcionario");
            Console.WriteLine("3 - Média Aluno");
            Console.WriteLine("4 - Banco");


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

        private static void Exercicio2()
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("Entre a Informaçoes do Funcionario ");
            Console.WriteLine("Nome : ");
            func._nome = Console.ReadLine();

            Console.WriteLine("Salario: ");
            func._salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Imposto: ");
            func._imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            Console.WriteLine(func.ToString());


            Console.WriteLine("Deseja aumentar o salário em qual porcentagem? ");

            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);

            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(func.ToString());
        }

        private static void Exercicio3()
        {

            Console.WriteLine("Entre a Informaçoes do Aluno ");

            Console.WriteLine("Nome do Aluno: ");
            string nomeAluno = Console.ReadLine() ?? "";

            double[] notas = new double[3];
            Console.WriteLine("Digite as três notas do aluno:");

            notas[0] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notas[1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notas[2] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Aluno alu = new Aluno(nomeAluno, notas);

            Console.WriteLine(alu.ToString());
        }

        private static void Exercicio4()
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine() ?? "");

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }


            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine() ?? "", CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }

    }
}
