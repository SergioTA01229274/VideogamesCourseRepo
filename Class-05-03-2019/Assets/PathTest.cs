using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathTest : MonoBehaviour
{
    // Start is called before the first frame update
    public WayPoint start, end;
    void Start()
    {
        //List<WayPoint> path = PathFinding.BreadthWise(start, end);
        List<WayPoint> path = PathFinding.DepthWise(start, end);
        foreach (WayPoint w in path)
        {
            Debug.Log(w.transform.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
