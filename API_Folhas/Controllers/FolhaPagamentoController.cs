using System.Collections.Generic;
using System.Linq;
using API_Folhas.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Folhas.Controllers
{
    [ApiController]
    [Route("api/folha")]
    public class FolhaController : ControllerBase
    {
        private readonly DataContext _context;

        public FolhaController(DataContext context) => _context = context;

        public static List<FolhaPagamento> folhaPagamento = new List<FolhaPagamento>();

        [Route("listar")]
        [HttpGet]
        public IActionResult Listar() =>
            Ok(_context.Folhas.ToList());

        [Route("cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar([FromBody] FolhaPagamento folhaPagamento)
        {
            _context.Folhas.Add(folhaPagamento);
            _context.SaveChanges();
            return Created("", folhaPagamento);
        }

        [Route("buscar/{cpf}/{mes}/{ano}")]
        [HttpGet]
        public IActionResult Buscar([FromBody] string cpf, string mes, string ano)
        {
            FolhaPagamento folha = _context.Folhas.FirstOrDefault(
                f => f.Cpf.Equals(cpf));
            return folha != null ? Ok(folhaPagamento) : NotFound();

        }

        [Route("buscar/{mes}/{ano}")]
        [HttpGet]
        public IActionResult Filtrar([FromBody] string mes, string ano)
        {
            FolhaPagamento folha = _context.Folhas.FirstOrDefault(
                f => f.Mes.Equals(mes));
            return folha != null ? Ok(folhaPagamento) : NotFound();
        
        }




    }
}