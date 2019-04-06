using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileDynamics : MonoBehaviour
{
    private Rigidbody rb;
    public float initialForce;
    public GameObject explosion;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * initialForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        var g = Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(g.gameObject, 1.9f);
        if (collision.gameObject.layer == 9 || collision.gameObject.layer == 0)
        {
            Destroy(gameObject);
        }
    }
}
