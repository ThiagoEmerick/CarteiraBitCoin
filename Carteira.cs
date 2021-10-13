using System;
using System.Collections.Generic;

class Carteira : IOptions{

  protected double _real;
  protected double saldoBTC;
  protected double saldoETH;
  protected double saldoPVU;
  protected List<(string, double)> transacao = new List<(string, double)>();
  
  public Carteira(){
    this._real = _real;
    this.saldoBTC = saldoBTC;
    this.saldoETH = saldoETH;
    this.saldoPVU = saldoPVU;
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

  public virtual void compraCripto(string moeda, double valor){
  }

  public virtual void vendaCripto(string moeda, double valor){
  }

  public virtual void realizarDeposito(double real){
  }
  
  public virtual void realizarSaque(double real){
  }
  
}