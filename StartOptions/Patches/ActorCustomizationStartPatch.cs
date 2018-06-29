using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Harmony;

namespace StartOptions.Patches
{
    [HarmonyPatch(typeof(ActorCustomization))]
    [HarmonyPatch("Start")]
    internal class ActorCustomizationStartPatch
    {
        private static readonly FieldInfo ActorCustomizationDifficultyFieldInfo =
            AccessTools.Field(typeof(ActorCustomization), "Difficulty");

        private static readonly MethodInfo SetSelectedMethod = AccessTools.Method(typeof(GUICombobox), "set_Selected",
            new[] {typeof(int)});

        [HarmonyTranspiler]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codes = new List<CodeInstruction>(instructions);
            for (int i = 0; i < codes.Count - 3; i++)
                if (codes[i].opcode == OpCodes.Ldarg_0 &&
                    codes[i + 1].opcode == OpCodes.Ldfld &&
                    (FieldInfo) codes[i + 1].operand == ActorCustomizationDifficultyFieldInfo &&
                    codes[i + 3].opcode == OpCodes.Callvirt && (MethodInfo) codes[i + 3].operand == SetSelectedMethod)
                    codes[i + 2] = new CodeInstruction(OpCodes.Ldc_I4, 3);

            return codes.AsEnumerable();
        }
    }
}