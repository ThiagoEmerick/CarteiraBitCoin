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
    int navegacao;
    double svalor, cmoeda;
    
    IOptions a = new Carteira();
    CotacaoMoeda b = new CotacaoMoeda();

    while (repetir == true){
      Console.WriteLine("1. Cotação da moeda\n2. Deposito\n3. Saque\n4. Compra criptomoeda\n5. Ver histórico\n6. Vizualizar saldo\n");
      navegacao = Convert.ToInt32(Console.ReadLine());
      switch (navegacao){ 
        case 1:
          b.ValorMoedas();
          b.AlteracaoPreco();
          b.ValorMoedas();
          break;
          
        case 2:
          Console.WriteLine("Insira um valor para Depósito: ");
          svalor = Convert.ToDouble(Console.ReadLine());
          a.realizarDeposito(svalor);
          break;

        case 3:
          Console.WriteLine("Insira um valor para Saque: ");
          svalor = Convert.ToDouble(Console.ReadLine());
          a.realizarSaque(svalor);
          break;

        case 4: 
          Console.WriteLine("1. BTC\n2. ETH\n3. PVU\n");
          cmoeda = Convert.ToDouble(Console.ReadLine());
          if (cmoeda == 1){
            Console.WriteLine("Insira um valor para compra de BTC: ");
            cmoeda = Convert.ToDouble(Console.ReadLine());
            a.compraCripto(1, cmoeda);
          }
          else if(cmoeda == 2){
            Console.WriteLine("Insira um valor para compra de ETH: ");
            cmoeda = Convert.ToDouble(Console.ReadLine());
            a.compraCripto(2, cmoeda);
          }
          else if(cmoeda == 3){
            Console.WriteLine("Insira um valor para compra de PVU: ");
            cmoeda = Convert.ToDouble(Console.ReadLine());
            a.compraCripto(3, cmoeda);
          }else{
            Console.WriteLine("Moeda não existente");
          }
          break;
        case 5:
          a.verificarTransacao();
          break;
        case 6:
          a.vizualizarSaldo();
          break;
     }
     Console.WriteLine("Deseja sair:(S/N)");
          resposta = Console.ReadLine();
          if (resposta == "S"){
            repetir = false;
          }
    }
 }
}