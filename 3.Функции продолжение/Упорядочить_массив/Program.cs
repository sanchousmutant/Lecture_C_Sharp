// упорядочить массив

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SlectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) // перебираем числа массива
                                               // чтобы во вложенном цикле не выйти за рамки данного массива,
                                               // во внешнем цикле перебираем все числа кроме последнего 
    {
        int minPosition = i; // задаем индекс(позицию) минимального числа
                             // (допустим в этом месте минимальное число в списке)

        for (int j = i + 1; j < array.Length; j++) // в этом цикле перебираем числа еще не рассмотренные
                                                   //(не проверенные)
        {
            if (array[j] < array[minPosition]) minPosition = j; // если текущий элемент меньше предыдущего,
                                                                // то индекс минимального элемента меняем
                                                                // на текущий. Иначе переходим к следующему 
        }

        int temporary = array[i]; //сортирока в буфер помещаем (запоминаем) текуший элемент, 
        array[i] = array[minPosition]; // вместо текущего помещаем минимальный из двух (текущий и следующий)
        array[minPosition] = temporary; // вместо бывшего минимального помещаем из буфера текущий
    }
}

PrintArray(arr);
SlectionSort(arr);
PrintArray(arr);
