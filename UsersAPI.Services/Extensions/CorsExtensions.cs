namespace UsersAPI.Services.Extensions
{
    public static class CorsExtensions
    {
        private static string _policyName = "DefaultPolicy";
        public static void AddCorsPolicy(this IServiceCollection services)
        {
            services.AddCors(s => s.AddPolicy(_policyName, builder =>
            {
                builder.AllowAnyOrigin() //qualquer dominio
                        .AllowAnyMethod() //qualquer metodo (post, put, delete, get etc)
                        .AllowAnyHeader(); // qualquer parametro de cabeçaho de requisição pode ser enviado
            }));
        }

        public static void UseCorsPolicy(this IApplicationBuilder app)
        {
            app.UseCors(_policyName);
        }
    }
}
