using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinding
{
    public static List<WayPoint> BreadthWise(WayPoint start, WayPoint end)
    {
        List<WayPoint> visited = new List<WayPoint>();
        Queue<WayPoint> work = new Queue<WayPoint>();

        visited.Add(start);
        work.Enqueue(start);

        start.history = new List<WayPoint>();

        while (work.Count > 0)
        {
            WayPoint current = work.Dequeue();
            if (current == end){
                current.history.Add(current);
                return current.history;
            }
            else {
                for (int i = 0; i < current.neighbors.Length; i++)
                {
                    WayPoint currentNeighbor = current.neighbors[i];
                    if (!visited.Contains(currentNeighbor)){
                        visited.Add(currentNeighbor);
                        work.Enqueue(currentNeighbor);
                        currentNeighbor.history = new List<WayPoint>(current.history);
                        currentNeighbor.history.Add(current);
                    }
                }
            }
        }

        return null;
    }

    public static List<WayPoint> DepthWise(WayPoint start, WayPoint end)
    {

        List<WayPoint> visited = new List<WayPoint>();
        Stack<WayPoint> work = new Stack<WayPoint>();

        visited.Add(start);
        work.Push(start);
        start.history = new List<WayPoint>();

        while (work.Count > 0){
            WayPoint current = work.Pop();

            if (current == end){
                current.history.Add(current);
                return current.history;
            }else{
                for (int i = 0; i < current.neighbors.Length; i++)
                {
                    WayPoint currentNeighbor = current.neighbors[i];
                    if (!visited.Contains(currentNeighbor))
                    {
                        visited.Add(currentNeighbor);
                        work.Push(currentNeighbor);

                        currentNeighbor.history = new List<WayPoint>(current.history);
                        currentNeighbor.history.Add(current);
                    }

                }
            }
        }
        return null;
    }

    public static List<WayPoint> Astar(WayPoint start, WayPoint end)
    {
        List<WayPoint> visited, work;
        visited = new List<WayPoint>();
        work = new List<WayPoint>();

        start.history = new List<WayPoint>();
        visited.Add(start);
        work.Add(start);
        start.g = 0;
        start.h = 0;

        while (work.Count > 0){
            WayPoint current = work[0];
            for (int i = 1; i < work.Count;i++){
                if (work[i].F < current.F){
                    current = work[i];
                }
            }

            work.Remove(current);

            foreach (WayPoint currentNeighbor in current.neighbors){
                if (!visited.Contains(currentNeighbor)){
                    if (currentNeighbor == end){
                        List<WayPoint> result = current.history;
                        result.Add(currentNeighbor);
                        return result;
                    }
                    currentNeighbor.g = current.g +
                    Vector3.Distance(current.transform.position, currentNeighbor.transform.position);

                    currentNeighbor.h = Vector3.Distance(currentNeighbor.transform.position, end.transform.position);

                    currentNeighbor.history = new List<WayPoint>(current.history);
                    currentNeighbor.history.Add(current);

                    visited.Add(currentNeighbor);
                    work.Add(currentNeighbor);
                }
            }
        }
        return null;
    }
}
