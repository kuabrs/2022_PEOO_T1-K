using System;

public class Program {

  public static void Main(string[] args) {
    string s = Console.ReadLine();
    string[] v = s.Split();
    double A = double.Parse(v[0]);
    double B = double.Parse(v[1]);
    double C = double.Parse(v[2]);
    double aTR= A*C;
    double aT1 = aTR/2;
    double pi = 3.14159;
    double aC = pi*C*C;
    double aT2 = ((A+B)*C)/2;
    double aQ = B*B;
    double aR = A*B;
    
    
    
    Console.WriteLine(string.Format("TRIANGULO: {0:0.000}", aT1));
    Console.WriteLine(string.Format("CIRCULO: {0:0.000}", aC));
    Console.WriteLine(string.Format("TRAPEZIO: {0:0.000}", aT2));
    Console.WriteLine(string.Format("QUADRADO: {0:0.000}", aQ));
    Console.WriteLine(string.Format("RETANGULO: {0:0.000}", aR));
  }
}
