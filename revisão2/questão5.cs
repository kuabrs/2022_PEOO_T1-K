using System; 

public class Program {

  public static void Main(string[] args) {
  Console.WriteLine("Informe o número do mês");
  int A = int.Parse(Console.ReadLine());
  if(A == 1) Console.WriteLine("O mês de janeiro é do primeiro trimestre do ano");
  if(A == 2) Console.WriteLine("O mês de fevereiro é do primeiro trimestre do ano");
  if(A == 3) Console.WriteLine("O mês de março é do primeiro trimestre do ano");
  if(A == 4) Console.WriteLine("O mês de abril é do segundo trimestre do ano");
  if(A == 5) Console.WriteLine("O mês de maio é do segundo trimestre do ano");
  if(A == 6) Console.WriteLine("O mês de junho é do segundo trimestre do ano");
  if(A == 7) Console.WriteLine("O mês de julho é do terceiro trimestre do ano");
  if(A == 8) Console.WriteLine("O mês de agosto é do terceiro trimestre do ano");
  if(A == 9) Console.WriteLine("O mês de setembro é do terceiro trimestre do ano");
  if(A == 10) Console.WriteLine("O mês de outubro é do quarto trimestre do ano");
  if(A == 11) Console.WriteLine("O mês de novembro é do quarto trimestre do ano");
  if(A == 12) Console.WriteLine("O mês de dezembro é do quarto trimestre do ano");

  } 
}