using System;

public class Program {

  public static void Main(string[] args) {
    string s = Console.ReadLine();
    string[] v = s.Split();
    double a = double.Parse(v[0]);
    double b = double.Parse(v[1]);
    double c = double.Parse(v[2]);
    double d = double.Parse(v[3]);
    double e = a+b+c+d-3;
    Console.WriteLine(e);
  }
}
