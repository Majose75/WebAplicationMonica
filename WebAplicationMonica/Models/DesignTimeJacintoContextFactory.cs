﻿using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace WebAplicationMonica.Models
{
    public class DesignTimeJacintoContextFactory : IDesignTimeDbContextFactory<JacintoContext>
    {
        public JacintoContext CreateDbContext(string[] args)
        {
            var dbContextBuilder = new DbContextOptionsBuilder<JacintoContext>();

            // this connection string is for local SQL database 
            // This database instance is generally installed with default Visual Studio components
            // If you use SQL Server Express, change connection string appropriately
            // NOTE: Do not hardcode connection strings in code.  
            // This is hard coded here to limit scope of demo.
            var connectionString = "Server=tcp:servidormonicasql.database.windows.net,1433;Initial Catalog=MonicaSQL;Persist Security Info=False;User ID=jacinto;Password=P0t@toP0t@to;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University; Integrated Security=True;";

            dbContextBuilder.UseSqlServer(connectionString);
            return new JacintoContext(dbContextBuilder.Options);
        }
    }
}
