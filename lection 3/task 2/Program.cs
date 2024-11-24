using static System.Math;

Console.Write("x = ");
string PositionStrX = Console.ReadLine();
Console.Write("y = ");
string PositionStrY = Console.ReadLine();
Console.Write("z = ");
string PositionStrZ = Console.ReadLine();

int PositionX = Convert.ToInt32(PositionStrX);
int PositionY = Convert.ToInt32(PositionStrY);
int PositionZ = Convert.ToInt32(PositionStrZ);

double length2D =  Sqrt(Pow(PositionX, 2) + Pow(PositionY, 2));
double length3D = Sqrt(Pow(length2D, 2)+Pow(PositionZ, 2));

Console.WriteLine($"length =  {Round(length3D, 3)}");