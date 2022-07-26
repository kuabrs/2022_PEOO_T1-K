using System; 

public class Program {
public static void AntecessorSucessor (int x, out int antecessor, out int sucessor){
    antecessor = x-1;
    sucessor = x+1;
  }
    
  public static void Main(string[] args) {
    int a = int.Parse(Console.ReadLine());
    int x,y;
    Program.AntecessorSucessor(a, out x, out y);
    Console.WriteLine($"sucessor: {y} antecessor: {x}");
  
  }
}