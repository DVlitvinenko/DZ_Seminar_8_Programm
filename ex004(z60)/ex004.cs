using static Metods;
public class Ex004
{
  public static void Ex004prog()
  {
    int sizeX = Input("Введите размер по X: ");
    int sizeY = Input("Введите размер по Y: ");
    int sizeZ = Input("Введите размер по Z: ");
    int[,,] cube = CreateCube(sizeX, sizeY, sizeZ);
    FillRandom(cube);
    Console.WriteLine(Printing(cube));
  }
}