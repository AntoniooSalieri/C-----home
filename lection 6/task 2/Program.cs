Console.WriteLine ("y1 = a1 * x + b1, y2 = a2 * x + b2");

Console.Write("a1 = ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("a2 = ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());
/*
int a1 = 1, b1 = 1,
    a2 = 2, b2 = 1;


/*
y1 = a1 * x + b1
y2 = a2 * x + b2

a1 * x + b1 * x = a2 * x + b2
*/
if (a1 == a2) Console.WriteLine("no answer");
else{
    int aDif = a1 - a2;
    int bDif = b2 - b1;

    int x = bDif / aDif;

    Console.WriteLine($"координаты пересечения: ( {x} , {a1*x + b1} )");
}
