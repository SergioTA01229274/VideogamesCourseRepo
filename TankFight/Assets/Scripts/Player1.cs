using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public int speed;
    public GameObject projectile, pivot;
    public int life;
    private bool turn;

    void Start()
    {
        this.life = 4;
       
    }

    void Update()
    {
        if (this.getTurn())
        {

            float horizontalAxis = Input.GetAxis("Horizontal");
            transform.Translate(speed * horizontalAxis * Time.deltaTime, 0, 0, Space.World);

            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.pivot.transform.Rotate(Vector3.left * 100f * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                this.pivot.transform.Rotate(Vector3.left * -100f * Time.deltaTime);
            }

        }
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 13)
        {
            Destroy(collision.gameObject, 0.0001f);
            this.life--;

        }
        else if (collision.gameObject.layer == 15)
        {
            print("out");
            Destroy(gameObject, 0.0001f);
            this.life = 0;
        }
    }
    public void setTurn(bool instruction)
    {
        this.turn = instruction;
    }

    public bool getTurn()
    {
        return this.turn;
    }
}
