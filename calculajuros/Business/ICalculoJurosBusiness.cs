using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculajuros.Business
{
    public interface ICalculoJurosBusiness
    {
        decimal ObterJurosComposto(decimal valorInicial, int meses);
    }
}
