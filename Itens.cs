using System;

  namespace loja
  {
  class Program
  {
      static void main(string[] args);
      {
        item espada = new item(Nome:"Gume",Descricao:"Aumenta seu Acerto Crítico em 50%", valor: 100,cat: "Ataque");

        
            Console.WriteLine("Nome:", espada.Nome);
            Console.WriteLine("Este item faz:", espada.Descricao);
            Console.WriteLine("O custo desse item é:", espada.Valor);
            Console.WriteLine("A categoria do item é:", espada.Cat);
        
        item couraca = new item(nome:"Couraça de Prata", Descricao:"Aumenta sua armadura em 80", valor:80, cat:"Tanque");

        
            Console.WriteLine("Nome:", couraca.Nome);
            Console.WriteLine("Este item faz:", couraca.Descricao);
            Console.WriteLine("O custo desse item é:", couraca.Valor);
            Console.WriteLine("A categoria do item é:", couraca.Cat);

        item bota = new item(nome:"Bota de Rapidez",Descricao:"Aumenta seu velocidade de movimento em 40%",valor:50,cat:"Movimento");

        
            Console.WriteLine("Nome:", bota.Nome);
            Console.WriteLine("Este item faz:", bota.Descricao);
            Console.WriteLine ("O custo desse item é:", bota.Valor);
            Console.WriteLine( "A categoria do item é:" , bota.Cat);
        
        
      }
   }   
 }
