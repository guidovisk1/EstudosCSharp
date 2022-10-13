using System;

namespace ExercicioRetangulo
{
    public class Retangulo
    {
        public double width;
        public double height;


        public double Area()
        {
            return width * height;
        }

        public double Perimetro()
        {
            return 2 * (width + height);
        }

        
    }
}
