using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace api1.Data
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class ContextFactory : IDesignTimeDbContextFactory<FilmeContext>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public FilmeContext CreateDbContext(string[] args)
        {
            #region [ Usado apenas para modelar a base com o Migration do EntityFramework ] 



            var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));

            var optionsBuilder = new DbContextOptionsBuilder<FilmeContext>();

            optionsBuilder.UseMySql(DbConnection.ConnectionString, serverVersion,
                       providerOptions => providerOptions.EnableRetryOnFailure());

            #endregion [ Usado apenas para modelar a base com o Migration do EntityFramework ] 

            return new FilmeContext(optionsBuilder.Options);
        }
    }
}
