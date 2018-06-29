using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using Harmony;

namespace StartOptions
{
    internal class Util
    {
        private const float NumDifficulties = 5f;

        private static readonly FieldInfo GameSettingsInstanceFieldInfo =
            AccessTools.Field(typeof(GameSettings), "Instance");

        private static readonly FieldInfo GameDifficultyFieldInfo =
            AccessTools.Field(typeof(GameSettings), "Difficulty");

        private static readonly MethodInfo MapRangeMethodInfo = AccessTools.Method(typeof(Utilities), "MapRange",
            new[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(bool)});

        public static int FindMapRangeDifficultyCall(int start, List<CodeInstruction> codes)
        {
            for (int i = start; i < codes.Count - 7; i++)
                if (codes[i].opcode == OpCodes.Ldsfld &&
                    (FieldInfo) codes[i].operand == GameSettingsInstanceFieldInfo &&
                    codes[i + 1].opcode == OpCodes.Ldfld &&
                    (FieldInfo) codes[i + 1].operand == GameDifficultyFieldInfo &&
                    codes[i + 7].opcode == OpCodes.Call && (MethodInfo) codes[i + 7].operand == MapRangeMethodInfo)
                    return i;

            return -1;
        }

        public static void OverwriteDifficultyMapRanges(List<CodeInstruction> codes)
        {
            int start = 0;
            while (start != -1)
            {
                int pos = FindMapRangeDifficultyCall(start, codes);
                if (pos != -1)
                {
                    codes[pos + 3].operand = NumDifficulties;
                    pos += 7;
                }

                start = pos;
            }
        }
    }
}