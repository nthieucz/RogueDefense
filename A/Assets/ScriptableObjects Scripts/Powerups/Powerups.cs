using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Powerups : ScriptableObject
{
    public Rarity rarity;
    public abstract void Apply(GameObject Turret);
    public enum Rarity
    {
        COMMON,
        UNCOMMON,
        RARE
    }
}
