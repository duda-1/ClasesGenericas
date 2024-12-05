using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    public class Par<T1, T2>
    {
        List<T1> list = new List<T1>();

        public void Adicionar(T1 item1,T2 item2)
        {
            list.Add(item1);
        }
        public void Listar()
        {
            foreach (T1 pilha in list)
            {
                Console.WriteLine(pilha);
            }
        }
    }
}
