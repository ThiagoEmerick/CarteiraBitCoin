using System;
class Real : Carteira {
  public override void realizarDeposito(double real){
    if(real >= 0){
      this._real += real;
      transacao.Add(("Adicionado via Depósito", real));
    }
    else{
      Console.WriteLine("Sério que ta tentando colocar nada?");
    }
  }

  public override void realizarSaque(double real){
    if(real <= this._real){ 
      this._real -= real;
      transacao.Add(("Descontado via Saque", real));
    }
    else{
      Console.WriteLine("Está tentando sacar mais do que tem");
    }
  }

}