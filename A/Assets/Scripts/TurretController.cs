using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurretController : MonoBehaviour
{

    public Turret turret;

    public List<GameObject> targets = new List<GameObject>();

    public bool active = false;
    

    public float damage;
    public float range;

    public CircleCollider2D proximityCollider;
    public GameObject child;

    public float cooldown;
    public float cooldownEnd;

    private void Start()
    {
        cooldown = 1/turret.attackspeed;
        damage = turret.baseDamage;
        range = turret.range;
        GetComponent<SpriteRenderer>().sprite = turret.sprite;
        
    }

    private void FixedUpdate()
    {

        //Track closest enemy
        if (targets.Count>0)
        {
            turret.Track(gameObject, targets[0]);
            if (cooldownEnd <= 0)
            {
                turret.Shoot(gameObject,targets[0], damage);
                cooldownEnd = cooldown;
            }
        }

        cooldownEnd -= Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            setActive();
        }
    }

    /*
    private void OnTriggerEnter2D(Collider2D enemy)
    {

        if (enemy.CompareTag("Enemy"))
        {
            targets.Add(enemy.gameObject);
            Debug.Log("Enemy Spotted!");
        }

    }

    private void OnTriggerExit2D(Collider2D enemy)
    {
        if (enemy.CompareTag("Enemy"))
        {
            targets.Remove(enemy.gameObject);
            Debug.Log("Enemy Lost!");
        }
    }
    */

    public void setActive()
    {
        active = !active;
        child.SetActive(active);
        if (active == true)
        {
            proximityCollider = child.GetComponent<CircleCollider2D>();
            proximityCollider.radius = range;
        }

        if (active == false)
        {
            targets = new List<GameObject>();
        }
    }

}
