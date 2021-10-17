using System;
class Criptomoeda : Carteira{

  public void compraCripto(int moeda, double valor){
    
    switch(moeda){
      case 1:
        if(valor*this.BTC <= Real){
          SaldoBTC += valor;
          Real -= (valor*this.BTC);
          Console.WriteLine("Compra efetuada com sucesso!");
          transacao.Add(("Descontado por Compra de criptomoeda", valor));
        }
        else{
          Console.WriteLine("Saldo insuficiente");
        }
      break;
      case 2:
        if(valor*ETH <= Real){
          SaldoETH += valor;
          Real -= (valor*ETH);
          Console.WriteLine("Compra efetuada com sucesso!");
          transacao.Add(("Descontado por Compra de criptomoeda", valor));
        }
        else{
          Console.WriteLine("Saldo insuficiente");
        }
      break;
      case 3:
        if(valor*this.PVU <= Real){
          SaldoPVU += valor;
          Real -= (valor*this.PVU);
          Console.WriteLine("Compra efetuada com sucesso!");
          transacao.Add(("Descontado por Compra de criptomoeda", valor));
          }
          else{
            Console.WriteLine("Saldo insuficiente");
          }
        break;
      default:
        Console.WriteLine("Moeda inexistente com sucesso!");
        break;
    }
  }

  public override void vendaCripto(int moeda, double valor){
    switch(moeda){
      case 1:
        if(valor <= SaldoBTC){
          SaldoBTC -= valor;
          Real += (valor*this.BTC);
          Console.WriteLine("Venda efetuada com sucesso!");
          transacao.Add(("Adicionado por Venda de criptomoeda", valor));
        }
        else{
          Console.WriteLine("Está tentando vender mais do que tem.");
        }
        break;
      case 2:
        if(valor <= SaldoETH){
          SaldoETH -= valor;
          Real += (valor*this.ETH);
          Console.WriteLine("Venda efetuada com sucesso!");
          transacao.Add(("Adicionado por Venda de criptomoeda", valor));
        }
        else{
          Console.WriteLine("Está tentando vender mais do que tem.");
        }
        break;
      case 3:
        if(valor <= this.saldoPVU){
          this.saldoPVU -= valor;
          this._real += (valor*this.PVU);
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