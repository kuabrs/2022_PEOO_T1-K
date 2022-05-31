using System; 

public class Program {

  public static void Main(string[] args) {
  Console.WriteLine("Digite três valores inteiros");
  int A = int.Parse(Console.ReadLine());
  int B = int.Parse(Console.ReadLine());
  int C = int.Parse(Console.ReadLine());
  int maior = 0;
  int menor = 0;
  if (A > C && A > B) maior += A;
  if (B > C && B > A) maior += B;
  if (C > A && C > B) maior += C;
  if (A < C && A < B) menor += A;
  if (B < C && B < A) menor += B;
  if (C < A && C < B) menor += C;
  int soma = maior + menor;
  Console.WriteLine("A soma do maior com o menor número é "+ soma );

  } 
}