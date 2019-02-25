using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public string counter;
    public int score;
    public Text t;
    void Start()
    {
        counter = "Score:  ";
        score = 0;
        t.text = counter + score;
    }

    
    void Update()
    {
        t.text = counter + score;
    }
}
