using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField]
    float pickupDelay = 0.3f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package collected");
            hasPackage = true;
            Destroy(collision.gameObject, pickupDelay);
        }
        if (collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package deliverd");
            hasPackage = false;
        }
    }
}
