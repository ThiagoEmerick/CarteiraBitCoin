using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class Program {
  public static void Main (string[] args) {

    bool repetir = true;
    string resposta;
    
    CotacaoMoeda a = new CotacaoMoeda();
    CotacaoMoeda c = new CotacaoMoeda(); 

    while (repetir == true){
      a.ValorMoedas();
      a.AlteracaoPreco();
      a.ValorMoedas();
      Console.WriteLine("Deseja sair:(S/N)");
      resposta = Console.ReadLine();
      if (resposta == "S"){
        repetir = false;
      }
    }
 }
}