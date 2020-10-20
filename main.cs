using System;
using System.Collections.Generic;

class MainClass 
{
  public static void Main (string[] args) 
  {
    List<string> carros = new List<string>();
    List<double> consumo = new List<double>();
    
    carros.Add("Uno");
    consumo.Add(13);

    carros.Add("Jetta");
    consumo.Add(8);

    carros.Add("Palio");
    consumo.Add(12);

    carros.Add("Fusca");
    consumo.Add(18);

    string carroEconomico = carros[0];
    double consumoEconomico = consumo[0];

    for( int i = 1; i < carros.Count ; i++ )
    {
      if( consumo[i] < consumoEconomico )
      {
        carroEconomico = carros[i];
        consumoEconomico = consumo[i];
      }
    }

    Console.WriteLine("Carro mais Economico: " + carroEconomico );
    Console.WriteLine("Consumo do Carro Economico: " + consumoEconomico );

    for( int i = 0; i < carros.Count ; i++ )
    {
      double valorLitro = ( 1000 / consumo[i] ) * 4.89;
      Console.WriteLine( "Carro: " + carros[i] );
      Console.WriteLine( "Valor: " + valorLitro );
    }
  }
}