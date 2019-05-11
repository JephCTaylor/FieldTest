using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UITrigger : MonoBehaviour
{
    private GameObject canvas;

    private void Start()
    {
        canvas = GameObject.Find("Canvas");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.GetComponent<Transform>().localScale += new Vector3(.002f, .002f, .002f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.GetComponent<Transform>().localScale -= new Vector3(.002f, .002f, .002f);
        }
    }
}
