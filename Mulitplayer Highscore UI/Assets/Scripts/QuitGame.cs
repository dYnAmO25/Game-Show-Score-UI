using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    [Header("Quit UI")]
    [SerializeField] GameObject goQuitPanel;

    public void ConfirmQuitButton()
    {
        Application.Quit();
    }
    
    public void ButtonQuitGame()
    {
        goQuitPanel.SetActive(true);
    }

    public void DontQuitGame()
    {
        goQuitPanel.SetActive(false);
    }
}
