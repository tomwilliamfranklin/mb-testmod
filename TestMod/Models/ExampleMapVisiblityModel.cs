using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.GameComponents.Map;

namespace TestMod.Models
{
    class ExampleMapVisiblityModel : DefaultMapVisibilityModel
    {
        public override float GetPartySpottingRange(MobileParty party, StatExplainer explainer)
        {
            return 100f;
        }
    }
}
