using AppSmartDoctor.Interfaces;
using AppSmartDoctor.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AppSmartDoctor.Services
{
    public class TokenService : ITokenService
    {

        private readonly IConfiguration _configuration;
        private readonly SymmetricSecurityKey _key;
        public TokenService(IConfiguration configuration) {
            _configuration = configuration;
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Token:Key"]));
        }

        public string CreateToken(Paciente paciente)
        {
            var credentils = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512);

            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, paciente.pacienteId.ToString()),
                new Claim(ClaimTypes.Name, paciente.nombres),
                new Claim(ClaimTypes.Email, paciente.email),
                new Claim("Edad", paciente.edad.ToString())
            };

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(7),
                signingCredentials: credentils
            );

            var jwt_token = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt_token;
        }
    }
}
