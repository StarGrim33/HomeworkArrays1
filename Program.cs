
namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int column = random.Next(1, 10);
            int rows = random.Next(1, 10);
            int[,] numbers = new int[rows, column];
            int sumSecondRow = 0;
            int multiplication = 1;
            int minValue = 0;
            int maxValue = 50;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(minValue, maxValue);
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                while (i == 1)
                {
                    for (int j = 0; j < numbers.GetLength(1); j++)
                    {
                        sumSecondRow += numbers[i, j];
                    }
                    break;
                }
            }
            Console.WriteLine("Сумма чисел второй строки равна: " + sumSecondRow);

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    while (j == 0)
                    {
                        multiplication *= numbers[i, j];
                        break;
                    }
                }
            }
            Console.WriteLine("Произведение чисел первого столбца равно: " + multiplication);
        }
    }
}