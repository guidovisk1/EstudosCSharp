

using System.Globalization;

namespace ExercicioContaBancacria
{
    public class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string NomeTitularConta { get; set; }
        public double DepositoInicial { get; set; }

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

        public double Desposito(double deposito)
        {
            return DepositoInicial += deposito;
        }

        public double Saque(double saque)
        {
            double a = (DepositoInicial -= saque);
            return a - 10;
        }

        public override string ToString()
        {
            return NomeTitularConta
            
            +
            ", numero da conta "
            +  NumeroConta 
            + " seu saldo Total: $ "
            + DepositoInicial;
        }
    }
}
