using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
    int b = int.Parse(Console.ReadLine());
    int c = 2*a;
    int d = 3*b;
    double e = c+d;
    double f = e/5;
    Console.WriteLine("Média parcial = "+ f);
  }
}
