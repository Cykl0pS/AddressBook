using AddressBuch.Contracts.Persistence.AddressBuecher;
using AddressBuch.Logic.Entities.AddressBuecher;
using Microsoft.EntityFrameworkCore;

namespace AddressBuch.Logic.DataContext
{
    partial class ProjectDbContext
    {
        DbSet<AddressBook> AddressBooks { get; set; }

        partial void GetDbSet<C, E>(ref DbSet<E> dbset) where E : class
        {
            if (typeof(C) == typeof(IAddressBook))
            {
                dbset = AddressBooks as DbSet<E>;
            }
        }

        partial void BeforeOnModelCreating(ModelBuilder modelBuilder, ref bool handled)
        {
            var addressBookBuilder = modelBuilder.Entity<AddressBook>();

            addressBookBuilder.HasKey(p => p.Id);
            addressBookBuilder.Property(p => p.RowVersion).IsRowVersion();
            addressBookBuilder.Property(p => p.Name).IsRequired().HasMaxLength(128);
            addressBookBuilder.Property(p => p.PostalCode).IsRequired();
            addressBookBuilder.Property(p => p.City).IsRequired().HasMaxLength(128);
            addressBookBuilder.Property(p => p.Address).IsRequired().HasMaxLength(256);
        }
    }
}
