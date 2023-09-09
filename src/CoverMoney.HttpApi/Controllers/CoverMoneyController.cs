using CoverMoney.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CoverMoney.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CoverMoneyController : AbpControllerBase
{
    protected CoverMoneyController()
    {
        LocalizationResource = typeof(CoverMoneyResource);
    }
}
