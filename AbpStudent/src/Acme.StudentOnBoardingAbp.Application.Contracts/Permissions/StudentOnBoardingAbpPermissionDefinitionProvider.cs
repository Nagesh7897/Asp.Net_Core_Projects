using Acme.StudentOnBoardingAbp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.StudentOnBoardingAbp.Permissions;

public class StudentOnBoardingAbpPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StudentOnBoardingAbpPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(StudentOnBoardingAbpPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StudentOnBoardingAbpResource>(name);
    }
}
