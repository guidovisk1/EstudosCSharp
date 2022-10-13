using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha");
            int senha = Convert.ToInt32(Console.ReadLine());

            while(senha != 2002)
            {
                Console.WriteLine("Senha incorreta");
                senha = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Senha correta");
        }
    }
}