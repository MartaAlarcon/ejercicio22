using System;
namespace Activitat
{
    public class ej22
    {
        public static void Main()
        {
            const string MsgChoose = "1 - área cuadrado, 2 - área rectángulo, 3 - área triángulo";
            const string MsgNumberOne = "Introduce el primer dato";
            const string MsgNumberTwo = "Introduce el segundo dato";
            
            int numberOne, numberTwo, select;
            Console.WriteLine(MsgChoose);
            select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.WriteLine(MsgNumberOne);
                    numberOne = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(MsgNumberTwo);
                    numberTwo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(CalcularRectanguloCuadrado(numberOne, numberTwo));
                    break;
                case 2:
                    Console.WriteLine(MsgNumberOne);
                    numberOne = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(MsgNumberTwo);
                    numberTwo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(CalcularRectanguloCuadrado(numberOne, numberTwo));
                    break;
                case 3:
                    Console.WriteLine(MsgNumberOne);
                    numberOne = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(MsgNumberTwo);
                    numberTwo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(CalcularTriangulo(numberOne, numberTwo));
                    break;
                    
            }
        }
        static int CalcularRectanguloCuadrado (int numberOne, int numberTwo) 
        {
            int result;
            result = numberOne * numberTwo;
            return result;
        }
        static int CalcularTriangulo(int numberOne, int numberTwo)
        {
            const int two = 2;
            int result;
            result = numberOne * numberTwo / two;
            return result;
        }
    }
}