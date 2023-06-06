using System.Threading.Tasks;
using LAB.Configuration.Dto;

namespace LAB.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
