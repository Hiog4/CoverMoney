using CoverMoney.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CoverMoney;

[DependsOn(
    typeof(CoverMoneyEntityFrameworkCoreTestModule)
    )]
public class CoverMoneyDomainTestModule : AbpModule
{

}
