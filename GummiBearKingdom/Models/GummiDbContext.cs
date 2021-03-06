﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GummiBearKingdom.Models
{
    public class GummiDbContext : DbContext
    {
        public GummiDbContext()
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=gummi_bear_kingdom;uid=root;pwd=root;");
        }

            public GummiDbContext(DbContextOptions<GummiDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().ToTable("Products");
            base.OnModelCreating(builder);
        }
    }
}
