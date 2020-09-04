using Microsoft.EntityFrameworkCore;
using MyTip.Shared.MyTipModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTip.Server.DbContexts
{
    public class MyTipDbContext : DbContext
    {
        public MyTipDbContext(DbContextOptions<MyTipDbContext> options) : base(options)
        {

        }
        public DbSet<MyTipHeader> MyTipHeaders { get; set; }
        public DbSet<MyTipDetail> MyTipDetails { get; set; }

    }
}
