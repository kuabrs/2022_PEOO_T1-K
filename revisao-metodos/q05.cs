using System; 

public class Program {
  public static double VolumeLitros(double h, double l, double p){
    double z = h*l*p;
      return z;
  }
    
  public static void Main(string[] args) {
    Console.WriteLine("Escreva a altura, a largura e a profundidade respectivamente:");
    string s = Console.ReadLine();
    string[] v = s.Split();
    double x = double.Parse(v[0]);
    double y = double.Parse(v[1]);
    double a = double.Parse(v[2]);
    Console.WriteLine(VolumeLitros(x,y,a));
  
  }
}