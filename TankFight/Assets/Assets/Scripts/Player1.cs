using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{


    public int speed;
    private bool isMyTurn;
    public GameObject projectile, pivot, adversary;

    void Start()
    {
        isMyTurn = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (this.getIsMyTurn() == true)
        {
            float horizontalAxis = Input.GetAxis("Horizontal");
            transform.Translate(speed * horizontalAxis * Time.deltaTime, 0, 0, Space.World);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.pivot.transform.Rotate(Vector3.left * 100f * Time.deltaTime);
        }else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.pivot.transform.Rotate(Vector3.left * -100f * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectile);
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
