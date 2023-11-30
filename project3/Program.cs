// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
            // Найдите разницу между максимальным и минимальным элементов массива.

            double[] array = {3.4, 6.5, 1.2, 6.7};
            double maxItem = array.Max(), minItem = array.Min();
            Console.WriteLine($"Max {maxItem}");
            Console.WriteLine($"Min {minItem}");
            Console.WriteLine(Math.Abs(maxItem - minItem));