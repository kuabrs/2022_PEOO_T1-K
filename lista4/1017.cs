using System; 

public class Program {

  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double km = a*b;
    double x = km/12;
    Console.WriteLine(string.Format("{0:0.000}", x));
  }
}
