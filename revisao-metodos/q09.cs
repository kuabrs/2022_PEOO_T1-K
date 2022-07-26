using System; 

public class Program {
public static int Soma(int inicio, int fim){
  int z = 0;
  while(inicio<=fim){
    z+= inicio;
    inicio++;
  }
 return z;
  }
    
  public static void Main(string[] args) {
    Console.WriteLine("Escreva dois numeros:");
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    Console.WriteLine(Soma(x,y));
  
  }
}