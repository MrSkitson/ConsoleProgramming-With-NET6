// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter Length:");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width:");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Height:");
int height = Convert.ToInt32(Console.ReadLine());

var cube = new Cube(width, height, length);
var triangle = new Triangle() {Height = height, Length = length, Hypotenuese = 10 };
var triangle2 = new Triangle(10); 
var triangle3 = new Triangle(length,height, 10); 
var rectangle = new Rectangle() { Width = width, Length = length };

Console.WriteLine("Cube Area Is: " + cube.GetArea());
Console.WriteLine("Cube Volume Is: " + cube.GetVolume());

Console.WriteLine("Triangle Area Is: " + triangle.GetArea());
Console.WriteLine("Triangle2 Area Is: " + triangle2.GetArea());
Console.WriteLine("Triangle3 Area Is: " + triangle3.GetArea());

Console.WriteLine("Rectangle Area Is: " + rectangle.GetArea());