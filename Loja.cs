using System    
using System.Collections.Generic;

    namespace loja
    {

        public Dictionary<string, item> Bazar;

        public Loja()
        {
            Bazar = new Dictionary<string, item>();
        }

        public void imprimirLista()
        {
            foreach(KeyValuePair<string, item> i in Bazar);
            {
                i.value.imprimiritem();
            }
        }
    }
