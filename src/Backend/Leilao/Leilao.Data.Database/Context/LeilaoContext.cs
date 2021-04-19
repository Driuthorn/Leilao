using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leilao.Data.Database.Context
{
    public class LeilaoContext : DbContext
    {
        public LeilaoContext(DbContextOptions<LeilaoContext> options) : base(options)
        { }

        public LeilaoContext()
        { }
    }
}
