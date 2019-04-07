using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public WayPoint[] path;
    public int speed;
    private int current;
    private float range;
    void Start()
    {
        StartCoroutine(walk());
        range = 0.1f;
        current = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(path[current].transform.position);
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
    }

    IEnumerator walk()
    {
        while (true)
        {
            float distanceToWayPoint = Vector3.Distance(transform.position, path[current].transform.position);
            if (distanceToWayPoint < range)
            {
                current++;
                current %= path.Length;
            }
            yield return new WaitForSeconds(0.01f);
        }
    }
}
