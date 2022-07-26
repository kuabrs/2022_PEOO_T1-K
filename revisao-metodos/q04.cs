using System; 

public class Program {
  public static double VolumeEsfera(double r){
    double z = (4*3.14*r*r*r)/3;
      return z;
  }
    
  public static void Main(string[] args) {
    Console.WriteLine("Escreva o raio:");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine(VolumeEsfera(x));
  
  }
}