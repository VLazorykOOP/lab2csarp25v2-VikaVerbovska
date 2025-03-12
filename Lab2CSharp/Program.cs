using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Оберіть завдання:");
            Console.WriteLine("1. Замінити елементи, що потрапляють в інтервал, нулем");
            Console.WriteLine("2. Замінити всі максимальні елементи нулями (одновимірний масив)");
            Console.WriteLine("3. Сума елементів побічної діагоналі (двовимірний масив)");
            Console.WriteLine("4. Кількість додатних елементів у східчастому масиві");
            Console.WriteLine("0. Вийти");

            Console.Write("Ваш вибір: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                    break;
            }
        }
    }

    static void Task1()
    {
        Console.WriteLine("Оберіть тип масиву: 1 - Одновимірний, 2 - Двовимірний");
        int type = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            Console.Write("Розмір масиву: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Введіть елементи:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Інтервал від: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("до: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= a && arr[i] <= b)
                {
                    arr[i] = 0;
                }
            }

            Console.WriteLine("Результат:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        else if (type == 2)
        {
            Console.Write("Рядків: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Стовпців: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] arr = new int[rows, cols];

            Console.WriteLine("Введіть елементи:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Інтервал від: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("до: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (arr[i, j] >= a && arr[i, j] <= b)
                    {
                        arr[i, j] = 0;
                    }
                }
            }

            Console.WriteLine("Результат:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    static void Task2()
    {
        Console.Write("Введіть розмір масиву: ");
        int n = int.Parse(Console.ReadLine());
        double[] arr = new double[n];

        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = double.Parse(Console.ReadLine());
        }

        double max = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (arr[i] == max)
            {
                arr[i] = 0;
            }
        }

        Console.WriteLine("Результат:");
        foreach (double num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Task3()
    {
        Console.Write("Введіть розмір матриці (n): ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += matrix[i, n - 1 - i];
        }

        Console.WriteLine("Сума елементів побічної діагоналі: " + sum);
    }

    static void Task4()
    {
        Console.Write("Введіть кількість рядків (n): ");
        int n = int.Parse(Console.ReadLine());
        int[][] jaggedArray = new int[n][];
        int[] positiveCounts = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть кількість елементів у рядку {i + 1}: ");
            int m = int.Parse(Console.ReadLine());
            jaggedArray[i] = new int[m];

            Console.WriteLine("Введіть елементи:");
            for (int j = 0; j < m; j++)
            {
                jaggedArray[i][j] = int.Parse(Console.ReadLine());
                if (jaggedArray[i][j] > 0)
                {
                    positiveCounts[i]++;
                }
            }
        }

        Console.WriteLine("Кількість додатних елементів у кожному рядку:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Рядок {i + 1}: {positiveCounts[i]}");
        }
    }
}
