using HarmonyLib;
using UnityEngine;

class ExampleMod : GameModification
{
    Harmony _harmony;

    public ExampleMod(Mod p_mod) : base(p_mod)
    {
        Debug.Log($"[MOD:{p_mod.name}] Registering...");
    }

    public override void OnModInitialization(Mod p_mod)
    {
        Debug.Log($"[MOD:{p_mod.name}] Initializing...");

        mod = p_mod;

        PatchGame();
    }

    public override void OnModUnloaded()
    {
        Debug.Log($"[MOD:{mod.name}] Unloading...");

        _harmony?.UnpatchAll(_harmony.Id);
    }

    void PatchGame()
    {
        Debug.Log($"[MOD:{mod.name}] Applying Patches...");

        _harmony = new Harmony("com.hexofsteel." + mod.name);
        _harmony.PatchAll();
    }
}