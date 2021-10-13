class Usuario{
  private string _userName;
  private string _senha;
  private Carteira _carteira;

  public Usuario (string nome, string senha){
    this._userName = nome;
    this._senha = senha;
    this._carteira = new Carteira();
  }

}
