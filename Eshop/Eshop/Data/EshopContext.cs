using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Eshop.Models;

namespace Eshop.Data
{
    public class EshopContext : DbContext
    {
        public EshopContext (DbContextOptions<EshopContext> options)
            : base(options)
        {
        }

        public DbSet<Eshop.Models.Account> Account { get; set; }

        public DbSet<Eshop.Models.ProductType> ProductType { get; set; }

        public DbSet<Eshop.Models.Invoice> Invoice { get; set; }

        public DbSet<Eshop.Models.Cart> Cart { get; set; }

        public DbSet<Eshop.Models.InvoiceDetail> InvoiceDetail { get; set; }

        public DbSet<Eshop.Models.Product> Product { get; set; }
    }
}
