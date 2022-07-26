using System; 

public class Program {

  public static void Main(string[] args) {
    string t = Console.ReadLine();
    int y = t.Length;
    string[] v = t.Split();
    int a = 0;
    int x = -1;
    while (a<=y) {
     while(x< a){
       Console.Write(v[a].Substring(0,1));
       x++;
     }
       a++;
      Console.Write(" ");
    }
  }
}