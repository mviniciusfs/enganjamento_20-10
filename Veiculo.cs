using System;
using System.Collections.Generic;

class Veiculo
{
  string ModeloCarro;
  public string getModeloCarro()
  {
    return ModeloCarro;
  }

  double Consumo;
  public double getConsumo()
  {
    return Consumo;
  }

  public Veiculo(string mc, double c)
  {
    ModeloCarro = mc;
    Consumo = c;
  }

}