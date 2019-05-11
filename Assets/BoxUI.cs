using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxUI : MonoBehaviour
{
    private Canvas canvas;
    private Slider sunSlider;
    private Dropdown colorSlider;
    private Button jumpButton;
    private float fadeTime;

    private void Start()
    {
        sunSlider = GameObject.Find("ColorDropdown").GetComponent<Slider>();
    }



    public void FadeUI(bool isDisplaying)
    {
        if (isDisplaying)
        {

        }
    }
}
