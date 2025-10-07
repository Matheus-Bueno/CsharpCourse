using System.Globalization;

namespace ClassesAtributosEtc.ExercicioTres
{
    internal class Aluno
    {
        public string Nome;
        public double[] Notas;


        public Aluno(string nome, double[] notas)
        {

            if (notas == null || notas.Length != 3) { throw new ArgumentException("é necessario informar exatamnete três notas."); }

            Nome = nome;
            Notas = notas;
        }


        public double mediaFinal()
        {
            double media = Notas[0] + Notas[1] + Notas[2];

            return media;
        }


        public override string ToString()
        {
            double calculoFinal = mediaFinal();

            if (calculoFinal >= 60)
            {
                return "Nota Final =" + calculoFinal.ToString("F2", CultureInfo.InvariantCulture) + "\n"
                     + "APROVADO";
            }
            else
            {

                return "Nota Final =" + calculoFinal.ToString("F2", CultureInfo.InvariantCulture) + "\n"
                     + "REPROVADO \n"
                     + "FALTARAM " + (60 - calculoFinal) + " PONTOS";
            }
        }
    }
}
