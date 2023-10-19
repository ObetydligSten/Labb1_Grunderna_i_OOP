

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
}