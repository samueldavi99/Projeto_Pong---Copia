using UnityEngine;
using System.Collections;

public class Scorekeeper : MonoBehaviour
{
    // the maximum score a player can reach
    public int ScoreLimit = 10;

    // Player 1's score
    private int p1Score = 0;

    // Player 2's score
    private int p2Score = 0;

    // give the appropriate player a point
    public void AddScore(int player)
    {
        // player 1
        if (player == 1)
        {
            p1Score++;
        }
        // player 2
        else if (player == 2)
        {
            p2Score++;
        }

        // check if either player reached the score limit
        if (p1Score >= ScoreLimit || p2Score >= ScoreLimit)
        {
            // player 1 has a better score than player 2
            if (p1Score > p2Score)
                Debug.Log("Player 1 wins");
            // player 2 has a better score than player 1
            if (p2Score > p1Score)
                Debug.Log("Player 2 wins");
            // both players have the same score - tie
            else
                Debug.Log("Players are tied");

            // reset scores and start over
            p1Score = 0;
            p2Score = 0;
        }
    }
}