﻿using System.Collections.Generic;
using System.Linq;
using Harmony;

namespace StartOptions.Patches
{
    [HarmonyPatch(typeof(MarketSimulation))]
    [HarmonyPatch("GenerateCompany")]
    internal class MarketSimulationGenerateCompanyPatch
    {
        [HarmonyTranspiler]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codes = new List<CodeInstruction>(instructions);
            Util.OverwriteDifficultyMapRanges(codes);
            return codes.AsEnumerable();
        }
    }
}