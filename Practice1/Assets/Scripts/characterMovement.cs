using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterMovement : MonoBehaviour
{
    /*Lifecycle: several methods that fit into a particular time in the life of code

    The engine works as a loop
    The logic we do is going to fit this loop*/
    public float speed;
    public Text texto;
    private Transform t;
    private GameObject go;
    

    private void Awake()
    {
        //This method runs once at the very beginning of this component's life
        texto.text = "Testing";
    }


    void Start()
    {
        //This method is used for initialization

        //This assigment retrieves a reference to another component in the same game object
        //t = GetComponent<Transform>();

        //this assigment retrieves a reference to another game object
        go = GameObject.Find("Capsule");
        t = go.GetComponent<Transform>();
    }


    void Update()
    {
        /*
        FPS refers to "Frames per second"
        Real time - 30 fps
        This methood is important for the performance
        Let´s try to limit the use of this method for two things:
            -Input: Responsiveness
            -Motion: as smooth as possible*/

        //We have two main ways to deal with an input:
        //  -Polling directly to devices

        if (Input.GetKeyDown(KeyCode.A)) {
            print("Down");
        }
        if (Input.GetKey(KeyCode.A)) {
            print("Key");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            print("Up");
        }
        if (Input.GetMouseButtonDown(0))
        {
            print("Mouse left");
        }
        if (Input.GetMouseButtonUp(1))
        {
            print("Mouse right");
            
        }
        /*
         Polling through axes: a way in which the engine abstracts input
        The result of polling an axis is a float value, it has a range of [-1, 1].*/

        float horizontalAxis = Input.GetAxis("Horizontal");
        /*Motion 
            There are several ways to move things
                -Affect the position directly
                -Move through physics engine */

        t.Translate(speed * horizontalAxis * Time.deltaTime, 0, 0, Space.World);
    }

    private void LateUpdate()
    {
        //This method it also happens once per frame, but it's called after ALL the updates
    }

    private void FixedUpdate()
    {
        //This method runs on a set of frametime, it is used if we want something to happen on a frametime.
    }

    /*Collisions with the physics engine
       Requirements:
            -At keast 2 objects
            -Both objects have a collider
            -At least one of them has a rigidbody
            -Rigidbody must be moving
        
        The method called OnCollisionEnter is only invoked at the beginning of the collision
        The method called OnCollisionStay is invoked while the objects keep touching each other
        The method called OnCollisionExit is invoked when the objects stop touching each other 
    */

    private void OnCollisionEnter(Collision choquesito)
    {
        print(choquesito.transform.name);
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }
    private void OnCollisionExit(Collision collision)
    {
        
    }

    //Collitions with trigger:
    //The restrictions/characteristics of the trigger's methods are the same of the collider's method.
    //Triggers does not limit the objects physically (it is possible to identify the contact betweeen objects )

    private void OnTriggerEnter(Collider other)
    {
        print("Enter trigger");
    }
    private void OnTriggerStay(Collider other)
    {
        //print("Stay on trigger");
    }
    private void OnTriggerExit(Collider other)
    {
        //print("Exit trigger");
    }
}
