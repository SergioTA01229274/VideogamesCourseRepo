using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    private float range;
    void Start()
    {
        range = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        transform.LookAt(player.transform);
        if (distance > range)
        {
            transform.Translate(transform.forward * 5 * Time.deltaTime, Space.World);
        }
    }

    public void setPlayer(GameObject character)
    {
        player = character;
    }
}
