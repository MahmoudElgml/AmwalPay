using AmwalPay.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmwalPay.DAL.Context
{
    public interface IAmwalPayDbContext
    {
        public DbSet<Transaction> Transaction { get; set; }

    }
}
