using HarmonyLib;
using UnityEngine;

class ExampleMod : GameModification
{
    Harmony _harmony;

    public ExampleMod(Mod p_mod) : base(p_mod)
    {
        Debug.Log($"Registering mod: {p_mod.name}");
    }

    public override void OnModInitialization(Mod p_mod)
    {
        Debug.Log($"Initializing mod: {p_mod.name}");

        mod = p_mod;

        PatchGame();
    }

    public override void OnModUnloaded()
    {
        Debug.Log($"Unloading mod: {mod.name}");

        _harmony?.UnpatchAll(_harmony.Id);
    }

    void PatchGame()
    {
        Debug.Log($"Applying patch from mod: {mod.name}");

        _harmony = new Harmony("com.hexofsteel." + mod.name);
        _harmony.PatchAll();
    }

    [HarmonyPatch(typeof(Unit), nameof(Unit.GetUnitName))]
    static class ExamplePatch1
    {
        [HarmonyPostfix]
        static void GetNamePostfix(Unit __instance, ref string __result)
        {
            if (__instance.Type == "Tank")
            {
                __result = "I'm a tank!";
            }
            else if (__instance.Type == "Plane")
            {
                __result = "I'm a plane!";
            }
            else __result = "I'm something else!";
        }
    }
}