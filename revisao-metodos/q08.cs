using System; 

public class Program {
public static int MenorInteiro(double x){
  int z = Convert.ToInt32(x);
  //int z = (int) x;
  if (z>=x) return z;
  else return z+1;
  }
    
  public static void Main(string[] args) {
    Console.WriteLine("Escreva um numero:");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine(MenorInteiro(x));
  
  }
}