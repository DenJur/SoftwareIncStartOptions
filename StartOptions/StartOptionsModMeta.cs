using UnityEngine;
using UnityEngine.UI;

namespace StartOptions
{
    internal class StartOptionsModMeta : ModMeta
    {
        public void ConstructOptionsScreen(RectTransform parent, ModBehaviour[] behaviours)
        {
            Text text = WindowManager.SpawnLabel();
            text.text = "Created by DNA\n\nAllows for wider modification of starting conditions.";
            WindowManager.AddElementToElement(text.gameObject, parent.gameObject, new Rect(0f, 0f, 400f, 128f),
                new Rect(0f, 0f, 0f, 0f));
        }

        public string Name => "More Starting Options";
    }
}