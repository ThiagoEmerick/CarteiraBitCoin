using System;
using System.Collections.Generic;

class Carteira : IOptions{

  protected double BTC;
  protected double ETH;
  protected double PVU;

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
  
  public Carteira(){
    this.BTC = 25000000;
    this.ETH = 1600000;
    this.PVU = 1400;
  }

  public void setBTC(double BTC){
    this.BTC = BTC;
  }
  public void setETH(double ETH){
    this.ETH = ETH;
  }
  public void setPVU(double PVU){
    this.PVU = PVU;
  }

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
        if(valor*this.ETH <= Real){
          SaldoETH += valor;
          Real -= (valor*this.ETH);
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

  public virtual void vendaCripto(int moeda, double valor){
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
  
  public virtual void realizarSaque(double real){
    if(real <= Real){ 
      Real -= real;
      transacao.Add(("Descontado via Saque", real));
    }
    else{
      Console.WriteLine("Está tentando sacar mais do que tem");
    }
  }

  public void ValorMoedas() {
    Console.WriteLine("BTC = {0}\nETH = {1}\nPVU = {2}",this.BTC,this.ETH,this.PVU);
  }
}