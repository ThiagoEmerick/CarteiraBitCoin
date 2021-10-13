using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class main {
  public static void Main (string[] args) {
    Real a = new Real();
    Carteira b = new Carteira();
    Criptomoeda c = new Criptomoeda();

    a.realizarDeposito(100);
    c.compraCripto("BTC", 2);
    Console.WriteLine(b.SaldoPVU);
    Console.WriteLine(b.Real);
    b.verificarTransacao();

  }
}