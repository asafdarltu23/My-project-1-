using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ProjectileScript : MonoBehaviour
{
    //Speed of projectile
    public float speed;
    //How long will this projectile last before self destruction;
    public float lifetime;
    //The counter that keeps track of how long this projectile has been around for
    private float lifetimeCounter = 0;

    // Update is called once per frame
    void Update()
    {
        //We use the function (to keep Update clean)
        MoveProjectile();

        //The deltatime is added to the counter
        lifetimeCounter += Time.deltaTime;
        
        //If the counter has exceeded the lifetime
        if(lifetimeCounter > lifetime)
        {
            Destroy(this);
        }
    }

    void MoveProjectile()
    {
        //define a new position vector to easily modify values
        Vector3 newPos = transform.position;
        /*We set the new postion to be 'speed" units along the forward direction
        of this transform every second.*/
        newPos += transform.forward * speed * Time.deltaTime;

        //Set the new position of the object
        transform.position = newPos;
    }
}
