using ConsoleApp1;

char name = 'A';

List<PolePoint> points =
[
        new PolePoint(0, 4),
        new PolePoint(0, 9),
        new PolePoint(1, 2),
        new PolePoint(1, 11),
        new PolePoint(3, 2),
        new PolePoint(3, 11),
        new PolePoint(9, 2),
        new PolePoint(9, 11),
];

Dictionary<string, string> names = new();
foreach (PolePoint A in points)
    names.Add(A.ToString(), (name++).ToString());

foreach (var A in points)
{

    foreach(var B in points)
    {

        var C = A + B;
        if (C.X != -1) Console.WriteLine($"{names[A.ToString()]} {A} + {names[B.ToString()]} {B} = {names[C.ToString()]} {C}");
        else Console.WriteLine($"{names[A.ToString()]} {A} + {names[B.ToString()]} {B} = O");

    }

}