using System; 

public class Program {

  public static void Main(string[] args) {
   compra x = new compra();

  Console.WriteLine("Escreva seu total a ser pago:");
    x.settotal(double.Parse(Console.ReadLine()));
  Console.WriteLine("Escreva o numero de prestações :");
    x.setprest(int.Parse(Console.ReadLine()));
    x.getvalorprestação();
  Console.WriteLine($"O preço das prestações é de: R$ {x.getvalorprestação():f2}");
    x.getvalordesconto();
  Console.WriteLine($"O preço a vista é de: R$ {x.getvalordesconto():f2}");
  }
}
class compra{
  private double total;
  private int nunprest;
  public void settotal(double total){
    if (total > 0) this.total = total ;
  }
  public void setprest(int nunprest){
    if (nunprest > 0) this.nunprest = nunprest ;
  }
  public double getvalorprestação(){
    return total/nunprest;
  }
  public double getvalordesconto(){
    return total*0.85;
  }
  
}