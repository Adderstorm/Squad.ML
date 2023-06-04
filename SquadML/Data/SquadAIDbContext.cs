using Microsoft.EntityFrameworkCore;
using SquadML.Application.Models;
using System.Collections.Generic;

namespace SquadML.Application.Data
{
    public class SquadAIDbContext : DbContext
    {
        public SquadAIDbContext(DbContextOptions<SquadAIDbContext> options) : base(options)
        {
        }

        public DbSet<AIPrep> AIPrep { get; set; }
    }
}
