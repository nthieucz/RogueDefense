using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityTrigger : MonoBehaviour
{

    public TurretController turretController;


    private void OnTriggerEnter2D(Collider2D enemy)
    {

        if (enemy.CompareTag("Enemy"))
        {
            turretController.targets.Add(enemy.gameObject);
            Debug.Log("Enemy Spotted!");
        }
        
    }

    private void OnTriggerExit2D(Collider2D enemy)
    {
        if (enemy.CompareTag("Enemy"))
        {
            turretController.targets.Remove(enemy.gameObject);
            Debug.Log("Enemy Lost!");
        }
    }

}
