using AmwalPay.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmwalPay.DAL.Context
{
    public class AmwalPayDbContext : IdentityDbContext<Client>, IAmwalPayDbContext
    {

        public AmwalPayDbContext(DbContextOptions<AmwalPayDbContext> options) : base(options)
        {

        }
       public DbSet<Transaction> Transaction { get; set; }
        
    }
}
