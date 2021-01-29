using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleSiteMSI.Models;

namespace SimpleSiteMSI.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<SimpleSiteMSI.Models.Team> Team { get; set; }
    }
}
