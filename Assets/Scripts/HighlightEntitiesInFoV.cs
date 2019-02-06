using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightEntitiesInFoV : MonoBehaviour
{
    const int MAX_LINE_OF_SIGHT = 100;
    const int VIEWING_ANGLE = 60;

    bool IsEnemyInLoS(Vector2 playerPosition, float playerFacingAngle, Vector2 targetPosition)
    {
        float distanceToTarget = Vector2.Distance(playerPosition, targetPosition);

        //if the distance to that target is greater than the maximum line of sight, then the target is too far away.
        if (distanceToTarget > MAX_LINE_OF_SIGHT)
        {
            return false;
        }

        float angleToTarget = Vector2.Angle(playerPosition, targetPosition);

        //compare the absolute difference in the player's facing angle to it's angle to the target and see if it's greater than the viewing angle
        if (Mathf.Abs(angleToTarget - playerFacingAngle) > VIEWING_ANGLE / 2)
        {
            return false;
        }

        return true;
    }

    const int MINIMUM_DISTANCE = 100;
    Vector2 GetClosestPositionAwayFromStar(Vector2 starPosition, Vector2 flagPosition)
    {
        float angleFromFlagToStar = Vector2.Angle(starPosition, flagPosition);
        angleFromFlagToStar *= Mathf.Deg2Rad;
        return new Vector2(Mathf.Cos(angleFromFlagToStar) * MINIMUM_DISTANCE, Mathf.Sin(angleFromFlagToStar) * MINIMUM_DISTANCE);
    }
}
