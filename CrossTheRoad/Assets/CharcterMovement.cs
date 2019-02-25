using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcterMovement : MonoBehaviour
{
    public float speed;
    public Transform t;
    void Start()
    {
        
    }

    void Update()
    {
        float horizontalDirection = Input.GetAxis("Horizontal");
        float verticalDirection = Input.GetAxis("Vertical");
        t.Translate(speed * horizontalDirection * Time.deltaTime, verticalDirection * speed * Time.deltaTime, 0);
    }
    
}
