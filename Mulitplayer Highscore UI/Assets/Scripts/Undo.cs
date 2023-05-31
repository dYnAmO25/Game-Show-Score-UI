using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Undo : MonoBehaviour
{
    public int iLastEffectedPlayer = -1;
    public int iLastMove = -1;

    public void UndoMove()
    {
        if (iLastEffectedPlayer != -1)
        {
            if (iLastMove == 1)
            {
                UndoPositive(iLastEffectedPlayer);
                iLastEffectedPlayer = -1;
            }
            else
            {
                UndoNegative(iLastEffectedPlayer);
                iLastEffectedPlayer = -1;
            }
        }
    }

    private void UndoPositive(int iID)
    {
        GameObject[] goaPlayers = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < goaPlayers.Length; i++)
        {
            if(goaPlayers[i].GetComponent<Player>().iID == iID)
            {
                goaPlayers[i].GetComponent<Player>().iPoints -= 3;
            }
        }
    }

    private void UndoNegative(int iID)
    {
        GameObject[] goaPlayers = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < goaPlayers.Length; i++)
        {
            if (goaPlayers[i].GetComponent<Player>().iID != iID)
            {
                goaPlayers[i].GetComponent<Player>().iPoints--;
            }
        }
    }
}
