using AutoMapper;
using TreinamentoLinq.ApiDados.AutoMapper.Mappers;

namespace TreinamentoLinq.ApiDados.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration Configurar()
        {
            return new MapperConfiguration(ps =>
            {
                ps.AddProfile(new BancoMappingProfile());
            });
        }
    }
}
