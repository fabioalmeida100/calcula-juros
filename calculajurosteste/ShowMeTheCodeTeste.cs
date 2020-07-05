using CalculaJurosAPI.Business;
using CalculaJurosAPI.Business.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaJurosTeste
{
    [TestClass]
    public class ShowMeTheCodeTeste
    {
        private IShowMeTheCodeBusiness _showMeTheCode;

        public ShowMeTheCodeTeste()
        {
            _showMeTheCode = new ShowMeTheCodeBusiness();
        }

        [TestMethod]
        public void obter_url_projeto_github_show_me_the_code()
        {
            Assert.AreEqual("", _showMeTheCode.ShowMeTheCode());
        }
    }
}
