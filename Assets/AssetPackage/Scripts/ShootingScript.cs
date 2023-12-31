using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public Transform projectile;
    //How many seconds pass between each shot
    public float fireRate;
    //An internal counter used to keep track of time passed between shots
    float fireCooldown = 0;

    // Update is called once per frame
    void Update()
    {
        fireCooldown = Time.deltaTime;

        if (fireCooldown >= fireRate)
        {
            //Call the function
            Shoot();
            //Reset the cooldown
            fireCooldown = 0;
        }
    }

    void Shoot()
    {
        /* The projection is spawned at the position of this transform
         * with the default rotation
         
         * Instantiate(projectile, transform.postion, Quaternion.identity);
         
         * with the muzzle's rotation */
        Instantiate(projectile, transform.position, Quaternion.identity);
    }
}
