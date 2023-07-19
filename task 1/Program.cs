/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Write("Укажите колличество строк массива - ");
int m = int.Parse(Console.ReadLine());
Console.Write("Укажите колличество столбцов массива - ");
int n = int.Parse(Console.ReadLine());
double[,] Array = new double[m,n];

for (int i = 0; i < m; i++){
    for (int j=0; j < n; j++) 
{
    Array[i,j] = Math.Round((new Random().NextDouble())*10 , 2);
        Console.Write(Array[i,j]);
        if(i < Array.Length-1) Console.Write(" ");
}
    Console.WriteLine();
}



