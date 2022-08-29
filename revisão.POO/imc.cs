using System; 

public class Program {

  public static void Main(string[] args) {
   IMC x = new IMC();

  Console.WriteLine("Escreva seu peso em quilos:");
    x.setpeso(double.Parse(Console.ReadLine()));
  Console.WriteLine("Escreva sua altura em metros:");
    x.setaltura(double.Parse(Console.ReadLine()));
    x.calcimc();
  Console.WriteLine("Seu imc é de de :" + x.calcimc());
  }
}
class IMC{
  private double peso;
  private double altura;
  public void setpeso(double p){
    if (p > 0) peso = p ;
  }
  public void setaltura(double a){
    if (a > 0) altura = a ;
  }
  public double getaltura(){
    return altura;
  }
  public double getpeso(){
    return peso;
  }
  public double calcimc(){
    return peso/(altura*altura);
  }
  
}