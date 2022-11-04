using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShiftTrackerApi.Models;

namespace ShiftTrackerApi.Data
{
    public class ShiftTrackerApiContext : DbContext
    {
        public ShiftTrackerApiContext (DbContextOptions<ShiftTrackerApiContext> options)
            : base(options)
        {
        }

        public DbSet<ShiftTrackerApi.Models.Shift> Shift { get; set; } = null!;
    }
}
