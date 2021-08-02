using EntityLibrary.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


/**
* @author udhayakumar_m
*
* @date - 7/21/2021 6:32:37 PM 
*/

namespace EntityLibrary.RepositoryContext
{
    public class AccessRepositoryDbContext : DbContext
    {
        public AccessRepositoryDbContext()
        {
        }

        public AccessRepositoryDbContext(DbContextOptions<AccessRepositoryDbContext> options) : base(options)
        {
        }


        public DbSet<CountryMaster> CountryMaster { get; set; }
        public DbSet<LanguageMaster> LanguageMaster { get; set; }
        public DbSet<PageMaster> PageMaster { get; set; }
        public DbSet<SectionMaster> SectionMaster { get; set; }
        public DbSet<Elements> Elements { get; set; }
        public DbSet<TablesRepository> TablesRepository { get; set; }
        public DbSet<FieldsRepository> FieldsRepository { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer($"Server=CHL129428;User Id=access;Password=Access@123;Database=AccessRepositoryDB");
            }
        }
    }
}
