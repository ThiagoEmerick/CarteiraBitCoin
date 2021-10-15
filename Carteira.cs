using System;
using System.Collections.Generic;

class Carteira : IOptions{

  protected double _real;
  protected double saldoBTC;
  protected double saldoETH;
  protected double saldoPVU;
  protected List<(string, double)> transacao = new List<(string, double)>();
  
  /*public Carteira(){
    this._real = _real;
    this.saldoBTC = saldoBTC;
    this.saldoETH = saldoETH;
    this.saldoPVU = saldoPVU;
  }*/

  public double Real{
    get { return _real; }
    set { _real = value; } 
  }

  public double SaldoBTC{
    get { return saldoBTC; }
    set { saldoBTC = value; } 
  }

  public double SaldoETH{
    get { return saldoETH; }
    set { saldoETH = value; } 
  }

  public double SaldoPVU{
    get { return saldoPVU; }
    set { saldoPVU = value; } 
  }

  public void verificarTransacao(){
    foreach(var list in transacao){
      Console.WriteLine(list);
    }
  }

  public virtual void compraCripto(int moeda, double valor){
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

  public virtual void vendaCripto(int moeda, double valor){
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

  public virtual void realizarDeposito(double real){
    if(real >= 0){
      Real += real;
      Console.WriteLine("Depósito realizado");
      transacao.Add(("Adicionado via Depósito", real));
    }
    else{
      Console.WriteLine("Sério que ta tentando colocar nada?");
    }
  }
  
  public virtual void realizarSaque(double real){
    if(real <= Real){ 
      Real -= real;
      transacao.Add(("Descontado via Saque", real));
    }
    else{
      Console.WriteLine("Está tentando sacar mais do que tem");
    }
  }
  
}