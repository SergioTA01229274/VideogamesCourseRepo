using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectile;
    public Player1 player1;
    public GameController gC;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (this.player1.getTurn() == true)
        {

            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(projectile, transform.position, transform.rotation);
                this.gC.turn = "Player1Shoot";
            }
        }
    }
}
