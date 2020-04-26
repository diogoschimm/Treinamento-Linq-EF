using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TreinamentoLinq.ApiDados.Controllers.Base;
using TreinamentoLinq.ApiDados.ViewModels;
using TreinamentoLinq.ApiDados.ViewModels.RetornoPadrao;
using TreinamentoLinq.Domain;
using TreinamentoLinq.Domain.Contracts.Repositories;

namespace TreinamentoLinq.ApiDados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BancoController : ApiControllerBase
    {
        private readonly IBancoRepository _bancoRepository;
        public BancoController(IBancoRepository bancoRepository, IMapper mapper) : base(mapper)
        {
            this._bancoRepository = bancoRepository;
        }

        [HttpGet]
        public ModelTable<BancoViewModel> GetAll()
        {
            return TryExecute(() =>
            {
                var result = this._bancoRepository.GetAll();
                var resultMap = this._mapper.Map<IEnumerable<BancoViewModel>>(result);

                return Ok(resultMap);
            });
        }

        [HttpGet("{codigoBanco}")]
        public ModelService<BancoViewModel> Get([FromRoute]string codigoBanco)
        {
            return TryExecute(() =>
            {
                var banco = this._bancoRepository.Get(codigoBanco);
                if (banco == null)
                    throw new Exception($"Banco {codigoBanco} não localizado");

                var resultMap = this._mapper.Map<BancoViewModel>(banco);

                return Ok(resultMap);
            });
        }

        [HttpPost]
        public ModelService<BancoViewModel> Post([FromBody]BancoViewModel model)
        {
            return TryExecute(() =>
            {
                var banco = this._bancoRepository.Get(model.CodigoBanco);
                if (banco != null)
                    throw new Exception($"Banco {model.CodigoBanco} já existe");

                var resultMap = this._mapper.Map<Banco>(model);
                this._bancoRepository.Save(resultMap);

                return Ok(model);
            });
        }

        [HttpPut("{codigoBanco}")]
        public ModelService<BancoViewModel> Put([FromRoute]string codigoBanco, [FromBody]BancoViewModel model)
        {
            return TryExecute(() =>
            {
                var banco = this._bancoRepository.Get(codigoBanco);
                if (banco == null)
                    throw new Exception($"Banco {codigoBanco} não localizado");

                model.CodigoBanco = codigoBanco;

                var result = this._mapper.Map<Banco>(model);
                this._bancoRepository.Update(result);

                return Ok(model);
            });
        }

        [HttpDelete("{codigoBanco}")]
        public ModelPadrao Delete([FromRoute]string codigoBanco)
        {
            return TryExecute(() =>
            {
                var banco = this._bancoRepository.Get(codigoBanco);
                if (banco == null)
                    throw new Exception($"Banco {codigoBanco} não localizado");

                var result = this._bancoRepository.Delete(banco);

                return Ok(result);
            });
        }
    }
}