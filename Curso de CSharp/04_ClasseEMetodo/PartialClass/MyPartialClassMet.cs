using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    internal partial class MyPartialClass
    {
        public TimeSpan CalcularIdade(DateTime DataNascimento)
        {
            return(DateTime.Now.Date - DataNascimento.Date);
        }

        public TimeSpan DiferencaEntreDatas(DateTime data1, DateTime data2)
        {
            var diferenca = data1.Subtract(data2);
            return diferenca;
        }
    }
}
