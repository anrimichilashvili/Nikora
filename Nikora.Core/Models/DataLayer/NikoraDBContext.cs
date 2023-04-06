using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Nikora.Core.Models.DataLayer
{
    public class NikoraDBContext : DbContext
    {
        public NikoraDBContext() 
        {

        }
        public NikoraDBContext(DbContextOptions<NikoraDBContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    ConfigurationManager.ConnectionStrings["NikoraDB"].ConnectionString);
            }
        }
        public virtual DbSet<UserModel> UserModels { get; set; }
        public virtual DbSet<ScaleModel> ScaleModels { get; set; }
    }
}