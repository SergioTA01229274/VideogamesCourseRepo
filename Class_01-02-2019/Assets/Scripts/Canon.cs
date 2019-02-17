using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    private float lastJ;
    public GameObject originalProjectile;
    public Transform reference;
    void Start()
    {
        lastJ = 0;
        StartCoroutine(example());
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        transform.Translate(h * 10 * Time.deltaTime, 0, 0);

        float jump = Input.GetAxis("Jump");

        if (lastJ == 0 && jump == 1)
        {
            Instantiate(originalProjectile, reference.position, reference.rotation);
        }
        lastJ = jump;
        
    }

    IEnumerator example(){
        while (true)
        {
            yield return new WaitForSeconds(1);
            print("This will still work");

        }
    }
}
