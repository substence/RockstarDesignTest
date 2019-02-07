using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPS : MonoBehaviour
{
    Player player1;
    Player player2;
    const int MAX_ROUNDS = 5;

    void Play()
    {
        for (int round = 0; round < MAX_ROUNDS;)
        {
            //Get player weapons for this round
            player1.UpdatePlayerWeapon();
            player2.UpdatePlayerWeapon();

            Player winner = GetWinner(player1, player2);
            if (winner == null)
            {
                break; // no winner(draw), play again without moving to the next round
            }
            else
            {
                winner.wins++;
                round++;
            }
        }
        Debug.Log("Player 1 has " + player1.wins + " wins.");
        Debug.Log("Player 2 has " + player2.wins + " wins.");\
    }

    Player GetWinner(Player player1, Player player2)
    {
        if (GetInferirorWeaponFor(player1.weapon) == player2.weapon)
        {
            return player1;
        }
        else if (GetInferirorWeaponFor(player2.weapon) == player1.weapon)
        {
            return player2;
        }
        return null;
    }

    Weapons GetInferirorWeaponFor(Weapons weapon)
    {
        switch (weapon)
        {
            case Weapons.ROCK:
                return Weapons.SCISSORS;
            case Weapons.PAPER:
                return Weapons.ROCK;
            case Weapons.SCISSORS:
                return Weapons.PAPER;
        }
        return Weapons.INVALID;
    }
}

public enum Weapons
{
    INVALID,
    ROCK,
    PAPER,
    SCISSORS
}

public abstract class Player
{
    public int wins;
    public Weapons weapon;
    public abstract void UpdatePlayerWeapon();  //unimplemented. This would populate the weapon based on the player's input
}
