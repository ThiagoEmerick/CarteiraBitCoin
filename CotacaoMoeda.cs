using System;

class CotacaoMoeda : Carteira {
  
  public void AlteracaoPreco(){

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