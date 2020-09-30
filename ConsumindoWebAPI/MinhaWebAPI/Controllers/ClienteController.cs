using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaWebAPI.Models;
using MinhaWebAPI.Util;

namespace MinhaWebAPI.Controllers
{
    // Rota api/cliente
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        Autenticacao AutenticacaoServico;

        public ClienteController(IHttpContextAccessor context)
        {
            AutenticacaoServico = new Autenticacao(context);
        }

        // GET api/cliente/listagem
        [HttpGet]
        [Route("listagem")]
        public ActionResult<List<ClienteModel>> Listagem()
        {
            // Instancia o objeto e chama o método.
            return new ClienteModel().Listagem();
        }

        // GET api/cliente/cliente/id
        [HttpGet]
        [Route("cliente/{id}")]
        public ClienteModel RetornarCliente(int id)
        {
            // Instancia o objeto e chama o método.
            return new ClienteModel().RetornarCliente(id);
        }

        // POST api/cliente/registrarcliente
        [HttpPost]
        [Route("registrarcliente")]
        public ReturnAllServices RegistrarCliente([FromBody]ClienteModel dados)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                dados.RegistrarCliente();
                retorno.Result = true;
                retorno.ErrorMessage = string.Empty;
            }
            catch(Exception e)
            {
                retorno.Result = false;
                retorno.ErrorMessage = "Erro ao tentar registrar um cliente. " + e.Message;
            }
            return retorno;
        }

        // PUT api/cliente/atualizar/id
        [HttpPut]
        [Route("atualizar/{id}")]
        public ReturnAllServices Atualizar(int id, [FromBody]ClienteModel dados)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                // Atribui à propiedade ID do objeto dados o id requisitado.
                dados.Id = id;
                dados.AtualizarCliente();
                retorno.Result = true;
                retorno.ErrorMessage = string.Empty;
            }
            catch (Exception e)
            {
                retorno.Result = false;
                retorno.ErrorMessage = "Erro ao tentar atualizar um cliente. " + e.Message;
            }
            return retorno;
        }

        // DELETE api/cliente/excluir/id
        [HttpDelete]
        [Route("excluir/{id}")]
        public ReturnAllServices Excluir(int id)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                retorno.Result = true;
                retorno.ErrorMessage = "Cliente excluído com sucesso!";
                AutenticacaoServico.Autenticar();
                new ClienteModel().Excluir(id);

            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = ex.Message;
            }
            return retorno;
        }
    }
}
