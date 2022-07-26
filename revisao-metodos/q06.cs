using System; 

public class Program {
  public static double Frete(double massa, double distancia){
    double z = (distancia*massa)/100;
      return z;
  }
    
  public static void Main(string[] args) {
    Console.WriteLine("Escreva a massa e a distancia respectivamente:");
    string s = Console.ReadLine();
    string[] v = s.Split();
    double x = double.Parse(v[0]);
    double y = double.Parse(v[1]);
    Console.WriteLine(Frete(x,y));
  
  }
}