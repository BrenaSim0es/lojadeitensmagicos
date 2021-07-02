using System    
using System.Collections.Generic;
{

    namespace loja
    {
        static void Main(string[args]);
        {
            Loja loja= new loja();

            Console.Write("Digite o seu nome");
            string nomedoPersonagem=Console.ReadLine();

            Personagem campeao = new Personagem(nomedoPersonagem, 100);

            Console.WriteLine();
            
            loja.ImprimirCatalogo();

            Console.WriteLine();

            string escolha;

            do
            {}
                Console.WriteLine("Você tem "valor" moedas", campeao.valor);

                Console.write("Digite o nome do item que quer comprar:");

                campeao.ComprarItem(nomedoitem, loja);

                Console.WriteLine();

                campeao.ImprimirInventario();

                Console.WriteLine();

                Console.WriteLine("Deseja comprar novamente? Digite sim para comprar de novo");
                escolha=Console.ReadLine();

            }while (escolha == "sim");
        }
 
}   }
