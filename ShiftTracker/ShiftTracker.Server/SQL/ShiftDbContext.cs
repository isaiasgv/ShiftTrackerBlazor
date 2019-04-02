using Microsoft.EntityFrameworkCore;
using ShiftTracker.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShiftTracker.Server.SQL
{
    public class ShiftDbContext : DbContext
    {
        
            public ShiftDbContext(DbContextOptions<ShiftDbContext> options)
                : base(options)
            { }

            public DbSet<Shift> Shifts { get; set; }
           
        
    }
}
