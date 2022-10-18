using System;

namespace VetorEstudante
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.WriteLine("Quanto quartos serão alugados");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"Número do quarto {i}");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = Convert.ToInt16(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);

            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }


            }
        }
    }
}