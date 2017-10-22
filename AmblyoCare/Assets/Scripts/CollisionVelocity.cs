using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionVelocity : MonoBehaviour {

    void OnCollisionEnter(Collision c)
    {
        string name = gameObject.name;
        gameObject.GetComponent<Rigidbody>().velocity = -gameObject.GetComponent<Rigidbody>().velocity;

    }
}
