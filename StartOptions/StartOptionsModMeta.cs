using UnityEngine;
using UnityEngine.UI;

namespace StartOptions
{
    internal class StartOptionsModMeta : ModMeta
    {
        public override void ConstructOptionsScreen(RectTransform parent, bool inGame)
        {
            Text text = WindowManager.SpawnLabel();
            text.text = "Created by DNA\n\nAllows for wider modification of starting conditions.";
            WindowManager.AddElementToElement(text.gameObject, parent.gameObject, new Rect(0f, 0f, 400f, 128f),
                new Rect(0f, 0f, 0f, 0f));
        }

        public override string Name => "More Starting Options";
    }
}