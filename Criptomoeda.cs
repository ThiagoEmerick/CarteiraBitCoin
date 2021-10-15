using System;
class Criptomoeda : Carteira{

  public override void compraCripto(int moeda, double valor){
    switch(moeda){
      case 1:
        if(valor*250.00000 <= Real){
          SaldoBTC += valor;
          Real -= (valor*250.00000);
          Console.WriteLine("Compra efetuada com sucesso!");
          transacao.Add(("Descontado por Compra de criptomoeda", valor));
        }
        else{
          Console.WriteLine("Saldo insuficiente");
        }
      break;
      case 2:
        if(valor*160.0000 <= Real){
          SaldoETH += valor;
          Real -= (valor*160.0000);
          Console.WriteLine("Compra efetuada com sucesso!");
          transacao.Add(("Descontado por Compra de criptomoeda", valor));
        }
        else{
          Console.WriteLine("Saldo insuficiente");
        }
      break;
      case 3:
        if(valor*14.00 <= Real){
          SaldoPVU += valor;
          Real -= (valor*14.00);
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
          Real += (valor*250.00000);
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
          Real += (valor*160.0000);
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