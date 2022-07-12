using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma frase:");
    string k = Console.ReadLine();
    int x = k.Length;
    int y = 0;
    while(y < x){
      k = k.Substring(1) + k.Substring(0, 1) ;
      Console.WriteLine(k);
      y++;
    }
  }
}
