using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;
using AutoMapper;
using lojavirtual_aurelio.Mappers;
using lojavirtual_aurelio.Models;

namespace TesteLojaVirtual
{
    [TestClass]
    public class TesteProdutoMapper
    {
        [TestInitialize]
        public void Init()
        {
            AutoMapperConfig.RegisterMappings();
        }
        [TestMethod]

        public void DeveMapearDeProdutoParaProdutoViewModel()
        {
            var produto = new Produto
            {
                Nome = "Chuteira Nike",
                Categoria = new Categoria
                {
                    Nome = "Calcados"
                }
            };

            var produtoViewModel = Mapper.Map<ProdutoViewModel>(produto);

            Assert.IsNotNull(produtoViewModel);
        }


        [TestMethod]
        public void DeveMapearNomeDoProduto()
        {
            var produto = new Produto
            {
                Nome = "Chuteira Nike",
                Categoria = new Categoria
                {
                    Nome = "Calcados"
                }
            };

            var produtoViewModel = Mapper.Map<ProdutoViewModel>(produto);

            Assert.AreEqual("Chuteira Nike", produtoViewModel.Nome);
        }
        [TestMethod]
        public void DeveMapearNomeDaCategoria()
        {
            Assert.Fail();
        }
    }
}
