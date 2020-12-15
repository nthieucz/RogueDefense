using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ProximityTrigger : MonoBehaviour, IPointerDownHandler
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

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
