using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int life;
    private int maxLife;
    public GameObject player, WaveController;
    public Text lifeDisplayer;

    // Start is called before the first frame update
    void Start()
    {
        life = 50;
        maxLife = life;
        lifeDisplayer.color = Color.green;
        lifeDisplayer.text = "" + life;

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void setWaveController(GameObject wave)
    {
        WaveController = wave;
    }

    public void setPlayer(GameObject character)
    {
        player = character;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer==11 || collision.gameObject.layer == 9)
        {
            life -= 10;
            if (life == 0)
            {
                WaveController.GetComponent<WaveController>().deleteEnemy(this);
                Destroy(this.gameObject);

            }
            else
            {
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

