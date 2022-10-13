namespace ExercicioClasse
{
    class Program 
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1,funcionario2;
            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();


            Console.WriteLine("Digite o nome do primeiro funcionário");
            funcionario1.Name = Console.ReadLine();
            Console.WriteLine("Digite o salario do primeiro funcionario");
            funcionario1.salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Digite o nome do segundo funcionário");
            funcionario2.Name = Console.ReadLine();
            Console.WriteLine("Digite o salario do segundo funcionario");
            funcionario2.salario = Convert.ToDouble(Console.ReadLine());

            double media = (funcionario1.salario + funcionario2.salario) / 2;
            Console.WriteLine($"A media do salario dos funcionario = {media}");

            double imposto1 = funcionario1.Imposto(funcionario1.salario);
            Console.WriteLine($"O valor do imposto(10%), será de {imposto1}");

        }
    }
}