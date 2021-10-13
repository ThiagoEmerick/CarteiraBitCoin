using System;
class CriptoMoeda : Carteira, IOptions {

  private double valor;
  private string moeda;

  protected override void compraCripto(double valor, string moeda){
    switch(moeda){
      case "BTC":
        if(valor*250.00000 > this._real){
          this.saldoBTC += valor;
          this._real -= (valor*250.00000);
          Console.WriteLine("Venda efetuada com sucesso!");
          break;
        }
        else{
          Console.WriteLine("Está tentando vender mais do que tem.");
        }
      case "ETH":
        if(valor*160.0000 > this._real){
          this.saldoETH += valor;
          this._real -= (valor*160.0000);
          Console.WriteLine("Venda efetuada com sucesso!");
          break;
        }
        else{
          Console.WriteLine("Está tentando vender mais do que tem.");
        }
      case "PVU":
        if(valor*14.00 > this._real){
          this.saldoPVU += valor;
          this._real -= (valor*14.00);
          Console.WriteLine("Venda efetuada com sucesso!");
          break;
          }
          else{
            Console.WriteLine("Está tentando vender mais do que tem.");
          }
      default:
        Console.WriteLine("Venda efetuada com sucesso!");
        break;
    }
  }

  protected override void vendaCripto(double valor, string moeda){
    switch(moeda){
      case "BTC":
        if(valor < this.saldoBTC){
          this.saldoBTC -= valor;
          this._real += (valor*250.00000);
          Console.WriteLine("Venda efetuada com sucesso!");
          break;
        }
        else{
          Console.WriteLine("Está tentando vender mais do que tem.");
        }
      case "ETH":
        if(valor < this.saldoETH){
          this.saldoETH -= valor;
          this._real += (valor*160.0000);
          Console.WriteLine("Venda efetuada com sucesso!");
          break;
        }
        else{
          Console.WriteLine("Está tentando vender mais do que tem.");
        }
      case "PVU":
        if(valor < this.saldoPVU){
          this.saldoPVU -= valor;
          this._real += (valor*14.00);
          Console.WriteLine("Venda efetuada com sucesso!");
          break;
          }
          else{
            Console.WriteLine("Está tentando vender mais do que tem.");
          }
      default:
        Console.WriteLine("Venda efetuada com sucesso!");
        break;
    }
  }
}