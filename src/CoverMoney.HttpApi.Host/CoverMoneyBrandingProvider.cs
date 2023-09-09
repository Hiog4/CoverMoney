using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CoverMoney;

[Dependency(ReplaceServices = true)]
public class CoverMoneyBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CoverMoney";
}
