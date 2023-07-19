/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет
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

Console.Write("Искать в строке (считая от 0) - ");
int searchM = int.Parse(Console.ReadLine());
Console.Write("Искать в столбце (считая от 0) - ");
int searchN = int.Parse(Console.ReadLine());
Console.Write($"{searchM};{searchN} -> ");
if (searchM >= Array.GetLength(0) || searchN >= Array.GetLength(1)) {
    Console.Write("Такого числа в массиве нет.");
    }
    
else{
    for (int i = searchM; i <= searchM; i++){
        for (int j = searchN; j <= searchN; j++) 
        {
        Console.Write(Array[i,j]);
    }
}
}