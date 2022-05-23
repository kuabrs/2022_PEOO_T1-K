using System;

public class Program {

  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    double b = 3.14159;
    double c = a*a*a;
    double d = (4/3.0);
    Console.WriteLine($"VOLUME = {c*b*d:0.000}");
  }
}
