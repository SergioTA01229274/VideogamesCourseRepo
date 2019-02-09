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

}
