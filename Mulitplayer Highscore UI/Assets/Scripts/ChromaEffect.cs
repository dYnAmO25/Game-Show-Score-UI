using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChromaEffect : MonoBehaviour
{
    [SerializeField] Toggle toToggler;
    [SerializeField] Image imBackground;
    [SerializeField] float fChange;

    [SerializeField] float fHue = 0.5f;
    void Start()
    {
        
    }

    void Update()
    {
        if (toToggler.isOn)
        {
            imBackground.color = Color.HSVToRGB(fHue, 1, 1);
            UpdateColor();
        }
        else
        {
            imBackground.color = Color.HSVToRGB(fHue, 1, 1);
        }
    }

    void UpdateColor()
    {
        if (fHue >= 1)
        {
            fHue = 0;
        }
        fHue += fChange;
    }
}
