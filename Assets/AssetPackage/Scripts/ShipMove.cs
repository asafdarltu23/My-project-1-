using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started");
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log("Tick");*/

        Vector3 newPos = this.gameObject.transform.position;
        newPos.z += speed;

        this.gameObject.transform.position = newPos;
    }
}
