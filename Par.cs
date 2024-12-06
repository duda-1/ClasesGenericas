using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    public class Par<T1, T2>
    {
        T1 propriedadeUm { get; set; }                      
        T2 propriedadeDois { get; set; }
    }
}
