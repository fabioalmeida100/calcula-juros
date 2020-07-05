using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaJurosAPI.Business.Implementation
{
    public class ShowMeTheCodeBusiness : IShowMeTheCodeBusiness
    {
        public string ShowMeTheCode()
        {
            var urlProjetoGithub = "https://github.com/fabioalmeida100/calcula-juros.git";
            return urlProjetoGithub;
        }
    }
}
