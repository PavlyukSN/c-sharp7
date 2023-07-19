/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Write("Укажите колличество строк массива - ");
int m = int.Parse(Console.ReadLine());
Console.Write("Укажите колличество столбцов массива - ");
int n = int.Parse(Console.ReadLine());
int[,] Array = new int[m,n];

    for (int i = 0; i < m; i++){
        for (int j=0; j < n; j++) {
            Array[i,j] = new Random().Next(0,10);
            Console.Write(Array[i,j]);
            if(i < Array.Length-1) Console.Write(" ");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < m; i++){
        double mean = 0;
        for (int j=0; j < n; j++) {
            mean = (mean + Array[j,i]);
        }
        Console.Write($"Среднее арифметическое {i+1} столбца: {mean/Array.GetLength(0)}");
        Console.WriteLine();
    }
    