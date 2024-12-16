namespace Fibonacci_numbers__methods_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int first_number = 0, second_number = 1;
            Console.WriteLine("Input number:");
            int number = int.Parse(Console.ReadLine());
            number = find_Fibonacci_numbers(number);
            Console.Write($"{number}");
        }
        static int find_Fibonacci_numbers(int number)
        {
            int temt;
            if (number == 1)
                return 0;
            if (number == 2) 
                return 1; 
 
            return find_Fibonacci_numbers(number-1) + find_Fibonacci_numbers(number-2);
        }
    }
}
/*
 static int find_Fibonacci_numbers( int first_number, int second_number, int number)
        {
            int temt;
            if (number == 1)
                return 0;
            if (number == 2) 
                return 1; 
            for (int i = 2; i < number; i++)
            {
                temt = first_number + second_number;
                first_number = second_number;
                second_number = temt;
                
            }   
            return second_number;
        }
 */