namespace ExercicioContaBancacria
{
    class Program
    {
        static void Main(string[] args)
        {


            ContaBancaria cb;

            Console.WriteLine("Entre o número da conta");
            int numero = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Entre o nome da conta");
            string nome = Console.ReadLine();

            Console.WriteLine("Haverá deposito inicial?(s/n)");
            char pergunta = Convert.ToChar(Console.ReadLine());
            if (pergunta == 's')
            {
                Console.WriteLine("Entre o valor  do depósito inicial");
                double deposito = Convert.ToDouble(Console.ReadLine());
                cb = new ContaBancaria(numero,nome,deposito);
            }
            else
            {
                cb = new ContaBancaria(numero, nome);
            }

            Console.WriteLine("Dados da conta :");
            Console.WriteLine(cb);

            Console.WriteLine("Ente um valor para depósito");
            double novoDeposito = Convert.ToDouble(Console.ReadLine());
            cb.Desposito(novoDeposito);
            Console.WriteLine("Dados atualizados...");
            Console.WriteLine(cb);

            Console.WriteLine("Entre um valor para saque");
            double novoSaque = Convert.ToDouble(Console.ReadLine());
            cb.Saque(novoSaque);
            Console.WriteLine("Dados atualizados...");
            Console.WriteLine(cb);
            

        }

    }
}