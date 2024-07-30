using System.Reflection.Metadata.Ecma335;

namespace MethodConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 65;
            int secondNumber = 42;
            int AddResault = Add(firstNumber, secondNumber);
            Console.WriteLine("Add Resault:" + AddResault);
            float SubtractResault = Subtract(firstNumber, secondNumber);
            Console.WriteLine("Subtract Resault:"+ SubtractResault);
        }
        static int Add(int firstNumber, int secondNumber)
        {
            int resault = 0;
            resault = firstNumber + secondNumber;
            return resault;

        }
        static float Subtract(float firstNumber, float secondNumber)
        {
            return firstNumber - secondNumber;
        }
        

    }
}
