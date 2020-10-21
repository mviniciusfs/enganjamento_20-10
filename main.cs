using System;
using System.Collections.Generic;

class MainClass 
{
  public static void Main (string[] args) 
  {
    /*
    Veiculo u = new Veiculo("Uno", 13);
    Veiculo j = new Veiculo("Jetta", 8);
    Veiculo p = new Veiculo("Palio", 12);
    Veiculo f = new Veiculo("Fusca", 18);
    
    List<string> carros = new List<string>();
    List<double> consumo = new List<double>();
    */

    string continuar = "S", marca;
    double consumo;

    Veiculo v = new Veiculo("Teste", 0);
    List<Veiculo> listaVeiculo = new List<Veiculo>();

    while(continuar == "S")
    {
      Console.Write("Marca do Carro: ");
      marca = Console.ReadLine();
      Console.Write("KM/L DO CARRO >>");
      consumo = double.Parse(Console.ReadLine());
      v = new Veiculo(marca, consumo);
      listaVeiculo.Add(v);
      Console.WriteLine("CONTINUAR? S/N");
      continuar = Console.ReadLine();
    }


    Veiculo menor_consumo = listaVeiculo[0];

    for(int i=1;i<listaVeiculo.Count;i++)
    {
      if(listaVeiculo[i].getConsumo() > menor_consumo.getConsumo())
      {
        menor_consumo = listaVeiculo[i];
      }
      
    }
    Console.WriteLine("MARCA DE MENOR CONSUMO: {0} \n CONSUMO DE: {1} KM/L", menor_consumo.getModeloCarro(), menor_consumo.getConsumo());

    for(int i=0;i<listaVeiculo.Count;i++){
      Console.WriteLine("-------------{0}------------", listaVeiculo[i].getModeloCarro());
      Console.WriteLine("LITROS GASTOS EM 1000 KM: {0}", 1000/listaVeiculo[i].getConsumo());
      Console.WriteLine("VALOR GASTO AO PERCORRER 1000 KM {0}", (1000/listaVeiculo[i].getConsumo())*4.89);    
    }
    


    

   
  }
}