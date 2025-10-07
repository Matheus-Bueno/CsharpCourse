using System.Globalization;

namespace ClassesAtributosEtc.ExercicioDois
{
    internal class Funcionario
    {
        public string _nome;
        public double _salarioBruto;
        public double _imposto;



        public double SalarioLiquido()
        {
            return _salarioBruto - _imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            _salarioBruto += _salarioBruto + (_salarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return $"Funcionário: {_nome}, R$ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
