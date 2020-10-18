using System;

public class Desafio {

  public static void Main() {
    
    int R;
    R = Int32.Parse(Console.ReadLine());

    int V;
    do {
      V = Int32.Parse(Console.ReadLine());
    } while(R>=V);

    int total = 0;
    int quantidade = 0;
    
    for(int i = R; total < V; i++)  
    {
      total+=i;
      quantidade++;
    }
    Console.WriteLine(quantidade);
  }
}
