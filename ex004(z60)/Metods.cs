public class Metods
{
  public static int[,,] CreateCube(int sizeX, int sizeY, int sizeZ)
  {
    return new int[sizeX, sizeY, sizeZ];
  }
  public static string Printing(int[,,] cube)
  {
    int x = cube.GetLength(0);
    int y = cube.GetLength(1);
    int z = cube.GetLength(2);
    string result = String.Empty;
    for (int i = 0; i < x; i++)
    {
      for (int j = 0; j < y; j++)
      {
        for (int k = 0; k < z; k++)
        {
          result += $"{cube[i, j, k]}({i},{j},{k}) ";
        }
        result += "\n";
      }
      result += "\n";
    }
    return result;
  }
  public static int Input(string msg)
  {
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
  }
  public static void FillRandom(int[,,] cube, int minValue = 1, int maxValue = 10)
  {
    int x = cube.GetLength(0);
    int y = cube.GetLength(1);
    int z = cube.GetLength(2);
    for (int i = 0; i < x; i++)
    {
      for (int j = 0; j < y; j++)
      {
        for (int k = 0; k < z; k++)
        {
          cube[i, j, k] = new Random().Next(minValue, maxValue);
        }
      }
    }
  }
}