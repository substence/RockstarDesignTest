using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPS : MonoBehaviour
{
    Player player1;
    Player player2;
    const int MAX_ROUNDS = 5;

    void Update ()
    {

        for (int round = 0; round < MAX_ROUNDS;)
        {
            Player winner = GetWinner(player1, player2);
            if (winner == null)
            {
                break;
            }
            else
            {
                winner.wins++;
                round++;
            }
        }
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

public enum Weapons
{
    INVALID,
    ROCK,
    PAPER,
    SCISSORS
}
public class Player
{
    public int wins;
    public Weapons weapon;
}
