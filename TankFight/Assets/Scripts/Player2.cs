using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public int speed;
    public GameObject projectile, pivot;
    public int life2;
    private bool turn2;

    void Start()
    {
        this.life2 = 4;

    }

    void Update()
    {
        if (this.getTurn2())
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
            this.life2--;

        }
        else if (collision.gameObject.layer == 15)
        {
            Destroy(gameObject, 0.0001f);
            this.life2 = 0;

        }
    }

    public void setTurn2(bool instruction)
    {
        this.turn2 = instruction;
    }
    public bool getTurn2()
    {
        return this.turn2;
    }
}
