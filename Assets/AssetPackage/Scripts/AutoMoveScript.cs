using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveScript : MonoBehaviour
{
    //The speed of the object
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //Make a new vector
        Vector3 newPos = transform.position;

        /*The new position is equal to
        (original position) + (direction * speed * DeltaTime (to 
        avoid frame dependence))*/
        newPos += transform.forward * speed * Time.deltaTime;

        transform.position = newPos;
    }
}
