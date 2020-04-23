using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;
using NoHarmony;
using TaleWorlds.CampaignSystem.SandBox.GameComponents.Map;
using TaleWorlds.CampaignSystem.SandBox.GameComponents;
using TestMod.Models;

namespace TestMod
{
    public class MySubModule : NoHarmonyLoader
    {
        public const string ModuleFolderName = "TestMod";

        public override void NoHarmonyInit()
        {

            LogFile = "NoHarmony.txt";
            LogDateFormat = "dd/MM/yy HH:mm:ss.fff";

        }

        public override void NoHarmonyLoad()
        {
            Module.CurrentModule.AddInitialStateOption(new InitialStateOption("Message", new TextObject("Message", null), 9990, () => {
                InformationManager.DisplayMessage(new InformationMessage("Hello World!"));
            },
                false));

            ReplaceModel<ExampleMapVisiblityModel, DefaultMapVisibilityModel>();

        }
        // Whenever the submodule is loaded (mod) this is loaded.





    }
}
