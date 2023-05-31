using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public int iID;
    [SerializeField] TMP_Text tPoints;

    public int iPoints = 0;

    private Undo scUndo;

    void Start()
    {
        scUndo = GameObject.FindGameObjectWithTag("Undo").GetComponent<Undo>();
    }

    void Update()
    {
        tPoints.text = iPoints.ToString();
    }

    public void WrongAnswer()
    {
        GameObject[] agoPlayers = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < agoPlayers.Length; i++)
        {
            if (agoPlayers[i].GetComponent<Player>().iID != iID)
            {
                agoPlayers[i].GetComponent<Player>().iPoints++;
            }
        }

        scUndo.iLastEffectedPlayer = iID;
        scUndo.iLastMove = 0;
    }

    public void RightAnswer()
    {
        iPoints += 3;

        scUndo.iLastEffectedPlayer = iID;
        scUndo.iLastMove = 1;
    }
}
