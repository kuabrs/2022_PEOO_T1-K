using System; 

public class Program {
  public static double AreaCirculo(double raio){
    double z = 3.14 * raio * raio;
      return z;
  }
    
  public static void Main(string[] args) {
    Console.WriteLine("Escreva o raio:");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine(AreaCirculo(x));
  
  }
}