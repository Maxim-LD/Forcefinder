using ForceFinder.Model.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForceFinder.Migration
{
    public class ForceFinderContext : DbContext
    {
        public ForceFinderContext(DbContextOptions<ForceFinderContext> options) : base(options)
        {

        }

        public DbSet<Force> Force { get; set; }
    }
}
