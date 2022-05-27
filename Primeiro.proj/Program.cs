using Primeiro.proj;
using System;
using System.Globalization;
Triangulo x, y;
x = new Triangulo();
y = new Triangulo();
Console.WriteLine("As Medidas do triangulo x: ");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("As medidas do triangula y: ");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = x.Area();
Console.WriteLine(area);
double area2 = y.Area();
Console.WriteLine(area2);
if (area > area2)
{
    Console.WriteLine("A area do tiangulo X e maior.");
}
else 
{
    Console.WriteLine("A area do trinagulo y e maior.");
}
