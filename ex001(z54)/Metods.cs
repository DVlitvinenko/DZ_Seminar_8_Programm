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
  public static void Replasing(int[,] matrix)
  {
    int temp = 0;
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int n = 0; n < columns; n++)
    {
      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j + 1 < columns; j++)
        {

          if (matrix[i, j] < matrix[i, j + 1])
          {
            temp = matrix[i, j];
            matrix[i, j] = matrix[i, j + 1];
            matrix[i, j + 1] = temp;
          }
        }
      }
    }
  }
}

