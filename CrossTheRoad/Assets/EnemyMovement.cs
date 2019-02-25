using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float direction, speed;
    public Transform t;
    public GameObject Character;
    public Counter count;

    void Start()
    {
        
    }
    
    void Update()
    {
        t.Translate(direction * speed * Time.deltaTime, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            this.direction *= -1;
        }else if (collision.gameObject.layer == 9)
        {
           Destroy(collision.gameObject, 0.001f);
           Instantiate(Character);
            if (this.speed < 15)
            {
                this.speed += 1;
            }
            this.count.score -= 100;
        }

    }
}
