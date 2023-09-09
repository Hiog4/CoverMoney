using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CoverMoney.Data;

/* This is used if database provider does't define
 * ICoverMoneyDbSchemaMigrator implementation.
 */
public class NullCoverMoneyDbSchemaMigrator : ICoverMoneyDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
