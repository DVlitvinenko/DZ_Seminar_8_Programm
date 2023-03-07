// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
using static Metods;
public class ex001
{
  public static void ex001prog()
  {
    int rows = Input("Введите количество строк: ");
    int columns = Input("Введите количество столбцов: ");
    int[,] matrix = CreateMatrix(rows, columns);
    FillRandom(matrix);
    Console.WriteLine();
    Console.WriteLine(PrintAsText(matrix));
    Replasing(matrix);
    Console.WriteLine();
    Console.WriteLine(PrintAsText(matrix));
  }
}