using FastPagamentos.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPagamentos.Data.Mappings
{
    public class ClientMapping : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("200");

            builder.Property(c => c.CPF)
                .IsRequired()
                .HasColumnType("14");

            builder.Property(c => c.Conta)
                .IsRequired()
                .HasColumnType("14");

            builder.Property(c => c.Banco)
                .IsRequired()
                .HasColumnType("60");

            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnType("256");

            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnType("256");

            // 1 : N => Client : Checkouts
            builder.HasMany(c => c.Checkouts)
                .WithOne(ck => ck.buyer_info)
                .HasForeignKey(c => c.buyer_info_id);

            builder.ToTable("Client"); //definindo o nome da tabela
        }
    }
}
