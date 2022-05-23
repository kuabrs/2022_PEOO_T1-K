using System;

public class Program {

  public static void Main(string[] args) {
    string s = Console.ReadLine();
    string[] v = s.Split();
    int A = int.Parse(v[0]);
    int B = int.Parse(v[1]);
    Console.WriteLine(A % B);
  }
}
