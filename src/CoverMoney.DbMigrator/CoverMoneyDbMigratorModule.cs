using CoverMoney.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace CoverMoney.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CoverMoneyEntityFrameworkCoreModule),
    typeof(CoverMoneyApplicationContractsModule)
    )]
public class CoverMoneyDbMigratorModule : AbpModule
{
}
