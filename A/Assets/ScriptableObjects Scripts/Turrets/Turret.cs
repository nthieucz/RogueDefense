using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Turret : ScriptableObject
{
    //Base stats
    public int maxHealth;
    public float baseDamage;
    public float range;
    public float attackspeed;
    public Rarity rarity;

    //add later
    //public int[] ups = [0, 0, 0, 0, 0, 0];

    public Sprite sprite;
    public GameObject Projectile;

    public abstract void Shoot(GameObject shooter, GameObject target, float damage);
    public abstract void Track(GameObject shooter, GameObject target);

    public enum Rarity
    {
        COMMON,
        UNCOMMON,
        RARE
    }


}
