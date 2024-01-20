using HarmonyLib;

namespace ScienceUnlock
{
    [HarmonyPatch(typeof(ItemTemplate), nameof(ItemTemplate.onLoad))]
    internal static class ItemTemplate_OnLoad
    {
        static void Postfix(ItemTemplate __instance, bool isCalledFromEditor)
        {
            // not longer in ItemTemplate: __instance.includeInBuild = true;
            __instance.includeInDemo = true;
        }
    }

    [HarmonyPatch(typeof(ResearchTemplate), nameof(ResearchTemplate.onLoad))]
    internal static class ResearchTemplate_OnLoad
    {
        static void Postfix(ResearchTemplate __instance)
        {
            // not longer in ItemTemplate: __instance.includeInBuild = true;
            __instance.includeInDemo = true;
        }
    }
}
