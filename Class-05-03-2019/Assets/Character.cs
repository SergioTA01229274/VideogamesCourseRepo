using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public WayPoint[] path;
    public float range;
    private int current;


    void Start()
    {
        current = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(path[current].transform);
        transform.Translate(transform.forward * Time.deltaTime * 2, Space.World);
    }

    //We need to checj distance on a regular basis with the least amount of overhead
    //Coroutine!!!

    IEnumerator CheckDistance(){

        
        while (true)
        {
            float d = Vector3.Distance(transform.position, path[current].transform.position);

            if (d < range)
            {
                current++;
                current %= path.Length; 
            }
            yield return new WaitForSeconds(0.2f);
        }
    }
}
