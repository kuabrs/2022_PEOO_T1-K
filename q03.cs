using System; 

public class Program {

  public static void Main(string[] args) {
   Viagem x = new Viagem();

  Console.WriteLine("Escreva qual foi a distancia percorrida em km:");
    x.distancia = double.Parse(Console.ReadLine());
  Console.WriteLine("Escreva a quantidade de horas gastas no formato '00:00':");
    x.tempo = Console.ReadLine();
    x.kmh();
  Console.WriteLine("A velocidade média foi de :" + x.kmh() + "km/h.");
  }
}
class Viagem{
  public double distancia;
  public string tempo;
  public int horas(){
    string[] v = tempo.Split(':');
      return int.Parse(v[0]);
  }
  public int minutos(){
    string[] v = tempo.Split(':');
      return int.Parse(v[1]);
  }
  public double kmh(){
    if (minutos() == 0) {
         return distancia/horas();
    }
    else return distancia/(horas()+(minutos()/60));
  }
}
