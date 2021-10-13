interface IOptions{

  void compraCripto(string moeda, double valor);
  void vendaCripto(string moeda, double valor);
  void realizarDeposito(double real);
  void realizarSaque(double real);
  void verificarTransacao();
}