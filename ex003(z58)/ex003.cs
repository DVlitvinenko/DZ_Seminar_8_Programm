using static Metods;
public class ex003
{
  public static void ex003prog()
  {
    int rows = Input("Введите количество строк: ");
    int columns = Input("Введите количество столбцов: ");
    int [,]matrixA = CreateMatrix(rows, columns);
    int [,]matrixB = CreateMatrix(rows, columns);
    Console.WriteLine();
    FillRandom(matrixA);
    Console.WriteLine(PrintAsText(matrixA));
    FillRandom(matrixB);
    Console.WriteLine(PrintAsText(matrixB));
    int [,] matrixResult = Proizv(matrixA, matrixB);
    Console.WriteLine($"Результирующая матрица будет: \n");
    Console.WriteLine(PrintAsText(matrixResult));
  }
}