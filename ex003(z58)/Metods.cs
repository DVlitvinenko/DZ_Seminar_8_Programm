public class Metods
{
  public static int Input(string msg)
  {
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
  }

  public static int[,] CreateMatrix(int rows, int columns)
  {
    return new int[rows, columns];
  }

  public static void FillRandom(int[,] matrix, int min = 1, int max = 10)
  {
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        matrix[i, j] = new Random().Next(min, max);
      }
    }
  }

  public static string PrintAsText(int[,] matrix)
  {
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    string result = String.Empty;
    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        result += $"{matrix[i, j]} ";
      }
      result += "\n";
    }
    return result;
  }

  public static int[,] Proizv(int[,] matrixA, int[,] matrixB)
  {
    int rows = matrixA.GetLength(0);
    int columns = matrixA.GetLength(1);
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        result[i, j] = PromegPeremnog(matrixA, matrixB, j, i);
      }
    }
    return result;
  }

  public static int PromegPeremnog(int[,] matrix1, int[,] matrix2, int index, int index2)
  {
    int columns = matrix2.GetLength(1);
    int result = 0;
    for (int j = 0; j < columns; j++)
    {
      result += (matrix1[index2, j] * matrix2[j, index]);
    }
    return result;
  }
}