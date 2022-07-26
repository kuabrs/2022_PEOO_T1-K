using System; 

public class Program {
public static string Senha(string texto){
  string[] x = texto.Split(' ');
  string k = "";
  foreach (var y in x){
    var u = y.Length;
    k+= u.ToString();
  }
  return k;
  }
  public static void Main(string[] args) {
    Console.WriteLine("Escreva o texto:"); 
    string p = Console.ReadLine();
    Console.WriteLine("Senha = "+Senha(p)+".");
  }
}