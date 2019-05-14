using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCube : MonoBehaviour
{
    public Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }
    
    public void Toggle()
    {
        if (rend.enabled)
        {
            rend.enabled = false;
        }
        else
        {
            rend.enabled = true;
        }
    }
}