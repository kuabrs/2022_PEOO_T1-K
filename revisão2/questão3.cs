using System; 

public class Program {

  public static void Main(string[] args) {
  Console.WriteLine("Digite quatro valores inteiros");
  int A = int.Parse(Console.ReadLine());
  int B = int.Parse(Console.ReadLine());
  int C = int.Parse(Console.ReadLine());
  int D = int.Parse(Console.ReadLine());
  int pares = 0;
  int impares = 0;
  if(A % 2 == 0) pares+= A;
    else impares += A;
  if(B % 2 == 0) pares+= B;
    else impares += B;
  if(C % 2 == 0) pares+= C;
    else impares += C;
  if(D % 2 == 0) pares+= D;
    else impares += D;
  Console.WriteLine("Soma dos pares = "+ pares);
  Console.WriteLine("Soma dos ímpares = "+ impares);

  } 
}