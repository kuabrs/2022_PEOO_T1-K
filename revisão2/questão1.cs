using System; 

public class Program {

  public static void Main(string[] args) {
  Console.WriteLine("Digite dois valores inteiros");
  int A = int.Parse(Console.ReadLine());
  int B = int.Parse(Console.ReadLine());
  if (A > B) Console.WriteLine("Maior = "+A);
    else if(B > A) Console.WriteLine("Maior = "+B);
      else Console.WriteLine("Números iguais");

  }
}