using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        /*controller.SimpleMove(new Vector3(h*5, 0, v*5)); 
        
         * This calculates gravity*/
        controller.Move(new Vector3(h*5*Time.deltaTime, 0, v*5*Time.deltaTime)); //This method does not calculate gravity

    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        print("Collision!!");
    }
}
