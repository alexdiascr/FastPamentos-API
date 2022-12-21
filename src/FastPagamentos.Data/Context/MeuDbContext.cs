using FastPagamentos.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace FastPagamentos.Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<payment_order> payment_orderss { get; set; }
        public DbSet<seller_info> seller_infos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurando para registrar cada mapping criado, de uma vez só, é feito via reflection
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);

            //Impendindo que uma classe que está sendo representando em uma tabela do banco ao ser excluido
            //um item da mesma 
            //evite de levar os filhos juntos
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
