using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseProjectile : MonoBehaviour
{

    public float damage;
    public float speed = 2;
    public GameObject target;

    //public abstract void enemyHit(); - should contai dealDamage
    public void dealDamage()
    {
        Debug.Log("Damage was dealt");
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == 8)
        {
            dealDamage();
            //enemyHit();
        }
    }

    public void Homing()
    {
        Vector3 direction = (target.transform.position - transform.position) / (target.transform.position - transform.position).magnitude;
        transform.Translate(direction * speed);
    }

    public void FixedUpdate()
    {
        Homing();
    }
}
