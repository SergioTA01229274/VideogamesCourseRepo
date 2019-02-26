using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject pivot1, pivot2;
    public float turretSpeed, tankVelocity;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.pivot1.transform.Rotate(Vector3.down * turretSpeed * Time.deltaTime);
        }if (Input.GetKey(KeyCode.RightArrow))
        {
            this.pivot1.transform.Rotate(Vector3.up * turretSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow) && pivot2.transform.localRotation.z > -.15f)
        {
            pivot2.transform.Rotate(Vector3.back * turretSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.DownArrow) && pivot2.transform.localRotation.z <= 0)
        {
            pivot2.transform.Rotate(Vector3.forward * turretSpeed * Time.deltaTime);
        }if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-tankVelocity * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(tankVelocity * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * (tankVelocity + 80) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * (tankVelocity + 80) * Time.deltaTime);
        }

    }
}
