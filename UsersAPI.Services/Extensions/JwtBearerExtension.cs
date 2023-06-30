using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace UsersAPI.Services.Extensions
{
    public static class JwtBearerExtension
    {
        public static void AddJwtBearer(this IServiceCollection services)
        {
            services.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(options => {

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true, //validar o emissor
                    ValidateAudience = true, //validar o destinatário
                    ValidateLifetime = true, // validar o tempo de esperição do token
                    ValidateIssuerSigningKey = true, //Validar a chave secreta utilizada pelo emissor do token
                };
            });
        }
    }
}
