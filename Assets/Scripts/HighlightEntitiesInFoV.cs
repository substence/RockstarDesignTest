using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightEntitiesInFoV : MonoBehaviour
{
	
	// Update is called once per frame
	void Update ()
    {
		//find all enemies
        //if enemie is in los
        //highlight
	}

    void Highlight()
    {
        //Gam
    }

    int length = 100;
    int fov = 30;

    bool isEnemyInLoS(Vector2 playerPosition, Vector2 playerdirection, Vector2 targetPosition)
    {
        //first we'll check the distance between the player and it's target
        float distance = start - target;
        Vector2.Distance(playerPosition, targetPosition);

        //if the distance is greater than the length (line of sight) we'll bail early.

        if (distance > length)
        {
            return false;
        }

        //otherwise, we'll check the angle from the player and the target and if it's greater than the player's facingle angle by (fov /2) then we'll bail

        enemyPosition
        float angle = 
        return false;
    }
}
