using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma frase:");
    string treze = Console.ReadLine();
    int x = 1;
    int y = treze.Length;
    while(y+1 > x){
      Console.WriteLine(x+" - "+treze);
      x++;
    }
  }
}
