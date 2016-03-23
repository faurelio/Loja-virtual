using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;

namespace TestModelo
{
    [TestClass]
    public class TestSalvarCliente
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeveLancarExcecaoSeONomeForNulo()

        {
            var cliente = new Cliente();
            new Clientes().Salvar(cliente);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeveLancarExcecaoSeONomeForVazio()

        {
            var cliente = new Cliente
            {
                Nome = ""
            };
            new Clientes().Salvar(cliente);
        }
    }
}