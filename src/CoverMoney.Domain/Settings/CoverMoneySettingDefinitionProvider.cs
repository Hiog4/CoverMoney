using Volo.Abp.Settings;

namespace CoverMoney.Settings;

public class CoverMoneySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CoverMoneySettings.MySetting1));
    }
}
