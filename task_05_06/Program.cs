namespace task_05_06
{
    internal class Program
    { /*Осуществить генерация двумерного [10*5] массива по следующему правилу:
        • 1 столбец содержит нули
        • 2 столбце содержит числа кратные 2
        • 3 столбец содержит числа кратные 3
        • 4 столбец содержит числа кратные 4
        • 5 столбец содержит числа кратные 5
        вывод обновленного массива*/
        static void Main(string[] args)
        {
            int[,] array = new int[10, 5];

            for (int i = 0; i < 10; i++)
            {
                array[i, 0] = 0;
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    array[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] array_2 = new int[5, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array_2[j, i] = array[i, j];
                }
            }

            Console.WriteLine("----------------------------------------");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(array_2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
