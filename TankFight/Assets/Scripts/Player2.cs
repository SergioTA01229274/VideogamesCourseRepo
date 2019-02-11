using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public int speed;
    public bool isMyTurn;


    void Start()
    {
        isMyTurn = false;
    }


    void Update()
    {

        if (this.getIsMyTurn() == true)
        {
            float horizontalAxis = Input.GetAxis("Horizontal");
            transform.Translate(speed * horizontalAxis * Time.deltaTime, 0, 0, Space.World);
        }


    }

    public void setIsMyTurn()
    {
        isMyTurn = !isMyTurn;
    }
    public bool getIsMyTurn()
    {
        return isMyTurn;
    }
}
