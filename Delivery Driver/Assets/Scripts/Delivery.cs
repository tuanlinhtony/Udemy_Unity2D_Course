using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        // if(the things we trigger is the package) => then print "package picked up" to the console
        if(other.tag == "Package"){
            Debug.Log("Package picked up");
        } 

        // if(the things we trigger is the customer) => then print "package delivered" to the console
        if(other.tag == "Customer"){
            Debug.Log("Package Delivered");
        } 
    }
}
