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

  public static int MinSummInRows(int[,] matrix)
  {
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int summ = 0;
    int minRow = 0;
     int minInRowSumm = SummElemFirstRow(matrix);
    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        summ+= matrix[i,j];
      }
      if (minInRowSumm > summ) 
      {
      minRow = i;
      minInRowSumm = summ;
      }
      summ = 0;
    }
  return minRow;
}

public static int SummElemFirstRow(int[,] matrix)
{
    int columns = matrix.GetLength(1);
    int summ = 0;
      for (int j = 0; j < columns; j++)
      {
        summ+= matrix[0, j];
      }
  return summ;
}
}