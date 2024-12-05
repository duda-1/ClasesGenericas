using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    public class ListaGenerica<T> //where T : class //Usa para limitar para oque deve ser usada 
    {
        private List<T> _item = new List<T>();

        public void Adicionar(T item)
        {
            _item.Add(item);
        }
        public void MostrarItem()
        {
            foreach(T item in _item)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
