﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
    }
    public void setPlayer(GameObject character)
    {
        player = character;
    }
}
