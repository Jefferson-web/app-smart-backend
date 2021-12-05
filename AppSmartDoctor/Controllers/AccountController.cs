using AppSmartDoctor.DataAccess;
using AppSmartDoctor.Interfaces;
using AppSmartDoctor.Models;
using AppSmartDoctor.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {

        private readonly ITokenService _tokenService;

        public AccountController(ITokenService tokenService)
        {
            _tokenService = tokenService ?? throw new ArgumentNullException(nameof(tokenService));
        }

        [HttpPost("Login")]
        public ActionResult<UsuarioLoginResponse> Login(LoginDTO loginDto) {
            DataContext ctx = new DataContext();

            var paciente = ctx.Pacientes.FirstOrDefault(p => p.email == loginDto.email);
            
            if (paciente == null) {
                return Unauthorized("Credenciales invalidas.");
            }

            if (paciente.contrasena != loginDto.contrasena) {
                return Unauthorized("Credenciales invalidas.");
            }
            
            string jwt_token = _tokenService.CreateToken(paciente);
            return new UsuarioLoginResponse()
            {
                paciente = paciente,
                token = jwt_token
            };
        }
    }
}
