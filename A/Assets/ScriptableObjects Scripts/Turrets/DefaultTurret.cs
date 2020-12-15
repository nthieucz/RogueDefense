using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Turret/Default")]
public class DefaultTurret : Turret
{

    public override void Shoot(GameObject shooter, GameObject target, float damage)
    {

        GameObject projectile =  Instantiate(Projectile, shooter.transform.position, new Quaternion());
        projectile.GetComponent<BaseProjectile>().target = target;
        projectile.GetComponent<BaseProjectile>().damage = damage;


    }

    public override void Track(GameObject shooter, GameObject target)
    {
        Vector3 difference = target.transform.position - shooter.transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        shooter.transform.rotation = Quaternion.Euler(0f, 0f, rotZ-90);
    }
}
