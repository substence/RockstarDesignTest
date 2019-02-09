using System;
using UnityEngine;

public class Class1
{
    private Player player1;
    private Player player2;

    void OnPlayerShoot(Player shooter, Player target)
    {
        Player winner = null;

        shooter.hasShot = true;
        if (target != null)
        {
            float angleFromTaretToShooter = Vector2.Angle(shooter.position, target.position);
            if (Math.Abs(angleFromTaretToShooter - target.facingAngle) < 90) //check 180 in front of the target's facing angle. Outside of this is the back.
            {
                shooter.score++;
            }
            else//shot in the back
            {
                shooter.score--;
            }

            if (target.isDead)
            {
                winner = shooter;
                shooter.score++;
            }
        }
        if (shooter.hasRunAway())
        {
            shooter.score--;
        }
        if (GetOpponent(shooter).hasShot)
        {
            shooter.score++;
            EndGame(winner);
        }
    }

    void EndGame(Player winner = null)
    {
        if (winner != null)
        {
            Debug.Log(winner + " wins!");
        }
        else
        {
            Debug.Log("draw!");
        }
        Debug.Log(player1 + " score : " + player1.score);
        Debug.Log(player2 + " score : " + player2.score);
    }

    Player GetOpponent(Player player)
    {
        return player == player1 ? player2 : player1;
    }
}
public abstract class Player
{
    public int score = 0;
    public bool hasShot = false;
    public Vector2 position;//implemented by the game
    public float facingAngle;//implemented by the game
    public bool isDead;//implemented by the game
    public abstract bool hasRunAway();//implemented by the game
}
