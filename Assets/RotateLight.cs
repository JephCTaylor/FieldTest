using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour
{
    public float speed = 0;

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }

    public void AdjustSpeed(float speed)
    {
        this.speed = speed;
    }
}
