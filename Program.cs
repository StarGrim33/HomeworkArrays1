
namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int columns = random.Next(1, 10);
            int rows = random.Next(1, 10);
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

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {

                    if (i == 1)
                    {
                        sumSecondRow += numbers[i, j];
                    }

                    if (j == 0)
                    {
                        multiplication *= numbers[i, j];
                    }
                }
            }
            Console.WriteLine("Сумма чисел второй строки равна: " + sumSecondRow);
            Console.WriteLine("Произведение чисел первого столбца равно: " + multiplication);
        }
    }
}