using Volo.Abp.Settings;

namespace Acme.StudentOnBoardingAbp.Settings;

public class StudentOnBoardingAbpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(StudentOnBoardingAbpSettings.MySetting1));
    }
}
