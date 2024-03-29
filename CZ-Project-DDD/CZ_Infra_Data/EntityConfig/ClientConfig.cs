﻿
using CZ.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace CZ.Infra.Data.EntityConfig
{
    public class ClientConfiguration: EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.FirstName).IsRequired().HasMaxLength(100);
            Property(c => c.LastName).IsRequired().HasMaxLength(100);
            Property(c => c.Email).IsRequired();
            
        }
    }
}
