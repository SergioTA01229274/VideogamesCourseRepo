using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float velocity;
    public Transform t;
    public int life;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float VerticalDir = Input.GetAxis("Vertical");
        float HorizontalDir = Input.GetAxis("Horizontal");

        t.Translate(0, 0, VerticalDir * velocity * Time.deltaTime);
        t.Translate(HorizontalDir * velocity * Time.deltaTime, 0, 0);

        if (this.life <= 0)
        {
            Destroy(gameObject, 0.001f);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 11)
        {
            Destroy(collision.gameObject, 0.001f);
            this.life -= 10;
        }
    }
}
