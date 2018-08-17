using System.Collections.Generic;
using System.Linq;
using Harmony;

namespace StartOptions
{
    [HarmonyPatch(typeof(Employee))]
    [HarmonyPatch("ChangeSkill")]
    internal class EmployeeChangeSkillPatch
    {
        [HarmonyTranspiler]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codes = new List<CodeInstruction>(instructions);
            Util.OverwriteDifficultyMapRanges(codes,3,0.5f);
            return codes.AsEnumerable();
        }
    }
}