
namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numb = new Random();
            int column = numb.Next(1, 10);
            int rows = numb.Next(1, 10);
            int[,] numbers = new int[rows, column];
            int sum = 0;
            int multiplication = 0;
            int minValue = 0;
            int maxValue = 50;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = numb.Next(minValue, maxValue);
                    Console.Write(numbers[i, j] + " ");
                    if (i == 1)
                    {
                        sum += numbers[i, j];
                    }
                    if (j == 0)
                    {
                        multiplication *= numbers[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма чисел второй строки равна: " + sum);
            Console.WriteLine("Произведение чисел первого столбца равно: " + multiplication);
        }
    }
}