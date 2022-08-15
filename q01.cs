using System; 

public class Program {

  public static void Main(string[] args) {
    Console.ReadLine();
    circulo a = new circulo();
    circulo b = new circulo();
    circulo c = new circulo();
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(a.raio);
    Console.WriteLine(b.raio);
    Console.WriteLine(c.raio);
    a.raio = int.Parse(Console.ReadLine());
    b.raio = int.Parse(Console.ReadLine());
    c.raio = int.Parse(Console.ReadLine());
    Console.
  }
}
 class circulo{
 public double raio;
 public double area() {
   return Math.PI * raio * raio;
 }  
   
}