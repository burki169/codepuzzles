using Models;

var r1 = new LoveRectangle(1,1,3,4);
var r2 = new LoveRectangle(2,2,1,1);
var p = r1.Intersect(r2);
Console.WriteLine($"{p.BottomLeft} - {p.BottomRight}");
Console.WriteLine($"{p.TopLeft} - {p.TopRight}");
