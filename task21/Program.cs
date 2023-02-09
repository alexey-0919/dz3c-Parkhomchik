Console.WriteLine("Input coordinate x1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input coordinate y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input coordinate z1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input coordinate x2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input coordinate y2");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input coordinate z2");
int z2 = Convert.ToInt32(Console.ReadLine());

int A = x1 - x2;
int B = y1 - y2;
int C = z1 - z2;

double distance = Math.Sqrt((A * A) + (B * B) + (C + C));
distance = Math.Round(distance, 2); 
Console.WriteLine($"Расстояние = " + distance);