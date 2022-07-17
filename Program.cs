
namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minNumber = 1;
            int maxNumber = 10;
            int columns = random.Next(minNumber, maxNumber);
            int rows = random.Next(minNumber, maxNumber);
            int[,] numbers = new int[rows, columns];
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

            if (rows >= 1)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    sumSecondRow += numbers[1, j];
                }
            }

            if (columns >= 0)
            {
                for (int j = 0; j < numbers.GetLength(0); j++)
                {
                    multiplication *= numbers[j, 0];
                }
            }
            Console.WriteLine("Сумма чисел второй строки равна: " + sumSecondRow);
            Console.WriteLine("Произведение чисел первого столбца равно: " + multiplication);
        }
    }
}

