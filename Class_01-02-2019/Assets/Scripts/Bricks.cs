using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    private Rigidbody RB;
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            RB.AddExplosionForce(1000, Vector3.zero, 10);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer != 10)
        {
            return;
        }
        Destroy(collision.gameObject, 0.01f);
        Destroy(gameObject, 0.01f);
    }
}
