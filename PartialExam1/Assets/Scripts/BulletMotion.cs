using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMotion : MonoBehaviour
{
    private Rigidbody rb;
    public float initialforce;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * initialforce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 12)
        {
            Destroy(gameObject, 0.001f);
        }else if (collision.gameObject.layer == 11)
        {
            Destroy(collision.gameObject, 0.001f);
            Destroy(gameObject, 0.001f);
        }
    }
}
