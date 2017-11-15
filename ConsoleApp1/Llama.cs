using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public class Llama
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class LlamaContext : DbContext
    {
        public LlamaContext() : base()
        {

        }

        public DbSet<Llama> Llamas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=LlamaDb;port=3306;User Id=root;Password=spok2017;");
        }
    }



}
