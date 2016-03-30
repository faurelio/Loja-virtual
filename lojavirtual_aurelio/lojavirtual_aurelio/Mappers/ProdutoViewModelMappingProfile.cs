using AutoMapper;
using lojavirtual_aurelio.Models;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lojavirtual_aurelio.Mappers
{
    public class ProdutoViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Produto, ProdutoViewModel>()
            .ForMember(Dest => Dest.Categoria, opt => opt.MapFrom(src => src.Categoria.Nome));
        }
    }
}