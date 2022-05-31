using System; 

public class Program {

  public static void Main(string[] args) {
  Console.WriteLine("Digite quatro valores inteiros");
  int A = int.Parse(Console.ReadLine());
  int B = int.Parse(Console.ReadLine());
  int C = int.Parse(Console.ReadLine());
  int D = int.Parse(Console.ReadLine());
  double Media = (A+B+C+D)/4;
   Console.WriteLine("Média = "+ Media); 
   Console.WriteLine("Números menores que a média");
  if(A < Media) Console.WriteLine(A);
  if(B < Media) Console.WriteLine(B);
  if(C < Media) Console.WriteLine(C);
  if(D < Media) Console.WriteLine(D);
  Console.WriteLine("Números maiores ou iguais à média");
  if(A > Media || A == Media) Console.WriteLine(A);
  if(B > Media || B == Media) Console.WriteLine(B);
  if(C > Media || C == Media) Console.WriteLine(C);
  if(D > Media || D == Media) Console.WriteLine(D);
  } 
}