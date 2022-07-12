using System; 

public class Program {

  public static void Main(string[] args) {
    int x = 1;
    int y = 1;
    while(x < 11){ 
      Console.WriteLine();
      Console.WriteLine($"Tabuada de {x}");
      if(y != 1) y = 1;
      while(y < 11){
       int z = x * y;
      Console.WriteLine(x+" x "+y+" = "+z);
      y++;
      }
      x++;
    }
  }
}
