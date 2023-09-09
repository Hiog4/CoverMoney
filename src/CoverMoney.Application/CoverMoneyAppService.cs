using System;
using System.Collections.Generic;
using System.Text;
using CoverMoney.Localization;
using Volo.Abp.Application.Services;

namespace CoverMoney;

/* Inherit your application services from this class.
 */
public abstract class CoverMoneyAppService : ApplicationService
{
    protected CoverMoneyAppService()
    {
        LocalizationResource = typeof(CoverMoneyResource);
    }
}
