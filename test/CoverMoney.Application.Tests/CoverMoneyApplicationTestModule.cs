using Volo.Abp.Modularity;

namespace CoverMoney;

[DependsOn(
    typeof(CoverMoneyApplicationModule),
    typeof(CoverMoneyDomainTestModule)
    )]
public class CoverMoneyApplicationTestModule : AbpModule
{

}
