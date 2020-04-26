using AutoMapper;
using TreinamentoLinq.ApiDados.ViewModels;
using TreinamentoLinq.Domain;

namespace TreinamentoLinq.ApiDados.AutoMapper.Mappers
{
    public class BancoMappingProfile : Profile
    {
        public BancoMappingProfile()
        {
            CreateMap<Banco, BancoViewModel>()
                .ConvertUsing((o, d) =>
                {
                    return new BancoViewModel(o.CodigoBanco, o.NomeBanco);
                });

            CreateMap<BancoViewModel, Banco>()
                .ConvertUsing((o, d) =>
                {
                    return new Banco(o.CodigoBanco, o.NomeBanco);
                });
        }
    }
}
