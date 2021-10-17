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
  
  public Carteira(double _real, double saldoBTC, double saldoETH, double saldoPVU){
    this._real = _real;
    this.saldoBTC = saldoBTC;
    this.saldoETH = saldoETH;
    this.saldoPVU = saldoPVU;
  }
  
  public Carteira(){
    this.BTC = 250000;
    this.ETH = 160000;
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

  public void vizualizarSaldo(){
    Console.WriteLine("Seu saldo em real é: {0}", Real);
    Console.WriteLine("Seu saldo em BTC é: {0}", SaldoBTC);
    Console.WriteLine("Seu saldo em ETH é: {0}", SaldoETH);
    Console.WriteLine("Seu saldo em PVU é: {0}", SaldoPVU);
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
          transacao.Add(("Descontado por Compra de criptomoeda", valor*this.BTC));
        }
        else{
          Console.WriteLine("Saldo insuficiente");
        }
      break;
      case 2:
        if(valor*ETH <= Real){
          SaldoETH += valor;
          Real -= (valor*ETH);
          Console.WriteLine("Compra efetuada com sucesso!");
          transacao.Add(("Descontado por Compra de criptomoeda", valor*this.ETH));
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
          transacao.Add(("Descontado por Compra de criptomoeda", valor*this.PVU));
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
          transacao.Add(("Adicionado por Venda de criptomoeda", valor*this.BTC));
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
          transacao.Add(("Adicionado por Venda de criptomoeda", valor*this.ETH));
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
          transacao.Add(("Adicionado por Venda de criptomoeda", valor*this.PVU));
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

  public void ValorMoedas() {
    Console.WriteLine("BTC = {0}\nETH = {1}\nPVU = {2}",this.BTC,this.ETH,this.PVU);
  }

  public virtual void AlteracaoPreco(){

      Random rnd = new Random();
      double BTC = this.BTC;
      double ETH = this.ETH;
      double PVU = this.PVU;
      double contabtc,contaeth,contapvu,porcentagembtc,porcentagemeth, porcentagempvu;

      contabtc = BTC + rnd.Next(-10000,10000);
      if (contabtc <= 0){
        contabtc = BTC + rnd.Next(1,10000);
        porcentagembtc = (((this.BTC - contabtc)/this.BTC)*100);
        this.setBTC(contabtc);
      }else{
        porcentagembtc = (((this.BTC - contabtc)/this.BTC)*100);
        this.setBTC(contabtc);
      }
      
      contaeth = ETH + rnd.Next(-10000,10000);
      if (contaeth <=0){
        contaeth = ETH + rnd.Next(1,10000);
        porcentagemeth = (((this.ETH - contaeth)/this.ETH)*100);
        this.setETH(contaeth);
      }else{
        porcentagemeth = (((this.ETH - contaeth)/this.ETH)*100);
        this.setETH(contaeth);
      }
      
      contapvu = PVU + rnd.Next(-100,100);
       if (contapvu <=0){
        contapvu = PVU + rnd.Next(1,1000);
        porcentagempvu = (((this.PVU - contapvu)/this.PVU)*100);
        this.setPVU(contapvu);
      }else{
        porcentagempvu = (((this.PVU - contapvu)/this.PVU)*100);
        this.setPVU(contapvu);
      }
    
    if(porcentagembtc > 0 || porcentagemeth > 0 || porcentagempvu > 0){
      
      if (porcentagembtc > porcentagemeth && porcentagembtc > porcentagempvu){
        Console.WriteLine("Teve dimunição no preço do BTC, vale a pena! ");
        Console.WriteLine("BTC: {0} ETH: {1} PVU: {2}",porcentagembtc,porcentagemeth, porcentagempvu);
      } 
      else if (porcentagemeth > porcentagempvu){
         Console.WriteLine("Teve dimunição no preço do ETH, vale a pena! ");
         Console.WriteLine("BTC: {0} ETH: {1} PVU: {2}",porcentagembtc,porcentagemeth, porcentagempvu);
      }
      else {
        Console.WriteLine("Teve dimunição no preço do PVU, vale a pena!");
        Console.WriteLine("BTC: {0} ETH: {1} PVU: {2}",porcentagembtc,porcentagemeth, porcentagempvu);
      }
    }else{
      Console.WriteLine("não diminuiu nada");
      Console.WriteLine("BTC: {0} ETH: {1} PVU: {2}",porcentagembtc,porcentagemeth, porcentagempvu);
    }
  }

}