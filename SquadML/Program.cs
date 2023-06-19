using Squad.ML.Application.Data;

namespace Squad.ML
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSqlite<SquadAIDbContext>("DataSource=SquadAIDb.db");

            //builder.Services.AddAuthentication()
            //    .AddJwtBearer(options =>
            //    {
            //        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
            //        {
            //            ValidateIssuer = true,
            //            ValidIssuer = AuthOptions.ISSUER,
            //            ValidateAudience = true,
            //            ValidAudience = AuthOptions.AUDIENCE,
            //            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
            //            ValidateIssuerSigningKey = true
            //        };
            //    });

            var app = builder.Build();

            app.CreateDbIfNotExists();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();


            app.MapControllers();

            app.Run();
        }
    }
}