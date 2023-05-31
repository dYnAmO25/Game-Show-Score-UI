using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    [Header("Players")] 
    [SerializeField] GameObject goPlayer0;
    [SerializeField] GameObject goPlayer1;
    [SerializeField] GameObject goPlayer2;
    [SerializeField] GameObject goPlayer3;
    [SerializeField] GameObject goPlayer4;
    [SerializeField] GameObject goPlayer5;
    [SerializeField] GameObject goPlayer6;
    [SerializeField] GameObject goPlayer7;

    [Header("Player Amount Text")]
    [SerializeField] GameObject goSpawnScreen;

    [Header("Player Amount Text")]
    [SerializeField] TMP_Text tPLayerAmount;

    [Header("Timer")]
    [SerializeField] GameObject goTimer;

    int iPlayerAmount;

    int iUpDistance = 160;
    int iDownDistance = -300;

    [Header("Canvas Distance")]
    [SerializeField] int iDistance = 960;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SpawnPlayers()
    {
        int.TryParse(tPLayerAmount.text, out iPlayerAmount);

        goSpawnScreen.SetActive(false);

        goTimer.GetComponent<TimerScript>().bGameStart = true;

        if (iPlayerAmount < 5)
        {
            switch (iPlayerAmount)
            {
                case 1:
                    goPlayer0.SetActive(true);
                    goPlayer0.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
                    break;
                case 2:
                    goPlayer0.SetActive(true);
                    goPlayer0.GetComponent<RectTransform>().localPosition = new Vector3(-iDistance / 2, 0, 0);
                    goPlayer1.SetActive(true);
                    goPlayer1.GetComponent<RectTransform>().localPosition = new Vector3(iDistance / 2, 0, 0);
                    break;
                case 3:
                    goPlayer0.SetActive(true);
                    goPlayer0.GetComponent<RectTransform>().localPosition = new Vector3(-iDistance / 2, 0, 0);
                    goPlayer1.SetActive(true);
                    goPlayer1.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
                    goPlayer2.SetActive(true);
                    goPlayer2.GetComponent<RectTransform>().localPosition = new Vector3(iDistance / 2, 0, 0);
                    break;
                case 4:
                    goPlayer0.SetActive(true);
                    goPlayer0.GetComponent<RectTransform>().localPosition = new Vector3(-iDistance / 3 * 2, 0, 0);
                    goPlayer1.SetActive(true);
                    goPlayer1.GetComponent<RectTransform>().localPosition = new Vector3((-iDistance / 3) + 105, 0, 0);
                    goPlayer2.SetActive(true);
                    goPlayer2.GetComponent<RectTransform>().localPosition = new Vector3((iDistance / 3) - 105, 0, 0);
                    goPlayer3.SetActive(true);
                    goPlayer3.GetComponent<RectTransform>().localPosition = new Vector3(iDistance / 3 * 2, 0, 0);
                    break;
            }
        }
        else
        {
            switch (iPlayerAmount)
            {
                case 5:
                    //1-4 Players
                    goPlayer0.SetActive(true);
                    goPlayer0.GetComponent<RectTransform>().localPosition = new Vector3(-iDistance / 3 * 2, iUpDistance, 0);
                    goPlayer1.SetActive(true);
                    goPlayer1.GetComponent<RectTransform>().localPosition = new Vector3((-iDistance / 3) + 105, iUpDistance, 0);
                    goPlayer2.SetActive(true);
                    goPlayer2.GetComponent<RectTransform>().localPosition = new Vector3((iDistance / 3) - 105, iUpDistance, 0);
                    goPlayer3.SetActive(true);
                    goPlayer3.GetComponent<RectTransform>().localPosition = new Vector3(iDistance / 3 * 2, iUpDistance, 0);
                    //5-8 Players
                    goPlayer4.SetActive(true);
                    goPlayer4.GetComponent<RectTransform>().localPosition = new Vector3(0, iDownDistance, 0);
                    break;
                case 6:
                    //1-4 Players
                    goPlayer0.SetActive(true);
                    goPlayer0.GetComponent<RectTransform>().localPosition = new Vector3(-iDistance / 3 * 2, iUpDistance, 0);
                    goPlayer1.SetActive(true);
                    goPlayer1.GetComponent<RectTransform>().localPosition = new Vector3((-iDistance / 3) + 105, iUpDistance, 0);
                    goPlayer2.SetActive(true);
                    goPlayer2.GetComponent<RectTransform>().localPosition = new Vector3((iDistance / 3) - 105, iUpDistance, 0);
                    goPlayer3.SetActive(true);
                    goPlayer3.GetComponent<RectTransform>().localPosition = new Vector3(iDistance / 3 * 2, iUpDistance, 0);
                    //5-8 Players
                    goPlayer4.SetActive(true);
                    goPlayer4.GetComponent<RectTransform>().localPosition = new Vector3(-iDistance / 2, iDownDistance, 0);
                    goPlayer5.SetActive(true);
                    goPlayer5.GetComponent<RectTransform>().localPosition = new Vector3(iDistance / 2, iDownDistance, 0);
                    break;
                case 7:
                    //1-4 Players
                    goPlayer0.SetActive(true);
                    goPlayer0.GetComponent<RectTransform>().localPosition = new Vector3(-iDistance / 3 * 2, iUpDistance, 0);
                    goPlayer1.SetActive(true);
                    goPlayer1.GetComponent<RectTransform>().localPosition = new Vector3((-iDistance / 3) + 105, iUpDistance, 0);
                    goPlayer2.SetActive(true);
                    goPlayer2.GetComponent<RectTransform>().localPosition = new Vector3((iDistance / 3) - 105, iUpDistance, 0);
                    goPlayer3.SetActive(true);
                    goPlayer3.GetComponent<RectTransform>().localPosition = new Vector3(iDistance / 3 * 2, iUpDistance, 0);
                    //5-8 Players
                    goPlayer4.SetActive(true);
                    goPlayer4.GetComponent<RectTransform>().localPosition = new Vector3(-iDistance / 2, iDownDistance, 0);
                    goPlayer5.SetActive(true);
                    goPlayer5.GetComponent<RectTransform>().localPosition = new Vector3(0, iDownDistance, 0);
                    goPlayer6.SetActive(true);
                    goPlayer6.GetComponent<RectTransform>().localPosition = new Vector3(iDistance / 2, iDownDistance, 0);
                    break;
                case 8:
                    //1-4 Players
                    goPlayer0.SetActive(true);
                    goPlayer0.GetComponent<RectTransform>().localPosition = new Vector3(-iDistance / 3 * 2, iUpDistance, 0);
                    goPlayer1.SetActive(true);
                    goPlayer1.GetComponent<RectTransform>().localPosition = new Vector3((-iDistance / 3) + 105, iUpDistance, 0);
                    goPlayer2.SetActive(true);
                    goPlayer2.GetComponent<RectTransform>().localPosition = new Vector3((iDistance / 3) - 105, iUpDistance, 0);
                    goPlayer3.SetActive(true);
                    goPlayer3.GetComponent<RectTransform>().localPosition = new Vector3(iDistance / 3 * 2, iUpDistance, 0);
                    //5-8 Players
                    goPlayer4.SetActive(true);
                    goPlayer4.GetComponent<RectTransform>().localPosition = new Vector3(-iDistance / 3 * 2, iDownDistance, 0);
                    goPlayer5.SetActive(true);
                    goPlayer5.GetComponent<RectTransform>().localPosition = new Vector3((-iDistance / 3) + 105, iDownDistance, 0);
                    goPlayer6.SetActive(true);
                    goPlayer6.GetComponent<RectTransform>().localPosition = new Vector3((iDistance / 3) - 105, iDownDistance, 0);
                    goPlayer7.SetActive(true);
                    goPlayer7.GetComponent<RectTransform>().localPosition = new Vector3(iDistance / 3 * 2, iDownDistance, 0);
                    break;
            }
        }
    }
}
