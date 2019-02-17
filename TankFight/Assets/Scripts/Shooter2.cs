using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter2 : MonoBehaviour
{
    public GameObject projectile;
    public Player2 player2;
    public GameController gC2;
   

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (this.player2.getTurn2() == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(projectile, transform.position, transform.rotation);
                this.gC2.turn = "Player2Shoot";
            }
        }
    }
}
