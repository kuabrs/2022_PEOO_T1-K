using System; 

public class Program {

  public static void Main(string[] args) {
  Console.WriteLine("Digite os coeficientes a, b, e c de uma equação do II grau");
    double A = double.Parse(Console.ReadLine());
    double B = double.Parse(Console.ReadLine());
    double C = double.Parse(Console.ReadLine());
    double delta = (B * B) - 4 * A * C;
     var R1 = -B + Math.Sqrt(delta) /(2 * A);
     var R2 = -B - Math.Sqrt(delta) /(2 * A);
    if (A == 0 || delta < 0) Console.WriteLine("Impossivel calcular");
     else {Console.WriteLine($"As raízes são {R1} e {R2}");
          }
  }
}