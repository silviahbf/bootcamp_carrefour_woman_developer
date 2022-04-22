using curso.api.Business.Entities;
using curso.api.Business.Repositories;
using curso.api.Configurations;
using curso.api.Filters;
using curso.api.Infraestructure.Data;
using curso.api.Models;
using curso.api.Models.Usuarios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;

namespace curso.api.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        //private readonly IConfiguration _configuration;
        private readonly IAuthenticationService _authenticationService;
        public UsuarioController(
            IUsuarioRepository usuarioRepository,
            //IConfiguration configuration,
            IAuthenticationService authenticationService)
        {
            _usuarioRepository = usuarioRepository;
            //_configuration = configuration;
            _authenticationService = authenticationService;
        }
        /// <summary>
        /// Este serviço permite autenticar um usuário cadastrado e ativo.
        /// </summary>
        /// /// <param name="LoginViewModelInput">View model do login</param>
        /// <returns>Retorna status ok, dados do usuário e o token em caso de sucesso.</returns>
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Campos obrigatórios", Type = typeof(ValidaCampoViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Erro interno", Type = typeof(ErroGenericoViewModel))]
        [HttpPost]
        [Route("logar")]
        [ValidacaoModelStateCustomizado]

        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            var usuario = _usuarioRepository.ObterUsuario(loginViewModelInput.Login);
            
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(new ValidaCampoViewModelOutput(ModelState.SelectMany(sm => sm.Value.Errors).Select(s => s.ErrorMessage)));
            //}
            //else return Ok(loginViewModelInput);

            if (usuario == null)
            {
            return BadRequest("Houve um erro ao tentar acessar.");
            }

            //var usuarioViewModelOutput = new UsuarioViewModelOutput()
            //{
            //    Codigo = 1,
            //    Login = "silviahbf",
            //    Email = "silviahbf@email.com"
            //};

            var usuarioViewModelOutput = new UsuarioViewModelOutput()
            {
                Codigo = usuario.Codigo,
                Login = loginViewModelInput.Login,
                Email = usuario.Email
            };

            //var secret = Encoding.ASCII.GetBytes(_configuration.GetSection("JwtConfigurations:Secret").Value);
            //var symmetricSecurityKey = new SymmetricSecurityKey(secret);
            //var securityTokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = new ClaimsIdentity(new Claim[]
            //    {
            //        new Claim(ClaimTypes.NameIdentifier, usuarioViewModelOutput.Codigo.ToString()),
            //        new Claim(ClaimTypes.Name, usuarioViewModelOutput.Login.ToString()),
            //        new Claim(ClaimTypes.Email, usuarioViewModelOutput.Email.ToString()),
            //    }),
            //    Expires = DateTime.UtcNow.AddDays(1),
            //    SigningCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature)
            //};
            //var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            //var tokenGenerated = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
            //var token = jwtSecurityTokenHandler.WriteToken(tokenGenerated);

            var token = _authenticationService.GerarToken(usuarioViewModelOutput);
        }

        /// <summary>
        /// Este serviço permite autenticar um usuário cadastrado e ativo.
        /// </summary>
        /// <param name="LoginViewModelInput">View model do login</param>
        /// <returns>Retorna status ok, dados do usuário e o token em caso de sucesso.</returns>
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Campos obrigatórios", Type = typeof(ValidaCampoViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Erro interno", Type = typeof(ErroGenericoViewModel))]
        [HttpPost]
        [Route("registrar")]
        [ValidacaoModelStateCustomizado]
        public IActionResult Registrar(RegistroViewModelInput loginViewModelInput, DbContextOptionsBuilder<CursoDbContext> options)
        {
            //var optionsBuilder = new DbContextOptionsBuilder<CursoDbContext>();
            //optionsBuilder.UseSqlServer("Server=localhost;Database=CURSO;user=sa;password=App@223020");
            //CursoDbContext contexto = new CursoDbContext(optionsBuilder.Options);

            //var migracoesPendentes = contexto.Database.GetPendingMigrations();
            //if (migracoesPendentes.Count() > 0)
            //{
            //    contexto.Database.Migrate();
            //}

            var usuario = new Usuario();
            usuario.Login = loginViewModelInput.Login;
            usuario.Senha = loginViewModelInput.Senha;
            usuario.Email = loginViewModelInput.Email;
            //contexto.Usuario.Add(usuario);
            //contexto.SaveChanges();
            _usuarioRepository.Adicionar(usuario);
            _usuarioRepository.Commit();
                        
            return Created("", loginViewModelInput);
        }
    }
}
