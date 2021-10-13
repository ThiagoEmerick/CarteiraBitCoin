class Real : Carteira {
  protected override void realizarDeposito(double real){
    this._real += real;
    return real;
  }

  protected void realizarSaque(double real){
    this._real -= real;
    return real;
  }

}