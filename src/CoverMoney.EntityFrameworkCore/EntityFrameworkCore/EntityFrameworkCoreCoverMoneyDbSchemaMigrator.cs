using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CoverMoney.Data;
using Volo.Abp.DependencyInjection;

namespace CoverMoney.EntityFrameworkCore;

public class EntityFrameworkCoreCoverMoneyDbSchemaMigrator
    : ICoverMoneyDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCoverMoneyDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the CoverMoneyDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CoverMoneyDbContext>()
            .Database
            .MigrateAsync();
    }
}
