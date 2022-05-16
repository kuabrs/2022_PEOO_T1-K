using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite a base e a altura do retângulo");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double area = a*b;
    double perimetro = a+a+b+b;
    double d1 = a*a;
    double d2 = b*b;
    double d3 = d1+d2;
    Math.Sqrt(d3);
    //double d3 = d1*d2;
    //Math.Round(Math.Sqrt(area.Item2), 2));
    Console.WriteLine("Área = "+ area + " Perímetro = "+ perimetro + " Diagonal = "+Math.Sqrt(d3));

  }
}
