using System;
using UnityEngine;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Update()
	{
		//get heading
        //get position
	}

    void PlayerShot(Player player)
    {
        if("shot a player")
        {
            if ("shot in the front")
            {
                player.score++;
            }
            else if ("shot in the back")
            {
                player.score--;
            }
        }
        if ("other player already shot")
        {
            player.score++;
            //end the game
        }
    }

    void PlayerDied(Player player)
    {

    }

    void EndGame()
    {
        Debug.Log();
    }
}
public abstract class Player
{
    int score;
    bool hasShot;
}
