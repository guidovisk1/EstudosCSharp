
namespace ExercicioRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x;

            Console.WriteLine("Entre a largura e a altura do retângulo");
            x = new Retangulo();
          

            x.width = Convert.ToInt32(Console.ReadLine());
            x.height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A área vale {x.Area()} e o perimetro {x.Perimetro()}");

        }
    }
}