using System;
using System.Collections.Generic;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Veiculo u = new Veiculo("Uno", 13);
    Veiculo j = new Veiculo("Jetta", 8);
    Veiculo p = new Veiculo("Palio", 12);
    Veiculo f = new Veiculo("Fusca", 18);

    List<string> carros = new List<string>();
    List<double> consumo = new List<double>();
    
    carros.Add(u.ModeloCarro);
    consumo.Add(u.Consumo);

    carros.Add(j.ModeloCarro);
    consumo.Add(j.Consumo);

    carros.Add(p.ModeloCarro);
    consumo.Add(p.Consumo);

    carros.Add(f.ModeloCarro);
    consumo.Add(f.Consumo);

    string maisEconomico = carros[0];
    double registroConsumo = consumo[0];

    for( int i = 1; i < carros.Count ; i++ )
    {
      if( consumo[i] > registroConsumo )
      {
        maisEconomico = carros[i];
        registroConsumo = consumo[i];
      }
    }

    Console.WriteLine("Carro com maior autonomia: " + maisEconomico );
    Console.WriteLine("Consumo registrado: " + registroConsumo );

    for( int i = 0; i < carros.Count ; i++ )
    {
      double valorLitro = ( 1000 / consumo[i] ) * 4.89;
      Console.WriteLine( "Carro: " + carros[i] );
      Console.WriteLine( "Valor: " + valorLitro );
    }
  }
}