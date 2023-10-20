

// RASMUS GLASELL JOHANSSON SUT23


namespace Labb1_Grunderna_i_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle radius1 = new Circle(3.141f, 5);
            Circle radius2 = new Circle(3.141f, 6);

            radius1.getArea();
            radius2.getArea();
        }
    }
    internal class Circle
    {
        float _pi = 3.141f;
        int _radius;
        public Circle(float pi, int radius)
        {
            _pi = pi;
            _radius = radius;
        }

        public void getArea()
        {
            float areaCircle = _radius * _radius * _pi;
            Console.WriteLine("Arean på cirkeln är : {0:F2}", areaCircle);
        }
    }
}