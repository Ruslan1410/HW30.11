 // Задача 2: Задайте массив на 10 целых чисел. Напишите программу,
            // которая определяет количество чётных чисел в массиве.

            // int[] array = Enumerable.Range(1, 10).Count(x => x % 2 == 0).ToArray();

            int[] array =  {1, 2, 3, 4, 5, 6, 7, 8, 9};
            int countOfEvenItems = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 == 0)
                    countOfEvenItems++;
           
            Console.WriteLine(countOfEvenItems);