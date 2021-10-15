using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class main {
  public static void Main (string[] args) {
    IOptions a = new Carteira();

    a.realizarDeposito(100);
    a.realizarDeposito(100);
    a.realizarSaque(100);
    a.compraCripto(3, 2);

    a.verificarTransacao();
    
  }
}