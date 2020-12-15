using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public Enemy enemy;
    private int maxHealth;
    private float movespeed;


    public int health;

    private void Start()
    {
        maxHealth = enemy.baseMaxHp;
        health = maxHealth;
        movespeed = enemy.movespeed;
        gameObject.GetComponent<SpriteRenderer>().sprite = enemy.sprite;
    }



}
