using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : ScriptableObject
{
    public int maxHealth;
    public int startingMoney;
    public Turret[] turretList;
    public Sprite sprite;

    public float abilityCooldown;





    public abstract void Ability();





}
