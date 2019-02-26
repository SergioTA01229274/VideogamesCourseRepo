using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int life;
    private int maxLife;
    private int direction; //not final
    private float cumulative;// not final
    public Text lifeDisplayer;

    // Start is called before the first frame update
    void Start()
    {
        life = 50;
        maxLife = life;
        // cumulative = 0;
        direction = 1;
        lifeDisplayer.color = Color.green;
        lifeDisplayer.text = "" + life;
    }

    // Update is called once per frame
    void Update()
    {
        // move forwards & backwards, podria ser subroutine
        //SI NO QUIERES QUE SE MUEVA QUITA TODO LO DE AQUI!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        transform.Translate(Vector3.down * direction * 2 * Time.deltaTime);
        if (cumulative < 5)
        {
            cumulative += Time.deltaTime;
        }
        else
        {
            direction *= -1;
            cumulative = 0;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        //if bala || tanke
        if(collision.gameObject.layer==11 || collision.gameObject.layer == 9)
        {
            life -= 1;
            if (life == 0)
            {
                Destroy(this.gameObject);
            }
            else
            {
                //recalc
                lifeDisplayer.text = "" + life;
                if (maxLife / 4 > life)
                {
                    lifeDisplayer.color = Color.red;
                }
                else if (maxLife / 2 > life)
                {
                    lifeDisplayer.color = Color.yellow;
                }
                else
                {
                    lifeDisplayer.color = Color.green;
                }

            }
        }
        
    }
}

