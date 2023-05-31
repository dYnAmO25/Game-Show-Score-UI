using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerAmount : MonoBehaviour
{
    [SerializeField] int iMaxPlayers;
    public TMP_Text tCurrentPlayers;
    [SerializeField] Button buLowerButton;
    [SerializeField] Button buHigherButton;

    int iCurrentPlayers = 1;

    void Update()
    {
        tCurrentPlayers.text = iCurrentPlayers.ToString();

        if (iCurrentPlayers == 1)
        {
            buLowerButton.interactable = false;
        }
        else
        {
            buLowerButton.interactable = true;
        }

        if (iCurrentPlayers == iMaxPlayers)
        {
            buHigherButton.interactable = false;
        }
        else
        {
            buHigherButton.interactable = true;
        }
    }

    public void LowerPlayers()
    {
        iCurrentPlayers--;
    }

    public void HigherPlayers()
    {
        iCurrentPlayers++;
    }
}
