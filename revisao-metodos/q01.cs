using System; 

public class Program {
  public static double Menor(double x, double y){
      return Math.Min(x,y);
  }
    
  public static void Main(string[] args) {
    Console.WriteLine("Escreva dois números:");
    string s = Console.ReadLine();
    string[] v = s.Split();
    double x = double.Parse(v[0]);
    double y = double.Parse(v[1]);
    Console.WriteLine(Menor(x,y));
  
  }
}