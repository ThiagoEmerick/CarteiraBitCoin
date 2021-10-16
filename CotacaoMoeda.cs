using System;

class CotacaoMoeda : Carteira {
  
  public void AlteracaoPreco(){

      Random rnd = new Random();
      double BTC = this.BTC;
      double ETH = this.ETH;
      double PVU = this.PVU;
      double contabtc,contaeth,contapvu,porcentagembtc,porcentagemeth, porcentagempvu;


      contabtc = BTC + rnd.Next(-10000,10000);
      porcentagembtc = (((this.BTC - contabtc)/this.BTC)*100);
      this.setBTC(contabtc);
      contaeth = ETH + rnd.Next(-10000,10000);
      porcentagemeth = (((this.ETH - contaeth)/this.ETH)*100);
      this.setETH(contaeth);
      contapvu = PVU + rnd.Next(-100,100);
      porcentagempvu = (((this.PVU - contapvu)/this.PVU)*100);
      this.setPVU(contapvu);
      
      if (contabtc <= 0){
        contabtc = BTC + rnd.Next(1,10000);
        this.setBTC(contabtc);
      }
      if (contaeth <=0){
        contaeth = ETH + rnd.Next(1,10000);
        this.setETH(contaeth);
      }
      if (contapvu <=0){
        contapvu = PVU + rnd.Next(1,1000);
        this.setPVU(contapvu);
      }

      if (porcentagembtc > porcentagemeth){
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
  }
}