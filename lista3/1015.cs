using System;

public class Program {

  public static void Main(string[] args) {
    var s = Console.ReadLine().Split();
    var T = Console.ReadLine().Split();
    double x1 = double.Parse(s[0]);
    double y1 = double.Parse(s[1]);
    double x2 = double.Parse(T[0]);
    double y2 = double.Parse(T[1]);
    var u = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
    Console.WriteLine($"{u:0.0000}");
  }
}
