// See https://aka.ms/new-console-template for more information
using Lab2.Models;


Line line = new Line();
Console.WriteLine($"X - {line.Point1.GetX()}, Y - {line.Point1.GetY()}");

Point point1 = new Point(1, 5);
Point point2 = new Point(2, 8);
Line line1 = new Line(point1, point2);
Line line2 = new Line(line);
Line line3 = new Line(ref line);
