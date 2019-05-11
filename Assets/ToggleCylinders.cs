using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCylinders : MonoBehaviour
{
    private GameObject[] cylinders;
    private bool visible = true; 

    // Start is called before the first frame update
    void Start()
    {
        cylinders = GameObject.FindGameObjectsWithTag("Cylinders");
    }

    public void OnClick()
    {
        if (visible)
        {
            foreach (GameObject cylinder in cylinders)
            {
                cylinder.GetComponent<Transform>().localScale = new Vector3(0, 0, 0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
