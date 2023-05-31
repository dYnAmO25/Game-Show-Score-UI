using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    [SerializeField] TMP_Text tTimer;
    public bool bGameStart = false;
    float fTime = 0;
    int iSec = 0;
    int iMin = 0;
    int iHour = 0;

    void Update()
    {
        if (bGameStart)
        {
            fTime += Time.deltaTime;
        }

        iSec = (int)fTime;
        iMin = iSec / 60;
        iHour = iMin / 60;

        tTimer.text = (iHour % 60).ToString() + ":" + (iMin % 60).ToString() + ":" + (iSec % 60).ToString(); 
    }
}
