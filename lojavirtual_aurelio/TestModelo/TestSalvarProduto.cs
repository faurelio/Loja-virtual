using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModelo
{
    [TestClass]
    public class TestSalvarProduto
    {
        [TestMethod]
        public void salvar()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var produto = new Produto { Nome = "Chuteira Noke T90" };

                session.Save(produto);
                session.Flush();
            }
        } 
   }
}
