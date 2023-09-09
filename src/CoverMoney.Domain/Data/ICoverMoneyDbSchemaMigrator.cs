using System.Threading.Tasks;

namespace CoverMoney.Data;

public interface ICoverMoneyDbSchemaMigrator
{
    Task MigrateAsync();
}
