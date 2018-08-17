using System.Collections.Generic;
using System.Linq;
using Harmony;

namespace StartOptions
{
    [HarmonyPatch(typeof(MarketingPlan))]
    [HarmonyPatch("GetHypeFactor")]
    internal class MarketingPlanGetHypeFactorPatch
    {
        [HarmonyTranspiler]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codes = new List<CodeInstruction>(instructions);
            Util.OverwriteDifficultyMapRanges(codes,48,8);
            return codes.AsEnumerable();
        }
    }
}