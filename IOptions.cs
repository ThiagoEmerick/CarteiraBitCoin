interface IOptions{

  void compraCripto(int moeda, double valor);
  void vendaCripto(int moeda, double valor);
  void realizarDeposito(double real);
  void realizarSaque(double real);
  void verificarTransacao();
  void vizualizarSaldo();

}