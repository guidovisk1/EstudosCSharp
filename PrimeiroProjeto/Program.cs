using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos sergio, damisa;

            sergio = new Alunos();
            damisa = new Alunos();

          Console.WriteLine("Diga o nome do sergio");
            sergio.name = Console.ReadLine();
            sergio.isCorno = true;
            sergio.age = 18;
            

            Console.WriteLine($"O {sergio.name} é um corno : {sergio.isCorno} e tambem, é inteligente? : {sergio.isIntelligent}");

        }
    }
}
