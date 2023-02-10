using System;

class Program {
  public static void Main (string[] args) {

string produto, convert3, convert2;
  Double total, totalPagar, precoUnitario, Quantidade;
    
    Console.Write("Informe o nome do produto: ");
     produto=Console.ReadLine();

    Console.Write("Informe o valor do produto: ");
    convert2= Console.ReadLine();
     precoUnitario= Double.Parse(convert2);

    Console.Write("Informe a quantidade do produto: ");
     convert3=Console.ReadLine();
     Quantidade=Double.Parse(convert3);

    if( Quantidade <= 5 )
    {
      total = precoUnitario * 0.02 ;
      totalPagar = precoUnitario - total;
      Console.Write("O valor do(a) " + produto + " com Desconto de 3% é: "  + totalPagar );
    }
    if ( Quantidade  <=10 && Quantidade > 5  )
    {
      total = precoUnitario * 0.03 ;
      totalPagar = precoUnitario - total;
      Console.Write("O valor do " + produto + " com Desconto de 3% é: "  + totalPagar );
    }
    
    if ( Quantidade  > 10 )
    {
      total = precoUnitario * 0.05 ;
      totalPagar = precoUnitario - total;
      Console.Write("O valor do(a) " + produto + " com Desconto de 5% é: "  + totalPagar );
    }
  }
}