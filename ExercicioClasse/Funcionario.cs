

namespace ExercicioClasse
{
    public class Funcionario
    {
        public string Name { get; set; }
        public double salario { get; set; }


    public  double Imposto(double salario)
        {
            double imp = salario * 0.1;
            return imp;
        }
    }
}
