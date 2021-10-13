using System;
class Criptomoeda : Carteira{

  public override void compraCripto(string moeda, double valor){
    switch(moeda){
      case "BTC":
        if(valor*250.00000 <= this._real){
          this.saldoBTC += valor;
          this._real -= (valor*250.00000);
          Console.WriteLine("Compra efetuada com sucesso!");
          transacao.Add(("Descontado por Compra de criptomoeda", valor));
        }
        else{
          Console.WriteLine("Está tentando vender mais do que tem.");
        }
      break;
      case "ETH":
        if(valor*160.0000 <= this._real){
          this.saldoETH += valor;
          this._real -= (valor*160.0000);
          Console.WriteLine("Compra efetuada com sucesso!");
          transacao.Add(("Descontado por Compra de criptomoeda", valor));
        }
        else{
          Console.WriteLine("Está tentando vender mais do que tem.");
        }
      break;
      case "PVU":
        if(valor*14.00 >= this._real){
          this.saldoPVU += valor;
          this._real -= (valor*14.00);
          Console.WriteLine("Compra efetuada com sucesso!");
          transacao.Add(("Descontado por Compra de criptomoeda", valor));
          }
          else{
            Console.WriteLine("Está tentando vender mais do que tem.");
          }
        break;
      default:
        Console.WriteLine("Moeda inexistente com sucesso!");
        break;
    }
  }

  public override void vendaCripto(string moeda, double valor){
    switch(moeda){
      case "BTC":
        if(valor <= this.saldoBTC){
          this.saldoBTC -= valor;
          this._real += (valor*250.00000);
          Console.WriteLine("Venda efetuada com sucesso!");
          transacao.Add(("Adicionado por Venda de criptomoeda", valor));
        }
        else{
          Console.WriteLine("Está tentando vender mais do que tem.");
        }
        break;
      case "ETH":
        if(valor <= this.saldoETH){
          this.saldoETH -= valor;
          this._real += (valor*160.0000);
          Console.WriteLine("Venda efetuada com sucesso!");
          transacao.Add(("Adicionado por Venda de criptomoeda", valor));
        }
        else{
          Console.WriteLine("Está tentando vender mais do que tem.");
        }
        break;
      case "PVU":
        if(valor <= this.saldoPVU){
          this.saldoPVU -= valor;
          this._real += (valor*14.00);
          Console.WriteLine("Venda efetuada com sucesso!");
          transacao.Add(("Adicionado por Venda de criptomoeda", valor));
          }
          else{
            Console.WriteLine("Está tentando vender mais do que tem.");
          }
          break;
      default:
        Console.WriteLine("Moeda inexistente com sucesso!");
        break;
    }
  }
}