using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TreinamentoLinq.ApiDados.ViewModels.RetornoPadrao;

namespace TreinamentoLinq.ApiDados.Controllers.Base
{
    public abstract class ApiControllerBase : ControllerBase
    { 
        private readonly string MENSAGEM_SUCESSO = "Processamento realizado com sucesso";
        private readonly string MENSAGEM_ERRO = "Erro no processamento";

        protected readonly IMapper _mapper;

        public ApiControllerBase(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public ModelPadrao TryExecute(TFuncModelPadrao func)
        {
            try
            {
                return func();
            }
            catch (System.Exception ex)
            {
                return new ModelPadrao
                {
                    Sucesso = false,
                    Mensagens = $"Erro ao executar: {ex.Message}"
                };
            }
        }
        public ModelService<TViewModel> TryExecute<TViewModel>(TFuncModel<TViewModel> func) where TViewModel : class
        {
            try
            {
                return func();
            }
            catch (System.Exception ex)
            {
                return new ModelService<TViewModel>
                {
                    Sucesso = false,
                    Mensagens = $"Erro ao executar: {ex.Message}",
                    Model = null
                };
            }
        }
        public ModelTable<TViewModel> TryExecute<TViewModel>(TFuncTable<TViewModel> func) where TViewModel : class
        {
            try
            {
                return func();
            }
            catch (System.Exception ex)
            {
                return new ModelTable<TViewModel>
                {
                    Sucesso = false,
                    Mensagens = $"Erro ao executar: {ex.Message}"
                };
            }
        }

        public ModelService<TViewModel> Ok<TViewModel>(TViewModel resultMap) where TViewModel : class
        {
            return new ModelService<TViewModel>
            {
                Sucesso = true,
                Mensagens = MENSAGEM_SUCESSO,
                Model = resultMap
            };
        }
        public ModelTable<TViewModel> Ok<TViewModel>(IEnumerable<TViewModel> resultMap) where TViewModel : class
        {
            return new ModelTable<TViewModel>
            {
                Sucesso = true,
                Mensagens = MENSAGEM_SUCESSO,
                Table = resultMap
            };
        }
        public ModelPadrao Ok(bool sucesso)
        {
            return new ModelPadrao
            {
                Sucesso = sucesso,
                Mensagens = sucesso ? MENSAGEM_SUCESSO : MENSAGEM_ERRO
            };
        }
    }

    public delegate ModelTable<TViewModel> TFuncTable<TViewModel>() where TViewModel : class;
    public delegate ModelService<TViewModel> TFuncModel<TViewModel>() where TViewModel : class;
    public delegate ModelPadrao TFuncModelPadrao();
}
