using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Player1 player1;
    public Player2 player2;
    public GameObject p1, p2;
    public string turn;
    public Text t;

    void Start()
    {
        this.player1.setTurn(true);
        this.player2.setTurn2(false);
        this.turn = "";
    }


    void Update()
    {
        if (this.turn == "Player1Shoot")
        {
            this.player1.setTurn(false);
            this.player2.setTurn2(true);
        }
        if (this.turn == "Player2Shoot")
        {
            this.player1.setTurn(true);
            this.player2.setTurn2(false);
            print(this.player1.life + ", " + this.player2.life2);
        }
        if (this.player1.life <= 0)
        {
            Destroy(p1, 0.001f);
            t.text = "Player 2 wins !";
        }
        if (this.player2.life2 <= 0)
        {
            Destroy(p2, 0.001f);
            t.text = "Player 1 wins !";
        }

    }
}
