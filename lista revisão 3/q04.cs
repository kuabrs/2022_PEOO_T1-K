using System; 

public class Program {

  public static void Main(string[] args) {
    int x = 1;
    while(x < 31){
      if(x % 3 == 0){
    Console.Write($"-{x}" + " ");}
      else
        Console.Write(x + " ");
      x++;
      
    }
  }
}
//V
