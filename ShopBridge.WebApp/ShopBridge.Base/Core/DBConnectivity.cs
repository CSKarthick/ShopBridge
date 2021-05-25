using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ShopBridge.Base.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Base.Core
{
    public class DBConnectivity : DbContext
    {
        protected readonly IConfiguration _configuration;
        private readonly ILoggerFactory _loggerFactory;
        public DBConnectivity(IConfiguration configuration, ILoggerFactory loggerFactory)
        {
            _configuration = configuration;
            _loggerFactory = loggerFactory;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder contextOptionsBuilder)
        {
            contextOptionsBuilder.UseSqlServer(_configuration["SqlServerConnectionString"])
                                .UseLoggerFactory(this._loggerFactory);
#if DEBUG
            contextOptionsBuilder.EnableSensitiveDataLogging();
#endif
        }

        public DbSet<Product> Product { get; set; }
    }
}
