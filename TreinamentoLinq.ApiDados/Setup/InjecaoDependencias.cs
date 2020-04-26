using Microsoft.Extensions.DependencyInjection;
using TreinamentoLinq.ApiDados.AutoMapper;
using TreinamentoLinq.Data.Repositories;
using TreinamentoLinq.Domain.Contracts.Repositories;

namespace TreinamentoLinq.ApiDados.Setup
{
    public static class InjecaoDependencias
    {
        public static void ConfigurarInjecaoDependencias(this IServiceCollection service)
        {  
            // Repositórios
            service.AddTransient<IBancoRepository, BancoRepository>();
            service.AddTransient<IBandeiraCartaoRepository, BandeiraCartaoRepository>();
            service.AddTransient<IClienteRepository, ClienteRepository>();
            service.AddTransient<IContaFinanceiraRepository, ContaFinanceiraRepository>();
            service.AddTransient<IEmpresaRepository, EmpresaRepository>();
            service.AddTransient<IMeioPagamentoRepository, MeioPagamentoRepository>();
            service.AddTransient<IOperadoraCartaoRepository, OperadoraCartaoRepository>();
            service.AddTransient<IPedidoItemRepository, PedidoItemRepository>();
            service.AddTransient<IPedidoPagamentoRepository, PedidoPagamentoRepository>();
            service.AddTransient<IPedidoRepository, PedidoRepository>();
            service.AddTransient<IProdutoRepository, ProdutoRepository>();
            service.AddTransient<ITaxaBandeiraOperadoraCartaoRepository, TaxaBandeiraOperadoraCartaoRepository>();

            // Automapper
            service.AddSingleton(AutoMapperConfiguration.Configurar().CreateMapper());
        }
    }
}
