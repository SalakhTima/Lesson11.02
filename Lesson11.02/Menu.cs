class MenuTask
{
    private static int[] arr = new int[6];
    public static void Menu(ref int code)
    {
        Console.WriteLine("1 - Заполнить массив.");
        Console.WriteLine("2 - Вывести массив.");
        Console.WriteLine("3 - Cортировка выбором.");
        Console.WriteLine("4 - Пирамидальная сортировка.");
        Console.WriteLine("5 - Сортировка пузырьком.");
        Console.WriteLine("6 - Шейкер сортировка.");
        Console.WriteLine("7 - Выход.");
        Console.WriteLine();

        Console.Write("Введите код операции: ");
        code = int.Parse(Console.ReadLine());
        Console.WriteLine();
        switch (code)
        {
            case 1:
                CreateArray(ref arr);
                break;
            case 2:
                Print(arr);
                break;
            case 3:
                SortChoice(ref arr);
                break;
            case 4:
                // HeapSort(ref arr);
                Console.WriteLine("Временно недоступно:");
                Console.WriteLine();
                break;
            case 5:
                BubbleSort(ref arr);
                break;
            case 6:
                ShakerSort(ref arr);
                Console.WriteLine();
                break;
            case 7:
                Console.WriteLine("Выход из программы.");
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("Ошибка. Неизвестный код операции.");
                Console.WriteLine();
                break;
        }
    }
    private static void CreateArray(ref int[] arr)
    {
        Console.WriteLine($"Заполните массив {arr.Length} элементами:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Введите элемент на {i} позицию:\t");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Заполнение окончено.");
        Console.WriteLine();
    }
    private static void Print(int[] arr)
    {
        Console.WriteLine("Вывод массива:");
        foreach (int e in arr)
            Console.WriteLine(e);
        Console.WriteLine();
    }
    private static void SortChoice(ref int[] arr)
    {
        int indexOfMin;
        for (int i = 0; i < arr.Length; i++)
        {
            indexOfMin = i;
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[j] < arr[indexOfMin])
                {
                    indexOfMin = j;
                }
            }
            if (arr[indexOfMin] == arr[i])
                continue;

            int temp = arr[i];
            arr[i] = arr[indexOfMin];
            arr[indexOfMin] = temp;
        }
        Console.WriteLine("Сортировка завершена.");
        Console.WriteLine();
    }
    private static void HeapSort(ref int[] arr)
    {
        // не сделал
    }
    private static void BubbleSort(ref int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int k = 0; k < arr.Length - 1 - i; k++)
            {
                if (arr[k] > arr[k + 1])
                {
                    int replacingNum = arr[k];
                    arr[k] = arr[k + 1];
                    arr[k + 1] = replacingNum;
                }
            }
        }
        Console.WriteLine("Сортировка завершена.");
        Console.WriteLine();
    }
    static void Swap(ref int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    static void ShakerSort(ref int[] arr)
    {
        int left = 0,
        right = arr.Length - 1;
        while (left < right)
        {
            for (int i = left; i < right; i++)
            {
                if (arr[i] > arr[i + 1])
                    Swap(ref arr, i, i + 1);
            }
            right--;
            for (int i = right; i > left; i--)
            {
                if (arr[i - 1] > arr[i])
                    Swap(ref arr, i - 1, i);
            }
            left++;
        }
        Console.WriteLine("Сортировка завершена.");
        Console.WriteLine();
    }
}