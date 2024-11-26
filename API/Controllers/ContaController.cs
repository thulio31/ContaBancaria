using ContaBancaria;
using Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaController : ControllerBase
    {
        private readonly IContaService _service;
        public ContaController(IConfiguration config, IContaService service)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = service;
        }
        [HttpPost("adicionar-Conta")]
        public void AdicionarCarro(Conta cont)
        {
            _service.Adicionar(cont);
        }
        [HttpGet("listar-Conta")]
        public List<Conta> ListarCarro()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Conta")]
        public void EditarCarro(Conta c)
        {
            _service.Editar(c);
        }
        [HttpDelete("deletar-Conta")]
        public void DeletarCarro(int id)
        {
            _service.Remover(id);
        }
    }
}
