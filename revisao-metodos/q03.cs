using System; 

public class Program {
  public static double Diagonal(double b, double h){
    double z = Math.Sqrt((b*b)+(h*h));
      return z;
  }
    
  public static void Main(string[] args) {
    Console.WriteLine("Escreva a base e altura respectivamente:");
    string s = Console.ReadLine();
    string[] v = s.Split();
    double x = double.Parse(v[0]);
    double y = double.Parse(v[1]);
    Console.WriteLine(Diagonal(x,y));
  
  }
}