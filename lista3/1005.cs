using System;

public class Program {

  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = 3.5*a + 7.5*b;
    double d = c/11;
    Console.WriteLine($"MEDIA = {d:0.00000}");
  }
}
