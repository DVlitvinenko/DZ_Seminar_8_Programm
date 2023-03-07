// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с
//  наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
//  выдаёт номер строки с наименьшей суммой элементов: 
//  1 строка
using static Metods;
public class ex002
{
  public static void ex002prog()
  {
    int rows = Input("Введите количество строк: ");
    int columns = Input("Введите количество столбцов: ");
    int [,]matrix = CreateMatrix(rows, columns);
    FillRandom(matrix);
    Console.WriteLine();
    Console.WriteLine(PrintAsText(matrix));
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов наименьшая в строке {MinSummInRows(matrix)+1}");
  }
}