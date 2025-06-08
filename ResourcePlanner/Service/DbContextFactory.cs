using LankaRetail.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcePlanner.Service
{
    public static class DbContextFactory
    {
        private static readonly DbContextOptions<AppDbContext> _options;

        static DbContextFactory()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlite("Data Source=erp.db");
            _options = optionsBuilder.Options;
        }

        public static AppDbContext Create()
        {
            return new AppDbContext(_options);
        }
    }

}
