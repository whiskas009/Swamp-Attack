using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public override void Shoot()
    {
        if (Input.GetMouseButtonDown(0) && Time.timeScale != 0)
        {
            Instantiate(Bullet, _shootPoint.position, Quaternion.identity);
        }
    }
}
