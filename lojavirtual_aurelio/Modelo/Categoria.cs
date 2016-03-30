using System;

namespace Modelo
{
    public class Categoria
    {
        public string Nome { get; set; }

        public static implicit operator string(Categoria v)
        {
            throw new NotImplementedException();
        }
    }
}