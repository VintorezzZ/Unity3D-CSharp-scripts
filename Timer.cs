using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float myTimer = 5.0f;
    void Update()
    {
        if (myTimer > 0)
        {
            myTimer -= Time.deltaTime;
        }
        else if (myTimer <= 0)
        {
            Debug.Log("GameOver");
        }
    }
}
