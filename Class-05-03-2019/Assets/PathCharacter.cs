using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathCharacter : MonoBehaviour
{
    public WayPoint start, end;

    private List<WayPoint> path;
    private int current;
    void Start()
    {
        // path = PathFinding.BreadthWise(start, end);
        path = PathFinding.Astar(start, end);
        current = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(path[current].transform);
        transform.Translate(transform.forward * Time.deltaTime * 5, Space.World);

        if (Vector3.Distance(transform.position, path[current].transform.position) < 0.1f)
        {
            current++;
            current %= path.Count;
        }
    }
}
