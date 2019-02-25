﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDymanics : MonoBehaviour
{
    private Rigidbody rb;
    public float initialForce;
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
        if (collision.gameObject.layer == 10)
        {
            Rigidbody EnemyRB = collision.gameObject.GetComponent<Rigidbody>();
            EnemyRB.AddExplosionForce(8500000, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), 10);
            Destroy(gameObject, 0.01f);
        }else if (collision.gameObject.layer == 0)
        {
            Destroy(gameObject, 0.001f);

        }
    }
}
