using MelonLoader;
using BTD_Mod_Helper;
using unlocker;

[assembly: MelonInfo(typeof(unlocker.unlocker), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace unlocker;

public class unlocker : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<unlocker>("unlocker loaded! yayyyyy!");
    }
}