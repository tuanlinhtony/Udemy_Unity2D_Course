using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;
    private void Start() {
        Debug.Log(hasPackage);
    }
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        // if(the things we trigger is the package) => then print "package picked up" to the console
        if(other.tag == "Package" && !hasPackage){
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        } 

        // if(the things we trigger is the customer) => then print "package delivered" to the console
        if(other.tag == "Customer" && hasPackage){
            Debug.Log("Package Delivered");
            hasPackage = false;
        } 
    }
}
