using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody rb;
    public float initialForce;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * initialForce, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.layer == 10)
        {
           
            Destroy(collision.gameObject, 0.001f);
            Destroy(gameObject, 0.001f);
        }else if (collision.gameObject.layer == 9)
        {
            Destroy(gameObject, 0.001f);
        }
        else if (collision.gameObject.layer == 11)
        {
            Destroy(gameObject, 0.001f);
        }
        else if (collision.gameObject.layer == 12)
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            rb.AddExplosionForce(7000, Vector3.zero, 10);
            Destroy(gameObject, 0.001f);
        }
        else if (collision.gameObject.layer == 15)
        {
            Destroy(gameObject, 0.001f);
        }
    }
}
