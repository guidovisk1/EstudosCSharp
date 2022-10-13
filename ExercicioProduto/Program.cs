namespace ExercicioProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV",1000,5);

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}
