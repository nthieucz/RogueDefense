using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretDrag : MonoBehaviour
{
    private TurretController turretController;


    // Start is called before the first frame update
    void Start()
    {
        turretController = gameObject.GetComponent<TurretController>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
