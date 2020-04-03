using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Action : MonoBehaviour
{
    public Action<int, int> Sum;
    void Start()
    {
        Sum = (a, b) =>
        {
            int total = a + b;
            if (total < 100)
            {
                Debug.Log("total is less of 100");
            }

            Debug.Log("Total: " + total);
        };

        Sum(5, 4);
    }

   
}
