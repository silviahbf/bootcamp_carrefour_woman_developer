using curso.api.Business.Entities;
using curso.api.Business.Repositories;
using curso.api.Models;
using curso.api.Models.Curso;
using curso.api.Models.Usuarios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace curso.api.Controllers
{
    [Route("api/v1/cursos")]
    [ApiController]
    [Authorize]
    public class CursoController : ControllerBase
    {
        private readonly ICursoRepository _cursoRepository;

        public CursoController(ICursoRepository cursoRepositorio)
        {
            _cursoRepository = cursoRepositorio;
        }

        /// <summary>
        /// Este serviço permite cadastrar curso para o usuário autenticado.
        /// </summary>
        /// <returns>Retorna status ok e dados do curso do usuário</returns>
        [SwaggerResponse(statusCode: 201, description: "Sucesso ao autenticar", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 401, description: "Campos obrigatórios", Type = typeof(ValidaCampoViewModelOutput))]
        [HttpPost]
        [Route("")]

        public async Task<IActionResult> Post(CursoViewModelInput cursoViewModelInput)
        {
            Curso curso = new Curso();
            curso.Nome = cursoViewModelInput.Nome;
            curso.Descricao = cursoViewModelInput.Descricao;
            var codigoUsuario = int.Parse(User.FindFirst(d => d.Type == ClaimTypes.NameIdentifier)?.Value);
            curso.CodigoUsuario = codigoUsuario;
            _cursoRepository.Adicionar(curso);
            _cursoRepository.Commit();
            return Created("", cursoViewModelInput);
        }

        /// <summary>
        /// Este serviço permite obter todos os cursos ativos do usuário.
        /// </summary>
        /// <returns>Retorna status ok e dados do curso do usuário</returns>
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 401, description: "Campos obrigatórios", Type = typeof(ValidaCampoViewModelOutput))]
        [HttpGet]
        [Route("")]

        public async Task<IActionResult> Get()
        {
            var codigoUsuario = int.Parse(User.FindFirst(d => d.Type == ClaimTypes.NameIdentifier)?.Value);
            //var cursos = new List<CursoViewModelOutput>();
            var cursos = _cursoRepository.ObterPorUsuario(codigoUsuario)
                .Select(s => new CursoViewModelOutput()
                {
                    Nome = s.Nome,
                    Descricao = s.Descricao,
                });
            //var codigoUsuario = int.Parse(User.FindFirst(d => d.Type == ClaimTypes.NameIdentifier)?.Value);

                //cursos.Add(new CursoViewModelOutput()
                //{
                //    Nome = "teste",
                //    Descricao = "teste"
                //});

            return Ok(cursos);
        }
    }
}
