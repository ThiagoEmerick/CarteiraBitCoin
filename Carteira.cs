using System;

abstract class Carteira : IOptions{

  private Usuario pessoa;
  protected double _real;
  protected double saldoBTC;
  protected double saldoETH;
  protected double saldoPVU;

  /*public Carteira(){
    this._real = _real;
    this.saldoBTC = saldoBTC;
    this.saldoETH = saldoETH;
    this.saldoPVU = saldoPVU;
  }*/

  private double Real{
    get { return _real; }
    set { _real = value; } 
  }

  private double SaldoBTC{
    get { return saldoBTC; }
    set { saldoBTC = value; } 
  }

  private double SaldoETH{
    get { return saldoETH; }
    set { saldoETH = value; } 
  }

  private double SaldoPVU{
    get { return saldoPVU; }
    set { saldoPVU = value; } 
  }

  public virtual void compraCripto(double valor, string moeda){
    
  }
  public virtual void vendaCripto(double valor, string moeda){

  }

  protected virtual void realizarDeposito(double real){

  }
  protected virtual void realizarSaque(double real){

  }
  
}