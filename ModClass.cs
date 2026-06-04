using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace UnderSong;

[BepInPlugin("com.silksong.undersong", "UnderSong", "0.0.0")]
public class ModClass: BaseUnityPlugin
{
    public void Awake()
    {
        var harmony = new Harmony("com.silksong.undersong");
        harmony.PatchAll();
    }
}
