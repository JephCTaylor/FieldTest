using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Color colorEnd = Color.red;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.color = colorEnd;
    }

    public void ColorSelection(int color)
    {
        switch (color)
        {
            case 0:
                colorEnd = Color.red;
                break;
            case 1:
                colorEnd = Color.green;
                break;
            case 2:
                colorEnd = Color.blue;
                break;
        }
    }
}
