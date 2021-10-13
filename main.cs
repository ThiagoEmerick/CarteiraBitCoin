using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class main {
  public static void Main (string[] args) {
    //StreamWriter x;
    Carteira a = new Carteira();

    string usuarioTxt = "usuario.txt";
    //x = File.CreateText(usuarioTxt);
    //x.ReadLine();
    
    StreamReader sr = new StreamReader(usuarioTxt);
    double linha = Convert.ToDouble(sr.ReadLine());;
    while(linha != null){
      
      linha = Convert.ToDouble(sr.ReadLine());
      a.realizarDeposito(linha);

      linha = Convert.ToDouble(sr.ReadLine());
      a.compraCriptomoeda(linha);
    }

    Console.WriteLine(a.Real);
    Console.WriteLine(a.Cripto);
    sr.Close();
  
  }
}