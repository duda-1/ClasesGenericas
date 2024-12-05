using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    public class Pilha<T> where T : Pessoa
    {
        List<T> _pilha = new List<T>();
 
        //Adiconar
        public void Push(T pilha)
        {
            _pilha.Add(pilha);
        }
        //Remover o ultiomo item
        public void Pop()
        {
            _pilha.RemoveAt(_pilha.Count-1);
        }
        //exibir toos os itens da pilha 
        public void MostrarElementos()
        {
            foreach(T pilha in _pilha)
            {
                Console.WriteLine(pilha);
            }
        }
    }
}
