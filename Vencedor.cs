using System    
using System.Collections.Generic;
{
    namespace loja
    {

        public class vencedor
        {
            public string Nome;
            public Int Valor;
            public List<item> Inventario = new List<item>();

            public vencedor(string nome, int valor)
            {
                this.Nome=nome;
                this.Valor=150;
                this.Inventario= new list<item>();
            }

            public void ImprimirInventario()
            {
                foreach(item i in Inventario)
                {
                    i.imprimiritem();
                }
            }
            public void ImprimirPersonagem()
        {
            Console.WriteLine("Nome:", this.Nome);
            Console.WriteLine("Valor:", this.Valor);
            Console.Write("Inventário:");
            foreach (var item in Inventario)
            {
                Console.Write("{0}", item.Nome);
            }
        }

        public void PegarItem(Item item)
        {
            this.Inventario.Add(item);
        }

        public void Comprar(Item item)
        {
            if (this.Valor > item.Valor)
            {
                this.Valor = this.Valor - item.Valor;
                this.PegarItem(item);
            }
            else
            {
                Console.WriteLine("Você não tem dinheiro o suficiente para este item.");
            }
        }
    }
 }
