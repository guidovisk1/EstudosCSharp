namespace ExercicioContaBancacria
{
    public class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string NomeTitularConta { get; set; }
        public double DepositoInicial { get; private set; }



        public ContaBancaria(int numeroConta, string nomeTitularConta)
        {
            NumeroConta = numeroConta;
            NomeTitularConta = nomeTitularConta;
        }

        public ContaBancaria(int numeroConta, string nomeTitularConta, double depositoInicial)
        {
            NumeroConta = numeroConta;
            NomeTitularConta = nomeTitularConta;
            DepositoInicial = depositoInicial;
        }

        public void Desposito(double quantia)
        {
            DepositoInicial += quantia;
        }

        public void Saque(double quantia)
        {
            DepositoInicial -= quantia + 5;

        }

        public override string ToString()
        {
            return "Nome titular da conta: "
            +
              NomeTitularConta
            +
            ", numero da conta: "
            + NumeroConta
            + " seu saldo Total: $ "
            + DepositoInicial;
        }
    }
}
