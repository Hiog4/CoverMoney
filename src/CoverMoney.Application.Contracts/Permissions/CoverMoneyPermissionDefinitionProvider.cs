using CoverMoney.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CoverMoney.Permissions;

public class CoverMoneyPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CoverMoneyPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CoverMoneyPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CoverMoneyResource>(name);
    }
}
