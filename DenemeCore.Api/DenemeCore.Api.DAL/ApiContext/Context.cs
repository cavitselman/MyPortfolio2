using DenemeCore.Api.DenemeCore.Api.DAL.ApiEntity;
using Microsoft.EntityFrameworkCore;

namespace DenemeCore.Api.DenemeCore.Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.\\SQLEXPRESS; Database = DenemeCore2; Trusted_Connection = SSPI; Encrypt = true; TrustServerCertificate = true");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
