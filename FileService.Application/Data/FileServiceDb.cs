using FileService.Application.Extensions;
using Microsoft.EntityFrameworkCore;
using File = FileService.Infrastructure.Models.File;

namespace FileService.Application.Data
{
    public class FileServiceDb : DbContext
    {
        
        private readonly IConfiguration configuration;


        public FileServiceDb(
            DbContextOptions<FileServiceDb> options,
            IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(configuration.GetValue<string>("Database:SchemaName"));
            modelBuilder.ConvertNamesToSnakeCase();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<File> Files { get; set; } 
    }
}
