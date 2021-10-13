using System;

class Carteira{
  private double _real;
  private double saldoBTC;
  private double saldoETH;
  private double saldoPVU;

  public Carteira(){
    this._real = _real;
    this.saldoBTC = saldoBTC;
    this.saldoETH = saldoETH;
    this.saldoPVU = saldoPVU;
  }

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

  protected virtual void realizarDeposito(double real){
    this._real += real;
    return real;
  }

  protected virtual void realizarSaque(double real){
    this._real -= real;
    return real;
  }

  

}